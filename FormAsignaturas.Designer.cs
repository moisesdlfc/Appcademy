using System.Windows.Forms;

namespace Appcademy
{
    partial class FormAsignaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignaturas));
            this.groupBoxAdministracionUsuarios = new System.Windows.Forms.GroupBox();
            this.BtnBorrarAsignatura = new System.Windows.Forms.Button();
            this.BtnModificarAsignatura = new System.Windows.Forms.Button();
            this.BtnNuevaAsignatura = new System.Windows.Forms.Button();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.radioButtonCarrera = new System.Windows.Forms.RadioButton();
            this.radioButtonProfesor = new System.Windows.Forms.RadioButton();
            this.listViewAsignaturas = new System.Windows.Forms.ListView();
            this.columnHeaderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCarrera = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAsignatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProfesor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAdministracionUsuarios.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdministracionUsuarios
            // 
            this.groupBoxAdministracionUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnBorrarAsignatura);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnModificarAsignatura);
            this.groupBoxAdministracionUsuarios.Controls.Add(this.BtnNuevaAsignatura);
            this.groupBoxAdministracionUsuarios.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdministracionUsuarios.Location = new System.Drawing.Point(24, 38);
            this.groupBoxAdministracionUsuarios.Name = "groupBoxAdministracionUsuarios";
            this.groupBoxAdministracionUsuarios.Size = new System.Drawing.Size(368, 69);
            this.groupBoxAdministracionUsuarios.TabIndex = 15;
            this.groupBoxAdministracionUsuarios.TabStop = false;
            this.groupBoxAdministracionUsuarios.Text = "ADMINISTRACIÓN DE ASIGNATURAS";
            // 
            // BtnBorrarAsignatura
            // 
            this.BtnBorrarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBorrarAsignatura.FlatAppearance.BorderSize = 0;
            this.BtnBorrarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarAsignatura.ForeColor = System.Drawing.Color.Black;
            this.BtnBorrarAsignatura.Location = new System.Drawing.Point(249, 19);
            this.BtnBorrarAsignatura.Name = "BtnBorrarAsignatura";
            this.BtnBorrarAsignatura.Size = new System.Drawing.Size(107, 36);
            this.BtnBorrarAsignatura.TabIndex = 12;
            this.BtnBorrarAsignatura.Text = "Borrar asignatura";
            this.BtnBorrarAsignatura.UseVisualStyleBackColor = false;
            this.BtnBorrarAsignatura.Click += new System.EventHandler(this.BtnBorrarAsignatura_Click);
            // 
            // BtnModificarAsignatura
            // 
            this.BtnModificarAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnModificarAsignatura.FlatAppearance.BorderSize = 0;
            this.BtnModificarAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificarAsignatura.ForeColor = System.Drawing.Color.Black;
            this.BtnModificarAsignatura.Location = new System.Drawing.Point(136, 19);
            this.BtnModificarAsignatura.Name = "BtnModificarAsignatura";
            this.BtnModificarAsignatura.Size = new System.Drawing.Size(107, 36);
            this.BtnModificarAsignatura.TabIndex = 11;
            this.BtnModificarAsignatura.Text = "Modificar asignatura";
            this.BtnModificarAsignatura.UseVisualStyleBackColor = false;
            this.BtnModificarAsignatura.Click += new System.EventHandler(this.BtnModificarAsignatura_Click);
            // 
            // BtnNuevaAsignatura
            // 
            this.BtnNuevaAsignatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnNuevaAsignatura.FlatAppearance.BorderSize = 0;
            this.BtnNuevaAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNuevaAsignatura.ForeColor = System.Drawing.Color.Black;
            this.BtnNuevaAsignatura.Location = new System.Drawing.Point(23, 19);
            this.BtnNuevaAsignatura.Name = "BtnNuevaAsignatura";
            this.BtnNuevaAsignatura.Size = new System.Drawing.Size(107, 36);
            this.BtnNuevaAsignatura.TabIndex = 10;
            this.BtnNuevaAsignatura.Text = "Nueva asignatura";
            this.BtnNuevaAsignatura.UseVisualStyleBackColor = false;
            this.BtnNuevaAsignatura.Click += new System.EventHandler(this.BtnNuevaAsignatura_Click);
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Controls.Add(this.TxtBuscar);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonNombre);
            this.groupBoxBusqueda.Controls.Add(this.BtnBuscar);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonCarrera);
            this.groupBoxBusqueda.Controls.Add(this.radioButtonProfesor);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBusqueda.ForeColor = System.Drawing.Color.White;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(24, 113);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(368, 376);
            this.groupBoxBusqueda.TabIndex = 14;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "BÚSQUEDA DE ASIGNATURAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Busqueda por:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(102, 30);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(199, 20);
            this.TxtBuscar.TabIndex = 0;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(102, 56);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(140, 17);
            this.radioButtonNombre.TabIndex = 2;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Nombre de la asignatura";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Black;
            this.BtnBuscar.Location = new System.Drawing.Point(146, 138);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 61);
            this.BtnBuscar.TabIndex = 9;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            // 
            // radioButtonCarrera
            // 
            this.radioButtonCarrera.AutoSize = true;
            this.radioButtonCarrera.Location = new System.Drawing.Point(102, 79);
            this.radioButtonCarrera.Name = "radioButtonCarrera";
            this.radioButtonCarrera.Size = new System.Drawing.Size(59, 17);
            this.radioButtonCarrera.TabIndex = 3;
            this.radioButtonCarrera.TabStop = true;
            this.radioButtonCarrera.Text = "Carrera";
            this.radioButtonCarrera.UseVisualStyleBackColor = true;
            // 
            // radioButtonProfesor
            // 
            this.radioButtonProfesor.AutoSize = true;
            this.radioButtonProfesor.Location = new System.Drawing.Point(102, 102);
            this.radioButtonProfesor.Name = "radioButtonProfesor";
            this.radioButtonProfesor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonProfesor.TabIndex = 4;
            this.radioButtonProfesor.TabStop = true;
            this.radioButtonProfesor.Text = "Profesor";
            this.radioButtonProfesor.UseVisualStyleBackColor = true;
            // 
            // listViewAsignaturas
            // 
            this.listViewAsignaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderID,
            this.columnHeaderCarrera,
            this.columnHeaderAsignatura,
            this.columnHeaderProfesor});
            this.listViewAsignaturas.FullRowSelect = true;
            this.listViewAsignaturas.Location = new System.Drawing.Point(398, 38);
            this.listViewAsignaturas.Name = "listViewAsignaturas";
            this.listViewAsignaturas.Size = new System.Drawing.Size(590, 451);
            this.listViewAsignaturas.TabIndex = 13;
            this.listViewAsignaturas.UseCompatibleStateImageBehavior = false;
            this.listViewAsignaturas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderID
            // 
            this.columnHeaderID.Text = "ID";
            // 
            // columnHeaderCarrera
            // 
            this.columnHeaderCarrera.Text = "Carrera";
            this.columnHeaderCarrera.Width = 120;
            // 
            // columnHeaderAsignatura
            // 
            this.columnHeaderAsignatura.Text = "Asignatura";
            this.columnHeaderAsignatura.Width = 120;
            // 
            // columnHeaderProfesor
            // 
            this.columnHeaderProfesor.Text = "Profesor";
            this.columnHeaderProfesor.Width = 150;
            // 
            // FormAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxAdministracionUsuarios);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.listViewAsignaturas);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAsignaturas";
            this.Text = "FormAsignaturas";
            this.Load += new System.EventHandler(this.FormAsignaturas_Load);
            this.groupBoxAdministracionUsuarios.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdministracionUsuarios;
        private System.Windows.Forms.Button BtnBorrarAsignatura;
        private System.Windows.Forms.Button BtnModificarAsignatura;
        private System.Windows.Forms.Button BtnNuevaAsignatura;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.RadioButton radioButtonCarrera;
        private System.Windows.Forms.RadioButton radioButtonProfesor;
        private System.Windows.Forms.ListView listViewAsignaturas;
        private System.Windows.Forms.Label label1;
        private ColumnHeader columnHeaderID;
        private ColumnHeader columnHeaderCarrera;
        private ColumnHeader columnHeaderAsignatura;
        private ColumnHeader columnHeaderProfesor;
    }
}