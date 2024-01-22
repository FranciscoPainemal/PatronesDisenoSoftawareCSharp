using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridege.Example1
{
    // las interfaces definene los contratos que las clases estarán implementando
    public interface IFormato
    {
        //  Método 
        public void Reproducir(string ruta_del_archivo);
    }
}
