using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public class Rectangulo : Forma
    {
        public Rectangulo()
        {
            Nombre = "Tectángulo";
        }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando  un Rectángulo con Id: {Id}.");
        }
    }
}
