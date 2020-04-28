namespace Appcademy
{
    partial class FormPadre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPadre));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelSpace2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonMenu = new System.Windows.Forms.ToolStripButton();
            this.btnMinimizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelSpace = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.buttonHorarios = new System.Windows.Forms.Button();
            this.buttonCursos = new System.Windows.Forms.Button();
            this.buttonAsignaturas = new System.Windows.Forms.Button();
            this.buttonAlumnos = new System.Windows.Forms.Button();
            this.buttonProfesores = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.toolStripLabelSpace2,
            this.toolStripButtonMenu,
            this.btnMinimizar,
            this.toolStripLabelSpace,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1024, 39);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStripMenu";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 36);
            this.btnSalir.Text = "X";
            this.btnSalir.ToolTipText = "Cerrar";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripLabelSpace2
            // 
            this.toolStripLabelSpace2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSpace2.Name = "toolStripLabelSpace2";
            this.toolStripLabelSpace2.Size = new System.Drawing.Size(16, 36);
            this.toolStripLabelSpace2.Text = "   ";
            // 
            // toolStripButtonMenu
            // 
            this.toolStripButtonMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMenu.Image")));
            this.toolStripButtonMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMenu.Name = "toolStripButtonMenu";
            this.toolStripButtonMenu.Size = new System.Drawing.Size(44, 36);
            this.toolStripButtonMenu.Click += new System.EventHandler(this.toolStripButtonMenu_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMinimizar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(23, 36);
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.ToolTipText = "Minimizar";
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // toolStripLabelSpace
            // 
            this.toolStripLabelSpace.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelSpace.Name = "toolStripLabelSpace";
            this.toolStripLabelSpace.Size = new System.Drawing.Size(16, 36);
            this.toolStripLabelSpace.Text = "   ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Bulletproof BB", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(209, 36);
            this.toolStripLabel1.Text = "Appcademy";
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 30;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.buttonConfiguracion);
            this.panelMenu.Controls.Add(this.buttonHorarios);
            this.panelMenu.Controls.Add(this.buttonCursos);
            this.panelMenu.Controls.Add(this.buttonAsignaturas);
            this.panelMenu.Controls.Add(this.buttonAlumnos);
            this.panelMenu.Controls.Add(this.buttonProfesores);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 537);
            this.panelMenu.TabIndex = 13;
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfiguracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfiguracion.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguracion.Location = new System.Drawing.Point(0, 495);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(150, 39);
            this.buttonConfiguracion.TabIndex = 6;
            this.buttonConfiguracion.Text = "Configuracion";
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // buttonHorarios
            // 
            this.buttonHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHorarios.FlatAppearance.BorderSize = 0;
            this.buttonHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHorarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorarios.ForeColor = System.Drawing.Color.White;
            this.buttonHorarios.Location = new System.Drawing.Point(0, 159);
            this.buttonHorarios.Name = "buttonHorarios";
            this.buttonHorarios.Size = new System.Drawing.Size(150, 39);
            this.buttonHorarios.TabIndex = 5;
            this.buttonHorarios.Text = "Horarios";
            this.buttonHorarios.UseVisualStyleBackColor = false;
            this.buttonHorarios.Click += new System.EventHandler(this.buttonHorarios_Click);
            // 
            // buttonCursos
            // 
            this.buttonCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCursos.FlatAppearance.BorderSize = 0;
            this.buttonCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCursos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCursos.ForeColor = System.Drawing.Color.White;
            this.buttonCursos.Location = new System.Drawing.Point(0, 120);
            this.buttonCursos.Name = "buttonCursos";
            this.buttonCursos.Size = new System.Drawing.Size(150, 39);
            this.buttonCursos.TabIndex = 4;
            this.buttonCursos.Text = "Cursos";
            this.buttonCursos.UseVisualStyleBackColor = false;
            this.buttonCursos.Click += new System.EventHandler(this.buttonCursos_Click);
            // 
            // buttonAsignaturas
            // 
            this.buttonAsignaturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonAsignaturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAsignaturas.FlatAppearance.BorderSize = 0;
            this.buttonAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAsignaturas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAsignaturas.ForeColor = System.Drawing.Color.White;
            this.buttonAsignaturas.Location = new System.Drawing.Point(0, 81);
            this.buttonAsignaturas.Name = "buttonAsignaturas";
            this.buttonAsignaturas.Size = new System.Drawing.Size(150, 39);
            this.buttonAsignaturas.TabIndex = 3;
            this.buttonAsignaturas.Text = "Asignaturas";
            this.buttonAsignaturas.UseVisualStyleBackColor = false;
            this.buttonAsignaturas.Click += new System.EventHandler(this.buttonAsignaturas_Click);
            // 
            // buttonAlumnos
            // 
            this.buttonAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlumnos.FlatAppearance.BorderSize = 0;
            this.buttonAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAlumnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlumnos.ForeColor = System.Drawing.Color.White;
            this.buttonAlumnos.Location = new System.Drawing.Point(0, 42);
            this.buttonAlumnos.Name = "buttonAlumnos";
            this.buttonAlumnos.Size = new System.Drawing.Size(150, 39);
            this.buttonAlumnos.TabIndex = 2;
            this.buttonAlumnos.Text = "Alumnos";
            this.buttonAlumnos.UseVisualStyleBackColor = false;
            this.buttonAlumnos.Click += new System.EventHandler(this.buttonAlumnos_Click);
            // 
            // buttonProfesores
            // 
            this.buttonProfesores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.buttonProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfesores.FlatAppearance.BorderSize = 0;
            this.buttonProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProfesores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfesores.ForeColor = System.Drawing.Color.White;
            this.buttonProfesores.Location = new System.Drawing.Point(0, 3);
            this.buttonProfesores.Name = "buttonProfesores";
            this.buttonProfesores.Size = new System.Drawing.Size(150, 39);
            this.buttonProfesores.TabIndex = 1;
            this.buttonProfesores.Text = "Profesores";
            this.buttonProfesores.UseVisualStyleBackColor = false;
            this.buttonProfesores.Click += new System.EventHandler(this.buttonProfesores_Click);
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APPCADEMY";
            this.Load += new System.EventHandler(this.FormPadre_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnMinimizar;
        private System.Windows.Forms.ToolStripButton toolStripButtonMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSpace;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSpace2;
        private System.Windows.Forms.Button buttonProfesores;
        private System.Windows.Forms.Button buttonAlumnos;
        private System.Windows.Forms.Button buttonConfiguracion;
        private System.Windows.Forms.Button buttonHorarios;
        private System.Windows.Forms.Button buttonCursos;
        private System.Windows.Forms.Button buttonAsignaturas;
    }
}

