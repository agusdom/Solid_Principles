using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid_S
{
    public class BeerRequest
    {
        private Beer _beer;
        public BeerRequest(Beer beer)
        {
            _beer = beer;
        }
        public void Send()
        {
            Console.WriteLine($"Enviamos a ese otro lugar {_beer.Name} y {_beer.Brand}");
        }
    }
}
