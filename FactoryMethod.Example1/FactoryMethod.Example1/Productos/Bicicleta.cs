using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Productos
{
    // Implementacipon de la interfza IVehiculo con sus métodos
    public class Bicicleta : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine($"Conducir la cleta");
        }

        public void Parada()
        {
            Console.WriteLine($"Detener la cleta");
        }

        public void Partida()
        {
            Console.WriteLine($"Partir en la cleta");
        }
    }
}
