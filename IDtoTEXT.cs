using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    public static class IDtoTEXT
    {
        // Get idAsignatura name from asignatura in curso
        public static int GetIDAsignaturaFromAsignaturaInCurso (int id)
        {
            int idAsignatura = 0;

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `curso` WHERE `id` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            idAsignatura = int.Parse(tablaCursos.Rows[0]["asignatura"].ToString());

            con.Cerrar();

            return idAsignatura;
        }

        // Get asignatura name from idAsignatura in asignatura
        public static string GetAsignaturaFromIDAsignaturaInAsignatura(int id)
        {
            string asignatura = "";

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `asignatura` WHERE `id` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAsignatura = new DataTable();
            tablaAsignatura.Load(myReader);

            asignatura = tablaAsignatura.Rows[0]["asignatura"].ToString();

            con.Cerrar();
            return asignatura;
        }

        // Get professor name + subname from DNI in profesor
        public static string GetProfesorFullNameFromDNIInProfesor(string dni)
        {
            string fullName = "";

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `profesor` WHERE `DNI` = '" + dni + "';";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            fullName = tablaCursos.Rows[0]["nombre"].ToString() + " " + tablaCursos.Rows[0]["apellidos"].ToString();

            con.Cerrar();

            return fullName;
        }

        // Get profesor DNI from ID in asignatura
        public static string GetProfesorDNIFromIDInAsignatura(int id)
        {
            string dni = "";

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT `profesor` FROM `asignatura` WHERE `ID` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            dni = tablaCursos.Rows[0]["profesor"].ToString();

            con.Cerrar();

            return dni;
        }

        // Get all courses of speciefied profesor
        public static List<int> GetAllCoursesFromDNIProfesor(string dni)
        {
            List<int> allCourses = new List<int>();

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT * FROM `curso`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursos = new DataTable();
            tablaCursos.Load(myReader);

            foreach (DataRow row in tablaCursos.Rows)
            {
                // Obtiene el profesor del curso recorrido y compara si coincide con el profesor que estamos actualizando
                if (dni.Equals(IDtoTEXT.GetProfesorDNIFromIDInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(int.Parse(row["ID"].ToString())))))
                {
                    // Si coincide entonces lo aniadimos a cursos del profesor
                    allCourses.Add(int.Parse(row["ID"].ToString()));
                }
            }

            con.Cerrar();

            return allCourses;
        }

        // Get precio from ID in precio
        public static double GetPrecioFromIDInPrecio(int id)
        {
            double precio = 0.0;

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT `precio` FROM `precio` WHERE `id` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaPrecio = new DataTable();
            tablaPrecio.Load(myReader);

            precio = double.Parse(tablaPrecio.Rows[0]["precio"].ToString());

            con.Cerrar();

            return precio;
        }

        // Get precio from ID in curso
        public static double GetPrecioFromIDInCurso(int id)
        {
            double precio = 0.0;

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT `precio` FROM `curso` WHERE `id` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaPrecio = new DataTable();
            tablaPrecio.Load(myReader);

            precio = double.Parse(tablaPrecio.Rows[0]["precio"].ToString());

            con.Cerrar();

            return precio;
        }

        // Get IDCurso from IDCursoAula in cursoaula
        public static int GetIDCursoFromIDCursoAulaInCursoAula(int id)
        {
            int idCurso = 0;

            Conexion con = new Conexion();
            con.Abrir();
            string query = "SELECT `idcurso` FROM `cursoaula` WHERE `idcursoaula` = " + id;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaCursoAula = new DataTable();
            tablaCursoAula.Load(myReader);

            idCurso = int.Parse(tablaCursoAula.Rows[0]["idcurso"].ToString());

            con.Cerrar();

            return idCurso;
        }
    }
}
