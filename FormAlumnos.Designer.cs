using System.Windows.Forms;

namespace Appcademy
{
    partial class FormAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlumnos));
            this.groupBoxAdministracionUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnBorrarAlumno = new System.Windows.Forms.Button();
            this.BtnModificarAlumno = new System.Windows.Forms.Button();
            this.BtnNuevoAlumno = new System.Windows.Forms.Button();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.radioButtonNinguno = new System.Windows.Forms.RadioButton();
            this.TxtBuscarTelefono = new System.Windows.Forms.TextBox();
            this.checkBoxPagoMatricula = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscarNombreApe = new System.Windows.Forms.TextBox();
            this.radioButtonNombreApellidos = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.radioButtonTelefono = new System.Windows.Forms.RadioButton();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.checkBoxPagosPendientes = new System.Windows.Forms.CheckBox();
            this.listViewAlumnos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdministracionUsuarios.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdministracionUsuarios
            // 
            this.groupBoxAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnBorrarAlumno);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnModificarAlumno);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnNuevoAlumno);
            this.groupBoxAdministracionUsuarios.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdministracionUsuarios.Location = new System.Drawing.Point(25, 35);
            this.groupBoxAdministracionUsuarios.Name = "groupBoxAdministracionUsuarios";
            this.groupBoxAdministracionUsuarios.Size = new System.Drawing.Size(384, 69);
            this.groupBoxAdministracionUsuarios.TabIndex = 15;
            this.groupBoxAdministracionUsuarios.TabStop = false;
            this.groupBoxAdministracionUsuarios.Text = "ADMINISTRACIÓN DE ALUMNOS";
            // 
            // BtnBorrarAlumno
            // 
            this.BtnBorrarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBorrarAlumno.FlatAppearance.BorderSize = 0;
            this.BtnBorrarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarAlumno.ForeColor = System.Drawing.Color.Black;
            this.BtnBorrarAlumno.Location = new System.Drawing.Point(251, 19);
            this.BtnBorrarAlumno.Name = "BtnBorrarAlumno";
            this.BtnBorrarAlumno.Size = new System.Drawing.Size(107, 36);
            this.BtnBorrarAlumno.TabIndex = 12;
            this.BtnBorrarAlumno.Text = "Borrar alumno";
            this.BtnBorrarAlumno.UseVisualStyleBackColor = false;
            this.BtnBorrarAlumno.Click += new System.EventHandler(this.BtnBorrarAlumno_Click);
            // 
            // BtnModificarAlumno
            // 
            this.BtnModificarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnModificarAlumno.FlatAppearance.BorderSize = 0;
            this.BtnModificarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarAlumno.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarAlumno.Location = new System.Drawing.Point(138, 19);
            this.BtnModificarAlumno.Name = "BtnModificarAlumno";
            this.BtnModificarAlumno.Size = new System.Drawing.Size(107, 36);
            this.BtnModificarAlumno.TabIndex = 11;
            this.BtnModificarAlumno.Text = "Modificar alumno";
            this.BtnModificarAlumno.UseVisualStyleBackColor = false;
            this.BtnModificarAlumno.Click += new System.EventHandler(this.buttonModificarAlumno_Click);
            // 
            // BtnNuevoAlumno
            // 
            this.BtnNuevoAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnNuevoAlumno.FlatAppearance.BorderSize = 0;
            this.BtnNuevoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevoAlumno.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevoAlumno.Location = new System.Drawing.Point(25, 19);
            this.BtnNuevoAlumno.Name = "BtnNuevoAlumno";
            this.BtnNuevoAlumno.Size = new System.Drawing.Size(107, 36);
            this.BtnNuevoAlumno.TabIndex = 10;
            this.BtnNuevoAlumno.Text = "Nuevo alumno";
            this.BtnNuevoAlumno.UseVisualStyleBackColor = false;
            this.BtnNuevoAlumno.Click += new System.EventHandler(this.buttonNuevoAlumno_Click);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBusqueda.Controls.Add(this.txtApellidos);
            this.groupBoxBusqueda.Controls.Add(this.lblApellidos);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonNinguno);
            this.groupBoxBusqueda.Controls.Add(this.TxtBuscarTelefono);
            this.groupBoxBusqueda.Controls.Add(this.checkBoxPagoMatricula);
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Controls.Add(this.TxtBuscarNombreApe);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonNombreApellidos);
            this.groupBoxBusqueda.Controls.Add(this.BtnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonTelefono);
            this.groupBoxBusqueda.Controls.Add(this.checkBoxBaja);
            this.groupBoxBusqueda.Controls.Add(this.checkBoxPagosPendientes);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusqueda.ForeColor = System.Drawing.Color.White;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(25, 109);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(384, 394);
            this.groupBoxBusqueda.TabIndex = 14;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "BÚSQUEDA DE ALUMNOS";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(138, 80);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(199, 20);
            this.txtApellidos.TabIndex = 15;
            this.txtApellidos.Visible = false;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(39, 82);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 14;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.Visible = false;
            // 
            // radioButtonNinguno
            // 
            this.radioButtonNinguno.AutoSize = true;
            this.radioButtonNinguno.Location = new System.Drawing.Point(25, 128);
            this.radioButtonNinguno.Name = "radioButtonNinguno";
            this.radioButtonNinguno.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNinguno.TabIndex = 13;
            this.radioButtonNinguno.TabStop = true;
            this.radioButtonNinguno.Text = "Ninguno";
            this.radioButtonNinguno.UseVisualStyleBackColor = true;
            this.radioButtonNinguno.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // TxtBuscarTelefono
            // 
            this.TxtBuscarTelefono.Location = new System.Drawing.Point(138, 105);
            this.TxtBuscarTelefono.Name = "TxtBuscarTelefono";
            this.TxtBuscarTelefono.Size = new System.Drawing.Size(199, 20);
            this.TxtBuscarTelefono.TabIndex = 12;
            this.TxtBuscarTelefono.Visible = false;
            // 
            // checkBoxPagoMatricula
            // 
            this.checkBoxPagoMatricula.AutoSize = true;
            this.checkBoxPagoMatricula.Location = new System.Drawing.Point(25, 200);
            this.checkBoxPagoMatricula.Name = "checkBoxPagoMatricula";
            this.checkBoxPagoMatricula.Size = new System.Drawing.Size(161, 17);
            this.checkBoxPagoMatricula.TabIndex = 11;
            this.checkBoxPagoMatricula.Text = "Pago de matricula pendiente";
            this.checkBoxPagoMatricula.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Busqueda por:";
            // 
            // TxtBuscarNombreApe
            // 
            this.TxtBuscarNombreApe.Location = new System.Drawing.Point(138, 55);
            this.TxtBuscarNombreApe.Name = "TxtBuscarNombreApe";
            this.TxtBuscarNombreApe.Size = new System.Drawing.Size(199, 20);
            this.TxtBuscarNombreApe.TabIndex = 0;
            this.TxtBuscarNombreApe.Visible = false;
            // 
            // radioButtonNombreApellidos
            // 
            this.radioButtonNombreApellidos.AutoSize = true;
            this.radioButtonNombreApellidos.Location = new System.Drawing.Point(25, 56);
            this.radioButtonNombreApellidos.Name = "radioButtonNombreApellidos";
            this.radioButtonNombreApellidos.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombreApellidos.TabIndex = 2;
            this.radioButtonNombreApellidos.TabStop = true;
            this.radioButtonNombreApellidos.Text = "Nombre";
            this.radioButtonNombreApellidos.UseVisualStyleBackColor = true;
            this.radioButtonNombreApellidos.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(148, 261);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 61);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // radioButtonTelefono
            // 
            this.radioButtonTelefono.AutoSize = true;
            this.radioButtonTelefono.Location = new System.Drawing.Point(25, 105);
            this.radioButtonTelefono.Name = "radioButtonTelefono";
            this.radioButtonTelefono.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTelefono.TabIndex = 3;
            this.radioButtonTelefono.TabStop = true;
            this.radioButtonTelefono.Text = "Telefono";
            this.radioButtonTelefono.UseVisualStyleBackColor = true;
            this.radioButtonTelefono.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(25, 223);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(95, 17);
            this.checkBoxBaja.TabIndex = 8;
            this.checkBoxBaja.Text = "Dados de baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            // 
            // checkBoxPagosPendientes
            // 
            this.checkBoxPagosPendientes.AutoSize = true;
            this.checkBoxPagosPendientes.Location = new System.Drawing.Point(25, 177);
            this.checkBoxPagosPendientes.Name = "checkBoxPagosPendientes";
            this.checkBoxPagosPendientes.Size = new System.Drawing.Size(132, 17);
            this.checkBoxPagosPendientes.TabIndex = 7;
            this.checkBoxPagosPendientes.Text = "Con pagos pendientes";
            this.checkBoxPagosPendientes.UseVisualStyleBackColor = true;
            // 
            // listViewAlumnos
            // 
            this.listViewAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewAlumnos.FullRowSelect = true;
            this.listViewAlumnos.Location = new System.Drawing.Point(415, 35);
            this.listViewAlumnos.Name = "listViewAlumnos";
            this.listViewAlumnos.Size = new System.Drawing.Size(567, 468);
            this.listViewAlumnos.TabIndex = 13;
            this.listViewAlumnos.UseCompatibleStateImageBehavior = false;
            this.listViewAlumnos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Contraseña";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellidos";
            this.columnHeader4.Width = 195;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teléfono";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Patricula Pagada";
            this.columnHeader6.Width = 131;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pagos Pendientes";
            this.columnHeader7.Width = 131;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Baja";
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdministracionUsuarios);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.listViewAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlumnos";
            this.Text = "ALUMNOS";
            this.Load += new System.EventHandler(this.FormAlumnos_Load);
            this.groupBoxAdministracionUsuarios.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdministracionUsuarios;
        private System.Windows.Forms.Button BtnBorrarAlumno;
        private System.Windows.Forms.Button BtnModificarAlumno;
        private System.Windows.Forms.Button BtnNuevoAlumno;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.RadioButton radioButtonNinguno;
        private System.Windows.Forms.TextBox TxtBuscarTelefono;
        private System.Windows.Forms.CheckBox checkBoxPagoMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscarNombreApe;
        private System.Windows.Forms.RadioButton radioButtonNombreApellidos;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton radioButtonTelefono;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.CheckBox checkBoxPagosPendientes;
        private System.Windows.Forms.ListView listViewAlumnos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
    }
}