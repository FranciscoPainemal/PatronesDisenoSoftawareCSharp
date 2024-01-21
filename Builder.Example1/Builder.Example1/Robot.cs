using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example1
{
    // vendría siendo nuestro producto de la clase Builder

    // producto
    public class Robot
    {
        // propiedades  de la clase ... capos
        public string Head { get; set; }
        public string Body { get; set; }
        public string Arms { get; set; }
        public string Legs { get; set; }


        // este método nos permite ver la instancia de nuestros robot, o sea, el robot con parametros dados(campos)
        public void DisplayRobotInfo() 
        {
            Console.WriteLine("Robot Info:");
            Console.WriteLine($"Cabeza: {Head}");
            Console.WriteLine($"Cuerpo: {Body}");
            Console.WriteLine($"Brazos: {Arms}");
            Console.WriteLine($"Piernas: {Legs}");
        }//
    }
}
