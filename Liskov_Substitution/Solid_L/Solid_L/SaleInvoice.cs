using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public class SaleInvoice : SaleWithTaxes
    {
        public SaleInvoice(decimal amount, String customer, decimal taxes)
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

        public void XML()
        {
            Console.WriteLine("Se genera el XML de la factura");
        }
    }
}
