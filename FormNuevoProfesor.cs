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
    public partial class FormNuevoProfesor : Form
    {
        MySqlConnection connection;

        public static FormNuevoProfesor shared = new FormNuevoProfesor();

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

        public FormNuevoProfesor()
        {
            InitializeComponent();
            shared = this;
        }

        private void FormNuevoProfesor_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=remotemysql.com;username=TTvn29NRP6;password=ZRNHmASUgv;database=TTvn29NRP6";

            connection = new MySqlConnection(connectionString);

            connection.Open();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            string[] fecha = TxtFechaAlta.Text.Split('/');
            string fechaAlta = fecha[2] + "/" + fecha[1] + "/" + fecha[0];

            string pagos = "";

            // TODO unir para guardar
            /*if (cmbPagos.SelectedItem.ToString().Equals("Si"))
            {
                pagosPendientes = "Si";
            }
            else
            {
                pagosPendientes = "No";
            }*/

            string fechaBaja = null;
            if (!TxtFechaBaja.Text.Equals("  /  /"))
            {
                fecha = TxtFechaBaja.Text.Split('/');
                fechaBaja = fecha[2] + "/" + fecha[1] + "/" + fecha[0];

                cmd = new MySqlCommand("INSERT INTO Profesor(DNI, password, nombre, apellidos, pagos, baja, fechaAlta, fechaBaja) " +
                    "VALUES('" + txtDNI + "','" + txtContrasena + "', '" + TxtNombre.Text + "', '" + TxtApellidos.Text + ", " + pagos + ", " + checkBoxBaja.Checked + ", '" + fechaAlta + "', '" + fechaBaja + "')");
            }
            else
            {
                cmd = new MySqlCommand("INSERT INTO Profesor(DNI, password, nombre, apellidos, pagos, baja, fechaAlta, fechaBaja) " +
                     "VALUES('" + txtDNI + "','" + txtContrasena + "', '" + TxtNombre.Text + "', '" + TxtApellidos.Text + "', " + pagos + ", " + checkBoxBaja.Checked + ", '" + fechaAlta + "', '" + fechaBaja + "')");
            }


            cmd.Connection = connection;

            cmd.ExecuteNonQuery();

            FormProfesores.shared.cargarProfesores();

            connection.Close();

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            connection.Close();

            this.Close();
        }

        internal void cargarDatosProfesor(ListViewItem listViewItem)
        {
            txtDNI.Text = listViewItem.SubItems[0].Text;
            txtContrasena.Text = listViewItem.SubItems[1].Text;
            TxtNombre.Text = listViewItem.SubItems[2].Text;
            TxtApellidos.Text = listViewItem.SubItems[3].Text;

            if (listViewItem.SubItems[4].ToString().Equals("True"))
            {
                checkBoxBaja.Checked = true;
            }
            else
            {
                checkBoxBaja.Checked = false;
            }

            /*if (listViewItem.SubItems[5].ToString().Equals("True"))
            {
                cmbPagos.SelectedIndex = 0;
            }
            else
            {
                cmbPagos.SelectedIndex = 1;
            }*/

            string[] fechaA = listViewItem.SubItems[6].Text.Split('/');
            string fechaAlta = fechaA[0] + "/" + fechaA[1] + "/" + fechaA[2];

            TxtFechaAlta.Text = fechaAlta;

            if (!listViewItem.SubItems[7].Text.Equals(""))
            {
                string[] fechaB = listViewItem.SubItems[7].Text.Split('/');
                string fechaBaja = fechaB[0] + "/" + fechaB[1] + "/" + fechaB[2];

                TxtFechaBaja.Text = fechaBaja;
            }

            // Carga los pagos en listBoxPagos
            Conexion con = new Conexion();
            con.Abrir();

            string query = "select `pagos` from `profesor` WHERE `DNI` = '" + listViewItem.SubItems[0].Text + "';";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaPagos = new DataTable();
            tablaPagos.Load(myReader);
            myReader.Close();

            string[] pagos = tablaPagos.Rows[0]["pagos"].ToString().Split('*');

            foreach (string pago in pagos)
            {
                if (!pago.Equals(""))
                {
                    listBoxPagos.Items.Add(pago.Replace('-', ' ') + " €");
                }
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
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
