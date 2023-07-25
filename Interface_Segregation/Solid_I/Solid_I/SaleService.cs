using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_I
{
    public class SaleService : IBasicActions<Sale>
    {
        public void Add(Sale entity)
        {
            Console.WriteLine("Creamos la venta");
        }

        public Sale Get(int id) => new Sale();

        public List<Sale> GetList() => new List<Sale>();
    }
}
