using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Example1
{
    public interface IVehiculo
    {
        // tiene 3 metodos
        public void Partida();

        public void Parada();

        public void Conducir();
    }
}
