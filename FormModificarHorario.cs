using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormModificarHorario : Form
    {
        // Attributes
        int idCursoAula;

        #region Dlls para poder hacer el movimiento del Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Rectangle sizeGripRectangle;
        bool inSizeDrag = false;
        const int GRIP_SIZE = 15;

        int w = 0;
        int h = 0;
        #endregion

        public FormModificarHorario(int idCursoAula)
        {
            InitializeComponent();

            loadData();

            // Initializate
            this.idCursoAula = idCursoAula;

            loadSelectedSchedule();
        }

        // Load data
        public void loadData()
        {
            // Carga aulas
            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT * FROM `curso`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            foreach (DataRow row in tablaCursos.Rows)
            {
                comboBoxCursos.Items.Add(new ComboItem(row["id"].ToString() + " - " + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(int.Parse(row["asignatura"].ToString())), int.Parse(row["id"].ToString())));
            }

            query = "SELECT * FROM `aula`";
            MySqlCommand comandA = con.Comando(query);

            MySqlDataReader myReaderA = comandA.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReaderA);

            foreach (DataRow row in tablaAulas.Rows)
            {
                comboBoxAulas.Items.Add(new ComboItem(row["nombre"].ToString(), int.Parse(row["id"].ToString())));
            }
        }

        // Carga horario seleccionado
        public void loadSelectedSchedule ()
        {
            // Load data from schedule selected
            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT * FROM `cursoaula` WHERE `IDCursoAula` = " + idCursoAula;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaHorario = new DataTable();
            tablaHorario.Load(myReader);

            // Select curso
            int idCurso = int.Parse(tablaHorario.Rows[0]["IDCurso"].ToString());
            //int idAsignatura = int.Parse(IDtoTEXT.GetIDAsignaturaFromCurso(idCurso));
            foreach (ComboItem item in comboBoxCursos.Items)
            {
                if (item.GetId() == idCurso)
                {
                    comboBoxCursos.SelectedItem = item;
                }
            }

            // Select aula
            int idAula = int.Parse(tablaHorario.Rows[0]["IDAula"].ToString());
            foreach (ComboItem item in comboBoxAulas.Items)
            {
                if (item.GetId() == idAula)
                {
                    comboBoxAulas.SelectedItem = item;
                }
            }

            // Set date
            maskedTextBoxFechaComienzo.Text = tablaHorario.Rows[0]["comienzo"].ToString();
            maskedTextBoxFechaFin.Text = tablaHorario.Rows[0]["fin"].ToString();
        }

        // Click BtnGuardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCursos.SelectedItem != null && comboBoxAulas.SelectedItem != null && maskedTextBoxFechaComienzo.Text != "" && maskedTextBoxFechaFin.Text != "")
                {
                    // Guarda los datos introducidos
                    Conexion con = new Conexion();
                    con.Abrir();
                    ComboItem curso = comboBoxCursos.SelectedItem as ComboItem;
                    ComboItem aula = comboBoxAulas.SelectedItem as ComboItem;
                    DateTime fechaInicio = Convert.ToDateTime(maskedTextBoxFechaComienzo.Text);
                    DateTime fechaFin = Convert.ToDateTime(maskedTextBoxFechaFin.Text);

                    //string query = "INSERT INTO `cursoaula` (`IDCursoAula`, `IDCurso`, `IDAula`, `comienzo`, `fin`) VALUES(NULL, '" + curso.GetId() + "', '" + aula.GetId() + "', '" + fechaInicio.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + fechaFin.ToString("yyyy-MM-dd HH:mm:ss") + "');";
                    string query = "UPDATE `cursoaula` SET `IDCurso` = '" + curso.GetId() + "', `IDAula` = '" + aula.GetId() + "', `comienzo` = '" + fechaInicio.ToString("yyyy-MM-dd HH:mm:ss") + "', `fin` = '" + fechaFin.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE `cursoaula`.`IDCursoAula` = " + idCursoAula + ";";
                    MySqlCommand comand = con.Comando(query);
                    MySqlDataReader myReader = comand.ExecuteReader();

                    con.Cerrar();

                    MessageBox.Show("Horario modificado guardado", "HORARIO MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarga el dataGridView
                    FormHorarios.sharedInstance.dateTimePicker_ValueChanged(null, null);

                    // Calcula las horas totales de este curso y actualiza el precio
                    Utils.CalcularPrecioCurso(curso.GetId());

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos antes de modificar un horario.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Debe rellenar todos los campos antes de modificar un horario.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click BtnCancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click btnSalir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event MouseDown
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            w = this.Width;
            h = this.Height;
        }
    }
}
