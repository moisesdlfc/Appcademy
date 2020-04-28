using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    public class Aula
    {
        // Atributos
        private int ID;
        string nombre;

        // Constructor vacio
        public Aula()
        {

        }

        // Constructor
        public Aula(int ID, string nombre)
        {
            this.ID = ID;
            this.nombre = nombre;
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

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
