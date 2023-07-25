using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora impresora = new Impresora();

            Factura factura = new Factura(1234,DateTime.Now,303);
            NotaCredito notaCredito = new NotaCredito(344, DateTime.Now, 400);
            Remito remito = new Remito(5551, DateTime.Now, 5);
            FacturaLuz facturaLuz = new FacturaLuz(441,"444545");
            Municipal municipal = new Municipal(1221, "55555662");
            Cobranza cobranza = new Cobranza()
            {
                Numero = 44441,
                Importe = 1343
            };

            List<IImprimible> imprimibles = new List<IImprimible>();
            imprimibles.Add(factura);
            imprimibles.Add(notaCredito);
            imprimibles.Add(remito);
            imprimibles.Add(facturaLuz);
            imprimibles.Add(municipal);
            imprimibles.Add(cobranza);

            foreach (var item in imprimibles)
            {
                item.Imprimir();
            }

            Console.ReadLine();
        }
    }
}
