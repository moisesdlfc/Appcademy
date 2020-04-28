using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public partial class FormHorarios : Form
    {
        // Shared instance
        public static FormHorarios sharedInstance;

        public FormHorarios()
        {
            InitializeComponent();
            sharedInstance = this;
        }

        // Load
        private void FormHorarios_Load(object sender, EventArgs e)
        {
            // Carga aulas
            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT * FROM `aula`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReader);

            foreach (DataRow row in tablaAulas.Rows)
            {
                comboBoxAulas.Items.Add(new ComboItem(row["nombre"].ToString(), int.Parse(row["id"].ToString())));
            }

            con.Cerrar();
        }

        // dateTimePicker event value changed
        public void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxAulas.SelectedItem != null)
            {
                //string enviado = dateTimePicker.Value.ToString("yyyy-MM-dd");
                DateTime dt = new DateTime(int.Parse(dateTimePicker.Value.ToString("yyyy")), int.Parse(dateTimePicker.Value.ToString("MM")), int.Parse(dateTimePicker.Value.ToString("dd")));

                // Obtiene el id del aula seleccionada
                ComboItem aulaSelected = comboBoxAulas.SelectedItem as ComboItem;

                // Select data and week of day selected and make CSV
                ToolsCSV.MakeCSV(ToolsCSV.LoadWeek(dt), aulaSelected.GetId());
                DataTable dtWeek = ToolsCSV.NewDataTable(@"week.csv");
                dataGridView.DataSource = dtWeek;

                // Back color in dataGridView
                foreach (DataGridViewColumn col in dataGridView.Columns)
                {
                    col.DefaultCellStyle.BackColor = Color.FromArgb(112, 195, 255);
                }
            } else
            {
                MessageBox.Show("Primero debe seleccionar un aula para visualizar sus horarios.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cell painting event
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = dataGridView.AdvancedCellBorderStyle.Top;
            }
        }

        // Is the same cell value
        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = dataGridView[column, row];
            DataGridViewCell cell2 = dataGridView[column, row - 1];
            if (cell1.Value == null || cell2.Value == null || cell1.Value == "" || cell2.Value == "")
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }

        // comboBoxAulas select event
        private void comboBoxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTimePicker_ValueChanged(null, null);
        }

        // Click button Add curso
        private void buttonAddHorario_Click(object sender, EventArgs e)
        {
            FormNuevoHorario formNuevoHorario = new FormNuevoHorario();
            formNuevoHorario.Show();
        }

        // Click buttonModificarHorario
        private void buttonModificarHorario_Click(object sender, EventArgs e)
        {
            try {
                // TODO: Crear form modificar horario y meterle los parametros pasados aqui
                // Guarda el id del aula seleccionada
                ComboItem idAula = comboBoxAulas.SelectedItem as ComboItem;

                int idCursoAula = int.Parse(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells[dataGridView.SelectedCells[0].ColumnIndex].Value.ToString().Split(' ')[0]);

                //FormModificarHorario formModificarHorario = new FormModificarHorario(idAula.GetId(), dataGridView.Rows[dataGridView.SelectedCells[dataGridView.SelectedCells.Count - 1].RowIndex].Cells[0].Value.ToString(), dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), dataGridView.Columns[dataGridView.SelectedCells[0].ColumnIndex].HeaderText);
                FormModificarHorario formModificarHorario = new FormModificarHorario(idCursoAula);
                formModificarHorario.Show();
            } catch (System.FormatException)
            {
                MessageBox.Show("No hay horario establecido en la celda seleccionada.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Debe seleccionar una celda para modificar el horario.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click buttonEliminarHorario
        private void buttonEliminarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                ComboItem idAula = comboBoxAulas.SelectedItem as ComboItem;

                int idCursoAula = int.Parse(dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex].Cells[dataGridView.SelectedCells[0].ColumnIndex].Value.ToString().Split(' ')[0]);

                Conexion con = new Conexion();
                con.Abrir();

                // Obtiene IDCurso del IDCursoAula eliminado
                int idCurso = IDtoTEXT.GetIDCursoFromIDCursoAulaInCursoAula(idCursoAula);

                string query = "DELETE FROM `cursoaula` WHERE `cursoaula`.`IDCursoAula` = " + idCursoAula;
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                DataTable tablaCursoAula = new DataTable();
                tablaCursoAula.Load(myReader);

                // Recarga el dataGridView
                FormHorarios.sharedInstance.dateTimePicker_ValueChanged(null, null);

                // Calcula las horas totales de este curso y actualiza el precio
                Utils.CalcularPrecioCurso(idCurso);

                MessageBox.Show("Horario eliminado", "HORARIO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Cerrar();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("No hay horario establecido en la celda seleccionada.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
