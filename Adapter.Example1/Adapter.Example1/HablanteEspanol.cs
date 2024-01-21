using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public class HablanteEspanol
    {
        public string Consultar(string pregunta)
        {
            return "Esta es una consulta en ESPAÑOL: " + pregunta;
        }

        public string Contestar(string respusta)
        {
            return "Esta es una contestación en ESPAÑOL: " + respusta;
        }
    }
}
