using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Example2
{
    public class Momia : Monstruo
    {
        public int Vendaje { get; set; }

        public Momia()
        {
            Nombramiento = "Momia";
        }

        public override void Atacar()
        {
            Console.WriteLine($"Atacando con una : {Nombramiento} con ID: {Identificador}.. .  y nivel de Venadje: {Vendaje} ");
        }
    }
}
