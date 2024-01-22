using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public abstract class Vehiculo
    {
        protected IMotor _motor;

        public Vehiculo(IMotor motor)
        {
            _motor = motor;
        }

        public abstract void Conducir();
    }
}
