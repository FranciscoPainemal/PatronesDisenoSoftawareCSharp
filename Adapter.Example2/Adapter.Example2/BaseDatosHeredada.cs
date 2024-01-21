using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example2
{
    public class BaseDatosHeredada
    {
        public void InsertarDatos(string datos)
        { 
            Console.WriteLine($"Insertado los datos en la BBDD heredada: " + datos);
        }

        public string ObtenerDatos() 
        {
            return "Datos de BBDD heredada";
        }
    }
}
