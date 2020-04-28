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
    public partial class FormNuevoCurso : Form
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

        public FormNuevoCurso()
        {
            InitializeComponent();
        }

        // Load
        private void FormNuevoCurso_Load(object sender, EventArgs e)
        {
            List<string> carreras = new List<string>();
            bool repetido = false;
            // Carga carreras
            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT `carrera` FROM `asignatura`";
            MySqlCommand comandCa = con.Comando(query);

            MySqlDataReader myReaderCa = comandCa.ExecuteReader();

            DataTable tablaCarreras = new DataTable();
            tablaCarreras.Load(myReaderCa);

            // Guarda en una lista todas las carreras (sin repeticiones)
            foreach (DataRow row in tablaCarreras.Rows)
            {
                foreach (string carrera in carreras)
                {
                    if (carrera.Equals(row["carrera"].ToString()))
                    {
                        repetido = true;
                        break;
                    }
                }

                if (!repetido)
                {
                    carreras.Add(row["carrera"].ToString());
                }

                // reset repetido
                repetido = false;
            }

            // Introduce todas las carreras (sin repeticiones) en el comboBoxCarrera
            foreach (string carrera in carreras)
            {
                comboBoxCarrera.Items.Add(carrera);
            }

            con.Cerrar();
        }

        // Click btn salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click boton cancelar
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Carrera selected
        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desbloquea comboBoxAsignatura
            comboBoxAsignatura.Enabled = true;

            // Limpia comboBoxAsignatura and clear text
            comboBoxAsignatura.Items.Clear();
            comboBoxAsignatura.Text = "";
            comboBoxTiposClases.Text = "";

            // Guarda la carrera seleccionada
            string carreraSeleccionada = comboBoxCarrera.SelectedItem.ToString();

            // Carga las asignaturas de la carrera seleccionada
            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT `id`, `asignatura` FROM `asignatura` WHERE asignatura.carrera = '" + carreraSeleccionada + "';";
            MySqlCommand comandAs = con.Comando(query);

            MySqlDataReader myReaderAs = comandAs.ExecuteReader();
            
            DataTable tablaAsignaturas = new DataTable();
            tablaAsignaturas.Load(myReaderAs);

            foreach (DataRow row in tablaAsignaturas.Rows)
            {
                comboBoxAsignatura.Items.Add(new ComboItem(row["asignatura"].ToString(), int.Parse(row["id"].ToString())));
            }

            con.Cerrar();
        }

        // Asignatura selected
        private void comboBoxAsignatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desbloquea comboBoxTipoClases
            comboBoxTiposClases.Enabled = true;

            // Limpia comboBoxTiposClases and clear text
            comboBoxTiposClases.Items.Clear();
            comboBoxTiposClases.Text = "";

            // Carga las asignaturas de la carrera seleccionada
            Conexion con = new Conexion();
            con.Abrir();

            // Carga tipoCurso
            string query = "SELECT * FROM `precio`";
            MySqlCommand comandTip = con.Comando(query);

            MySqlDataReader myReaderTip = comandTip.ExecuteReader();

            DataTable tablaTipoCurso = new DataTable();
            tablaTipoCurso.Load(myReaderTip);

            foreach (DataRow row in tablaTipoCurso.Rows)
            {
                comboBoxTiposClases.Items.Add(new ComboItem(row["tipoCurso"].ToString() + " - " + row["precio"].ToString() + "€/hora", int.Parse(row["id"].ToString())));
            }

            con.Cerrar();
        }

        // tipoPrecio selected
        private void comboBoxTiposClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set 0 in precio
            textBoxPrecio.Text = "0";
        }

        // Click BtnGuardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Guarda los datos introducidos
            Conexion con = new Conexion();
            con.Abrir();
            ComboItem asignatura = comboBoxAsignatura.SelectedItem as ComboItem;
            ComboItem tipoCurso = comboBoxTiposClases.SelectedItem as ComboItem;

            string query = "INSERT INTO `curso` (`ID`, `asignatura`, `tipoCurso`, `precio`) VALUES(NULL, '" + asignatura.GetId() + "', '" + tipoCurso.GetId() + "', '" + textBoxPrecio.Text + "');";
            MySqlCommand comandAs = con.Comando(query);

            MySqlDataReader myReaderAs = comandAs.ExecuteReader();

            con.Cerrar();

            MessageBox.Show("Nuevo curso guardado", "NUEVO CURSO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Recarga los cursos en listViewCursos
            FormCursos.sharedInstance.CargarCursos();

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
