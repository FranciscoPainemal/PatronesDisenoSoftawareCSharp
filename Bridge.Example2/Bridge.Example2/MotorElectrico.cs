using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Example2
{
    public class MotorElectrico : IMotor
    {
        public void Arrancar()
        {
            Console.WriteLine($"Arrancando con el motor Eléctrico ");
        }

        public void Detener()
        {
            Console.WriteLine($"Arrancando con el motor Eléctrico ");
        }
    }
}
