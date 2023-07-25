using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_L
{
    public abstract class AbstractSale
    {
        protected decimal amount;
        protected String customer;

        public abstract void Generate();

    }
}
