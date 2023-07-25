using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public abstract class SaleWithTaxes : AbstractSale
    {
        protected decimal taxes;
        public abstract void CalculateTaxes();
    }
}
