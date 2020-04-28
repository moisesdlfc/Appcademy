using System.Windows.Forms;

namespace Appcademy
{
    partial class FormCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCursos));
            this.groupBoxAdministracionUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnNuevoCurso = new System.Windows.Forms.Button();
            this.BtnBorrarCurso = new System.Windows.Forms.Button();
            this.BtnModificarCurso = new System.Windows.Forms.Button();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.radioButtonMostrarTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonProfesor = new System.Windows.Forms.RadioButton();
            this.radioButtonCarrera = new System.Windows.Forms.RadioButton();
            this.radioButtonTipoCurso = new System.Windows.Forms.RadioButton();
            this.radioButtonAsignatura = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.comboBoxBusquedaCursos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCursos = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAsignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipoCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdministracionUsuarios.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdministracionUsuarios
            // 
            this.groupBoxAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnNuevoCurso);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnBorrarCurso);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnModificarCurso);
            this.groupBoxAdministracionUsuarios.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdministracionUsuarios.Location = new System.Drawing.Point(29, 48);
            this.groupBoxAdministracionUsuarios.Name = "groupBoxAdministracionUsuarios";
            this.groupBoxAdministracionUsuarios.Size = new System.Drawing.Size(380, 69);
            this.groupBoxAdministracionUsuarios.TabIndex = 18;
            this.groupBoxAdministracionUsuarios.TabStop = false;
            this.groupBoxAdministracionUsuarios.Text = "ADMINISTRACIÓN DE CURSOS";
            // 
            // BtnNuevoCurso
            // 
            this.BtnNuevoCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnNuevoCurso.FlatAppearance.BorderSize = 0;
            this.BtnNuevoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevoCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevoCurso.Location = new System.Drawing.Point(25, 19);
            this.BtnNuevoCurso.Name = "BtnNuevoCurso";
            this.BtnNuevoCurso.Size = new System.Drawing.Size(107, 36);
            this.BtnNuevoCurso.TabIndex = 13;
            this.BtnNuevoCurso.Text = "Nuevo curso";
            this.BtnNuevoCurso.UseVisualStyleBackColor = false;
            this.BtnNuevoCurso.Click += new System.EventHandler(this.BtnNuevoCurso_Click);
            // 
            // BtnBorrarCurso
            // 
            this.BtnBorrarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBorrarCurso.FlatAppearance.BorderSize = 0;
            this.BtnBorrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnBorrarCurso.Location = new System.Drawing.Point(251, 19);
            this.BtnBorrarCurso.Name = "BtnBorrarCurso";
            this.BtnBorrarCurso.Size = new System.Drawing.Size(107, 36);
            this.BtnBorrarCurso.TabIndex = 12;
            this.BtnBorrarCurso.Text = "Borrar curso";
            this.BtnBorrarCurso.UseVisualStyleBackColor = false;
            this.BtnBorrarCurso.Click += new System.EventHandler(this.BtnBorrarCurso_Click);
            // 
            // BtnModificarCurso
            // 
            this.BtnModificarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnModificarCurso.FlatAppearance.BorderSize = 0;
            this.BtnModificarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarCurso.Location = new System.Drawing.Point(138, 19);
            this.BtnModificarCurso.Name = "BtnModificarCurso";
            this.BtnModificarCurso.Size = new System.Drawing.Size(107, 36);
            this.BtnModificarCurso.TabIndex = 11;
            this.BtnModificarCurso.Text = "Modificar curso";
            this.BtnModificarCurso.UseVisualStyleBackColor = false;
            this.BtnModificarCurso.Click += new System.EventHandler(this.BtnModificarCurso_Click);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBusqueda.Controls.Add(this.radioButtonMostrarTodos);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonProfesor);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonCarrera);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonTipoCurso);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonAsignatura);
            this.groupBoxBusqueda.Controls.Add(this.BtnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.comboBoxBusquedaCursos);
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusqueda.ForeColor = System.Drawing.Color.White;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(29, 123);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(380, 380);
            this.groupBoxBusqueda.TabIndex = 17;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "BÚSQUEDA DE CURSOS";
            // 
            // radioButtonMostrarTodos
            // 
            this.radioButtonMostrarTodos.AutoSize = true;
            this.radioButtonMostrarTodos.Checked = true;
            this.radioButtonMostrarTodos.Location = new System.Drawing.Point(23, 142);
            this.radioButtonMostrarTodos.Name = "radioButtonMostrarTodos";
            this.radioButtonMostrarTodos.Size = new System.Drawing.Size(89, 17);
            this.radioButtonMostrarTodos.TabIndex = 18;
            this.radioButtonMostrarTodos.TabStop = true;
            this.radioButtonMostrarTodos.Text = "Mostrar todos";
            this.radioButtonMostrarTodos.UseVisualStyleBackColor = true;
            this.radioButtonMostrarTodos.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonProfesor
            // 
            this.radioButtonProfesor.AutoSize = true;
            this.radioButtonProfesor.Location = new System.Drawing.Point(23, 119);
            this.radioButtonProfesor.Name = "radioButtonProfesor";
            this.radioButtonProfesor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProfesor.TabIndex = 17;
            this.radioButtonProfesor.Text = "Profesor";
            this.radioButtonProfesor.UseVisualStyleBackColor = true;
            this.radioButtonProfesor.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonCarrera
            // 
            this.radioButtonCarrera.AutoSize = true;
            this.radioButtonCarrera.Location = new System.Drawing.Point(23, 50);
            this.radioButtonCarrera.Name = "radioButtonCarrera";
            this.radioButtonCarrera.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCarrera.TabIndex = 16;
            this.radioButtonCarrera.Text = "Carrera";
            this.radioButtonCarrera.UseVisualStyleBackColor = true;
            this.radioButtonCarrera.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonTipoCurso
            // 
            this.radioButtonTipoCurso.AutoSize = true;
            this.radioButtonTipoCurso.Location = new System.Drawing.Point(23, 96);
            this.radioButtonTipoCurso.Name = "radioButtonTipoCurso";
            this.radioButtonTipoCurso.Size = new System.Drawing.Size(90, 17);
            this.radioButtonTipoCurso.TabIndex = 15;
            this.radioButtonTipoCurso.Text = "Tipo de curso";
            this.radioButtonTipoCurso.UseVisualStyleBackColor = true;
            this.radioButtonTipoCurso.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonAsignatura
            // 
            this.radioButtonAsignatura.AutoSize = true;
            this.radioButtonAsignatura.Location = new System.Drawing.Point(23, 73);
            this.radioButtonAsignatura.Name = "radioButtonAsignatura";
            this.radioButtonAsignatura.Size = new System.Drawing.Size(75, 17);
            this.radioButtonAsignatura.TabIndex = 14;
            this.radioButtonAsignatura.Text = "Asignatura";
            this.radioButtonAsignatura.UseVisualStyleBackColor = true;
            this.radioButtonAsignatura.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(151, 168);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 61);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // comboBoxBusquedaCursos
            // 
            this.comboBoxBusquedaCursos.FormattingEnabled = true;
            this.comboBoxBusquedaCursos.Location = new System.Drawing.Point(138, 82);
            this.comboBoxBusquedaCursos.Name = "comboBoxBusquedaCursos";
            this.comboBoxBusquedaCursos.Size = new System.Drawing.Size(206, 21);
            this.comboBoxBusquedaCursos.TabIndex = 11;
            this.comboBoxBusquedaCursos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Busqueda por:";
            // 
            // listViewCursos
            // 
            this.listViewCursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderAsignatura,
            this.columnHeaderTipoCurso,
            this.columnHeaderPrecio});
            this.listViewCursos.FullRowSelect = true;
            this.listViewCursos.Location = new System.Drawing.Point(415, 48);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(569, 455);
            this.listViewCursos.TabIndex = 16;
            this.listViewCursos.UseCompatibleStateImageBehavior = false;
            this.listViewCursos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            this.columnHeaderID.Width = 50;
            // 
            // columnHeaderAsignatura
            // 
            this.columnHeaderAsignatura.Text = "Asignatura";
            this.columnHeaderAsignatura.Width = 200;
            // 
            // columnHeaderTipoCurso
            // 
            this.columnHeaderTipoCurso.Text = "Tipo curso";
            this.columnHeaderTipoCurso.Width = 200;
            // 
            // columnHeaderPrecio
            // 
            this.columnHeaderPrecio.Text = "Precio";
            this.columnHeaderPrecio.Width = 100;
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdministracionUsuarios);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.listViewCursos);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.groupBoxAdministracionUsuarios.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdministracionUsuarios;
        private System.Windows.Forms.Button BtnBorrarCurso;
        private System.Windows.Forms.Button BtnModificarCurso;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.ListView listViewCursos;
        private System.Windows.Forms.RadioButton radioButtonTipoCurso;
        private System.Windows.Forms.RadioButton radioButtonAsignatura;
        private System.Windows.Forms.ComboBox comboBoxBusquedaCursos;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderAsignatura;
        private System.Windows.Forms.ColumnHeader columnHeaderTipoCurso;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecio;
        private System.Windows.Forms.Button BtnNuevoCurso;
        private RadioButton radioButtonProfesor;
        private RadioButton radioButtonCarrera;
        private RadioButton radioButtonMostrarTodos;
    }
}