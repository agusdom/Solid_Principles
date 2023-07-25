using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(12344,DateTime.Now);
            factura.CAI = "234324324";

            FacturaElectronica facturaElectronica = new FacturaElectronica(12344, DateTime.Now);
            facturaElectronica.CAE = "666345444";

            facturaElectronica.Imprimir();
            facturaElectronica.EnviarPorEmail();
            factura.Imprimir();


            Console.ReadKey();
        }
    }
}
