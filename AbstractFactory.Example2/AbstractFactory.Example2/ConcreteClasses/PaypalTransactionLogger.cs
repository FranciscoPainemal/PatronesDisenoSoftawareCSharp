using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2.ConcreteClasses
{
    public class PaypalTransactionLogger : ITransactionLogger
    {
        public void LogTransaccion(string mensaje)
        {
            Console.WriteLine($"Registrando la transacción en Paypal: {mensaje}");
        }
    }
}
