using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
   public class Alimento : IAlimento
    {
        protected string nombre = "";
        protected int bono = 0;

        public int Bono
        {
            get { return this.bono; }
            set { this.bono = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Alimento()
        {
                
        }

        public Alimento(int bono, string nombre)
        {
            this.bono = Bono;
            this.nombre = Nombre;
        }
    }
}
