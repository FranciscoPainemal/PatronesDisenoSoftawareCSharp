using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class Bus : Vehiculo
    {
        public Bus(IMotor motor) : base(motor)
        {
            
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo el Bus");
            _motor.Arrancar();
        }
    }
}
