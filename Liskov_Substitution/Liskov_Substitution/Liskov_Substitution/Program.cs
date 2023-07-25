using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Remito rto = new Remito(3331,DateTime.Now,10);
            DocumentoContable fc = new Factura(66423, DateTime.Now);
            DocumentoContable nc = new NotaCredito(441, DateTime.Now);
            DocumentoContable nd = new NotaDebito(866, DateTime.Now);

            impresora.ImprimirRemito(rto);
            impresora.Imprimir(fc);
            impresora.Imprimir(nc);
            impresora.Imprimir(nd);

            Console.ReadKey();
        }
    }
}
