using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public class ForeingSale : AbstractSale
    {
        public ForeingSale(decimal amount, String customer)
        {
            this.amount = amount;
            this.customer = customer;
        }


        public override void Generate()
        {
            Console.WriteLine("Se genera la venta");
        }
    }
}
