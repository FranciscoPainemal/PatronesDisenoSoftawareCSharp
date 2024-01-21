using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.ConcreteClasses
{
    public class PayPalGateway : IPaymentGateway
    {
        public bool ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando el pago de {monto} con PayPal");
            return true;
        }
    }
}
