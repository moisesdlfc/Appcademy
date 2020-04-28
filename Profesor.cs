using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    class Profesor
    {
        // Atributos
        private int ID;
        private String nombre;
        private String apellidos;
        private String asignaturas;
        private double pagos;
        private bool baja;
        private DateTime fechaAlta;
        private DateTime fechaBaja;

        // Constructor vacio
        public Profesor()
        {

        }

        // Constructor
        public Profesor(int ID, String nombre, String apellidos, String asignaturas, double pagos, bool baja, DateTime fechaAlta, DateTime fechaBaja)
        {
            this.ID = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.asignaturas = asignaturas;
            this.pagos = pagos;
            this.baja = baja;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
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

        public String getAsignaturas()
        {
            return asignaturas;
        }

        public void setAsignaturas(String asignaturas)
        {
            this.asignaturas = asignaturas;
        }

        public double getPagos()
        {
            return pagos;
        }

        public void setPagos(double pagos)
        {
            this.pagos = pagos;
        }

        public bool getBaja()
        {
            return baja;
        }

        public void setBaja(bool baja)
        {
            this.baja = baja;
        }

        public DateTime getFechaAlta()
        {
            return fechaAlta;
        }

        public void setFechaAlta(DateTime fechaAlta)
        {
            this.fechaAlta = fechaAlta;
        }

        public DateTime getFechaBaja()
        {
            return fechaBaja;
        }

        public void setFechaBaja(DateTime fechaBaja)
        {
            this.fechaBaja = fechaBaja;
        }
    }
}
