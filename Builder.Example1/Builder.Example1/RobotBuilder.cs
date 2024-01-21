using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    // Concretor del builder, esta clase implementa la interfaz IRobotBuilder
    public class RobotBuilder : IRobotBuilder
    {
        // campo o propiedad del tipo robot que será la instancia dl robot
        // esta instancia del robot del tipo privada
        private Robot _robot = new Robot();

        public void BuildArms(string arms)
        {
            // esta instancia robot, que es privada al builder
            // va a ser un Set de su propiedad "Arms"  con lo que sea que reciba por parametros de la variable "arms"
            _robot.Arms = arms;
        }

        public void BuildBody(string body)
        {
            // va a ser un Set de su propiedad "Body" con lo que sea que reciba por parametros de la variable "body"
            _robot.Body = body;
        }

        public void BuildHead(string head)
        {
            // va a ser un Set de su propiedad "Head" con lo que sea que reciba por parametros de la variable "head"
            _robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            // va a ser un Set de su propiedad "Legs" con lo que sea que reciba por parametros de la variable "legs"
            _robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            // acá  devolvemos el robot armado
            return _robot;  
        }
    }
}
