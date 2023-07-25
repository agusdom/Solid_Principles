using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable unaFactura = new Factura(14312);
            Console.WriteLine(unaFactura.Descripcion());

            DocumentoContable unaNotaCredito = new NotaCredito(14312);
            Console.WriteLine(unaNotaCredito.Descripcion());

            DocumentoContable unaNotaDebito = new NotaDebito(14312);
            Console.WriteLine(unaNotaDebito.Descripcion());
            Console.ReadKey();
        }
    }
}
