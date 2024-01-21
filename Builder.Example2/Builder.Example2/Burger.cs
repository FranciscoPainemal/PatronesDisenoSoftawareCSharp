using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    // producto
    public class Burger
    {
        // propiedades de la hamburguesa
        public string Pan {  get; set; }
        public string Carne { get; set; }
        public string Queso { get; set; }
        public string Salsa { get; set; }
        public bool Lechuga { get; set; }
        public bool Tomate { get; set; }

        // método para mostrar la hamburguesa
        public void DisplayBurgerInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Pan {Pan}");
            Console.WriteLine($"Carne {Carne}");
            Console.WriteLine($"Queso {Queso}");
            Console.WriteLine($"Salsa {Salsa}");
            Console.WriteLine($"Lechuga {Lechuga}");
            Console.WriteLine($"Tomate {Tomate}");
        }
    }
}
