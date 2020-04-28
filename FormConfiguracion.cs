using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormConfiguracion : Form
    {
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

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        // Load
        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            // Carga el precio de la matricula en el textBoxMatricula
            textBoxMatricula.Text = Utils.cargarMatricula();

            //cargarDatosPrecios();
            Utils.cargarPrecios(listViewPrecios);

            //Carga gananciaProfesores
            textBoxGananciaProfesores.Text = Utils.cargarGananciaProfesores();

            // Carga los datos de los aulas
            cargarDatosAulas();
        }

        // Click boton Añadir (Precio)
        private void buttonAñadir_Click(object sender, EventArgs e)
        {

            if (!textBoxTipoCurso.Text.Equals("") || !textBoxPrecio.Text.Equals(""))
            {
                Utils.guardarPrecio(textBoxTipoCurso.Text, textBoxPrecio.Text);

                // Actualiza el listViewPrecios
                Utils.cargarPrecios(listViewPrecios);
            } else
            {
                MessageBox.Show("Faltan campos por rellenar, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click boton Eliminar (Precio)
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Utils.eliminarPrecio(listViewPrecios.SelectedItems[0].Tag.ToString());

            // Actualiza el listViewPrecios
            Utils.cargarPrecios(listViewPrecios);
        }

        // Click boton Guardar (Matricula)
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (!textBoxMatricula.Text.Equals(""))
            {
                Utils.guardarMatricula(textBoxMatricula.Text);
            } else
            {
                MessageBox.Show("Debe introducir una cantidad, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Click cargar datos Aulas
        public void cargarDatosAulas()
        {
            Utils.cargarAulas(listViewAulas);
        }

        // Click boton Añadir aula
        private void buttonAñadirAula_Click(object sender, EventArgs e)
        {
            if (!textBoxNombreAula.Text.Equals(""))
            {
                Utils.guardarAula(textBoxNombreAula.Text);

                // Recarga datos aulas
                cargarDatosAulas();
            } else
            {
                MessageBox.Show("Debe introducir un nombre de aula, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Click boton Eliminar (Aula)
        private void buttonEliminarAula_Click(object sender, EventArgs e)
        {
            try {
                Utils.eliminarAula(listViewAulas.SelectedItems[0].Tag.ToString());

                // Recarga datos aulas
                cargarDatosAulas();
            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar un aula, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click boton Guardar cuenta
        private void buttonGuardarCuenta_Click(object sender, EventArgs e)
        {
            if (!textBoxUsuario.Text.Equals("") || !textBoxContraseñaActual.Text.Equals("") || !textBoxNuevaContraseña.Text.Equals(""))
            {
                if (Utils.comprobarUsuario(textBoxUsuario.Text, textBoxContraseñaActual.Text))
                {
                    Utils.guardarUsuario(textBoxUsuario.Text, textBoxNuevaContraseña.Text);

                    // Limpia los campos
                    textBoxUsuario.Text = "";
                    textBoxContraseñaActual.Text = "";
                    textBoxNuevaContraseña.Text = "";
                } else
                {
                    // Informa al usuario
                    MessageBox.Show("El usuario o la contraseña actual es incorrecto, inténtelo de nuevo...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos, inténtelo de nuevo...", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click salir
        private void btnSalir_Click_1(object sender, EventArgs e)
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

        // Click guardar ganancia profesores
        private void buttonGuardarGananciaProfesores_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBoxGananciaProfesores.Text.Replace('.', ',')) >= 0 && double.Parse(textBoxGananciaProfesores.Text.Replace('.', ',')) <= 100)
            {
                Utils.guardarGananciaProfesores(double.Parse(textBoxGananciaProfesores.Text.Replace('.', ',')));
            } else
            {
                MessageBox.Show("El porcentaje introducido no es correcto", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
