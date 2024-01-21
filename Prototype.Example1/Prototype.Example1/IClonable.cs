using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public interface IClonable
    {
        // método Clonar va devolver un objeto cualquiera
        //  devualve una copia de lo que sea
        object Clonar();
    }
}
