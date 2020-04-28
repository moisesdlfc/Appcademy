namespace Appcademy
{
    partial class FormNuevoAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoAlumno));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxDNI = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.labelEliminarDatos = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelPasarDatos = new System.Windows.Forms.Label();
            this.listViewCursosApuntado = new System.Windows.Forms.ListView();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.checkBoxMatriculaPagada = new System.Windows.Forms.CheckBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelCursos = new System.Windows.Forms.Label();
            this.labelPagosPendientes = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.listBoxPagosPendientes = new System.Windows.Forms.ListBox();
            this.labelTotalPagosPendientes = new System.Windows.Forms.Label();
            this.buttonPagado = new System.Windows.Forms.Button();
            this.listViewCursosDesapuntado = new System.Windows.Forms.ListView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 27);
            this.toolStrip1.TabIndex = 41;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 24);
            this.btnSalir.Text = "X";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(115, 24);
            this.toolStripLabel1.Text = "Nuevo Alumno";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.ForeColor = System.Drawing.Color.White;
            this.textBoxDNI.Location = new System.Drawing.Point(111, 49);
            this.textBoxDNI.Mask = "00000000?";
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(105, 23);
            this.textBoxDNI.TabIndex = 69;
            this.textBoxDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Contraseña:";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.ForeColor = System.Drawing.Color.White;
            this.textBoxContrasena.Location = new System.Drawing.Point(128, 185);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(129, 23);
            this.textBoxContrasena.TabIndex = 67;
            this.textBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "DNI:";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.BackColor = System.Drawing.SystemColors.HotTrack;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.White;
            this.TxtTelefono.Location = new System.Drawing.Point(111, 149);
            this.TxtTelefono.Mask = "000-000-000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(115, 23);
            this.TxtTelefono.TabIndex = 65;
            this.TxtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEliminarDatos
            // 
            this.labelEliminarDatos.AutoSize = true;
            this.labelEliminarDatos.BackColor = System.Drawing.Color.Transparent;
            this.labelEliminarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarDatos.ForeColor = System.Drawing.Color.White;
            this.labelEliminarDatos.Location = new System.Drawing.Point(681, 221);
            this.labelEliminarDatos.Name = "labelEliminarDatos";
            this.labelEliminarDatos.Size = new System.Drawing.Size(26, 17);
            this.labelEliminarDatos.TabIndex = 64;
            this.labelEliminarDatos.Text = "<<";
            this.labelEliminarDatos.Click += new System.EventHandler(this.labelEliminarDatos_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardar.Location = new System.Drawing.Point(370, 354);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 63;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelar.Location = new System.Drawing.Point(452, 354);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelPasarDatos
            // 
            this.labelPasarDatos.AutoSize = true;
            this.labelPasarDatos.BackColor = System.Drawing.Color.Transparent;
            this.labelPasarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasarDatos.ForeColor = System.Drawing.Color.White;
            this.labelPasarDatos.Location = new System.Drawing.Point(681, 134);
            this.labelPasarDatos.Name = "labelPasarDatos";
            this.labelPasarDatos.Size = new System.Drawing.Size(26, 17);
            this.labelPasarDatos.TabIndex = 61;
            this.labelPasarDatos.Text = ">>";
            this.labelPasarDatos.Click += new System.EventHandler(this.labelPasarDatos_Click);
            // 
            // listViewCursosApuntado
            // 
            this.listViewCursosApuntado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewCursosApuntado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCursosApuntado.ForeColor = System.Drawing.Color.White;
            this.listViewCursosApuntado.Location = new System.Drawing.Point(713, 70);
            this.listViewCursosApuntado.MultiSelect = false;
            this.listViewCursosApuntado.Name = "listViewCursosApuntado";
            this.listViewCursosApuntado.Size = new System.Drawing.Size(165, 225);
            this.listViewCursosApuntado.TabIndex = 60;
            this.listViewCursosApuntado.UseCompatibleStateImageBehavior = false;
            this.listViewCursosApuntado.View = System.Windows.Forms.View.List;
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBaja.ForeColor = System.Drawing.Color.White;
            this.checkBoxBaja.Location = new System.Drawing.Point(29, 248);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(124, 21);
            this.checkBoxBaja.TabIndex = 58;
            this.checkBoxBaja.Text = "Dado de baja";
            this.checkBoxBaja.UseVisualStyleBackColor = false;
            // 
            // checkBoxMatriculaPagada
            // 
            this.checkBoxMatriculaPagada.AutoSize = true;
            this.checkBoxMatriculaPagada.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMatriculaPagada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMatriculaPagada.ForeColor = System.Drawing.Color.White;
            this.checkBoxMatriculaPagada.Location = new System.Drawing.Point(29, 221);
            this.checkBoxMatriculaPagada.Name = "checkBoxMatriculaPagada";
            this.checkBoxMatriculaPagada.Size = new System.Drawing.Size(152, 21);
            this.checkBoxMatriculaPagada.TabIndex = 57;
            this.checkBoxMatriculaPagada.Text = "Matricula pagada";
            this.checkBoxMatriculaPagada.UseVisualStyleBackColor = false;
            this.checkBoxMatriculaPagada.CheckedChanged += new System.EventHandler(this.checkBoxMatriculaPagada_CheckedChanged);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.ForeColor = System.Drawing.Color.White;
            this.textBoxApellidos.Location = new System.Drawing.Point(111, 115);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(175, 23);
            this.textBoxApellidos.TabIndex = 54;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(111, 82);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(105, 23);
            this.textBoxNombre.TabIndex = 53;
            // 
            // labelCursos
            // 
            this.labelCursos.AutoSize = true;
            this.labelCursos.BackColor = System.Drawing.Color.Transparent;
            this.labelCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCursos.ForeColor = System.Drawing.Color.White;
            this.labelCursos.Location = new System.Drawing.Point(560, 49);
            this.labelCursos.Name = "labelCursos";
            this.labelCursos.Size = new System.Drawing.Size(63, 17);
            this.labelCursos.TabIndex = 52;
            this.labelCursos.Text = "Cursos:";
            // 
            // labelPagosPendientes
            // 
            this.labelPagosPendientes.AutoSize = true;
            this.labelPagosPendientes.BackColor = System.Drawing.Color.Transparent;
            this.labelPagosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagosPendientes.ForeColor = System.Drawing.Color.White;
            this.labelPagosPendientes.Location = new System.Drawing.Point(323, 49);
            this.labelPagosPendientes.Name = "labelPagosPendientes";
            this.labelPagosPendientes.Size = new System.Drawing.Size(143, 17);
            this.labelPagosPendientes.TabIndex = 51;
            this.labelPagosPendientes.Text = "Pagos pendientes:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(26, 152);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(77, 17);
            this.labelTelefono.TabIndex = 50;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.Color.White;
            this.labelApellidos.Location = new System.Drawing.Point(26, 118);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(79, 17);
            this.labelApellidos.TabIndex = 49;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(26, 85);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 17);
            this.labelNombre.TabIndex = 48;
            this.labelNombre.Text = "Nombre:";
            // 
            // listBoxPagosPendientes
            // 
            this.listBoxPagosPendientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxPagosPendientes.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPagosPendientes.FormattingEnabled = true;
            this.listBoxPagosPendientes.Location = new System.Drawing.Point(315, 69);
            this.listBoxPagosPendientes.Name = "listBoxPagosPendientes";
            this.listBoxPagosPendientes.Size = new System.Drawing.Size(161, 173);
            this.listBoxPagosPendientes.TabIndex = 70;
            // 
            // labelTotalPagosPendientes
            // 
            this.labelTotalPagosPendientes.AutoSize = true;
            this.labelTotalPagosPendientes.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPagosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPagosPendientes.Location = new System.Drawing.Point(359, 248);
            this.labelTotalPagosPendientes.Name = "labelTotalPagosPendientes";
            this.labelTotalPagosPendientes.Size = new System.Drawing.Size(67, 15);
            this.labelTotalPagosPendientes.TabIndex = 71;
            this.labelTotalPagosPendientes.Text = "Total: 0 €";
            // 
            // buttonPagado
            // 
            this.buttonPagado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonPagado.FlatAppearance.BorderSize = 0;
            this.buttonPagado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPagado.ForeColor = System.Drawing.Color.Black;
            this.buttonPagado.Location = new System.Drawing.Point(355, 272);
            this.buttonPagado.Name = "buttonPagado";
            this.buttonPagado.Size = new System.Drawing.Size(75, 23);
            this.buttonPagado.TabIndex = 72;
            this.buttonPagado.Text = "Pagado";
            this.buttonPagado.UseVisualStyleBackColor = false;
            this.buttonPagado.Click += new System.EventHandler(this.buttonPagado_Click);
            // 
            // listViewCursosDesapuntado
            // 
            this.listViewCursosDesapuntado.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listViewCursosDesapuntado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCursosDesapuntado.ForeColor = System.Drawing.Color.White;
            this.listViewCursosDesapuntado.Location = new System.Drawing.Point(510, 70);
            this.listViewCursosDesapuntado.MultiSelect = false;
            this.listViewCursosDesapuntado.Name = "listViewCursosDesapuntado";
            this.listViewCursosDesapuntado.Size = new System.Drawing.Size(165, 225);
            this.listViewCursosDesapuntado.TabIndex = 73;
            this.listViewCursosDesapuntado.UseCompatibleStateImageBehavior = false;
            this.listViewCursosDesapuntado.View = System.Windows.Forms.View.List;
            // 
            // FormNuevoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(895, 389);
            this.ControlBox = false;
            this.Controls.Add(this.listViewCursosDesapuntado);
            this.Controls.Add(this.buttonPagado);
            this.Controls.Add(this.labelTotalPagosPendientes);
            this.Controls.Add(this.listBoxPagosPendientes);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.labelEliminarDatos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelPasarDatos);
            this.Controls.Add(this.listViewCursosApuntado);
            this.Controls.Add(this.checkBoxBaja);
            this.Controls.Add(this.checkBoxMatriculaPagada);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelCursos);
            this.Controls.Add(this.labelPagosPendientes);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoAlumno";
            this.Text = "NUEVO ALUMNO";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.FormNuevoAlumno_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MaskedTextBox textBoxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.Label labelEliminarDatos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelPasarDatos;
        private System.Windows.Forms.ListView listViewCursosApuntado;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.CheckBox checkBoxMatriculaPagada;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelCursos;
        private System.Windows.Forms.Label labelPagosPendientes;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ListBox listBoxPagosPendientes;
        private System.Windows.Forms.Label labelTotalPagosPendientes;
        private System.Windows.Forms.Button buttonPagado;
        private System.Windows.Forms.ListView listViewCursosDesapuntado;
    }
}