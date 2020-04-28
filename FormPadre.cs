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
    public partial class FormPadre : Form
    {
        // Instancia compartida
        public static FormPadre sharedInstance;

        // Atributos
        private bool formAbierto = false;
        MySqlConnection connection;
        private bool menuHidden;
        int panelWidth;

        // Configuraciones
        public Dictionary<String, Double> precios = new Dictionary<String, Double>();
        public double matricula = 0;
        public List<Aula> aulas = new List<Aula>();

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

        public FormPadre()
        {
            InitializeComponent();

            // Double buffered to avoid flickering in mdi childs
            this.DoubleBuffered = true;

            sharedInstance = this;

            // Save original width of panelMenu
            panelWidth = panelMenu.Width;

            // hide panelMenu
            panelMenu.Width = 0;

            // bool to show/hide panelMenu
            menuHidden = true;

            // EXAMPLE: Asi se abre conexion
            /*Conexion con = new Conexion();
            con.Abrir();
            
            string query = "select * from alumno";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable pruebaTabla = new DataTable();
            pruebaTabla.Load(myReader);
            foreach (DataRow row in pruebaTabla.Rows)
            {
                MessageBox.Show(row["nombre"].ToString());
            }*/
        }

        // Load
        private void FormPadre_Load(object sender, EventArgs e)
        {
            // Carga la configuracion
            //matricula = Utils.cargarMatricula();
            //precios = Utils.cargarPrecios();

            // Set background image to MdiClient
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.OfType<MdiClient>().First().BackgroundImage = Image.FromFile("background.jpg");
        }

        // Event MouseDown
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            //para poder arrastrar el formulario sin bordes
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            w = this.Width;
            h = this.Height;
        }

        // Click menu button
        private void toolStripButtonMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        // TimerMenu
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (menuHidden)
            {
                panelMenu.Width = panelMenu.Width + 15;

                if (panelMenu.Width >= panelWidth)
                {
                    timerMenu.Stop();
                    menuHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelMenu.Width = panelMenu.Width - 15;

                if (panelMenu.Width <= 0)
                {
                    timerMenu.Stop();
                    menuHidden = true;
                    this.Refresh();
                }
            }
        }

        // Click boton salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Click btnSalir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Click btnMinimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Click buttonConfiguracion
        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            FormConfiguracion formConfiguracion = new FormConfiguracion();
            formConfiguracion.Show();
        }

        // Click buttonProfesores
        private void buttonProfesores_Click(object sender, EventArgs e)
        {
            //Controlar que si ya hay un formulario de este tipo no saque mas
            foreach (Form f in MdiChildren)
            {
                if (f.Text.Equals("PROFESORES"))
                {
                    f.WindowState = FormWindowState.Normal;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    formAbierto = true;
                }
                else
                {
                    f.Close();
                }
            }
            if (!formAbierto)
            {
                //Declaro e instancio un FormAlumnos
                FormProfesores fp = new FormProfesores();
                //Le digo que su MdiParent es este Form
                fp.MdiParent = this;
                //Lo abrimos maximizado y centrado
                fp.WindowState = FormWindowState.Normal;
                fp.StartPosition = FormStartPosition.CenterScreen;
                //Lo muestro
                fp.Show();
            }

            //Reseteamos el bool formAbierto
            formAbierto = false;
        }

        // Click buttonAlumnos
        private void buttonAlumnos_Click(object sender, EventArgs e)
        {
            //Controlar que si ya hay un formulario de este tipo no saque mas
            foreach (Form f in MdiChildren)
            {
                if (f.Text.Equals("ALUMNOS"))
                {
                    f.WindowState = FormWindowState.Normal;
                    formAbierto = true;
                    f.StartPosition = FormStartPosition.CenterScreen;
                }
                else
                {
                    f.Close();
                }
            }
            if (!formAbierto)
            {
                //Declaro e instancio un FormAltaDeLibros
                FormAlumnos formAlumnos = new FormAlumnos();
                //Le digo que su MdiParent es este Form
                formAlumnos.MdiParent = this;
                //Lo abrimos maximizado y centrado
                formAlumnos.WindowState = FormWindowState.Normal;
                formAlumnos.StartPosition = FormStartPosition.CenterScreen;

                //Lo muestro
                formAlumnos.Show();
            }

            //Reseteamos el bool formAbierto
            formAbierto = false;
        }

        // Click buttonAsignaturas
        private void buttonAsignaturas_Click(object sender, EventArgs e)
        {
            //Controlar que si ya hay un formulario de este tipo no saque mas
            foreach (Form f in MdiChildren)
            {
                if (f.Text.Equals("ASIGNATURAS"))
                {
                    f.WindowState = FormWindowState.Normal;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    formAbierto = true;
                }
                else
                {
                    f.Close();
                }
            }
            if (!formAbierto)
            {
                //Declaro e instancio un FormAlumnos
                FormAsignaturas fa = new FormAsignaturas();
                //Le digo que su MdiParent es este Form
                fa.MdiParent = this;
                //Lo abrimos maximizado y centrado
                fa.WindowState = FormWindowState.Normal;
                fa.StartPosition = FormStartPosition.CenterScreen;
                //Lo muestro
                fa.Show();
            }

            //Reseteamos el bool formAbierto
            formAbierto = false;
        }

         // Click buttonCursos
        private void buttonCursos_Click(object sender, EventArgs e)
        {
            //Controlar que si ya hay un formulario de este tipo no saque mas
            foreach (Form f in MdiChildren)
            {
                if (f.Text.Equals("CURSOS"))
                {
                    f.WindowState = FormWindowState.Normal;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    formAbierto = true;
                }
                else
                {
                    f.Close();
                }
            }
            if (!formAbierto)
            {
                //Declaro e instancio un FormAlumnos
                FormCursos fc = new FormCursos();
                //Le digo que su MdiParent es este Form
                fc.MdiParent = this;
                //Lo abrimos maximizado y centrado
                fc.WindowState = FormWindowState.Normal;
                fc.StartPosition = FormStartPosition.CenterScreen;
                //Lo muestro
                fc.Show();
            }

            //Reseteamos el bool formAbierto
            formAbierto = false;
        }

         // Click buttonHorarios
        private void buttonHorarios_Click(object sender, EventArgs e)
        {
            //Controlar que si ya hay un formulario de este tipo no saque mas
            foreach (Form f in MdiChildren)
            {
                if (f.Text.Equals("HORARIOS"))
                {
                    f.WindowState = FormWindowState.Normal;
                    f.StartPosition = FormStartPosition.CenterScreen;
                    formAbierto = true;
                }
                else
                {
                    f.Close();
                }
            }
            if (!formAbierto)
            {
                //Declaro e instancio un FormAlumnos
                FormHorarios fh = new FormHorarios();
                //Le digo que su MdiParent es este Form
                fh.MdiParent = this;
                //Lo abrimos maximizado y centrado
                fh.WindowState = FormWindowState.Normal;
                fh.StartPosition = FormStartPosition.CenterScreen;
                //Lo muestro
                fh.Show();
            }

            //Reseteamos el bool formAbierto
            formAbierto = false;
        }
    }
}
