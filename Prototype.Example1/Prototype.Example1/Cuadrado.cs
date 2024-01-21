using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public class Cuadrado : Forma
    {
        public Cuadrado()
        {
            Nombre = "Cuadrado";
        }
        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando una CUadrado con Id: {Id}.");
        }
    }
}
