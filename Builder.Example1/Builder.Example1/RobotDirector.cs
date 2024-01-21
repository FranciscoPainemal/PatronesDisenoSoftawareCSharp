using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    // Director de orquesta del armado del robot
    public class RobotDirector
    {
        // propiedad privada _robotBuilder
        // aquí se define la interfaz que tiene que respetar el builder concreto
        private IRobotBuilder _robotBuilder;

        // constructor con inyección de dependencia IRobotBuilder
        public RobotDirector(IRobotBuilder robotBuilder)
        {
            // este robot debe ser igual al que recibe
            // por el constructor
            _robotBuilder = robotBuilder;
        }

        // método publico que basicamente va a construir el robot
        public void ConstructRobot() 
        {
            // acá ocupamos los métodos del _robotBuilder
            _robotBuilder.BuildHead("De TV");
            _robotBuilder.BuildBody("Carbono");
            _robotBuilder.BuildArms("Largos de tercipelo");
            _robotBuilder.BuildLegs("Ruedas");
        }//
    }
}
