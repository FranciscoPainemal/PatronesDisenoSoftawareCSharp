using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example2
{
    public interface IPaymentGateway
    {
        bool ProcesarPago(decimal monto);        
    }
}
