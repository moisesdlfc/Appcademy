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
    public partial class FormCursos : Form
    {
        // Shared instance
        public static FormCursos sharedInstance;

        public FormCursos()
        {
            InitializeComponent();
            sharedInstance = this;
        }

        // Load
        private void FormCursos_Load(object sender, EventArgs e)
        {
            // Carga cursos
            CargarCursos();
        }

        // Cargar cursos
        public void CargarCursos()
        {
            // Limpia listViewCursos
            listViewCursos.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `curso`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            // Carga los datos en listViewCursos
            foreach (DataRow row in tablaCursos.Rows)
            {
                // id
                ListViewItem lvi = new ListViewItem();
                lvi.Text = row["id"].ToString();

                // asignatura
                string queryAs = "SELECT `asignatura` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                MySqlCommand comandAs = con.Comando(queryAs);
                MySqlDataReader myReaderAs = comandAs.ExecuteReader();
                DataTable tablaAsignatura = new DataTable();
                tablaAsignatura.Load(myReaderAs);
                lvi.SubItems.Add(tablaAsignatura.Rows[0]["asignatura"].ToString());

                // tipoCurso
                string queryTC = "SELECT `tipoCurso` FROM `precio` WHERE `id` = " + row["tipoCurso"].ToString();
                MySqlCommand comandTC = con.Comando(queryTC);
                MySqlDataReader myReaderTC = comandTC.ExecuteReader();
                DataTable tablaTC = new DataTable();
                tablaTC.Load(myReaderTC);
                lvi.SubItems.Add(tablaTC.Rows[0]["tipoCurso"].ToString());

                // precio
                lvi.SubItems.Add(row["precio"].ToString());

                // Add to listViewCursos
                listViewCursos.Items.Add(lvi);
            }
        }

        // Nuevo curso
        private void BtnNuevoCurso_Click(object sender, EventArgs e)
        {
            //Abre FormNuevoCurso
            FormNuevoCurso formNuevoCurso = new FormNuevoCurso();
            formNuevoCurso.Show();
        }

        // Click Modificar curso
        private void BtnModificarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre FormModificarCurso
                FormModificarCurso formModificarCurso = new FormModificarCurso();
                formModificarCurso.Show();
                formModificarCurso.loadItemSelected(listViewCursos.SelectedItems[0]);
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un curso para poder modificarlo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click BtnBorrarCurso
        private void BtnBorrarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listViewCursos.SelectedItems[0];

                Conexion con = new Conexion();
                con.Abrir();
                string query = "DELETE FROM `curso` WHERE `curso`.`ID` = " + lvi.Text;
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                // Borra el curso del listViewCursos
                listViewCursos.Items.Remove(listViewCursos.SelectedItems[0]);

                MessageBox.Show("Curso seleccionado eliminado", "CURSO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un curso para poder eliminarlo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // RadioButton changed
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Clear comboBoxBusquedaCursos and clear text
            comboBoxBusquedaCursos.Items.Clear();
            comboBoxBusquedaCursos.Text = "";

            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                switch (rb.Text)
                {
                    case "Carrera":
                        // Muestra comboBoxBusquedaCursos
                        comboBoxBusquedaCursos.Visible = true;

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
                            comboBoxBusquedaCursos.Items.Add(carrera);
                        }

                        con.Cerrar();
                        break;

                    case "Asignatura":
                        // Muestra comboBoxBusquedaCursos
                        comboBoxBusquedaCursos.Visible = true;

                        List<string> asignaturas = new List<string>();
                        bool asignaturaRepetida = false;
                        // Carga carreras
                        Conexion conA = new Conexion();
                        conA.Abrir();

                        string queryA = "SELECT `asignatura` FROM `asignatura`";
                        MySqlCommand comandA = conA.Comando(queryA);

                        MySqlDataReader myReaderA = comandA.ExecuteReader();

                        DataTable tablaAsignaturas = new DataTable();
                        tablaAsignaturas.Load(myReaderA);

                        // Guarda en una lista todas las carreras (sin repeticiones)
                        foreach (DataRow row in tablaAsignaturas.Rows)
                        {
                            foreach (string asignatura in asignaturas)
                            {
                                if (asignatura.Equals(row["asignatura"].ToString()))
                                {
                                    asignaturaRepetida = true;
                                    break;
                                }
                            }

                            if (!asignaturaRepetida)
                            {
                                asignaturas.Add(row["asignatura"].ToString());
                            }

                            // reset repetido
                            asignaturaRepetida = false;
                        }

                        // Introduce todas las carreras (sin repeticiones) en el comboBoxCarrera
                        foreach (string asignatura in asignaturas)
                        {
                            comboBoxBusquedaCursos.Items.Add(asignatura);
                        }

                        conA.Cerrar();
                        break;

                    case "Tipo de curso":
                        // Muestra comboBoxBusquedaCursos
                        comboBoxBusquedaCursos.Visible = true;

                        List<string> tipoCurso = new List<string>();
                        bool tipoCursoRepetido = false;
                        // Carga carreras
                        Conexion conT = new Conexion();
                        conT.Abrir();

                        string queryT = "SELECT `tipoCurso` FROM `precio`";
                        MySqlCommand comandT = conT.Comando(queryT);

                        MySqlDataReader myReaderT = comandT.ExecuteReader();

                        DataTable tablaTipoCurso = new DataTable();
                        tablaTipoCurso.Load(myReaderT);

                        // Guarda en una lista todas las carreras (sin repeticiones)
                        foreach (DataRow row in tablaTipoCurso.Rows)
                        {
                            foreach (string tipo in tipoCurso)
                            {
                                if (tipo.Equals(row["tipoCurso"].ToString()))
                                {
                                    tipoCursoRepetido = true;
                                    break;
                                }
                            }

                            if (!tipoCursoRepetido)
                            {
                                tipoCurso.Add(row["tipoCurso"].ToString());
                            }

                            // reset repetido
                            tipoCursoRepetido = false;
                        }

                        // Introduce todas las carreras (sin repeticiones) en el comboBoxCarrera
                        foreach (string tipo in tipoCurso)
                        {
                            comboBoxBusquedaCursos.Items.Add(tipo);
                        }

                        conT.Cerrar();
                        break;

                    case "Profesor":
                        // Muestra comboBoxBusquedaCursos
                        comboBoxBusquedaCursos.Visible = true;

                        List<string> profesores = new List<string>();
                        bool profesorRepetido = false;
                        // Carga carreras
                        Conexion conP = new Conexion();
                        conP.Abrir();

                        string queryP = "SELECT `nombre`, `apellidos` FROM `profesor`";
                        MySqlCommand comandP = conP.Comando(queryP);

                        MySqlDataReader myReaderP = comandP.ExecuteReader();

                        DataTable tablaProfesores = new DataTable();
                        tablaProfesores.Load(myReaderP);

                        // Guarda en una lista todas las carreras (sin repeticiones)
                        foreach (DataRow row in tablaProfesores.Rows)
                        {
                            foreach (string profesor in profesores)
                            {
                                if (profesor.Equals(row["nombre"].ToString() + " " + row["apellidos"].ToString()))
                                {
                                    profesorRepetido = true;
                                    break;
                                }
                            }

                            if (!profesorRepetido)
                            {
                                profesores.Add(row["nombre"].ToString() + " " + row["apellidos"].ToString());
                            }

                            // reset repetido
                            profesorRepetido = false;
                        }

                        // Introduce todas las carreras (sin repeticiones) en el comboBoxCarrera
                        foreach (string profesor in profesores)
                        {
                            comboBoxBusquedaCursos.Items.Add(profesor);
                        }

                        conP.Cerrar();
                        break;

                    case "Mostrar todos":
                        // Oculta comboBoxBusquedaCursos
                        comboBoxBusquedaCursos.Visible = false;

                        // Carga todos los cursos
                        CargarCursos();
                        break;

                    default:

                        break;
                }
            }
        }

        // Click BtnBuscar
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpia listViewCursos
                listViewCursos.Items.Clear();

                RadioButton rb = new RadioButton();

                if (radioButtonCarrera.Checked)
                {
                    rb = radioButtonCarrera;
                }
                else if (radioButtonAsignatura.Checked)
                {
                    rb = radioButtonAsignatura;
                }
                else if (radioButtonTipoCurso.Checked)
                {
                    rb = radioButtonTipoCurso;
                }
                else if (radioButtonProfesor.Checked)
                {
                    rb = radioButtonProfesor;
                }
                else if (radioButtonMostrarTodos.Checked)
                {
                    rb = radioButtonMostrarTodos;
                }

                switch (rb.Text)
                {
                    case "Carrera":
                        // Carga todos los cursos
                        Conexion con = new Conexion();
                        con.Abrir();
                        string query = "SELECT * FROM `curso`";
                        MySqlCommand comand = con.Comando(query);

                        MySqlDataReader myReader = comand.ExecuteReader();

                        DataTable tablaCursos = new DataTable();
                        tablaCursos.Load(myReader);

                        // Carga los datos en listViewCursos
                        foreach (DataRow row in tablaCursos.Rows)
                        {
                            ListViewItem lvi = new ListViewItem();

                            // asignatura
                            string queryAs = "SELECT `carrera`, `asignatura` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                            MySqlCommand comandAs = con.Comando(queryAs);
                            MySqlDataReader myReaderAs = comandAs.ExecuteReader();
                            DataTable tablaAsignatura = new DataTable();
                            tablaAsignatura.Load(myReaderAs);

                            if (tablaAsignatura.Rows[0]["carrera"].ToString().Equals(comboBoxBusquedaCursos.SelectedItem.ToString()))
                            {
                                // id
                                lvi.Text = row["id"].ToString();

                                // asignatura
                                lvi.SubItems.Add(tablaAsignatura.Rows[0]["asignatura"].ToString());

                                // tipoCurso
                                string queryTC = "SELECT `tipoCurso` FROM `precio` WHERE `id` = " + row["tipoCurso"].ToString();
                                MySqlCommand comandTC = con.Comando(queryTC);
                                MySqlDataReader myReaderTC = comandTC.ExecuteReader();
                                DataTable tablaTC = new DataTable();
                                tablaTC.Load(myReaderTC);
                                lvi.SubItems.Add(tablaTC.Rows[0]["tipoCurso"].ToString());

                                // precio
                                lvi.SubItems.Add(row["precio"].ToString());

                                // Add to listViewCursos
                                listViewCursos.Items.Add(lvi);
                            }

                        }
                        con.Cerrar();
                        break;

                    case "Asignatura":
                        // Carga todos los cursos
                        Conexion con2 = new Conexion();
                        con2.Abrir();
                        string query2 = "SELECT * FROM `curso`";
                        MySqlCommand comand2 = con2.Comando(query2);

                        MySqlDataReader myReader2 = comand2.ExecuteReader();

                        DataTable tablaCursos2 = new DataTable();
                        tablaCursos2.Load(myReader2);

                        // Carga los datos en listViewCursos
                        foreach (DataRow row in tablaCursos2.Rows)
                        {
                            ListViewItem lvi = new ListViewItem();

                            // asignatura
                            string queryAs = "SELECT `asignatura` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                            MySqlCommand comandAs = con2.Comando(queryAs);
                            MySqlDataReader myReaderAs = comandAs.ExecuteReader();
                            DataTable tablaAsignatura = new DataTable();
                            tablaAsignatura.Load(myReaderAs);

                            if (tablaAsignatura.Rows[0]["asignatura"].ToString().Equals(comboBoxBusquedaCursos.SelectedItem.ToString()))
                            {
                                // id
                                lvi.Text = row["id"].ToString();

                                // asignatura
                                lvi.SubItems.Add(tablaAsignatura.Rows[0]["asignatura"].ToString());

                                // tipoCurso
                                string queryTC = "SELECT `tipoCurso` FROM `precio` WHERE `id` = " + row["tipoCurso"].ToString();
                                MySqlCommand comandTC = con2.Comando(queryTC);
                                MySqlDataReader myReaderTC = comandTC.ExecuteReader();
                                DataTable tablaTC = new DataTable();
                                tablaTC.Load(myReaderTC);
                                lvi.SubItems.Add(tablaTC.Rows[0]["tipoCurso"].ToString());

                                // precio
                                lvi.SubItems.Add(row["precio"].ToString());

                                // Add to listViewCursos
                                listViewCursos.Items.Add(lvi);
                            }
                        }

                        con2.Cerrar();
                        break;

                    case "Tipo de curso":
                        // Carga todos los cursos
                        Conexion con3 = new Conexion();
                        con3.Abrir();
                        string query3 = "SELECT * FROM `curso`";
                        MySqlCommand comand3 = con3.Comando(query3);

                        MySqlDataReader myReader3 = comand3.ExecuteReader();

                        DataTable tablaCursos3 = new DataTable();
                        tablaCursos3.Load(myReader3);

                        // Carga los datos en listViewCursos
                        foreach (DataRow row in tablaCursos3.Rows)
                        {
                            ListViewItem lvi = new ListViewItem();

                            string queryTC = "SELECT `tipoCurso` FROM `precio` WHERE `id` = " + row["tipoCurso"].ToString();
                            MySqlCommand comandTC = con3.Comando(queryTC);
                            MySqlDataReader myReaderTC = comandTC.ExecuteReader();
                            DataTable tablaTC = new DataTable();
                            tablaTC.Load(myReaderTC);

                            if (tablaTC.Rows[0]["tipoCurso"].ToString().Equals(comboBoxBusquedaCursos.SelectedItem.ToString()))
                            {
                                // id
                                lvi.Text = row["id"].ToString();

                                // asignatura
                                string queryAs = "SELECT `asignatura` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                                MySqlCommand comandAs = con3.Comando(queryAs);
                                MySqlDataReader myReaderAs = comandAs.ExecuteReader();
                                DataTable tablaAsignatura = new DataTable();
                                tablaAsignatura.Load(myReaderAs);
                                lvi.SubItems.Add(tablaAsignatura.Rows[0]["asignatura"].ToString());

                                // tipoCurso
                                lvi.SubItems.Add(tablaTC.Rows[0]["tipoCurso"].ToString());

                                // precio
                                lvi.SubItems.Add(row["precio"].ToString());

                                // Add to listViewCursos
                                listViewCursos.Items.Add(lvi);
                            }
                        }

                        con3.Cerrar();
                        break;

                    case "Profesor":
                        // Carga todos los cursos
                        Conexion con4 = new Conexion();
                        con4.Abrir();
                        string query4 = "SELECT * FROM `curso`";
                        MySqlCommand comand4 = con4.Comando(query4);

                        MySqlDataReader myReader4 = comand4.ExecuteReader();

                        DataTable tablaCursos4 = new DataTable();
                        tablaCursos4.Load(myReader4);

                        // Carga los datos en listViewCursos
                        foreach (DataRow row in tablaCursos4.Rows)
                        {
                            ListViewItem lvi = new ListViewItem();

                            string queryPr = "SELECT `profesor` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                            MySqlCommand comandPr = con4.Comando(queryPr);
                            MySqlDataReader myReaderPr = comandPr.ExecuteReader();
                            DataTable tablaPr = new DataTable();
                            tablaPr.Load(myReaderPr);

                            string nombreProfesor = IDtoTEXT.GetProfesorFullNameFromDNIInProfesor(tablaPr.Rows[0]["profesor"].ToString());

                            if (nombreProfesor.Equals(comboBoxBusquedaCursos.SelectedItem.ToString()))
                            {
                                // id
                                lvi.Text = row["id"].ToString();

                                // asignatura
                                string queryAs = "SELECT `asignatura` FROM `asignatura` WHERE `id` = " + row["asignatura"].ToString();
                                MySqlCommand comandAs = con4.Comando(queryAs);
                                MySqlDataReader myReaderAs = comandAs.ExecuteReader();
                                DataTable tablaAsignatura = new DataTable();
                                tablaAsignatura.Load(myReaderAs);
                                lvi.SubItems.Add(tablaAsignatura.Rows[0]["asignatura"].ToString());

                                // tipoCurso
                                string queryTC = "SELECT `tipoCurso` FROM `precio` WHERE `id` = " + row["tipoCurso"].ToString();
                                MySqlCommand comandTC = con4.Comando(queryTC);
                                MySqlDataReader myReaderTC = comandTC.ExecuteReader();
                                DataTable tablaTC = new DataTable();
                                tablaTC.Load(myReaderTC);
                                lvi.SubItems.Add(tablaTC.Rows[0]["tipoCurso"].ToString());

                                // precio
                                lvi.SubItems.Add(row["precio"].ToString());

                                // Add to listViewCursos
                                listViewCursos.Items.Add(lvi);
                            }
                        }

                        con4.Cerrar();
                        break;

                    case "Mostrar todos":
                        CargarCursos();
                        break;

                    default:

                        break;
                }
            } catch (System.NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar un elemento para realizar una busqueda.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
