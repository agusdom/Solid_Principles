using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Impresora
    {
        public void ImprimirRemito(Remito unRemito)
        {
            Console.WriteLine(unRemito.Imprimir());
        }

        public void Imprimir(DocumentoContable UnDocumento)
        {
            Console.WriteLine(UnDocumento.Imprimir());
        }
    }
}
