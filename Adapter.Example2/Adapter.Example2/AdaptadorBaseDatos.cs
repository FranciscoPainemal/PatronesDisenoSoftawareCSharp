using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example2
{
    public class AdaptadorBaseDatos : IDatabase
    {
        //MAntiene una instancia de BaseDatosHeredada
        private readonly BaseDatosHeredada _baseDatosHeredada;

        // esta instancia "baseDatosHeredada" será cargada en el constructor
        public AdaptadorBaseDatos(BaseDatosHeredada baseDatosHeredada)
        {
            _baseDatosHeredada = baseDatosHeredada;
        }

        public void Agregar(string datos)
        {
            _baseDatosHeredada.InsertarDatos(datos);
        }

        public string Recuperar()
        {
            return _baseDatosHeredada.ObtenerDatos();
        }
    }
}
