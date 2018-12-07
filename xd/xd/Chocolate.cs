using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    class Chocolate : Alimento
    {
        
       public Chocolate()
        {
            bono = 25;
            nombre = "chocolate";
        }

        public Chocolate(int bono, string nombre)
        {
            Bono = bono;
            Nombre = nombre;
        }
            
    }
}
