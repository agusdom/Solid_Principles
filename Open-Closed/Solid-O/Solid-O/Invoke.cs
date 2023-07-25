using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O
{
    public class Invoke
    {
        public decimal GetTotal(IEnumerable<IDrink> lstDrink)
        {
            decimal total = 0;
            foreach (var drink in lstDrink)
            {
                total += drink.GetPrice();
            }
            return total;
        }
    }
}
