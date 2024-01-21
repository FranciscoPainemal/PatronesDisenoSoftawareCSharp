using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public class Triangulo : Forma
    {
        public Triangulo()
        {
            Nombre = "Triángulo";
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un Triángulo cno Id: {Id}.");
        }
    }
}
