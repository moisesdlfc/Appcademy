using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Appcademy
{
    public partial class FormAlumnos : Form
    {

        public static FormAlumnos shared = new FormAlumnos();

        MySqlConnection connection;

        public FormAlumnos()
        {
            InitializeComponent();
            shared = this;
        }

        private void FormAlumnos_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server=remotemysql.com;Port=3306;Database=b9TYluBdVP;Uid=b9TYluBdVP;Pwd=KR3ZcAYoPt;";

            connection = new MySqlConnection(connectionString);

            connection.Open();

            cargarAlumnos();
        }

        public void cargarAlumnos()
        {
            // Limpia listViewAlumnos
            listViewAlumnos.Items.Clear();

            MySqlCommand cargarAlumnos = new MySqlCommand("SELECT * FROM alumno");

            cargarAlumnos.Connection = connection;

            MySqlDataReader reader = cargarAlumnos.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = listViewAlumnos.Items.Add(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));
                lv.SubItems.Add(reader.GetString(6));
            }

            reader.Close();
        }

        // Click boton ´Nuevo alumno´
        private void buttonNuevoAlumno_Click(object sender, EventArgs e)
        {
            FormNuevoAlumno formNuevoAlumno = new FormNuevoAlumno("Nuevo Alumno");
            formNuevoAlumno.Show();
        }

        // Click boton ´Modificar alumno´
        private void buttonModificarAlumno_Click(object sender, EventArgs e)
        {
            if (listViewAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un contacto");
            }
            else
            {
                FormNuevoAlumno formNuevoAlumno = new FormNuevoAlumno("Modificar Alumno");
                formNuevoAlumno.Show();
                FormNuevoAlumno.shared.cargarDatosAlumno(listViewAlumnos.SelectedItems[0]);
            }

        }

        private void BtnBorrarAlumno_Click(object sender, EventArgs e)
        {
            if (listViewAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un contacto");
            }
            else
            {
                MySqlCommand borrarAlumnos = new MySqlCommand("DELETE FROM `alumno` WHERE `dni` = '" + listViewAlumnos.SelectedItems[0].SubItems[0].Text + "';");

                borrarAlumnos.Connection = connection;

                borrarAlumnos.ExecuteNonQuery();
            }

            cargarAlumnos();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            listViewAlumnos.Items.Clear();
            //Query por defecto en caso de pulsar el botón de búsqueda sin opciones
            String query = "SELECT * FROM alumno";

            if (radioButtonNombreApellidos.Checked)
            {

                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 1);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 2);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 3);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 5);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 6);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(0, 7);
                }
            }
            else if (radioButtonTelefono.Checked)
            {
                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 1);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 2);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 3);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 5);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 6);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(1, 7);
                }
            }
            else if (radioButtonNinguno.Checked)
            {
                if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 0);
                }
                else if ((checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 1);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 2);
                }
                else if ((checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 3);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 4);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 5);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 6);
                }
                else if ((!checkBoxPagosPendientes.Checked) && (!checkBoxBaja.Checked) && (!checkBoxPagoMatricula.Checked))
                {
                    query = comprobacion(2, 7);
                }
            }


            listViewAlumnos.Items.Clear();

            MySqlCommand buscarAlumnos = new MySqlCommand(query);

            buscarAlumnos.Connection = connection;

            MySqlDataReader lectorAlumnos = buscarAlumnos.ExecuteReader();

            while (lectorAlumnos.Read())
            {
                ListViewItem lv = listViewAlumnos.Items.Add(lectorAlumnos.GetString(0));
                lv.SubItems.Add(lectorAlumnos.GetString(1));
                lv.SubItems.Add(lectorAlumnos.GetString(2));
                lv.SubItems.Add(lectorAlumnos.GetString(3));
                lv.SubItems.Add(lectorAlumnos.GetString(4));
                if (lectorAlumnos.GetString(5).Equals("True"))
                {
                    lv.SubItems.Add("Si");
                }
                else
                {
                    lv.SubItems.Add("No");
                }

                lv.SubItems.Add(lectorAlumnos.GetString(6));
            }

            lectorAlumnos.Close();

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
                    query = "SELECT * FROM alumno WHERE nombre LIKE '" + TxtBuscarNombreApe.Text + "' AND apellidos LIKE '" + txtApellidos.Text + "'";

                    //Switch que comprueba los checkbox activos y añade a la query la búsqueda correspondiente
                    switch (caso)
                    {
                        case 0:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 1:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0";
                            break;
                        case 2:
                            query = $"{query} AND pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 3:
                            query = $"{query} AND pagosPendientes != 0";
                            break;
                        case 4:
                            query = $"{query} AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 5:
                            query = $"{query} AND matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} AND baja != 0";
                            break;
                        case 7:
                            break;
                    }
                    break;

                case 1:
                    query = "SELECT * FROM alumno WHERE telefono LIKE '" + TxtBuscarNombreApe.Text + "'";

                    switch (caso)
                    {
                        case 0:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 1:
                            query = $"{query} AND pagosPendientes != 0 AND baja != 0";
                            break;
                        case 2:
                            query = $"{query} AND pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 3:
                            query = $"{query} AND pagosPendientes != 0";
                            break;
                        case 4:
                            query = $"{query} AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 5:
                            query = $"{query} AND matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} AND baja != 0";
                            break;
                        case 7:
                            break;

                    }
                    break;

                case 2:
                    query = "SELECT * FROM alumno";

                    switch (caso)
                    {
                        case 0:
                            query = $"{query} WHERE pagosPendientes != 0 AND baja != 0 AND matriculaPagada != 0";
                            break;
                        case 1:
                            query = $"{query} WHERE pagosPendientes != 0 AND baja != 0";
                            break;
                        case 2:
                            query = $"{query} WHERE pagosPendientes != 0 AND matriculaPagada != 0";
                            break;
                        case 3:
                            query = $"{query} WHERE pagosPendientes != 0";
                            break;
                        case 4:
                            query = $"{query} WHERE baja != 0 AND matriculaPagada != 0";
                            break;
                        case 5:
                            query = $"{query} WHERE matriculaPagada != 0";
                            break;
                        case 6:
                            query = $"{query} WHERE baja != 0";
                            break;
                        case 7:
                            break;

                    }
                    break;
            }
            return query;
        }
    }
}
