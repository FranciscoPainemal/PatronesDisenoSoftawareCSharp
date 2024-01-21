using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example1
{
    public interface IComunicacion
    {
        string Preguntar(string pregunta);

        string Responder(string respusta);
    }
}
