namespace Appcademy
{
    partial class FormHorarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarios));
            this.comboBoxAulas = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelAula = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelFecha = new System.Windows.Forms.Label();
            this.buttonAddHorario = new System.Windows.Forms.Button();
            this.buttonModificarHorario = new System.Windows.Forms.Button();
            this.buttonEliminarHorario = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAulas
            // 
            this.comboBoxAulas.FormattingEnabled = true;
            this.comboBoxAulas.Location = new System.Drawing.Point(518, 39);
            this.comboBoxAulas.Name = "comboBoxAulas";
            this.comboBoxAulas.Size = new System.Drawing.Size(162, 21);
            this.comboBoxAulas.TabIndex = 1;
            this.comboBoxAulas.SelectedIndexChanged += new System.EventHandler(this.comboBoxAulas_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(90, 66);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(892, 437);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_CellPainting);
            // 
            // labelAula
            // 
            this.labelAula.AutoSize = true;
            this.labelAula.BackColor = System.Drawing.Color.Transparent;
            this.labelAula.ForeColor = System.Drawing.Color.White;
            this.labelAula.Location = new System.Drawing.Point(481, 42);
            this.labelAula.Name = "labelAula";
            this.labelAula.Size = new System.Drawing.Size(31, 13);
            this.labelAula.TabIndex = 3;
            this.labelAula.Text = "Aula:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(333, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(111, 20);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.ForeColor = System.Drawing.Color.White;
            this.labelFecha.Location = new System.Drawing.Point(287, 42);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha:";
            // 
            // buttonAddHorario
            // 
            this.buttonAddHorario.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddHorario.BackgroundImage")));
            this.buttonAddHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddHorario.Location = new System.Drawing.Point(34, 66);
            this.buttonAddHorario.Name = "buttonAddHorario";
            this.buttonAddHorario.Size = new System.Drawing.Size(50, 50);
            this.buttonAddHorario.TabIndex = 6;
            this.toolTip.SetToolTip(this.buttonAddHorario, "Crear horario");
            this.buttonAddHorario.UseVisualStyleBackColor = false;
            this.buttonAddHorario.Click += new System.EventHandler(this.buttonAddHorario_Click);
            // 
            // buttonModificarHorario
            // 
            this.buttonModificarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificarHorario.BackgroundImage")));
            this.buttonModificarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificarHorario.Location = new System.Drawing.Point(34, 122);
            this.buttonModificarHorario.Name = "buttonModificarHorario";
            this.buttonModificarHorario.Size = new System.Drawing.Size(50, 50);
            this.buttonModificarHorario.TabIndex = 7;
            this.toolTip.SetToolTip(this.buttonModificarHorario, "Modificar horario");
            this.buttonModificarHorario.UseVisualStyleBackColor = true;
            this.buttonModificarHorario.Click += new System.EventHandler(this.buttonModificarHorario_Click);
            // 
            // buttonEliminarHorario
            // 
            this.buttonEliminarHorario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminarHorario.BackgroundImage")));
            this.buttonEliminarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminarHorario.Location = new System.Drawing.Point(34, 178);
            this.buttonEliminarHorario.Name = "buttonEliminarHorario";
            this.buttonEliminarHorario.Size = new System.Drawing.Size(50, 50);
            this.buttonEliminarHorario.TabIndex = 8;
            this.toolTip.SetToolTip(this.buttonEliminarHorario, "Eliminar horario");
            this.buttonEliminarHorario.UseVisualStyleBackColor = true;
            this.buttonEliminarHorario.Click += new System.EventHandler(this.buttonEliminarHorario_Click);
            // 
            // FormHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 515);
            this.ControlBox = false;
            this.Controls.Add(this.buttonEliminarHorario);
            this.Controls.Add(this.buttonModificarHorario);
            this.Controls.Add(this.buttonAddHorario);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelAula);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxAulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHorarios";
            this.Text = "FormHorarios";
            this.Load += new System.EventHandler(this.FormHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxAulas;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelAula;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button buttonAddHorario;
        private System.Windows.Forms.Button buttonModificarHorario;
        private System.Windows.Forms.Button buttonEliminarHorario;
        private System.Windows.Forms.ToolTip toolTip;
    }
}