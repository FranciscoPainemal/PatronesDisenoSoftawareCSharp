using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege.Example1
{
    public class MP3 : IFormato
    {
        public void Reproducir(string ruta_del_archivo)
        {
            Console.WriteLine($"Reproduciendo archivo MP3 {ruta_del_archivo}");
        }
    }
}
