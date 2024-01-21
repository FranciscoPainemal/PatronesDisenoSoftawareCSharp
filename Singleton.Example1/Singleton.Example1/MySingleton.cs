using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{

    /// <summary>
    /// UNa clase cuyo constructor es privado y que contiene una referencia a la única instancia (_instance)
    /// con una lógica para conyrolar sea una sola 
    /// </summary>
    internal class MySingleton
    {
        private static MySingleton _instance;// campo variable global "_nobrevariable" estatico de la calse mysingleton , esto es la instancia de MyuSingleton

        // constructor privado, al hacerlo privado nos aseguramos de que nadie pueda crear instancia de myssngleton directamente, solo desde su prpopia clasae
        private MySingleton() 
        { 
        
        }//

        public static MySingleton GetInstance() 
        {
            //m si no esxite la instancia de esta clse, se creas
            if (_instance == null)
            {
                _instance = new MySingleton();
            }

            return _instance;
        }//

    }//
}
