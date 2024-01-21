using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Example2
{
    // Concretar del builder, esta clase implementa la interfaz IBugerBuilder
    public class ClassicBurgerBuilder: IBurgerBuilder
    {
        // campo o propiedad del tipoburger que sera la instancia de la burger
        //  esta instancia de la bruger del tipo privada
        private Burger _classicBurger = new Burger();

        public void AddCarne()
        {
            // hará un Set de su propiedad "Carne" con lo que sea que reciba  por parametros de la variable "carne"
            _classicBurger.Carne = "Carne vacuno";
        }

        public void AddLechuga()
        {
            // hará un Set de su propiedad "Lechuga con lo que sea que rciba por parametros de la variablew "lechuga"
            _classicBurger.Lechuga = true;
        }

        public void AddPan()
        {
            // hará un Set de su prpiedad "Pan" con lo que sea que reciba por parametros de la variable "pan"
            _classicBurger.Pan = "Tostado";
        }

        public void AddQueso()
        {
            // hará un Set de su propiedad "Queso" con lo que sea que reciba de la variable "queso"
            _classicBurger.Queso = "GAuda";
        }

        public void AddSalsa()
        {
            // hará un Set de su propiedad "Salsa" con lo que sea que reciba de la variable "salsa"
            _classicBurger.Salsa = "MAyonesa";
        }

        public void AddTomate()
        {
            // hará un Set de su propiedad "Tomate"  con lo que sea que reciba de la variable "tomate"
            _classicBurger.Tomate = true;
        }

        public Burger GetBurger()
        {
            return _classicBurger;
        }
    }
}
