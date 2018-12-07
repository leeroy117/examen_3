using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xd
{
    class Animales : IAnimales
    {
       protected string nombre ="", tiporaza = "";
       protected int edad = 0, salud=0;


        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Tiporaza
        {
            get { return this.tiporaza; }
            set { this.tiporaza = value; }
        }

        public  int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public int Salud
        {
            get { return this.salud; }
            set { this.salud = value; }
        }

        public Animales()
        {

        }

        public Animales(string nombre, string tiporaza, int edad,int salud )
        {
            this.nombre = nombre;
            this.tiporaza = tiporaza;
            this.edad = edad;
            this.salud = salud;
        }

        public void Comer()
        {
            //string texto;
            //texto = "el " + this.Nombre + " esta comiendo ";
        }

        public virtual void Comer(Alimento alimento)
        {
            //this.Comer(alimento);
            Console.WriteLine("El " + this.Nombre + " esta comiendo " + alimento.Nombre);
        }

    }
}
