using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();

            //perro
            Perro perro = new Perro();
            Chocolate chocolate = new Chocolate();
            Naranja naranja = new Naranja();

            perro.Nombre = "chilaquil";
            perro.Tiporaza = "chibaba";
            //chocolate.Nombre = "Chocolate";
            perro.Edad = 10;
            Console.WriteLine("Nombre: " +perro.Nombre.ToString());
            Console.WriteLine("Raza: "+perro.Tiporaza.ToString());
            Console.WriteLine("Edad: " +perro.Edad.ToString());
            perro.Comer(chocolate);
            perro.Comer(naranja);   
        }
    }
}
