using FactoryMethod.Example1.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Fabricas
{
    // Heredamos o implementamos de FabricaVehiculo
    // y debemos implementar el método CrearVehiculo() en la clase FabricaAutomovil
    public class FabricaAutomovil : FabricaVehiculo
    {
        // acá es el punico lugar donde sabemos que debemos devolver el Automovil ya que estamos en su fabrica
        public override IVehiculo CrearVehiculo()
        {
            return new Automovil();
        }
    }
}
