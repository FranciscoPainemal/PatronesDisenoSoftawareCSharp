using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public class Circulo : Forma
    {
        public Circulo()
        {
            Nombre = "Circulo";
        }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un circulo con ID: {Id}. ");
        }
    }
}
