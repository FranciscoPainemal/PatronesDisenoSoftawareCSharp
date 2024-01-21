using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    public interface IBurgerBuilder
    {
        // acá pondremos una serie de métodos que nos va a representar
        // la manera que vamos a construir los distintos elementos de la hamburguesa
        void AddPan();
        void AddCarne();
        void AddQueso();
        void AddSalsa();
        void AddLechuga();
        void AddTomate();

        // método que devulve la hamburguesa
        Burger GetBurger();
    }
}
