using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public interface IMotor
    {
        // dos métodos
        public void Arrancar();

        public void Detener();
    }
}
