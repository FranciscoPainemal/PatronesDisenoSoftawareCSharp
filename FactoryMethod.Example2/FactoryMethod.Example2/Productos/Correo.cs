using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example2.Productos
{
    public class Correo : INotificacion
    {
        public void Enviar(string mensaje)
        {
            Console.WriteLine($"Enviando notificación por: {mensaje}...");
        }
    }
}
