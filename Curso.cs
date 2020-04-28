using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    class Curso
    {
        // Atributos
        private int ID;
        private Asignatura asignatura;
        private String tipoCurso; // METER
        private List<DateTime> horarios;
        private double precio;
        private List<Alumno> alumnos;

        // Constructor vacio
        public Curso()
        {

        }

        // Constructor
        public Curso(int ID, Asignatura asignatura, String tipoCurso, List<DateTime> horarios, double precio, List<Alumno> alumnos)
        {
            this.ID = ID;
            this.asignatura = asignatura;
            this.tipoCurso = tipoCurso;
            this.horarios = horarios;
            this.precio = precio;
            this.alumnos = alumnos;
        }

        // Getters y setters
        public int getID()
        {
            return ID;
        }

        public void setID(int ID)
        {
            this.ID = ID;
        }

        public Asignatura getAsignatura()
        {
            return asignatura;
        }

        public void setAsignatura(Asignatura asignatura)
        {
            this.asignatura = asignatura;
        }

        public String getTipoCurso()
        {
            return tipoCurso;
        }

        public void setTipoCurso(String tipoCurso)
        {
            this.tipoCurso = tipoCurso;
        }

        public List<DateTime> getHorarios()
        {
            return horarios;
        }

        public void setHorarios(List<DateTime> horarios)
        {
            this.horarios = horarios;
        }

        public double getPrecio()
        {
            return precio;
        }

        public void setPrecio(double precio)
        {
            this.precio = precio;
        }

        public List<Alumno> getAlumnos()
        {
            return alumnos;
        }

        public void setAlumnos(List<Alumno> alumnos)
        {
            this.alumnos = alumnos;
        }
    }
}
