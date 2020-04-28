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
using MySql.Data.MySqlClient;

namespace Appcademy
{
    public partial class FormNuevoAlumno : Form
    {
        MySqlConnection connection;

        public static FormNuevoAlumno shared = new FormNuevoAlumno();

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

        public FormNuevoAlumno()
        {
            InitializeComponent();
            shared = this;
        }

        public FormNuevoAlumno(string title)
        {
            InitializeComponent();
            shared = this;

            // Change text of toolStripLabel1 (title)
            toolStripLabel1.Text = title;
        }

        private void FormNuevoAlumno_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=remotemysql.com;username=TTvn29NRP6;password=ZRNHmASUgv;database=TTvn29NRP6";

            connection = new MySqlConnection(connectionString);

            connection.Open();
            
            MySqlCommand cargarCarreras = new MySqlCommand("SELECT * FROM curso ORDER BY ID");

            cargarCarreras.Connection = connection;

            MySqlDataReader reader = cargarCarreras.ExecuteReader();

            List<String> carreras = new List<String>();

            reader.Close();

            connection.Close();

            if (toolStripLabel1.Text.Equals("Nuevo Alumno"))
            {
                // Actualiza matricula
                checkBoxMatriculaPagada_CheckedChanged(null, null);

                // Carga todos los cursos en listViewCursosDesapuntado
            }

            // Carga todos los cursos en listViewCursosDesapuntado
            cargarCursos("carga_nueva");
        }

        internal void cargarDatosAlumno(ListViewItem lv)
        {
            textBoxDNI.Text = lv.SubItems[0].Text;
            textBoxContrasena.Text = lv.SubItems[1].Text;
            textBoxNombre.Text = lv.SubItems[2].Text;
            textBoxApellidos.Text = lv.SubItems[3].Text;
            TxtTelefono.Text = lv.SubItems[4].Text;

            if (lv.SubItems[5].Text.ToString().Equals("True") || lv.SubItems[5].Text.ToString().Equals("Si") || lv.SubItems[5].Text.ToString().Equals("Yes") || lv.SubItems[5].Text.ToString().Equals("1"))
            {
                checkBoxMatriculaPagada.Checked = true;
            }
            else
            {
                checkBoxMatriculaPagada.Checked = false;
            }

            // Carga cursos
            cargarCursos(lv.SubItems[0].Text);

            // Carga pagosPendientes en listBoxPagosPendientes
            // Selecciona todos los datos de uno de los alumnos apuntados al curso
            Conexion con = new Conexion();
            con.Abrir();

            List<string> cursosAlumno = new List<string>();

            string queryAlumno = "select * from `alumno` WHERE `DNI` = '" + lv.SubItems[0].Text + "';";
            MySqlCommand comandAlumno = con.Comando(queryAlumno);

            MySqlDataReader myReaderAlumno = comandAlumno.ExecuteReader();

            DataTable alumno = new DataTable();
            alumno.Load(myReaderAlumno);
            myReaderAlumno.Close();

            // Si el alumno existe y tiene pagosPendientes crea una lista con dichos pagos
            if (alumno.Rows.Count != 0)
            {
                if (!alumno.Rows[0]["pagosPendientes"].ToString().Equals(""))
                {
                    // Generar lista de pagos pendientes de alumno recorrido
                    cursosAlumno = Utils.GenerarCursosAlumno(alumno.Rows[0]["pagosPendientes"].ToString());
                }

            }

            double totalPagosPendientes = 0.0f;
            // Anade los pagosPendientes del alumno al listBoxPagosPendientes
            foreach (string curso in cursosAlumno)
            {
                totalPagosPendientes += double.Parse(curso.Split('-')[2].ToString());
                listBoxPagosPendientes.Items.Add(curso.Replace('-','_') + "_€");

            }

            // Set totalPagosPendientes on labelTotalPagosPendientes
            labelTotalPagosPendientes.Text = "Total: " + totalPagosPendientes + "_€";

            // Aniade matricula a pagosPendientes en funcion de si el alumno ha pagado matricula o no
            CheckPagoMatricula();
        }

        // Click boton cancelar
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Une los pagosPendientes
            string fullPagosPendientes = "";
            for (int i = 0; i < listBoxPagosPendientes.Items.Count; i++)
            {
                string[] pagoPendientePartes = listBoxPagosPendientes.Items[i].ToString().Split('_');
                fullPagosPendientes += pagoPendientePartes[0] + "-" + pagoPendientePartes[1] + "-" + pagoPendientePartes[2] + "*";
            }

            int matriculaPagada = 0;
            if (checkBoxMatriculaPagada.Checked)
            {
                matriculaPagada = 1;
            }
            connection.Open();
            //Colocar en orden
            if (toolStripLabel1.Text.Equals("Nuevo Alumno"))
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO alumno(DNI, password, nombre, apellidos, telefono, matriculaPagada, pagosPendientes, pagosRealizados, baja) " +
                    "VALUES('" + textBoxDNI.Text + "','" + textBoxContrasena.Text + "','" + textBoxNombre.Text + "', '" + textBoxApellidos.Text + "', '" + TxtTelefono.Text + "', " + matriculaPagada + ", '" + fullPagosPendientes + "', '', " + checkBoxBaja.Checked + ")");

                // TODO ELIMINAR
                //MySqlCommand cmdCursoAula = new MySqlCommand("INSERT INTO cursoalumno(IDCurso, DNIAlumno) " +
                 //   "VALUES('" + listViewClases.Items[0].Text + "','" + textBoxDNI.Text + "')");

                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                //cmdCursoAula.Connection = connection;

                //cmdCursoAula.ExecuteNonQuery();
            }
            else
            {
                /*Pues para hacer esto tendrías que añadir a la base de datos un cursoalumno y Le pasas el id del alumno 
                 * (o el dni no lo recuerdo bien ahira mismo) y el id del curso al que se va a apuntar*/
                /*UPDATE `table_name` SET `column_name` = `new_value' [WHERE condition];*/
                MySqlCommand cmd = new MySqlCommand("UPDATE alumno " +
                    "SET password = '" + textBoxContrasena.Text +
                    "', nombre = '" + textBoxNombre.Text +
                    "', apellidos = '" + textBoxApellidos.Text +
                    "', telefono = '" + TxtTelefono.Text +
                    "', matriculaPagada = " + matriculaPagada +
                    ", pagosPendientes = '" + fullPagosPendientes +
                    "', baja = " + checkBoxBaja.Checked +
                    " WHERE DNI = '" + textBoxDNI.Text + "'");

                // TODO ELIMINAR
                //MySqlCommand cmdCursoAula = new MySqlCommand("UPDATE cursoalumno " +
                //    "SET IDCurso = '" + listViewClases.Items[0].Text +
                //    "' WHERE DNIAlumno = '" + textBoxDNI.Text + "'");


                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                //cmdCursoAula.Connection = connection;

                //cmdCursoAula.ExecuteNonQuery();
            }

            connection.Close();

            FormAlumnos.shared.cargarAlumnos();

            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click apuntar curso
        private void labelPasarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string idCurso = listViewCursosDesapuntado.SelectedItems[0].Text.Split(' ')[0];

                Conexion con = new Conexion();
                con.Abrir();

                string query = "INSERT INTO `cursoalumno` (`IDCurso`, `DNIAlumno`) VALUES ('" + idCurso + "', '" + textBoxDNI.Text + "');";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                // Aniade el curso a apuntados y lo elimina de desapuntados
                listViewCursosApuntado.Items.Add(listViewCursosDesapuntado.SelectedItems[0].Text.Clone().ToString());
                listViewCursosDesapuntado.Items.Remove(listViewCursosDesapuntado.SelectedItems[0]);
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un curso para poder apuntar al alumno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click desapuntar curso
        private void labelEliminarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                string idCurso = listViewCursosApuntado.SelectedItems[0].Text.Split(' ')[0];

                Conexion con = new Conexion();
                con.Abrir();

                string query = "DELETE FROM `cursoalumno` WHERE `cursoalumno`.`IDCurso` = " + idCurso + " AND `cursoalumno`.`DNIAlumno` = '" + textBoxDNI.Text + "';";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                // Aniade el curso a desapuntados y lo elimina de apuntados
                listViewCursosDesapuntado.Items.Add(listViewCursosApuntado.SelectedItems[0].Text.Clone().ToString());
                listViewCursosApuntado.Items.Remove(listViewCursosApuntado.SelectedItems[0]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un curso para poder desapuntar al alumno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click buttonPagado
        private void buttonPagado_Click(object sender, EventArgs e)
        {
            // Elimina el item (pagoPendiente) seleccionado
            // Si el item eliminado es la matricula entonces hace check en checkBoxMatriculaPagada
            if (listBoxPagosPendientes.SelectedItem.ToString().Split('_')[0].Equals("0"))
            {
                checkBoxMatriculaPagada.Checked = true;
            } else
            {
                // Aniade el id del curso pagado a pagosRealizados
                Conexion con = new Conexion();
                con.Abrir();

                string query = "SELECT `pagosRealizados` FROM `alumno` WHERE `DNI` = '" + textBoxDNI.Text + "';";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();
                DataTable tablaPagosRealizados = new DataTable();
                tablaPagosRealizados.Load(myReader);

                string fullPagosRealizados = "";

                if (tablaPagosRealizados.Rows.Count != 0)
                {
                    fullPagosRealizados = tablaPagosRealizados.Rows[0]["pagosRealizados"].ToString() + listBoxPagosPendientes.SelectedItem.ToString().Split('_')[0] + "*";
                } else
                {
                    fullPagosRealizados = listBoxPagosPendientes.SelectedItem.ToString().Split('_')[0] + "*";
                }

                string queryUpdate = "UPDATE `alumno` SET `pagosRealizados` = '" + fullPagosRealizados + "' WHERE `alumno`.`DNI` = '" + textBoxDNI.Text + "';";
                MySqlCommand comandUpdate = con.Comando(queryUpdate);

                MySqlDataReader myReaderUpdate = comandUpdate.ExecuteReader();

                // Elimina de listBoxPagosPendientes
                listBoxPagosPendientes.Items.Remove(listBoxPagosPendientes.SelectedItem);

            }
            
        }

        // Comprueba pagoMatricula
        private void CheckPagoMatricula ()
        {
            // Si la matricula esta pagada entonces lo elimina de pagosPendientes...
            if (checkBoxMatriculaPagada.Checked)
            {
                for (int i = 0; i < listBoxPagosPendientes.Items.Count; i++)
                {
                    if (listBoxPagosPendientes.Items[i].ToString().Split('_')[0].Equals("0"))
                    {
                        listBoxPagosPendientes.Items.Remove(listBoxPagosPendientes.Items[i]);
                    }
                }
            }
            // Si no lo aniade si no esta ya
            else
            {
                bool encontrado = false;

                for (int i = 0; i < listBoxPagosPendientes.Items.Count; i++)
                {
                    if (listBoxPagosPendientes.Items[i].ToString().Split('_')[0].Equals("0"))
                    {
                        encontrado = true;
                    }
                }

                // Si no lo encuentra lo aniade
                if (!encontrado) {
                    Conexion con = new Conexion();
                    con.Abrir();

                    // Carga tipoCurso
                    string query = "SELECT `precioMatricula` FROM `cuenta` WHERE `id` = 0";
                    MySqlCommand comand = con.Comando(query);

                    MySqlDataReader myReader = comand.ExecuteReader();

                    DataTable tablaMatricula = new DataTable();
                    tablaMatricula.Load(myReader);

                    listBoxPagosPendientes.Items.Add("0_Matricula_" + tablaMatricula.Rows[0]["precioMatricula"].ToString() + "_€");
                }
            }
        }

        // Event MouseDown
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            w = this.Width;
            h = this.Height;
        }

        // Checked changed checkBoxMatriculaPagada
        private void checkBoxMatriculaPagada_CheckedChanged(object sender, EventArgs e)
        {
            CheckPagoMatricula();
        }

        // Carga cursos
        public void cargarCursos (string dni)
        {
            // Limpia listViews
            listViewCursosDesapuntado.Items.Clear();
            listViewCursosApuntado.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT * FROM `curso`;";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();
            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            // Introduce todos los cursos en listBiewcursosDesapuntado
            foreach (DataRow row in tablaCursos.Rows)
            {
                listViewCursosDesapuntado.Items.Add(row["ID"].ToString() + " " + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(int.Parse(row["ID"].ToString()))));
            }

            // Busca los cursos a los que esta apuntado el dni en cursoalumnos
            string queryApuntado = "SELECT * FROM `cursoalumno` WHERE `DNIAlumno` = '" + dni + "';";
            MySqlCommand comandApuntado = con.Comando(queryApuntado);

            MySqlDataReader myReaderApuntado = comandApuntado.ExecuteReader();
            DataTable tablaCursosApuntado = new DataTable();
            tablaCursosApuntado.Load(myReaderApuntado);

            // Introduce los cursos a los que esta apuntado el alumno y lo elimina de la lista de desapuntados
            foreach (DataRow row in tablaCursosApuntado.Rows)
            {
                listViewCursosApuntado.Items.Add(row["IDCurso"].ToString() + " " + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(int.Parse(row["IDCurso"].ToString()))));

                List<ListViewItem> itemsEliminar = new List<ListViewItem>();
                foreach (ListViewItem lvi in listViewCursosDesapuntado.Items)
                {
                    if (lvi.Text.Equals(row["IDCurso"].ToString() + " " + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(int.Parse(row["IDCurso"].ToString())))))
                    {
                        itemsEliminar.Add(lvi);
                    }
                }

                foreach(ListViewItem lvi in itemsEliminar)
                {
                    listViewCursosDesapuntado.Items.Remove(lvi);
                }
            }
        }
    }
}
