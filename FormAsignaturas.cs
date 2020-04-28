using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormAsignaturas : Form
    {
        // Shard instance
        public static FormAsignaturas sharedInstance;

        public FormAsignaturas()
        {
            InitializeComponent();
            sharedInstance = this;
        }

        // Click boton Nueva asignatura
        private void BtnNuevaAsignatura_Click(object sender, EventArgs e)
        {
            FormNuevoAsignatura fa = new FormNuevoAsignatura("Nueva Asignatura");
            fa.Show();
        }

        // Load
        private void FormAsignaturas_Load(object sender, EventArgs e)
        {
            CargarAsignaturas();
        }

        // Cargar asignaturas
        public void CargarAsignaturas()
        {
            // Limpia listViewAsignaturas
            listViewAsignaturas.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `asignatura`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAsignaturas = new DataTable();
            tablaAsignaturas.Load(myReader);

            foreach (DataRow row in tablaAsignaturas.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = row["ID"].ToString();
                lvi.SubItems.Add(row["carrera"].ToString());
                lvi.SubItems.Add(row["asignatura"].ToString());
                lvi.SubItems.Add(IDtoTEXT.GetProfesorFullNameFromDNIInProfesor(row["profesor"].ToString()));

                listViewAsignaturas.Items.Add(lvi);
            }

            con.Cerrar();
        }

        // Click modificar asignatura
        private void BtnModificarAsignatura_Click(object sender, EventArgs e)
        {
            FormNuevoAsignatura formNuevaAsignatura = new FormNuevoAsignatura("Modificar Asignatura");
            formNuevaAsignatura.Show();

            formNuevaAsignatura.CargarModificacion(listViewAsignaturas.SelectedItems[0]);
        }

        // Click BtnBorrarAsignatura
        private void BtnBorrarAsignatura_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listViewAsignaturas.SelectedItems[0];

            Conexion con = new Conexion();
            con.Abrir();
            string query = "DELETE FROM `asignatura` WHERE `asignatura`.`ID` = " + lvi.Text;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            CargarAsignaturas();
        }
    }
}
