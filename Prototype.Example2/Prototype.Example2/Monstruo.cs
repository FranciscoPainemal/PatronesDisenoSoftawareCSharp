using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public abstract class Monstruo : IClonable
    {
        public int Identificador { get; set; }
        public string Nombramiento { get; set; }

        public abstract void Atacar();

        public object Clonar()
        {
            return this.MemberwiseClone();
        }
    }
}
