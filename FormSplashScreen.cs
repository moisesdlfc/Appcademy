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
    public partial class FormSplashScreen : Form
    {
        // Atributos
        public int timeLeft;
        FormLogin formLogin;

        // Instancia compartida
        //public static FormSplashScreen sharedInstance;

        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            // Make the background color of form display transparently.
            this.TransparencyKey = BackColor;

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from `curso`;";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable cursos = new DataTable();
            cursos.Load(myReader);
            myReader.Close();

            foreach (DataRow row in cursos.Rows)
            {
                Utils.CalcularPrecioCurso(int.Parse(row["id"].ToString()));
            }
            
            // Inicia el timer del SplashScreen
            timeLeft = 5;
            timer.Start();

            // Crea el formLogin
            formLogin = new FormLogin();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            } else
            {
                timer.Stop();

                formLogin.Show();

                this.Hide();
            }
        }
    }
}
