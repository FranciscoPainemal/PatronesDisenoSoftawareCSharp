using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    // Builder
    public interface IRobotBuilder
    {
        // acá pondremos una serie de métodos que nos va a representar
        // la manera que vamos a construir los distintos elementos del robot
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);
        

        // metodo devuelve el robot
        Robot GetRobot();
    }
}
