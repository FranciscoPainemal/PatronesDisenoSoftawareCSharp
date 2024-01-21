using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public interface IClonable
    {
        // Método que devuelve un clon de cualquier cosas que le pasen
        object Clonar();
    }
}
