using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class SistemaDeComunicacion
    {
        public void ComenzarConversacion(IComunicacion comunicacion, string pregunta, string respuesta) 
        {
            Console.WriteLine(comunicacion.Preguntar(pregunta));
            Console.WriteLine(comunicacion.Responder(respuesta));
        }
    }
}
