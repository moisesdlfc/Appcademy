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
    public partial class FormNuevoAsignatura : Form
    {
        MySqlConnection connection;
        string id = "";

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

        public FormNuevoAsignatura(string title)
        {
            InitializeComponent();

            // Cambia titulo de ventana
            toolStripLabelAsignatura.Text = title;
        }

        private void FormNuevoAsignatura_Load(object sender, EventArgs e)
        {
            if (toolStripLabelAsignatura.Text.Equals("Nueva Asignatura"))
            {
                CargarProfesores();
            }
        }

        // Cargar profesores
        private void CargarProfesores()
        {
            // Limpia comboBoxProfesores
            comboBoxProfesores.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `profesor`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaProfesores = new DataTable();
            tablaProfesores.Load(myReader);

            foreach (DataRow row in tablaProfesores.Rows)
            {
                comboBoxProfesores.Items.Add(new ComboItem(IDtoTEXT.GetProfesorFullNameFromDNIInProfesor(row["DNI"].ToString()), row["DNI"].ToString()));
            }

            con.Cerrar();
        }

        // Cargar modificacion
        public void CargarModificacion (ListViewItem lvi)
        {
            id = lvi.SubItems[1].Text;
            TxtCarrera.Text = lvi.SubItems[1].Text;
            TxtAsignaturas.Text = lvi.SubItems[2].Text;

            // Carga profesores
            CargarProfesores();

            comboBoxProfesores.SelectedText = lvi.SubItems[3].Text;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (toolStripLabelAsignatura.Text.Equals("Nueva Asignatura"))
            {
                Conexion con = new Conexion();
                con.Abrir();

                // Obtiene dni del profesor seleccionado
                ComboItem ci = comboBoxProfesores.SelectedItem as ComboItem;

                string query = "INSERT INTO asignatura(id, carrera, asignatura, profesor) VALUES(DEFAULT, '" + TxtCarrera.Text + "', '" + TxtAsignaturas.Text + "', '" + ci.getDni() + "')";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                con.Cerrar();
            } else
            {
                Conexion con = new Conexion();
                con.Abrir();

                try
                {
                    // Obtiene dni del profesor seleccionado
                    ComboItem ci = comboBoxProfesores.SelectedItem as ComboItem;

                    string query = "UPDATE `asignatura` SET `carrera` = '" + TxtCarrera.Text + "', `asignatura` = '" + TxtAsignaturas.Text + "', `profesor` = '" + ci.getDni() + "' WHERE `asignatura`.`ID` = " + id + ";";
                    MySqlCommand comand = con.Comando(query);

                    MySqlDataReader myReader = comand.ExecuteReader();
                } catch (System.NullReferenceException)
                {
                    string queryE = "UPDATE `asignatura` SET `carrera` = '" + TxtCarrera.Text + "', `asignatura` = '" + TxtAsignaturas.Text + "' WHERE `asignatura`.`ID` = " + id + ";";
                    MySqlCommand comandE = con.Comando(queryE);

                    MySqlDataReader myReaderE = comandE.ExecuteReader();
                }
                con.Cerrar();
            }

            FormAsignaturas.sharedInstance.CargarAsignaturas();
            this.Close();
        }

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
