using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Example2
{
    public class NuevoSistema
    {
        // Inyecta IDatabase así la clase no depende directamente de la Interfaz pero la usamos
        private readonly IDatabase _database;

        // constructor 
        // Aquí inyectamos IDatabase
        public NuevoSistema(IDatabase database)
        {
            _database = database;
        }

        // Método que se encarga de guardar los datos
        public void GuardarDatos(string datos)
        {
            _database.Agregar(datos);
            Console.WriteLine($"Los datos fueron guardados correctamente en el nuevo Sitema");
        }

        public void LeerDatos() 
        {
            string dato = _database.Recuperar();
            Console.WriteLine($"Leyendo datos del sistema " + dato);
        }
    }
}
