using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege.Example1
{
    public class WAV : IFormato
    {
        public void Reproducir(string ruta_del_archivo)
        {
            Console.WriteLine($"Reproduciendo archivo WAM {ruta_del_archivo}");
        }
    }
}
