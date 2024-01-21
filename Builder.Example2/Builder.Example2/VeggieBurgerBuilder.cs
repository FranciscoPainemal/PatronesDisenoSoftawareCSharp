using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    public class VeggieBurgerBuilder: IBurgerBuilder
    {
        private Burger _veggieBurger = new Burger();

        public void AddCarne()
        {
            // hará un Set de su propiedad "Carne" con lo que sea que reciba de la variable "carne"
            _veggieBurger.Carne = "pollo";
        }

        public void AddLechuga()
        {
            // har´+a un Set de su propiedad "Lechuga" con lo que sea que reciba de la variable "lechuga"
            _veggieBurger.Lechuga = false;
        }

        public void AddPan()
        {
            // hará un Set de su propiedad "Pan" con lo que sea que reciba de la variable "pan"
            _veggieBurger.Pan = "baguette";
        }

        public void AddQueso()
        {
            // hará un Set de su propiedad "Queso" con lo que sea que reciba de la variable "queso"
            _veggieBurger.Queso = "chanco";
        }

        public void AddSalsa()
        {
            // hará un Setde su propiedad "Salsa" con lo que sea que reciba de la variable "salsa"
            _veggieBurger.Salsa = "ketchup";
        }

        public void AddTomate()
        {
            // hará un Set de su propiedad "Tomate" con lo que sea que reciba de la variable "tomate"
            _veggieBurger.Tomate = false;
        }

        // método que devuelve la burger
        public Burger GetBurger()
        {
            return _veggieBurger;
        }
    }
}
