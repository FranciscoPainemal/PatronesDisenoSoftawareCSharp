using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public class Vampiro : Monstruo
    {
        public int SedDeSangre {  get; set; }

        public Vampiro()
        {
            Nombramiento = "Vampirulo";
        }

        public override void Atacar()
        {
            Console.WriteLine($"Atacando con un: {Nombramiento} con ID: {Identificador}.  y nivel de sed de sangre: {SedDeSangre}");
        }
    }
}
