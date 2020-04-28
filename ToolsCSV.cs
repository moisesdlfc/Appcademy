using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appcademy
{
    public static class ToolsCSV
    {
        public static void MakeCSV(DateTime[] week, int idAula)
        {
            string filePath = @"week.csv";
            string delimiter = ";";

            // Get cursos from week selected
            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `cursoaula` WHERE `IDAula` = " + idAula + " AND `comienzo` >= '" + week[0].ToString("yyyy/MM/dd HH:mm:ss") + "' AND `fin` < '" + week[6].AddDays(1).ToString("yyyy/MM/dd HH:mm:ss") + "'";

            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            con.Cerrar();

            // Array bidimensional
            string[][] output = new string[][]{
                new string[]{"HORAS/DIAS", week[0].ToString("dd/MM/yyyy"), week[1].ToString("dd/MM/yyyy"), week[2].ToString("dd/MM/yyyy"), week[3].ToString("dd/MM/yyyy"), week[4].ToString("dd/MM/yyyy"), week[5].ToString("dd/MM/yyyy"), week[6].ToString("dd/MM/yyyy") },
                new string[]{"08:00:00", "", "", "", "", "", "", "" },
                new string[]{"08:30:00", "", "", "", "", "", "", "" },
                new string[]{"09:00:00", "", "", "", "", "", "", "" },
                new string[]{"09:30:00", "", "", "", "", "", "", "" },
                new string[]{"10:00:00", "", "", "", "", "", "", "" },
                new string[]{"10:30:00", "", "", "", "", "", "", "" },
                new string[]{"11:00:00", "", "", "", "", "", "", "" },
                new string[]{"11:30:00", "", "", "", "", "", "", "" },
                new string[]{"12:00:00", "", "", "", "", "", "", "" },
                new string[]{"12:30:00", "", "", "", "", "", "", "" },
                new string[]{"13:00:00", "", "", "", "", "", "", "" },
                new string[]{"13:30:00", "", "", "", "", "", "", "" },
                new string[]{"14:00:00", "", "", "", "", "", "", "" },
                new string[]{"14:30:00", "", "", "", "", "", "", "" },
                new string[]{"15:00:00", "", "", "", "", "", "", "" },
                new string[]{"15:30:00", "", "", "", "", "", "", "" },
                new string[]{"16:00:00", "", "", "", "", "", "", "" },
                new string[]{"16:30:00", "", "", "", "", "", "", "" },
                new string[]{"17:00:00", "", "", "", "", "", "", "" },
                new string[]{"17:30:00", "", "", "", "", "", "", "" },
                new string[]{"18:00:00", "", "", "", "", "", "", "" },
                new string[]{"18:30:00", "", "", "", "", "", "", "" },
                new string[]{"19:00:00", "", "", "", "", "", "", "" },
                new string[]{"19:30:00", "", "", "", "", "", "", "" },
                new string[]{"20:00:00", "", "", "", "", "", "", "" },
                new string[]{"20:30:00", "", "", "", "", "", "", "" },
                new string[]{"21:00:00", "", "", "", "", "", "", "" },
                new string[]{"21:30:00", "", "", "", "", "", "", "" },
                new string[]{"22:00:00", "", "", "", "", "", "", "" }
            };

            // Introduce datos en el array bidimensional
            foreach (DataRow row in tablaCursos.Rows)
            {
                // Seleccion de columna
                string[] fechaHoraComienzo = row["comienzo"].ToString().Split(' ');
                string[] fechaHoraFin = row["fin"].ToString().Split(' ');

                int columna = 1;

                for (int i = columna; i < output[0].Length; i++)
                {
                    if (output[0][i].ToString().Equals(fechaHoraComienzo[0]))
                    {
                        columna = i;
                    }
                }

                // Seleccion de hora comienzo y hora fin
                int fila = 1;

                for (int i = fila; i < output.Length; i++)
                {
                    DateTime horaFila = Convert.ToDateTime(output[i][0].ToString());
                    DateTime horaComienzoCurso = Convert.ToDateTime(fechaHoraComienzo[1]);
                    DateTime horaFinCurso = Convert.ToDateTime(fechaHoraFin[1]);

                    // Si esta dentro del rango de horas introduce la clase en array bidimensional
                    if (horaComienzoCurso <= horaFila && horaFinCurso >= horaFila)
                    {
                        // Obtiene el idAsignatura de curso, despues obtiene el nombre de la asignatura de asignaturas y lo introduce en el array bidimensional
                        output[i][columna] = row["IDCursoAula"].ToString() + " - " + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(int.Parse(row["IDCurso"].ToString()))) + " (" + row["IDCurso"].ToString() + ")";
                    }
                }
            }

            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(delimiter, output[index]));

            File.WriteAllText(filePath, sb.ToString());
        }

        public static DataTable NewDataTable(string filePath)
        {
            DataTable dt = new DataTable();

            // Creating the columns
            foreach (var headerLine in File.ReadLines(filePath).Take(1))
            {
                foreach (var headerItem in headerLine.Split(new[] { ';' }))
                {
                    dt.Columns.Add(headerItem.Trim());
                }
            }

            // Adding the rows
            foreach (var line in File.ReadLines(filePath).Skip(1))
            {
                dt.Rows.Add(line.Split(';'));
            }

            return dt;
        }

        public static DateTime[] LoadWeek(DateTime dt)
        {
            // Week DateTime
            DateTime[] week = new DateTime[7];

            switch (dt.DayOfWeek.ToString().ToUpper())
            {
                case "MONDAY":
                    week[0] = dt;
                    for (int i = 1; i < 7; i++)
                    {
                        week[i] = dt.AddDays(i);
                    }
                    break;

                case "TUESDAY":
                    week[0] = dt.AddDays(-1);
                    week[1] = dt;
                    int contadorT = 0;
                    for (int i = 2; i < 7; i++)
                    {
                        week[i] = dt.AddDays(++contadorT);
                    }
                    break;

                case "WEDNESDAY":
                    week[0] = dt.AddDays(-2);
                    week[1] = dt.AddDays(-1);
                    week[2] = dt;
                    int contadorW = 0;
                    for (int i = 3; i < 7; i++)
                    {
                        week[i] = dt.AddDays(++contadorW);
                    }
                    break;

                case "THURSDAY":
                    week[0] = dt.AddDays(-3);
                    week[1] = dt.AddDays(-2);
                    week[2] = dt.AddDays(-1);
                    week[3] = dt;
                    int contadorX = 0;
                    for (int i = 4; i < 7; i++)
                    {
                        week[i] = dt.AddDays(++contadorX);
                    }
                    break;

                case "FRIDAY":
                    week[0] = dt.AddDays(-4);
                    week[1] = dt.AddDays(-3);
                    week[2] = dt.AddDays(-2);
                    week[3] = dt.AddDays(-1);
                    week[4] = dt;
                    int contadorF = 0;
                    for (int i = 5; i < 7; i++)
                    {
                        week[i] = dt.AddDays(++contadorF);
                    }
                    break;

                case "SATURDAY":
                    week[0] = dt.AddDays(-5);
                    week[1] = dt.AddDays(-4);
                    week[2] = dt.AddDays(-3);
                    week[3] = dt.AddDays(-2);
                    week[4] = dt.AddDays(-1);
                    week[5] = dt;
                    int contadorS = 0;
                    for (int i = 6; i < 7; i++)
                    {
                        week[i] = dt.AddDays(++contadorS);
                    }
                    break;

                case "SUNDAY":
                    week[0] = dt.AddDays(-6);
                    week[1] = dt.AddDays(-5);
                    week[2] = dt.AddDays(-4);
                    week[3] = dt.AddDays(-3);
                    week[4] = dt.AddDays(-2);
                    week[5] = dt.AddDays(-1);
                    week[6] = dt;

                    break;
            }

            return week;
        }

    }
}
