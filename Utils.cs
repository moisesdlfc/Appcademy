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
    static class Utils
    {
        // *** Cargar matricula ****
        public static string cargarMatricula()
        {
            string matricula = "0";

            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT `precioMatricula` FROM `cuenta` WHERE `cuenta`.`id` = '0'";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReader);
            matricula = tablaAulas.Rows[0]["precioMatricula"].ToString();

            con.Cerrar();
            return matricula;
        }

        // *** Guardar matricula ***
        public static void guardarMatricula(string matricula)
        {
            try
            {
                // Introduce los datos de la matricula en la tabla cuenta
                Conexion con = new Conexion();
                con.Abrir();

                string query = "UPDATE `cuenta` SET `precioMatricula` = '" + matricula + "' WHERE `cuenta`.`id` = 0;";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                con.Cerrar();
                // Informa al usuario
                MessageBox.Show("Matrícula guardada correctamente...", "MATRÍCULA GUARDADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("El campo matricula solo admite valores numericos, vuelva a intentarlo....", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Cargar precios ***
        public static void cargarPrecios(ListView listViewPrecios)
        {
            // Limpia el listViewPrecios
            listViewPrecios.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from `precio`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReader);

            // Actualiza los datos
            for (int i = 0; i < tablaAulas.Rows.Count; i++)
            {
                ListViewItem lv = listViewPrecios.Items.Add(tablaAulas.Rows[i]["tipoCurso"].ToString());
                lv.SubItems.Add(tablaAulas.Rows[i]["precio"].ToString());
                listViewPrecios.Items[i].Tag = tablaAulas.Rows[i]["id"].ToString();
            }

            con.Cerrar();
        }
        // *** Cargar gananciaProfesores ***
        public static string cargarGananciaProfesores()
        {
            string gananciaProfesores = "";

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select `gananciaProfesores` from `cuenta` WHERE `id` = 0";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaGananciaProfesores = new DataTable();
            tablaGananciaProfesores.Load(myReader);

            gananciaProfesores = tablaGananciaProfesores.Rows[0]["gananciaProfesores"].ToString();

            return gananciaProfesores;
        }

        // *** Guarda gananciaProfesores ***
        public static void guardarGananciaProfesores (double gananciaProfesores)
        {
            try
            {
                // Introduce los datos de la matricula en la tabla cuenta
                Conexion con = new Conexion();
                con.Abrir();

                string query = "UPDATE `cuenta` SET `gananciaProfesores` = '" + gananciaProfesores.ToString().Replace(',', '.') + "' WHERE `cuenta`.`id` = 0;";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                con.Cerrar();
                // Informa al usuario
                MessageBox.Show("Porcentaje de ganancia de los profesores guardado correctamente", "PORCENTAJE DE GANANCIA GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("El campo ganancia de los profesores solo admite valores porcentuales, vuelva a intentarlo....", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  *** Guardar precio ***
        public static void guardarPrecio(string tipoCurso, string precio)
        {
            try
            {
                // Introduce los datos en la tabla precio
                Conexion con = new Conexion();
                con.Abrir();

                string query = "INSERT INTO `precio` (`id`, `tipoCurso`, `precio`) VALUES(NULL, '" + tipoCurso + "', '" + precio + "');";
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                con.Cerrar();
                // Informa al usuario
                MessageBox.Show("Precio añadido correctamente...", "PRECIO AÑADIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("El campo precio solo admite valores numericos, vuelva a intentarlo...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *** Eliminar precio ***
        public static void eliminarPrecio(string idPrecioSelected)
        {
            string claveTag = idPrecioSelected;

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from precio";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReader);


            for (int i = 0; i < tablaAulas.Rows.Count; i++)
            {
                if (claveTag.ToString().Equals(tablaAulas.Rows[i]["id"].ToString()))
                {
                    string queryTag = "DELETE FROM `precio` WHERE `precio`.`id` = " + tablaAulas.Rows[i]["id"] + ";";
                    MySqlCommand comandTag = con.Comando(queryTag);
                    MySqlDataReader myReaderTag = comandTag.ExecuteReader();
                }
            }

            con.Cerrar();
            // Informa al usuario
            MessageBox.Show("Precio eliminado correctamente...", "PRECIO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // *** Cargar aulas ***
        public static void cargarAulas(ListView listViewAulas)
        {
            // Limpia el ListViewAulas
            listViewAulas.Items.Clear();

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from aula";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaAulas = new DataTable();
            tablaAulas.Load(myReader);
            for (int i = 0; i < tablaAulas.Rows.Count; i++)
            {
                listViewAulas.Items.Add(tablaAulas.Rows[i]["nombre"].ToString());
                listViewAulas.Items[i].Tag = tablaAulas.Rows[i]["id"].ToString();
            }

            con.Cerrar();
        }

        // *** Guardar aula ***
        public static void guardarAula(string nombreAula)
        {
            // Añade el aula a la lista
            Conexion con = new Conexion();
            con.Abrir();

            string query = "INSERT INTO `aula` (`id`, `nombre`) VALUES(NULL, '" + nombreAula + "');";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            con.Cerrar();
        }

        // *** Eliminar aula ***
        public static void eliminarAula(string idAula)
        {
            Conexion con = new Conexion();
            con.Abrir();

            string query = "DELETE FROM `aula` WHERE `aula`.`ID` = " + idAula + ";";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            con.Cerrar();
        }

        // *** Guarda usuario y password o modifica password ***
        public static void guardarUsuario(string usuario, string password)
        {
            Conexion con = new Conexion();
            con.Abrir();

            string query = "INSERT INTO `cuenta` (`id`, `usuario`, `password`) VALUES('0', '" + usuario + "', '" + password + "');";
            MySqlCommand comand = con.Comando(query);

            try
            {
                MySqlDataReader myReader = comand.ExecuteReader();
            } catch (MySql.Data.MySqlClient.MySqlException)
            {
                query = "UPDATE `cuenta` SET `password` = '" + password + "' WHERE `cuenta`.`id` = 0;";
                comand = con.Comando(query);
                MySqlDataReader myReader = comand.ExecuteReader();
            }

            con.Cerrar();
            // Informa al usuario
            MessageBox.Show("Usuario guardado correctamente...", "USUARIO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // *** Comprueba si el usuario y la password introducidas coinciden con las guardadas ***
        public static bool comprobarUsuario(string usuarioProbado, string passwordProbada)
        {
            // Atributos del metodo
            string usuario = "";
            string password = "";

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from `cuenta`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable cuenta = new DataTable();
            cuenta.Load(myReader);

            for (int i = 0; i < 1; i++)
            {
                usuario = cuenta.Rows[i]["usuario"].ToString();
                password = cuenta.Rows[i]["password"].ToString();
            }

            con.Cerrar();

            // Comprueba si se ha introducido un usuario correcto o no
            if (usuario.Equals(usuarioProbado) && password.Equals(passwordProbada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // *** Calcula precio total de un curso y lo actualiza ***
        public static void CalcularPrecioCurso (int idCurso)
        {
            double precioTotal = 0.0;
            double horasTotal = 0.0;

            Conexion con = new Conexion();
            con.Abrir();

            string query = "select * from `cursoaula`";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable cursoAula = new DataTable();
            cursoAula.Load(myReader);
            myReader.Close();

            foreach (DataRow row in cursoAula.Rows)
            {
                // Si es el curso especificado calcula las horas totales
                if (idCurso == int.Parse(row["IDCurso"].ToString()))
                {
                    DateTime comienzo = Convert.ToDateTime(row["comienzo"].ToString());
                    DateTime fin = Convert.ToDateTime(row["fin"].ToString());

                    TimeSpan result = fin.Subtract(comienzo);

                    horasTotal += result.TotalHours;
                }
            }

            // Obtiene tipo precio del curso especificado y lo multiplica por las horas totales
            string queryPrecio = "select `tipoCurso` from `curso` WHERE ID = " + idCurso;
            MySqlCommand comandPrecio = con.Comando(queryPrecio);

            MySqlDataReader myReaderPrecio = comandPrecio.ExecuteReader();

            DataTable precio = new DataTable();
            precio.Load(myReaderPrecio);
            myReaderPrecio.Close();

            double precioHora = IDtoTEXT.GetPrecioFromIDInPrecio(int.Parse(precio.Rows[0]["tipoCurso"].ToString()));

            // precioTotal = horasTotal * precio/hora
            precioTotal = horasTotal * precioHora;

            // Actualiza el precio en el curso
            string queryUpdatePrecio = "UPDATE `curso` SET `precio` = '" + precioTotal.ToString().Replace(',', '.') + "' WHERE `curso`.`ID` = " + idCurso + ";";
            MySqlCommand comandUpdatePrecio = con.Comando(queryUpdatePrecio);

            MySqlDataReader myReaderUpdatePrecio = comandUpdatePrecio.ExecuteReader();
            myReaderUpdatePrecio.Close();

            con.Cerrar();

            // Actualiza todos los alumnos apuntados al curso
            ActualizaPagosPendientesAlumnos(idCurso);

            // Actualiza el cobro mensual del profesor que imparte el curso especificado
            ActualizaPagosProfesores(idCurso);
        }

        // *** Actualiza precio a pagar de los alumnos del curso especificado ***
        public static void ActualizaPagosPendientesAlumnos (int idCurso)
        {
            List<string> cursosAlumno = new List<string>();

            Conexion con = new Conexion();
            con.Abrir();

            // Primero selecciona todos los alumnos apuntados a dicho curso
            string query = "select * from `cursoalumno` WHERE `IDCurso` = " + idCurso;
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable cursoAlumno = new DataTable();
            cursoAlumno.Load(myReader);
            myReader.Close();

            foreach (DataRow row in cursoAlumno.Rows)
            {
                // Comprueba si el curso recorrido ya esta pagado por ese alumno
                if (!Utils.CheckCursoPagado(idCurso, row["DNIAlumno"].ToString()))
                {
                    // Selecciona todos los datos de uno de los alumnos apuntados al curso
                    string queryAlumno = "select * from `alumno` WHERE `DNI` = '" + row["DNIAlumno"].ToString() + "';";
                    MySqlCommand comandAlumno = con.Comando(queryAlumno);

                    MySqlDataReader myReaderAlumno = comandAlumno.ExecuteReader();

                    DataTable alumno = new DataTable();
                    alumno.Load(myReaderAlumno);
                    myReaderAlumno.Close();

                    // Si el alumno existe y tiene pagosPendientes crea una lista con dichos pagos
                    if (alumno.Rows.Count != 0)
                    {
                        if (!alumno.Rows[0]["pagosPendientes"].ToString().Equals(""))
                        {
                            // Generar lista de pagos pendientes de alumno recorrido
                            cursosAlumno = GenerarCursosAlumno(alumno.Rows[0]["pagosPendientes"].ToString());
                        }
                        else
                        {
                            cursosAlumno = new List<string>();
                        }
                    }
                    // Si no crea una lista vacia
                    else
                    {
                        cursosAlumno = new List<string>();
                    }

                    // Close MySqlDataReaders
                    myReader.Close();
                    myReaderAlumno.Close();

                    // Actualizar el curso actual en la lista generada anteriormente
                    // Si el alumno tiene pagosPendientes...
                    if (cursosAlumno.Count != 0)
                    {
                        string fullDatos = "";

                        // Recorre los pagosPendientes del alumno, comprueba si el curso ya se encuentra entre ellos:
                        // Si lo encuentra lo elimina y despues lo aniade
                        // SI no lo encuentra lo aniade
                        foreach (string curso in cursosAlumno)
                        {
                            if (curso.Split('-')[0].ToString().Equals(idCurso.ToString()))
                            {
                                cursosAlumno.Remove(curso);
                                break;
                            }
                        }

                        fullDatos = idCurso + "-" + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(idCurso)) + "-" + IDtoTEXT.GetPrecioFromIDInCurso(idCurso);
                        cursosAlumno.Add(fullDatos);

                        fullDatos = "";
                        foreach (string curso in cursosAlumno)
                        {
                            // Si el precio del curso no es 0...
                            if (!curso.Split('-')[2].Equals("0"))
                            {
                                fullDatos = fullDatos + curso + "*";
                            }
                        }

                        string queryMultiple = "UPDATE `alumno` SET `pagosPendientes` = '" + fullDatos + "' WHERE `alumno`.`DNI` = '" + row["DNIAlumno"] + "';";
                        MySqlCommand comandMultiple = con.Comando(queryMultiple);

                        MySqlDataReader myReaderMultiple = comandMultiple.ExecuteReader();
                        myReaderMultiple.Close();
                    }
                    // si el alumno no tiene pagos pendientes...
                    else
                    {
                        string fullDatos = "";
                        fullDatos = idCurso + "-" + IDtoTEXT.GetAsignaturaFromIDAsignaturaInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(idCurso)) + "-" + IDtoTEXT.GetPrecioFromIDInCurso(idCurso) + "*";

                        string queryUnico = "UPDATE `alumno` SET `pagosPendientes` = '" + fullDatos + "' WHERE `alumno`.`DNI` = '" + row["DNIAlumno"] + "';";
                        MySqlCommand comandUnico = con.Comando(queryUnico);

                        MySqlDataReader myReaderUnico = comandUnico.ExecuteReader();
                        myReaderUnico.Close();
                    }
                }
            }

            con.Cerrar();
        }

        // *** Carga los cursos de un alumno ***
        public static List<string> GenerarCursosAlumno(string pagosPendientes)
        {
            List<string> cursosAlumno = new List<string>();

            string[] cursos = pagosPendientes.Split('*');

            // Recorre todos los cursos excepto el ultimo que esta en blanco despues del ultimo *
            for (int i = 0; i < (cursos.Length - 1); i++)
            {
                string[] datosCurso = cursos[i].Split('-');
                cursosAlumno.Add(datosCurso[0] + "-" + datosCurso[1] + "-" + datosCurso[2]);
            }

            return cursosAlumno;
        }

        // *** Actualiza cobro al profesor del curso especificado ***
        public static void ActualizaPagosProfesores (int idCurso)
        {
            // Get profesor DNI from idAsignatura
            string dni = IDtoTEXT.GetProfesorDNIFromIDInAsignatura(IDtoTEXT.GetIDAsignaturaFromAsignaturaInCurso(idCurso));

            // Get all courses of this profesor
            List<int> allCourses = IDtoTEXT.GetAllCoursesFromDNIProfesor(dni);

            // Calcula mensualidad del profesor
            double precioMensual = calcularMensualidadProfesor(allCourses);

            // Actualiza las ganancias del profesor
            Conexion con = new Conexion();
            con.Abrir();

            string query = "select `pagos` from `profesor` WHERE `DNI` = '" + dni + "';";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();

            DataTable tablaPagos = new DataTable();
            tablaPagos.Load(myReader);
            myReader.Close();

            if (tablaPagos.Rows.Count != 0)
            {
                string[] arrayPagos = tablaPagos.Rows[0]["pagos"].ToString().Split('*');

                List<string> pagos = arrayPagos.ToList<string>();
                bool pagoEncontrado = false;
                string pagoEncontradoTexto = "";

                foreach (string pago in pagos)
                {
                    string mes = pago.Split('-')[0];

                    if (mes.Equals(GetMonthName(DateTime.Today.Month)))
                    {
                        pagoEncontrado = true;
                        pagoEncontradoTexto = pago;
                    }
                }

                if (pagoEncontrado)
                {
                    pagos.Remove(pagoEncontradoTexto);
                }

                // Aniade la ganancia del mes actual
                pagos.Add(GetMonthName(DateTime.Today.Month) + "-" + precioMensual);

                string fullPagos = "";

                foreach (string pago in pagos)
                {
                    if (!pago.Equals(""))
                    {
                        fullPagos += pago + "*";
                    }
                    
                }

                string queryUpdatePago = "UPDATE `profesor` SET `pagos` = '" + fullPagos + "' WHERE `profesor`.`DNI` = '" + dni + "';";
                MySqlCommand comandUpdatePago = con.Comando(queryUpdatePago);

                MySqlDataReader myReaderUpdatePago = comandUpdatePago.ExecuteReader();

                con.Cerrar();
            }
            

        }

        // Calcular mensualidad de profesor
        public static double calcularMensualidadProfesor (List<int> allCourses)
        {
            double precioMensual = 0.0;

            Conexion con = new Conexion();
            con.Abrir();

            // Recorre todos los cursos del profesor
            foreach (int idCurso in allCourses)
            {
                double horasTotal = 0.0;

                // Almacena la cantidad de alumnos apuntados al curso
                int alumnosApuntados = 0;

                // Primero selecciona todos los alumnos apuntados a dicho curso
                string query = "select * from `cursoalumno` WHERE `IDCurso` = " + idCurso;
                MySqlCommand comand = con.Comando(query);

                MySqlDataReader myReader = comand.ExecuteReader();

                DataTable tablaCantidadAlumnos = new DataTable();
                tablaCantidadAlumnos.Load(myReader);
                myReader.Close();

                // Calcula la cantidad de alumnos apuntados
                alumnosApuntados = tablaCantidadAlumnos.Rows.Count;

                // Carga todos los horarios de el curso recorrido
                string queryHorario = "select * from `cursoaula` WHERE `IDCurso` = " + idCurso;
                MySqlCommand comandHorario = con.Comando(queryHorario);

                MySqlDataReader myReaderHorario = comandHorario.ExecuteReader();

                DataTable cursoAula = new DataTable();
                cursoAula.Load(myReaderHorario);
                myReader.Close();

                foreach (DataRow row in cursoAula.Rows)
                {
                    DateTime comienzo = Convert.ToDateTime(row["comienzo"].ToString());
                    DateTime fin = Convert.ToDateTime(row["fin"].ToString());

                    // Si el horario pertenece al mes actual entonces lo aniade
                    if (comienzo.Month == DateTime.Today.Month)
                    {
                        TimeSpan result = fin.Subtract(comienzo);

                        horasTotal += result.TotalHours;
                    }
                }

                // Obtiene tipo precio del curso especificado y lo multiplica por las horas totales
                string queryPrecio = "select `tipoCurso` from `curso` WHERE ID = " + idCurso;
                MySqlCommand comandPrecio = con.Comando(queryPrecio);

                MySqlDataReader myReaderPrecio = comandPrecio.ExecuteReader();

                DataTable precio = new DataTable();
                precio.Load(myReaderPrecio);
                myReaderPrecio.Close();

                double precioHora = IDtoTEXT.GetPrecioFromIDInPrecio(int.Parse(precio.Rows[0]["tipoCurso"].ToString()));

                // precioMensual = horasTotal * precio/hora
                precioMensual += (horasTotal * precioHora * alumnosApuntados);
            }

            // Multiplica por gananciaProfesores
            precioMensual = precioMensual * (double.Parse(Utils.cargarGananciaProfesores()) / 100);

            return precioMensual;
        }

        // Get month name
        public static string GetMonthName (int month)
        {
            switch (month)
            {
                case 1:
                    return "ENERO";
                    break;

                case 2:
                    return "FEBRERO";
                    break;

                case 3:
                    return "MARZO";
                    break;

                case 4:
                    return "ABRIL";
                    break;

                case 5:
                    return "MAYO";
                    break;

                case 6:
                    return "JUNIO";
                    break;

                case 7:
                    return "JULIO";
                    break;

                case 8:
                    return "AGOSTO";
                    break;

                case 9:
                    return "SEPTIEMBRE";
                    break;

                case 10:
                    return "OCTUBRE";
                    break;

                case 11:
                    return "NOVIEMBRE";
                    break;

                case 12:
                    return "DICIEMBRE";
                    break;

                default:
                    return "MES DESCONOCIDO";
                    break;
            }
        }

        // Check si un curso ya esta pagado por un alumno especifico
        public static bool CheckCursoPagado (int idCurso, string dni)
        {
            bool pagoRealizado = false;

            Conexion con = new Conexion();
            con.Abrir();

            string query = "SELECT `pagosRealizados` FROM `alumno` WHERE `DNI` = '" + dni + "';";
            MySqlCommand comand = con.Comando(query);

            MySqlDataReader myReader = comand.ExecuteReader();
            DataTable tablaPagosRealizados = new DataTable();
            tablaPagosRealizados.Load(myReader);

            if (tablaPagosRealizados.Rows.Count != 0)
            {
                string[] pagosRealizados = tablaPagosRealizados.Rows[0]["pagosRealizados"].ToString().Split('*');

                for (int i = 0; i < pagosRealizados.Length; i++)
                {
                    if (pagosRealizados[i].Equals(idCurso.ToString()))
                    {
                        pagoRealizado = true;
                    }
                }
            }

            return pagoRealizado;
        }

    }
}
