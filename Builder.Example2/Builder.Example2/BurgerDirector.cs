using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    // Director de orquesta del armado de la hamburguesa
    public class BurgerDirector
    {
        // aquí se define la interfaz que tiene que respetar el builder concreto
        //private IBurgerBuilder _burgerBuilder;

        //public BurgerDirector(IBurgerBuilder burgerBuilder) 
        //{ 
        //    // esta burger debe ser igual a la que recibe por el constructor
        //    _burgerBuilder = burgerBuilder;
        //}

        //public void ConstructBurger() 
        //{
        //    // acá ocupamos los métodos del _burgerBuilder
        //    _burgerBuilder.AddCarne();
        //    _burgerBuilder.AddPan();
        //    _burgerBuilder.AddQueso();
        //    _burgerBuilder.AddLechuga();
        //    _burgerBuilder.AddSalsa();
        //    _burgerBuilder.AddTomate();
        //}

        public void MakeBurger(IBurgerBuilder burgerBuilder2) 
        {
            // acá ocupamos los métodos del _burgerBuilder
            burgerBuilder2.AddCarne();
            burgerBuilder2.AddPan();
            burgerBuilder2.AddQueso();
            burgerBuilder2.AddLechuga();
            burgerBuilder2.AddSalsa();
            burgerBuilder2.AddTomate();
        }
    }
}
