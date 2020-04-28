using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    class Alumno
    {
        // Atributos
        private int ID;
        private String nombre;
        private String apellidos;
        private String telefono;
        private bool matriculaPagada;
        private double pagosPendientes;
        private bool baja;
        private List<Curso> clases;

        // Constructor vacio
        public Alumno()
        {

        }

        // Constructor
        public Alumno(int ID, String nombre, String apellidos, String telefono, bool matriculaPagada, double pagosPendientes, bool baja, List<Curso> clases)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.matriculaPagada = matriculaPagada;
            this.pagosPendientes = pagosPendientes;
            this.baja = baja;
            this.clases = clases;
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

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getApellidos()
        {
            return apellidos;
        }

        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }

        public String getTelefono()
        {
            return telefono;
        }

        public void setTelefono(String telefono)
        {
            this.telefono = telefono;
        }

        public bool getMatriculaPagada()
        {
            return matriculaPagada;
        }

        public void setMatriculaPagada(bool matriculaPagada)
        {
            this.matriculaPagada = matriculaPagada;
        }

        public double getPagosPendientes()
        {
            return pagosPendientes;
        }

        public void setPagosPendientes(double pagosPendientes)
        {
            this.pagosPendientes = pagosPendientes;
        }

        public bool getBaja()
        {
            return baja;
        }

        public void setBaja(bool baja)
        {
            this.baja = baja;
        }

        public List<Curso> getClases()
        {
            return clases;
        }

        public void setClases(List<Curso> clases)
        {
            this.clases = clases;
        }
    }
}
