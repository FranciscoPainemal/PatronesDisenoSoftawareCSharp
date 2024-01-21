using FactoryMethod.Example1.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Fabricas
{
    // heredamos o implementamos de FabricaVehiculo
    // y debemos de implementar el método CrearVehiculo() en la clase FabricaMotocicleta
    public class FabricaMotocicleta : FabricaVehiculo
    {
        // acá es el único lugar donde sabemos que debemos devolver la Motocicleta por que estamos en su fabrica
        public override IVehiculo CrearVehiculo()
        {
            return new Motocicleta();
        }
    }
}
