using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.RealWorldExample
{
    public class EventLogger
    {
        // campo privado que va acontener la instancia de eventlogger en todo momento
        private static EventLogger _instance;

        // lista de cadena de texto que contendrá los logs
        private List<string> _eventLogs;

        // constructor privado
        private EventLogger()
        {
            // cda vez que se cree una instancia de eventlogger se va a crear en la lista
            // inicalizamos eventLogs
            _eventLogs = new List<string>();
        }//

        // método que comprueba si la instancia es nula y la crea ,
        // si vuelven a llamar al metodo devolvera la misma instancia
        public static EventLogger GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }

            return _instance;
        }//

        // método para logear un evento, cargar un log
        public void LogEvent(string eventMessage) 
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            _eventLogs.Add($"{timestamp} ; {eventMessage}");

        }//

        // método para mostrar los log en pantalla (consola)
        public void DisplayLogs() 
        { 
            foreach (string log in _eventLogs) 
            { 
                Console.WriteLine(log);
            }
        }//
    }
}
