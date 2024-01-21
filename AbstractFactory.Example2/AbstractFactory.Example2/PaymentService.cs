using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    public class PaymentService
    {
        private readonly IPaymentGateway _paymentGateway;
        private readonly ITransactionLogger _transactionLogger;

        // constructor que le inyectamos una dependencia IPaymentGatewayFactory
        public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
        {
            _paymentGateway    = paymentGatewayFactory.CreatePaymentGateway();
            _transactionLogger = paymentGatewayFactory.CreateTransactionLogger();
        }

        public void ProcesoDePago(decimal montos)
        {
            if (_paymentGateway.ProcesarPago(montos))
            {
                _transactionLogger.LogTransaccion($"Pagandose de :{montos}, fue exitoso");
            }
            else 
            {
                _transactionLogger.LogTransaccion($"Pagandose de :{montos} Fallido");
            }

        }
    }
}
