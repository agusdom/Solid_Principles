using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public class LocalSale : SaleWithTaxes
    {
        public LocalSale(decimal amount, String customer, decimal taxes)
        {
            this.amount = amount;
            this.customer = customer;
            this.taxes = taxes;
        }
        public override void Generate()
        {
            Console.WriteLine("Se genera la venta");
        }

        public override void CalculateTaxes()
        {
            Console.WriteLine("Se calculan los impuestos");
        }

        
    }
}
