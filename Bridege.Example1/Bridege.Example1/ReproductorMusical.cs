using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege.Example1
{
    public abstract class ReproductorMusical
    {
        // inyectamos de Iformato en este campo "formato"
        protected IFormato _formato;

        // constructor recibe por parametros el formato que queremos que 
        // el reproductor reproduzcaS
        public ReproductorMusical(IFormato formato)
        {
            this._formato = formato;
        }

        // Nuestra clase "ReproductorMusical" obliga a cualquier clase que implemente o herede de ReproductorMusical
        //  a que de un implementación de este Método "Reproducir" sin cuerpo a ser implementado por los hijos
        // que significa qué, a cada hijo va atener que ser capaz de dar su implementación propia
        public abstract void ReproducirArchivo(string ruta_del_archivo);
    }
}
