using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    class Program
    {
        static void Main(string[] args)
        {
            SaleWithTaxes sale = new LocalSale(100,"Hector",0.16m);
            sale.CalculateTaxes();
            sale.Generate();

            sale = new SaleInvoice(100, "Hector", 0.16m);
            sale.CalculateTaxes();
            sale.Generate();

            AbstractSale sale2 = new ForeingSale(200, "Pepe");
            sale2.Generate();
            Console.ReadKey();
        }
    }
}
