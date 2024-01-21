using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.ConcreteClasses
{
    public class StripeGateway : IPaymentGateway
    {
        public bool ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando el pagamiento con de:{monto} con Stripe");
            return true;
        }
    }
}
