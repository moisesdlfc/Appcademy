using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    internal class Conexion
    {
        MySqlConnection databaseConnection;
        string cadena = @"Server=remotemysql.com;Port=3306;Database=b9TYluBdVP;Uid=b9TYluBdVP;Pwd=KR3ZcAYoPt;";

        public Conexion()
        {
            databaseConnection = new MySqlConnection(cadena);
        }

        public void Abrir()
        {
            if (databaseConnection.State != ConnectionState.Open)
            {
                try
                {
                    databaseConnection.Open();
                }
                catch (Exception)
                {
                    try
                    {
                        databaseConnection = new MySqlConnection(cadena);
                        databaseConnection.Open();
                    }
                    catch (Exception)
                    {
                        // devolver string para mostrar en MessageBox
                        //MessageBox.Show("No se pudo establecer la conexión con el servidor.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public void Cerrar()
        {
            databaseConnection.Close();
        }

        public MySqlCommand Comando(string query)
        {
            MySqlCommand com = new MySqlCommand(query, databaseConnection);
            return com;
        }
    }
}
