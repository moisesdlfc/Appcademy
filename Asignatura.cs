using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    class Asignatura
    {
        // Atributos
        private int ID;
        private String carrera;
        private String asignatura;
        //private String tipoCurso;
        private Profesor profesor;
        //private double precio;

        //  Constructor vacio
        public Asignatura()
        {

        }

        // Constructor
        public Asignatura(int ID, String carrera, String asignatura, Profesor profesor)
        {
            this.ID = ID;
            this.carrera = carrera;
            this.asignatura = asignatura;
            this.profesor = profesor;
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

        public String getCarrera()
        {
            return carrera;
        }

        public void setCarrera(String carrera)
        {
            this.carrera = carrera;
        }

        public String getAsignatura()
        {
            return asignatura;
        }

        public void setAsignatura(String asignatura)
        {
            this.asignatura = asignatura;
        }

        public Profesor getProfesor()
        {
            return profesor;
        }

        public void setProfesor(Profesor profesor)
        {
            this.profesor = profesor;
        }
    }
}
