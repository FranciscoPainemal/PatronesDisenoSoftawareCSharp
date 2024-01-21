using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class HablanteIngles : IComunicacion
    {
        public string Preguntar(string pregunta)
        {
            return "Esta es una pregunta en Inglés: " + pregunta;
        }

        public string Responder(string respusta)
        {
            return "Esta es una respuesta en Inglés: " + respusta;
        }
    }
}
