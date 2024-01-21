using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Fabricas
{
    public abstract class FabricaNotificacion
    {
        public abstract INotificacion CrearNotificacion();

        //public INotificacion ordenarNotificacion()
        //{
        //    INotificacion notificacion = CrearNotificacion();
        //    notificacion.Enviar(null);

        //    return notificacion;
        //}
    }
}
