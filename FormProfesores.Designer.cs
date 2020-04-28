using System.Windows.Forms;

namespace Appcademy
{
    partial class FormProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesores));
            this.groupBoxAdministracionUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnBorrarProfesor = new System.Windows.Forms.Button();
            this.BtnModificarProfesor = new System.Windows.Forms.Button();
            this.BtnNuevoProfesor = new System.Windows.Forms.Button();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.TxtBuscarTelefono = new System.Windows.Forms.TextBox();
            this.TxtBuscarNombreApe = new System.Windows.Forms.TextBox();
            this.checkBoxPagosPendientes = new System.Windows.Forms.CheckBox();
            this.radioButtonNombreApellidos = new System.Windows.Forms.RadioButton();
            this.comboBoxAsignaturas = new System.Windows.Forms.ComboBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.labelAsignaturas = new System.Windows.Forms.Label();
            this.radioButtonTelefono = new System.Windows.Forms.RadioButton();
            this.radioButtonNinguno = new System.Windows.Forms.RadioButton();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.lsvProfesores = new System.Windows.Forms.ListView();
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
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnBorrarProfesor);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnModificarProfesor);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnNuevoProfesor);
            this.groupBoxAdministracionUsuarios.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdministracionUsuarios.Location = new System.Drawing.Point(24, 27);
            this.groupBoxAdministracionUsuarios.Name = "groupBoxAdministracionUsuarios";
            this.groupBoxAdministracionUsuarios.Size = new System.Drawing.Size(380, 69);
            this.groupBoxAdministracionUsuarios.TabIndex = 18;
            this.groupBoxAdministracionUsuarios.TabStop = false;
            this.groupBoxAdministracionUsuarios.Text = "ADMINISTRACIÓN DE PROFESORES";
            // 
            // BtnBorrarProfesor
            // 
            this.BtnBorrarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBorrarProfesor.FlatAppearance.BorderSize = 0;
            this.BtnBorrarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarProfesor.ForeColor = System.Drawing.Color.Black;
            this.BtnBorrarProfesor.Location = new System.Drawing.Point(249, 19);
            this.BtnBorrarProfesor.Name = "BtnBorrarProfesor";
            this.BtnBorrarProfesor.Size = new System.Drawing.Size(107, 36);
            this.BtnBorrarProfesor.TabIndex = 12;
            this.BtnBorrarProfesor.Text = "Borrar profesor";
            this.BtnBorrarProfesor.UseVisualStyleBackColor = false;
            this.BtnBorrarProfesor.Click += new System.EventHandler(this.BtnBorrarProfesor_Click);
            // 
            // BtnModificarProfesor
            // 
            this.BtnModificarProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnModificarProfesor.FlatAppearance.BorderSize = 0;
            this.BtnModificarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarProfesor.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarProfesor.Location = new System.Drawing.Point(136, 19);
            this.BtnModificarProfesor.Name = "BtnModificarProfesor";
            this.BtnModificarProfesor.Size = new System.Drawing.Size(107, 36);
            this.BtnModificarProfesor.TabIndex = 11;
            this.BtnModificarProfesor.Text = "Modificar profesor";
            this.BtnModificarProfesor.UseVisualStyleBackColor = false;
            this.BtnModificarProfesor.Click += new System.EventHandler(this.BtnModificarProfesor_Click);
            // 
            // BtnNuevoProfesor
            // 
            this.BtnNuevoProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnNuevoProfesor.FlatAppearance.BorderSize = 0;
            this.BtnNuevoProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevoProfesor.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevoProfesor.Location = new System.Drawing.Point(23, 19);
            this.BtnNuevoProfesor.Name = "BtnNuevoProfesor";
            this.BtnNuevoProfesor.Size = new System.Drawing.Size(107, 36);
            this.BtnNuevoProfesor.TabIndex = 10;
            this.BtnNuevoProfesor.Text = "Nuevo profesor";
            this.BtnNuevoProfesor.UseVisualStyleBackColor = false;
            this.BtnNuevoProfesor.Click += new System.EventHandler(this.BtnNuevoProfesor_Click);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBusqueda.Controls.Add(this.lblApellidos);
            this.groupBoxBusqueda.Controls.Add(this.txtApellidos);
            this.groupBoxBusqueda.Controls.Add(this.TxtBuscarTelefono);
            this.groupBoxBusqueda.Controls.Add(this.TxtBuscarNombreApe);
            this.groupBoxBusqueda.Controls.Add(this.checkBoxPagosPendientes);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonNombreApellidos);
            this.groupBoxBusqueda.Controls.Add(this.comboBoxAsignaturas);
            this.groupBoxBusqueda.Controls.Add(this.BtnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.labelAsignaturas);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonTelefono);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonNinguno);
            this.groupBoxBusqueda.Controls.Add(this.checkBoxBaja);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusqueda.ForeColor = System.Drawing.Color.White;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(24, 102);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(380, 401);
            this.groupBoxBusqueda.TabIndex = 17;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "BÚSQUEDA";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(37, 61);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 27;
            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.Visible = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(124, 61);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(199, 20);
            this.txtApellidos.TabIndex = 26;
            // 
            // TxtBuscarTelefono
            // 
            this.TxtBuscarTelefono.Location = new System.Drawing.Point(124, 85);
            this.TxtBuscarTelefono.Name = "TxtBuscarTelefono";
            this.TxtBuscarTelefono.Size = new System.Drawing.Size(199, 20);
            this.TxtBuscarTelefono.TabIndex = 25;
            // 
            // TxtBuscarNombreApe
            // 
            this.TxtBuscarNombreApe.Location = new System.Drawing.Point(124, 33);
            this.TxtBuscarNombreApe.Name = "TxtBuscarNombreApe";
            this.TxtBuscarNombreApe.Size = new System.Drawing.Size(199, 20);
            this.TxtBuscarNombreApe.TabIndex = 16;
            // 
            // checkBoxPagosPendientes
            // 
            this.checkBoxPagosPendientes.AutoSize = true;
            this.checkBoxPagosPendientes.Location = new System.Drawing.Point(23, 198);
            this.checkBoxPagosPendientes.Name = "checkBoxPagosPendientes";
            this.checkBoxPagosPendientes.Size = new System.Drawing.Size(132, 17);
            this.checkBoxPagosPendientes.TabIndex = 22;
            this.checkBoxPagosPendientes.Text = "Con pagos pendientes";
            this.checkBoxPagosPendientes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombreApellidos
            // 
            this.radioButtonNombreApellidos.AutoSize = true;
            this.radioButtonNombreApellidos.Location = new System.Drawing.Point(23, 33);
            this.radioButtonNombreApellidos.Name = "radioButtonNombreApellidos";
            this.radioButtonNombreApellidos.Size = new System.Drawing.Size(62, 17);
            this.radioButtonNombreApellidos.TabIndex = 17;
            this.radioButtonNombreApellidos.TabStop = true;
            this.radioButtonNombreApellidos.Text = "Nombre";
            this.radioButtonNombreApellidos.UseVisualStyleBackColor = true;
            this.radioButtonNombreApellidos.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // comboBoxAsignaturas
            // 
            this.comboBoxAsignaturas.FormattingEnabled = true;
            this.comboBoxAsignaturas.Location = new System.Drawing.Point(138, 159);
            this.comboBoxAsignaturas.Name = "comboBoxAsignaturas";
            this.comboBoxAsignaturas.Size = new System.Drawing.Size(164, 21);
            this.comboBoxAsignaturas.TabIndex = 21;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(149, 279);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 61);
            this.BtnBuscar.TabIndex = 24;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // labelAsignaturas
            // 
            this.labelAsignaturas.AutoSize = true;
            this.labelAsignaturas.Location = new System.Drawing.Point(187, 140);
            this.labelAsignaturas.Name = "labelAsignaturas";
            this.labelAsignaturas.Size = new System.Drawing.Size(65, 13);
            this.labelAsignaturas.TabIndex = 20;
            this.labelAsignaturas.Text = "Asignaturas:";
            // 
            // radioButtonTelefono
            // 
            this.radioButtonTelefono.AutoSize = true;
            this.radioButtonTelefono.Location = new System.Drawing.Point(23, 86);
            this.radioButtonTelefono.Name = "radioButtonTelefono";
            this.radioButtonTelefono.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTelefono.TabIndex = 18;
            this.radioButtonTelefono.TabStop = true;
            this.radioButtonTelefono.Text = "Telefono";
            this.radioButtonTelefono.UseVisualStyleBackColor = true;
            this.radioButtonTelefono.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // radioButtonNinguno
            // 
            this.radioButtonNinguno.AutoSize = true;
            this.radioButtonNinguno.Location = new System.Drawing.Point(23, 109);
            this.radioButtonNinguno.Name = "radioButtonNinguno";
            this.radioButtonNinguno.Size = new System.Drawing.Size(65, 17);
            this.radioButtonNinguno.TabIndex = 19;
            this.radioButtonNinguno.TabStop = true;
            this.radioButtonNinguno.Text = "Ninguno";
            this.radioButtonNinguno.UseVisualStyleBackColor = true;
            this.radioButtonNinguno.CheckedChanged += new System.EventHandler(this.mostrarTextoBusqueda);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(23, 221);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(95, 17);
            this.checkBoxBaja.TabIndex = 23;
            this.checkBoxBaja.Text = "Dados de baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            // 
            // lsvProfesores
            // 
            this.lsvProfesores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvProfesores.FullRowSelect = true;
            this.lsvProfesores.Location = new System.Drawing.Point(410, 27);
            this.lsvProfesores.Name = "lsvProfesores";
            this.lsvProfesores.Size = new System.Drawing.Size(574, 476);
            this.lsvProfesores.TabIndex = 16;
            this.lsvProfesores.UseCompatibleStateImageBehavior = false;
            this.lsvProfesores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Contraseña";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellidos";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pagos";
            this.columnHeader5.Width = 74;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Baja";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fecha Alta";
            this.columnHeader7.Width = 116;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fecha Baja";
            this.columnHeader8.Width = 129;
            // 
            // FormProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdministracionUsuarios);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lsvProfesores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProfesores";
            this.Text = "FormProfesores";
            this.Load += new System.EventHandler(this.FormProfesores_Load);
            this.groupBoxAdministracionUsuarios.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdministracionUsuarios;
        private System.Windows.Forms.Button BtnBorrarProfesor;
        private System.Windows.Forms.Button BtnModificarProfesor;
        private System.Windows.Forms.Button BtnNuevoProfesor;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.TextBox TxtBuscarTelefono;
        private System.Windows.Forms.TextBox TxtBuscarNombreApe;
        private System.Windows.Forms.CheckBox checkBoxPagosPendientes;
        private System.Windows.Forms.RadioButton radioButtonNombreApellidos;
        private System.Windows.Forms.ComboBox comboBoxAsignaturas;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label labelAsignaturas;
        private System.Windows.Forms.RadioButton radioButtonTelefono;
        private System.Windows.Forms.RadioButton radioButtonNinguno;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.ListView lsvProfesores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
    }
}