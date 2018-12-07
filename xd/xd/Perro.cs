using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xd
{
    class Perro : Animales
    {

        public Perro()
        {
            salud = 50;
        }

        public Perro(string nombre, string tiporaza, int edad, int salud)
        {
            this.nombre = nombre;
            this.tiporaza = tiporaza;
            this.edad = edad;
            this.Salud = salud;
        }

        public override void Comer(Alimento alimento)
        {
            base.Comer(alimento);
            if (alimento.Nombre == "chocolate")
            {
                Salud = Salud - alimento.Bono;
                Console.WriteLine("Comio " + alimento.Nombre + " que baja " + alimento.Bono + " de vida .La vida del perro es de: " + Salud);
            }
            else 
            {
                Salud = Salud + alimento.Bono;
                Console.WriteLine("Comio " + alimento.Nombre + " que sube " + alimento.Bono + " de vida .La vida del perro es de: " + Salud);
            }
           
        }
    }
}
