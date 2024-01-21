using FactoryMethod.Example1.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Fabricas
{
    // Heredamos o implementamos de FabricaVehhiculo donde debemos de implementar el método CRaerVehiculo() en la clase FabricaBicicleta
    public class FabricaBicicleta : FabricaVehiculo
    {
        // Acá es donde devolvemos la bicicleta, ya que no puede ser otrro vehículo estando en su propia fabrica
        public override IVehiculo CrearVehiculo()
        {
            return new Bicicleta();
        }
    }
}