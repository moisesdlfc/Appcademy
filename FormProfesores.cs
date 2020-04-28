using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormProfesores : Form
    {
        MySqlConnection connection;

        public static FormProfesores shared = new FormProfesores();

        public FormProfesores()
        {
            InitializeComponent();
            shared = this;
        }

        private void BtnNuevoProfesor_Click(object sender, EventArgs e)
        {
            FormNuevoProfesor fp = new FormNuevoProfesor();
            fp.Text = "Nuevo profesor";
            fp.Show();
        }

        private void FormProfesores_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=remotemysql.com;Port=3306;Database=b9TYluBdVP;Uid=b9TYluBdVP;Pwd=KR3ZcAYoPt;";

            connection = new MySqlConnection(connectionString);

            connection.Open();

            cargarProfesores();

            radioButtonNinguno.Checked = true;

            cargarAsignaturas();
        }

        // Cargar asignaturas
        private void cargarAsignaturas()
        {
            MySqlCommand cargarProfesor = new MySqlCommand("SELECT * FROM asignatura");

            cargarProfesor.Connection = connection;

            MySqlDataReader reader = cargarProfesor.ExecuteReader();

            while (reader.Read())
            {
                comboBoxAsignaturas.Items.Add(reader.GetString(2));
            }

            reader.Close();
        }

        public void cargarProfesores()
        {
            MySqlCommand cargarProfesor = new MySqlCommand("SELECT * FROM profesor");

            cargarProfesor.Connection = connection;

            MySqlDataReader reader = cargarProfesor.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = lsvProfesores.Items.Add(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                if (reader.GetString(4).Equals("True"))
                {
                    lv.SubItems.Add("Esta de baja");
                }
                else
                {
                    lv.SubItems.Add("No esta de baja");
                }

                lv.SubItems.Add(reader.GetString(5));

                String[] fechaAlta = Regex.Split(reader.GetString(6), @" ");
                lv.SubItems.Add(fechaAlta[0]);

                if (!reader.GetValue(7).ToString().Equals(""))
                {
                    String[] fechaBaja = Regex.Split(reader.GetString(7), @" ");
                    lv.SubItems.Add(fechaBaja[0]);
                }
                else
                {
                    lv.SubItems.Add("");
                }
            }

            reader.Close();
        }

        private void BtnModificarProfesor_Click(object sender, EventArgs e)
        {
            if (lsvProfesores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un profesor");
            }
            else
            {
                FormNuevoProfesor formNuevoProfesor = new FormNuevoProfesor();
                formNuevoProfesor.Text = "Modificar profesor";
                formNuevoProfesor.Show();
                FormNuevoProfesor.shared.cargarDatosProfesor(lsvProfesores.SelectedItems[0]);
            }
        }

        private void BtnBorrarProfesor_Click(object sender, EventArgs e)
        {
            if (lsvProfesores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un profesor");
            }
            else
            {
                MySqlCommand borrarAlumnos = new MySqlCommand("DELETE profesor WHERE id = " + lsvProfesores.SelectedItems[0].SubItems[0]);

                borrarAlumnos.Connection = connection;

                borrarAlumnos.ExecuteNonQuery();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            lsvProfesores.Items.Clear();
            //Query por defecto en caso de pulsar el botón de búsqueda sin opciones
            String query = "SELECT * FROM profesor";

            if (radioButtonNombreApellidos.Checked)
            {

                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(0, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(0, 2);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(0, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(0, 6);
                }
            }
            else if (radioButtonTelefono.Checked)
            {
                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(1, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(1, 2);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(1, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(1, 6);
                }
            }
            else if (radioButtonNinguno.Checked)
            {
                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(2, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(2, 2);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked))
                {
                    query = comprobacion(2, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked))
                {
                    query = comprobacion(2, 6);
                }
            }


            lsvProfesores.Items.Clear();

            MySqlCommand buscarProfesores = new MySqlCommand(query);

            buscarProfesores.Connection = connection;

            MySqlDataReader lectorProfesores = buscarProfesores.ExecuteReader();

            while (lectorProfesores.Read())
            {
                ListViewItem lv = lsvProfesores.Items.Add(lectorProfesores.GetString(0));
                lv.SubItems.Add(lectorProfesores.GetString(1));
                lv.SubItems.Add(lectorProfesores.GetString(2));
                lv.SubItems.Add(lectorProfesores.GetString(3));
                lv.SubItems.Add(lectorProfesores.GetString(4));
                if (lectorProfesores.GetString(5).Equals("True"))
                {
                    lv.SubItems.Add("Si");
                }
                else
                {
                    lv.SubItems.Add("No");
                }

                lv.SubItems.Add(lectorProfesores.GetString(6));
                lv.SubItems.Add(lectorProfesores.GetString(7));
            }

            lectorProfesores.Close();

        }

        //Método para mostrar los textbox en función del radiobutton
        private void mostrarTextoBusqueda(object sender, EventArgs e)
        {
            if (radioButtonNombreApellidos.Checked)
            {
                TxtBuscarNombreApe.Visible = true;
                txtApellidos.Visible = true;
                lblApellidos.Visible = true;
                TxtBuscarTelefono.Visible = false;
            }
            else if (radioButtonTelefono.Checked)
            {
                TxtBuscarNombreApe.Visible = false;
                txtApellidos.Visible = false;
                lblApellidos.Visible = false;
                TxtBuscarTelefono.Visible = true;
            }
            else if (radioButtonNinguno.Checked)
            {
                TxtBuscarNombreApe.Visible = false;
                txtApellidos.Visible = false;
                lblApellidos.Visible = false;
                TxtBuscarTelefono.Visible = false;
            }
        }

        //Método que comprueba las opciones seleccionadas para la búsqueda y devuelve una query en función de ello
        private String comprobacion(int nombre, int caso)
        {
            //query a devolver
            String query = "";

            //Comprobación de si se ha optado por buscar por nombre o por teléfono
            switch (nombre)
            {
                case 0:
                    //Se inicializa la búsqueda en función del nombre 
                    query = "SELECT * FROM profesor WHERE nombre LIKE '" + TxtBuscarNombreApe.Text + "' AND apellidos LIKE '" + txtApellidos.Text + "'";
                    String n = TxtBuscarNombreApe.Text;
                    //n.Substring(n.Split(" "));

                    //Switch que comprueba los checkbox activos y añade a la query la búsqueda correspondiente
                    switch (caso)
                    {
                        case 0:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 2:
                            query = $"{query} AND pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 4:
                            query = $"{query} AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} AND baja != 0";
                            break;
                    }
                    break;

                case 1:
                    query = "SELECT * FROM profesor WHERE telefono LIKE '" + TxtBuscarNombreApe.Text + "'";

                    switch (caso)
                    {
                        case 0:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 2:
                            query = $"{query} AND pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 4:
                            query = $"{query} AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} AND baja != 0";
                            break;

                    }
                    break;

                case 2:
                    query = "SELECT * FROM profesor";

                    switch (caso)
                    {
                        case 0:
                            query = $"{query} WHERE pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 2:
                            query = $"{query} WHERE pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 4:
                            query = $"{query} WHERE baja != 0 AND matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} WHERE baja != 0";
                            break;

                    }
                    break;
            }
            return query;
        }
    }
}
