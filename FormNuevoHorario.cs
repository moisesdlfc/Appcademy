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
    public partial class FormNuevoHorario : Form
    {

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

        public FormNuevoHorario()
        {
            InitializeComponent();

            // Load data
            loadData();
        }

        public void loadData ()
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

        // Click btnSalir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click BtnCancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    string query = "INSERT INTO `cursoaula` (`IDCursoAula`, `IDCurso`, `IDAula`, `comienzo`, `fin`) VALUES(NULL, '" + curso.GetId() + "', '" + aula.GetId() + "', '" + fechaInicio.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + fechaFin.ToString("yyyy-MM-dd HH:mm:ss") + "');";
                    MySqlCommand comand = con.Comando(query);
                    MySqlDataReader myReader = comand.ExecuteReader();

                    con.Cerrar();

                    MessageBox.Show("Nuevo horario guardado", "NUEVO HORARIO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Recarga el dataGridView
                    FormHorarios.sharedInstance.dateTimePicker_ValueChanged(null, null);

                    // Calcula las horas totales de este curso y actualiza el precio
                    Utils.CalcularPrecioCurso(curso.GetId());

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe rellenar todos los campos antes de guardar un nuevo horario.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } catch (System.FormatException)
            {
                MessageBox.Show("Debe rellenar todos los campos antes de guardar un nuevo horario.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelApellidos_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxFechaComienzo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelTelefono_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxFechaFin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
