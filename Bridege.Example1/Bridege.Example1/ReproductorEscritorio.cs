using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege.Example1
{
    public class ReproductorEscritorio : ReproductorMusical
    {
        // constructor capaz de reproducir y/o recibir un formato
        // tiene un formato pasandolo a la clase Base "base(formato)"
        public ReproductorEscritorio(IFormato formato) : base(formato) 
        {
            
        }

        // tiene un mplementación propia
        public override void ReproducirArchivo(string ruta_del_archivo)
        {
            Console.WriteLine($"Usando el reproductor de escritorio...");

            // se le indica que formato tiene que saber reproducir
            _formato.Reproducir(ruta_del_archivo);
        }
    }
}
