namespace Appcademy
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMatricula = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEuro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.tabPagePrecios = new System.Windows.Forms.TabPage();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelTipoCurso = new System.Windows.Forms.Label();
            this.listViewPrecios = new System.Windows.Forms.ListView();
            this.columnHeaderTipoCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTipoCurso = new System.Windows.Forms.TextBox();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelEurosHora = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.tabPageProfesores = new System.Windows.Forms.TabPage();
            this.labelPorcentaje = new System.Windows.Forms.Label();
            this.buttonGuardarGananciaProfesores = new System.Windows.Forms.Button();
            this.textBoxGananciaProfesores = new System.Windows.Forms.TextBox();
            this.labelGananciaProfesores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPageAulas = new System.Windows.Forms.TabPage();
            this.buttonEliminarAula = new System.Windows.Forms.Button();
            this.labelNombreAula = new System.Windows.Forms.Label();
            this.listViewAulas = new System.Windows.Forms.ListView();
            this.columnHeaderNombreAula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxNombreAula = new System.Windows.Forms.TextBox();
            this.buttonAñadirAula = new System.Windows.Forms.Button();
            this.tabPageCuenta = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxNuevaContraseña = new System.Windows.Forms.TextBox();
            this.labelNuevaContraseña = new System.Windows.Forms.Label();
            this.buttonGuardarCuenta = new System.Windows.Forms.Button();
            this.textBoxContraseñaActual = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelContraseñaActual = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripConfiguracion = new System.Windows.Forms.ToolStripLabel();
            this.tabControl.SuspendLayout();
            this.tabPageMatricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPagePrecios.SuspendLayout();
            this.tabPageProfesores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPageAulas.SuspendLayout();
            this.tabPageCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMatricula);
            this.tabControl.Controls.Add(this.tabPagePrecios);
            this.tabControl.Controls.Add(this.tabPageProfesores);
            this.tabControl.Controls.Add(this.tabPageAulas);
            this.tabControl.Controls.Add(this.tabPageCuenta);
            this.tabControl.Location = new System.Drawing.Point(0, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(500, 320);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageMatricula
            // 
            this.tabPageMatricula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageMatricula.BackgroundImage")));
            this.tabPageMatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMatricula.Controls.Add(this.pictureBox1);
            this.tabPageMatricula.Controls.Add(this.labelEuro);
            this.tabPageMatricula.Controls.Add(this.label1);
            this.tabPageMatricula.Controls.Add(this.buttonGuardar);
            this.tabPageMatricula.Controls.Add(this.textBoxMatricula);
            this.tabPageMatricula.Location = new System.Drawing.Point(4, 22);
            this.tabPageMatricula.Name = "tabPageMatricula";
            this.tabPageMatricula.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMatricula.Size = new System.Drawing.Size(492, 294);
            this.tabPageMatricula.TabIndex = 0;
            this.tabPageMatricula.Text = "MATRÍCULA";
            this.tabPageMatricula.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Appcademy.Properties.Resources.icono;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 188);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 99);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelEuro
            // 
            this.labelEuro.AutoSize = true;
            this.labelEuro.ForeColor = System.Drawing.Color.White;
            this.labelEuro.Location = new System.Drawing.Point(314, 129);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(13, 13);
            this.labelEuro.TabIndex = 9;
            this.labelEuro.Text = "€";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardar.Location = new System.Drawing.Point(207, 175);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(188, 126);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(120, 20);
            this.textBoxMatricula.TabIndex = 7;
            // 
            // tabPagePrecios
            // 
            this.tabPagePrecios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePrecios.BackgroundImage")));
            this.tabPagePrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagePrecios.Controls.Add(this.buttonEliminar);
            this.tabPagePrecios.Controls.Add(this.labelTipoCurso);
            this.tabPagePrecios.Controls.Add(this.listViewPrecios);
            this.tabPagePrecios.Controls.Add(this.textBoxTipoCurso);
            this.tabPagePrecios.Controls.Add(this.buttonAñadir);
            this.tabPagePrecios.Controls.Add(this.labelPrecio);
            this.tabPagePrecios.Controls.Add(this.labelEurosHora);
            this.tabPagePrecios.Controls.Add(this.textBoxPrecio);
            this.tabPagePrecios.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrecios.Name = "tabPagePrecios";
            this.tabPagePrecios.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrecios.Size = new System.Drawing.Size(492, 294);
            this.tabPagePrecios.TabIndex = 1;
            this.tabPagePrecios.Text = "PRECIOS";
            this.tabPagePrecios.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.ForeColor = System.Drawing.Color.Black;
            this.buttonEliminar.Location = new System.Drawing.Point(247, 65);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelTipoCurso
            // 
            this.labelTipoCurso.AutoSize = true;
            this.labelTipoCurso.ForeColor = System.Drawing.Color.White;
            this.labelTipoCurso.Location = new System.Drawing.Point(122, 23);
            this.labelTipoCurso.Name = "labelTipoCurso";
            this.labelTipoCurso.Size = new System.Drawing.Size(57, 13);
            this.labelTipoCurso.TabIndex = 0;
            this.labelTipoCurso.Text = "Tipo curso";
            // 
            // listViewPrecios
            // 
            this.listViewPrecios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTipoCurso,
            this.columnHeaderPrecio});
            this.listViewPrecios.Location = new System.Drawing.Point(60, 94);
            this.listViewPrecios.Name = "listViewPrecios";
            this.listViewPrecios.Size = new System.Drawing.Size(363, 168);
            this.listViewPrecios.TabIndex = 6;
            this.listViewPrecios.UseCompatibleStateImageBehavior = false;
            this.listViewPrecios.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTipoCurso
            // 
            this.columnHeaderTipoCurso.Text = "Tipo curso";
            this.columnHeaderTipoCurso.Width = 150;
            // 
            // columnHeaderPrecio
            // 
            this.columnHeaderPrecio.Text = "Precio";
            this.columnHeaderPrecio.Width = 100;
            // 
            // textBoxTipoCurso
            // 
            this.textBoxTipoCurso.Location = new System.Drawing.Point(60, 39);
            this.textBoxTipoCurso.Name = "textBoxTipoCurso";
            this.textBoxTipoCurso.Size = new System.Drawing.Size(192, 20);
            this.textBoxTipoCurso.TabIndex = 1;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonAñadir.FlatAppearance.BorderSize = 0;
            this.buttonAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadir.ForeColor = System.Drawing.Color.Black;
            this.buttonAñadir.Location = new System.Drawing.Point(166, 65);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadir.TabIndex = 5;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = false;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.ForeColor = System.Drawing.Color.White;
            this.labelPrecio.Location = new System.Drawing.Point(269, 23);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio";
            // 
            // labelEurosHora
            // 
            this.labelEurosHora.AutoSize = true;
            this.labelEurosHora.ForeColor = System.Drawing.Color.White;
            this.labelEurosHora.Location = new System.Drawing.Point(384, 42);
            this.labelEurosHora.Name = "labelEurosHora";
            this.labelEurosHora.Size = new System.Drawing.Size(39, 13);
            this.labelEurosHora.TabIndex = 4;
            this.labelEurosHora.Text = "€/hora";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(258, 39);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(120, 20);
            this.textBoxPrecio.TabIndex = 3;
            // 
            // tabPageProfesores
            // 
            this.tabPageProfesores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageProfesores.BackgroundImage")));
            this.tabPageProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageProfesores.Controls.Add(this.labelPorcentaje);
            this.tabPageProfesores.Controls.Add(this.buttonGuardarGananciaProfesores);
            this.tabPageProfesores.Controls.Add(this.textBoxGananciaProfesores);
            this.tabPageProfesores.Controls.Add(this.labelGananciaProfesores);
            this.tabPageProfesores.Controls.Add(this.pictureBox2);
            this.tabPageProfesores.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfesores.Name = "tabPageProfesores";
            this.tabPageProfesores.Size = new System.Drawing.Size(492, 294);
            this.tabPageProfesores.TabIndex = 4;
            this.tabPageProfesores.Text = "PROFESORES";
            this.tabPageProfesores.UseVisualStyleBackColor = true;
            // 
            // labelPorcentaje
            // 
            this.labelPorcentaje.AutoSize = true;
            this.labelPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentaje.ForeColor = System.Drawing.Color.White;
            this.labelPorcentaje.Location = new System.Drawing.Point(280, 128);
            this.labelPorcentaje.Name = "labelPorcentaje";
            this.labelPorcentaje.Size = new System.Drawing.Size(20, 16);
            this.labelPorcentaje.TabIndex = 15;
            this.labelPorcentaje.Text = "%";
            // 
            // buttonGuardarGananciaProfesores
            // 
            this.buttonGuardarGananciaProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonGuardarGananciaProfesores.FlatAppearance.BorderSize = 0;
            this.buttonGuardarGananciaProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardarGananciaProfesores.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardarGananciaProfesores.Location = new System.Drawing.Point(203, 173);
            this.buttonGuardarGananciaProfesores.Name = "buttonGuardarGananciaProfesores";
            this.buttonGuardarGananciaProfesores.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarGananciaProfesores.TabIndex = 14;
            this.buttonGuardarGananciaProfesores.Text = "Guardar";
            this.buttonGuardarGananciaProfesores.UseVisualStyleBackColor = false;
            this.buttonGuardarGananciaProfesores.Click += new System.EventHandler(this.buttonGuardarGananciaProfesores_Click);
            // 
            // textBoxGananciaProfesores
            // 
            this.textBoxGananciaProfesores.Location = new System.Drawing.Point(203, 126);
            this.textBoxGananciaProfesores.Name = "textBoxGananciaProfesores";
            this.textBoxGananciaProfesores.Size = new System.Drawing.Size(75, 20);
            this.textBoxGananciaProfesores.TabIndex = 13;
            // 
            // labelGananciaProfesores
            // 
            this.labelGananciaProfesores.AutoSize = true;
            this.labelGananciaProfesores.ForeColor = System.Drawing.Color.White;
            this.labelGananciaProfesores.Location = new System.Drawing.Point(190, 110);
            this.labelGananciaProfesores.Name = "labelGananciaProfesores";
            this.labelGananciaProfesores.Size = new System.Drawing.Size(105, 13);
            this.labelGananciaProfesores.TabIndex = 12;
            this.labelGananciaProfesores.Text = "Ganancia profesores";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Appcademy.Properties.Resources.icono;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(7, 188);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 99);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // tabPageAulas
            // 
            this.tabPageAulas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageAulas.BackgroundImage")));
            this.tabPageAulas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAulas.Controls.Add(this.buttonEliminarAula);
            this.tabPageAulas.Controls.Add(this.labelNombreAula);
            this.tabPageAulas.Controls.Add(this.listViewAulas);
            this.tabPageAulas.Controls.Add(this.textBoxNombreAula);
            this.tabPageAulas.Controls.Add(this.buttonAñadirAula);
            this.tabPageAulas.Location = new System.Drawing.Point(4, 22);
            this.tabPageAulas.Name = "tabPageAulas";
            this.tabPageAulas.Size = new System.Drawing.Size(492, 294);
            this.tabPageAulas.TabIndex = 2;
            this.tabPageAulas.Text = "AULAS";
            this.tabPageAulas.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarAula
            // 
            this.buttonEliminarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonEliminarAula.FlatAppearance.BorderSize = 0;
            this.buttonEliminarAula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminarAula.ForeColor = System.Drawing.Color.Black;
            this.buttonEliminarAula.Location = new System.Drawing.Point(223, 59);
            this.buttonEliminarAula.Name = "buttonEliminarAula";
            this.buttonEliminarAula.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarAula.TabIndex = 7;
            this.buttonEliminarAula.Text = "Eliminar";
            this.buttonEliminarAula.UseVisualStyleBackColor = false;
            this.buttonEliminarAula.Click += new System.EventHandler(this.buttonEliminarAula_Click);
            // 
            // labelNombreAula
            // 
            this.labelNombreAula.AutoSize = true;
            this.labelNombreAula.ForeColor = System.Drawing.Color.White;
            this.labelNombreAula.Location = new System.Drawing.Point(182, 18);
            this.labelNombreAula.Name = "labelNombreAula";
            this.labelNombreAula.Size = new System.Drawing.Size(82, 13);
            this.labelNombreAula.TabIndex = 0;
            this.labelNombreAula.Text = "Nombre de aula";
            // 
            // listViewAulas
            // 
            this.listViewAulas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombreAula});
            this.listViewAulas.Location = new System.Drawing.Point(36, 88);
            this.listViewAulas.Name = "listViewAulas";
            this.listViewAulas.Size = new System.Drawing.Size(363, 168);
            this.listViewAulas.TabIndex = 6;
            this.listViewAulas.UseCompatibleStateImageBehavior = false;
            this.listViewAulas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNombreAula
            // 
            this.columnHeaderNombreAula.Text = "Nombre de aula";
            this.columnHeaderNombreAula.Width = 200;
            // 
            // textBoxNombreAula
            // 
            this.textBoxNombreAula.Location = new System.Drawing.Point(127, 34);
            this.textBoxNombreAula.Name = "textBoxNombreAula";
            this.textBoxNombreAula.Size = new System.Drawing.Size(192, 20);
            this.textBoxNombreAula.TabIndex = 1;
            // 
            // buttonAñadirAula
            // 
            this.buttonAñadirAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonAñadirAula.FlatAppearance.BorderSize = 0;
            this.buttonAñadirAula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAñadirAula.ForeColor = System.Drawing.Color.Black;
            this.buttonAñadirAula.Location = new System.Drawing.Point(142, 59);
            this.buttonAñadirAula.Name = "buttonAñadirAula";
            this.buttonAñadirAula.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadirAula.TabIndex = 5;
            this.buttonAñadirAula.Text = "Añadir";
            this.buttonAñadirAula.UseVisualStyleBackColor = false;
            this.buttonAñadirAula.Click += new System.EventHandler(this.buttonAñadirAula_Click);
            // 
            // tabPageCuenta
            // 
            this.tabPageCuenta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCuenta.BackgroundImage")));
            this.tabPageCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCuenta.Controls.Add(this.pictureBox3);
            this.tabPageCuenta.Controls.Add(this.textBoxNuevaContraseña);
            this.tabPageCuenta.Controls.Add(this.labelNuevaContraseña);
            this.tabPageCuenta.Controls.Add(this.buttonGuardarCuenta);
            this.tabPageCuenta.Controls.Add(this.textBoxContraseñaActual);
            this.tabPageCuenta.Controls.Add(this.textBoxUsuario);
            this.tabPageCuenta.Controls.Add(this.labelContraseñaActual);
            this.tabPageCuenta.Controls.Add(this.labelUsuario);
            this.tabPageCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageCuenta.Name = "tabPageCuenta";
            this.tabPageCuenta.Size = new System.Drawing.Size(492, 294);
            this.tabPageCuenta.TabIndex = 3;
            this.tabPageCuenta.Text = "CUENTA";
            this.tabPageCuenta.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Appcademy.Properties.Resources.icono;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(7, 188);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 99);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxNuevaContraseña
            // 
            this.textBoxNuevaContraseña.Location = new System.Drawing.Point(166, 176);
            this.textBoxNuevaContraseña.Name = "textBoxNuevaContraseña";
            this.textBoxNuevaContraseña.PasswordChar = '*';
            this.textBoxNuevaContraseña.Size = new System.Drawing.Size(153, 20);
            this.textBoxNuevaContraseña.TabIndex = 6;
            // 
            // labelNuevaContraseña
            // 
            this.labelNuevaContraseña.AutoSize = true;
            this.labelNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.labelNuevaContraseña.Location = new System.Drawing.Point(195, 160);
            this.labelNuevaContraseña.Name = "labelNuevaContraseña";
            this.labelNuevaContraseña.Size = new System.Drawing.Size(95, 13);
            this.labelNuevaContraseña.TabIndex = 5;
            this.labelNuevaContraseña.Text = "Nueva contraseña";
            // 
            // buttonGuardarCuenta
            // 
            this.buttonGuardarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.buttonGuardarCuenta.FlatAppearance.BorderSize = 0;
            this.buttonGuardarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardarCuenta.Location = new System.Drawing.Point(205, 220);
            this.buttonGuardarCuenta.Name = "buttonGuardarCuenta";
            this.buttonGuardarCuenta.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardarCuenta.TabIndex = 4;
            this.buttonGuardarCuenta.Text = "Guardar";
            this.buttonGuardarCuenta.UseVisualStyleBackColor = false;
            this.buttonGuardarCuenta.Click += new System.EventHandler(this.buttonGuardarCuenta_Click);
            // 
            // textBoxContraseñaActual
            // 
            this.textBoxContraseñaActual.Location = new System.Drawing.Point(166, 127);
            this.textBoxContraseñaActual.Name = "textBoxContraseñaActual";
            this.textBoxContraseñaActual.PasswordChar = '*';
            this.textBoxContraseñaActual.Size = new System.Drawing.Size(153, 20);
            this.textBoxContraseñaActual.TabIndex = 3;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(166, 77);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(153, 20);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // labelContraseñaActual
            // 
            this.labelContraseñaActual.AutoSize = true;
            this.labelContraseñaActual.ForeColor = System.Drawing.Color.White;
            this.labelContraseñaActual.Location = new System.Drawing.Point(197, 111);
            this.labelContraseñaActual.Name = "labelContraseñaActual";
            this.labelContraseñaActual.Size = new System.Drawing.Size(93, 13);
            this.labelContraseñaActual.TabIndex = 1;
            this.labelContraseñaActual.Text = "Contraseña actual";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(223, 61);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 0;
            this.labelUsuario.Text = "Usuario";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripConfiguracion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 27);
            this.toolStrip1.TabIndex = 74;
            this.toolStrip1.Text = "toolStrip";
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // toolStripConfiguracion
            // 
            this.toolStripConfiguracion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripConfiguracion.ForeColor = System.Drawing.Color.White;
            this.toolStripConfiguracion.Name = "toolStripConfiguracion";
            this.toolStripConfiguracion.Size = new System.Drawing.Size(107, 24);
            this.toolStripConfiguracion.Text = "Configuracion";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageMatricula.ResumeLayout(false);
            this.tabPageMatricula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPagePrecios.ResumeLayout(false);
            this.tabPagePrecios.PerformLayout();
            this.tabPageProfesores.ResumeLayout(false);
            this.tabPageProfesores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPageAulas.ResumeLayout(false);
            this.tabPageAulas.PerformLayout();
            this.tabPageCuenta.ResumeLayout(false);
            this.tabPageCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewPrecios;
        private System.Windows.Forms.ColumnHeader columnHeaderTipoCurso;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecio;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.Label labelEurosHora;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxTipoCurso;
        private System.Windows.Forms.Label labelTipoCurso;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.Button buttonEliminarAula;
        private System.Windows.Forms.ListView listViewAulas;
        private System.Windows.Forms.ColumnHeader columnHeaderNombreAula;
        private System.Windows.Forms.Button buttonAñadirAula;
        private System.Windows.Forms.TextBox textBoxNombreAula;
        private System.Windows.Forms.Label labelNombreAula;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMatricula;
        private System.Windows.Forms.TabPage tabPagePrecios;
        private System.Windows.Forms.TabPage tabPageAulas;
        private System.Windows.Forms.TabPage tabPageCuenta;
        private System.Windows.Forms.Button buttonGuardarCuenta;
        private System.Windows.Forms.TextBox textBoxContraseñaActual;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelContraseñaActual;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxNuevaContraseña;
        private System.Windows.Forms.Label labelNuevaContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripConfiguracion;
        private System.Windows.Forms.TabPage tabPageProfesores;
        private System.Windows.Forms.Label labelPorcentaje;
        private System.Windows.Forms.Button buttonGuardarGananciaProfesores;
        private System.Windows.Forms.TextBox textBoxGananciaProfesores;
        private System.Windows.Forms.Label labelGananciaProfesores;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}