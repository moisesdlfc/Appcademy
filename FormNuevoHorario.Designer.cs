﻿namespace Appcademy
{
    partial class FormNuevoHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoHorario));
            this.comboBoxCursos = new System.Windows.Forms.ComboBox();
            this.comboBoxAulas = new System.Windows.Forms.ComboBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.maskedTextBoxFechaComienzo = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCursos
            // 
            this.comboBoxCursos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCursos.ForeColor = System.Drawing.Color.White;
            this.comboBoxCursos.FormattingEnabled = true;
            this.comboBoxCursos.Location = new System.Drawing.Point(163, 48);
            this.comboBoxCursos.Name = "comboBoxCursos";
            this.comboBoxCursos.Size = new System.Drawing.Size(151, 25);
            this.comboBoxCursos.TabIndex = 80;
            this.comboBoxCursos.SelectedIndexChanged += new System.EventHandler(this.comboBoxCursos_SelectedIndexChanged);
            // 
            // comboBoxAulas
            // 
            this.comboBoxAulas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAulas.ForeColor = System.Drawing.Color.White;
            this.comboBoxAulas.FormattingEnabled = true;
            this.comboBoxAulas.Location = new System.Drawing.Point(163, 82);
            this.comboBoxAulas.Name = "comboBoxAulas";
            this.comboBoxAulas.Size = new System.Drawing.Size(151, 25);
            this.comboBoxAulas.TabIndex = 79;
            this.comboBoxAulas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAulas_SelectedIndexChanged);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(102, 195);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 77;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.BtnCancelar.Location = new System.Drawing.Point(183, 195);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 76;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(33, 119);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(132, 17);
            this.labelTelefono.TabIndex = 75;
            this.labelTelefono.Text = "Fecha Comienzo:";
            this.labelTelefono.Click += new System.EventHandler(this.labelTelefono_Click);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.Color.White;
            this.labelApellidos.Location = new System.Drawing.Point(33, 84);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(45, 17);
            this.labelApellidos.TabIndex = 74;
            this.labelApellidos.Text = "Aula:";
            this.labelApellidos.Click += new System.EventHandler(this.labelApellidos_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(33, 51);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(55, 17);
            this.labelNombre.TabIndex = 73;
            this.labelNombre.Text = "Curso:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // maskedTextBoxFechaComienzo
            // 
            this.maskedTextBoxFechaComienzo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.maskedTextBoxFechaComienzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxFechaComienzo.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxFechaComienzo.Location = new System.Drawing.Point(163, 116);
            this.maskedTextBoxFechaComienzo.Mask = "00/00/0000 00:00";
            this.maskedTextBoxFechaComienzo.Name = "maskedTextBoxFechaComienzo";
            this.maskedTextBoxFechaComienzo.Size = new System.Drawing.Size(151, 23);
            this.maskedTextBoxFechaComienzo.TabIndex = 81;
            this.maskedTextBoxFechaComienzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxFechaComienzo.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFechaComienzo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxFechaComienzo_MaskInputRejected);
            // 
            // maskedTextBoxFechaFin
            // 
            this.maskedTextBoxFechaFin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.maskedTextBoxFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxFechaFin.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxFechaFin.Location = new System.Drawing.Point(163, 151);
            this.maskedTextBoxFechaFin.Mask = "00/00/0000 00:00";
            this.maskedTextBoxFechaFin.Name = "maskedTextBoxFechaFin";
            this.maskedTextBoxFechaFin.Size = new System.Drawing.Size(151, 23);
            this.maskedTextBoxFechaFin.TabIndex = 83;
            this.maskedTextBoxFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxFechaFin.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxFechaFin.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxFechaFin_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 82;
            this.label1.Text = "Fecha Fin:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(359, 27);
            this.toolStrip1.TabIndex = 84;
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
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(112, 24);
            this.toolStripLabel1.Text = "Nuevo Horario";
            // 
            // FormNuevoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 266);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maskedTextBoxFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBoxFechaComienzo);
            this.Controls.Add(this.comboBoxCursos);
            this.Controls.Add(this.comboBoxAulas);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoHorario";
            this.Text = "FormNuevoHorario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCursos;
        private System.Windows.Forms.ComboBox comboBoxAulas;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaComienzo;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}