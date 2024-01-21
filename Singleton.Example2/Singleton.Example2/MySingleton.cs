using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example2
{
    public class MySingleton
    {
        // agregamos un campo "_instrance" que contiene la instancia
        private static MySingleton _instance;
        
        // Agragamos una propiedad
        public Guid Id { get; private set; }

        // se crea constructor
        private MySingleton() 
        {
            // dentor de este constructor se la da un valor a la propiedad Id
            Id = Guid.NewGuid();
        }//


        // método para obtner la instancia
        public static MySingleton GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }

            return _instance;
        }
    }
}
