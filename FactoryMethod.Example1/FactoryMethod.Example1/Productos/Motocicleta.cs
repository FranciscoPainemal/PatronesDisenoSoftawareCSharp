using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Productos
{

    // implemantamos la interfaz IVehiculo trayendo los métodos
    public class Motocicleta : IVehiculo
    {
        public void Conducir()
        {
            Console.WriteLine($"Conducir la moto");
        }

        public void Parada()
        {
            Console.WriteLine($"Chantar la moto");
        }

        public void Partida()
        {
            Console.WriteLine($"Salir en la moto");
        }
    }
}
