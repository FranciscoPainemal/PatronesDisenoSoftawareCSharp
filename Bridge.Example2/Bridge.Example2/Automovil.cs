using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class Automovil : Vehiculo
    {
        //  constructor
        public Automovil(IMotor motor) : base(motor)
        {
            
        }

        public override void Conducir()
        {
            Console.WriteLine($"Conduciendo el auto");
            _motor.Arrancar();
        }
    }
}
