using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class MotorCombustion : IMotor
    {
        public void Arrancar()
        {
            Console.WriteLine($"Arrancando con el motor a Combustión ");
        }

        public void Detener()
        {
            Console.WriteLine($"Deteniendo con el motor a Combustión ");
        }
    }
}
