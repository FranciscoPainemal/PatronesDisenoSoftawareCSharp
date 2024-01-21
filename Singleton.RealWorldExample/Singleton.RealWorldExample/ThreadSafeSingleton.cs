using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.RealWorldExample
{
    internal class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _lock = new object();

        // constructor
        private ThreadSafeSingleton() 
        { 
        
        }//

        public static ThreadSafeSingleton GetInstance()
        {
            if (_instance == null)
            {
                // con "lock "nos aseguramos, esto permite que solo un "hilo" enrte a la vez a crear la instancia
                lock (_lock)
                {
                    // con esto se hace una doble verificación de la instancia
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }//
            return _instance;
        }//

    }
}
