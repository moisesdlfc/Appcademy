using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        // Click boton Entrar
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (!textBoxUsuario.Text.Equals("") || !textBoxPassword.Text.Equals(""))
            {
                if (Utils.comprobarUsuario(textBoxUsuario.Text, textBoxPassword.Text))
                {
                    FormPadre formPadre = new FormPadre();
                    formPadre.Show();

                    this.Close();
                } else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from cuenta";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable cuenta = new DataTable();
            cuenta.Load(myReader);
            if (cuenta.Rows.Count == 0)
            {
                buttonEntrar.Visible = false;
                buttonCrearCuenta.Visible = true;
            } else
            {
                buttonEntrar.Visible = true;
                buttonCrearCuenta.Visible = false;

                
            }
        }

        // Click boton Crear cuenta
        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            // TODO
            if (!textBoxUsuario.Text.Equals("") || !textBoxPassword.Text.Equals(""))
            {
                Utils.guardarUsuario(textBoxUsuario.Text, textBoxPassword.Text);

                MessageBox.Show("Usuario creado correctamente", "USUARIO CREADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormPadre formPadre = new FormPadre();
                formPadre.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos usuario y contraseña no pueden estar vacios, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click btnSalir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Click event mouse down on buttonShowPassword
        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        // Click event mouse up on buttonShowPassword
        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
