using FactoryMethod.Example2.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Fabricas
{
    public class FabricaNotificacionCorreo : FabricaNotificacion
    {
        public override INotificacion CrearNotificacion()
        {
            return new Correo();
        }
    }
}
