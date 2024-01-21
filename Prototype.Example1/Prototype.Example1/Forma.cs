using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example1
{
    public abstract class Forma : IClonable
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public abstract void Dibujar();

        public object Clonar()
        {
            // retorna una copia del objeto en el cual estoy "parado"
            // va tenr los mismos campos, valores del objeto
            return this.MemberwiseClone();
        }
    }
}
