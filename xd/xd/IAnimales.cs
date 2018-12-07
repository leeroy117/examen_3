using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xd
{
    interface IAnimales
    {
         string Nombre { get; set; }

         string Tiporaza { get; set; }
        
         int Edad { get; set; }

         int Salud { get; set; }

         void Comer();


    }
}
