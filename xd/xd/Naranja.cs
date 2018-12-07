using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    class Naranja : Alimento
    {

        public Naranja()
        {
            bono = 30;
            nombre = "naranja";

        }

        public Naranja(int bono, string nombre)
        {
            Bono = bono;
            Nombre = nombre;
        }
    }
}
