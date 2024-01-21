using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1.Fabricas
{
    // ESta clase es Abstracta
    public abstract class FabricaVehiculo
    {
        // Tiene un método Abstracto con el cual se crean los vehículos
        // acá se obtiene la instancia del vehículo concretp
        public abstract IVehiculo CrearVehiculo();

        // Método que se usa para "Usar" el vehículo
        // Ejemplo: "... de ordenar una pizza" que la treaigan a la mesa
        public IVehiculo OrdenarVehiculo() 
        {
            // creamos el Objeto invocando al método : public abstract IVehiculo CrearVehiculo();
            IVehiculo vehiculo = CrearVehiculo();
            vehiculo.Partida();
            vehiculo.Conducir();
            vehiculo.Parada();

            return vehiculo;
        }
    }
}
