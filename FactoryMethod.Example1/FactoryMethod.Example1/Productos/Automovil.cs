using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Productos
{
    // Implementación de la interfaz IVehiculo con sus métodos
    public class Automovil : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine($"Conducir el auto");
        }

        public void Parada()
        {
            Console.WriteLine($"Detener el auto");
        }

        public void Partida()
        {
            Console.WriteLine($"Salir en el auto");
        }
    }
}
