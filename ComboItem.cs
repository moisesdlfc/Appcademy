using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appcademy
{
    public class ComboItem : object
    {
        protected String name;
		protected int id;
        protected string dni;

        public ComboItem(String name, int id)
        {
            this.name = name;
			this.id = id;
        }

        public ComboItem(String name, string dni)
        {
            this.name = name;
            this.dni = dni;
        }

        public override string ToString()
        {
            return name;
        }

        public int GetId()
        {
            return id;
        }

        public string getDni()
        {
            return dni;
        }
    };
}
