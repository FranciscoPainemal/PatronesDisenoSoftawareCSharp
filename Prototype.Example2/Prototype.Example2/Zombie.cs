using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public class Zombie : Monstruo
    {
        public int Salud {  get; set; }

        public Zombie()
        {
            Nombramiento = "Zombienwn";
        }

        public override void Atacar()
        {
            Console.WriteLine($"Atacando con un: {Nombramiento} con ID: {Identificador}. .  y nivel de SAlud: {Salud}");
        }
    }
}
