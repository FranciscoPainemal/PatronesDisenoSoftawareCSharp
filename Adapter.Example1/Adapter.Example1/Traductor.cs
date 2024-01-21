using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class Traductor : IComunicacion
    {
        private readonly HablanteEspanol _hablanteEspañol;

        //constructor con inyección de dependencias
        public Traductor(HablanteEspanol hablanteEspanol)
        {
            _hablanteEspañol = hablanteEspanol;
        }

        public string Preguntar(string pregunta)
        {
            return _hablanteEspañol.Consultar(pregunta);
        }

        public string Responder(string respusta)
        {
            return _hablanteEspañol.Contestar(respusta);
        }
    }
}
