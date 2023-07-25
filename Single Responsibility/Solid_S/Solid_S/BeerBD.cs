using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Solid_S
{
    public class BeerBD
    {
        private Beer _beer;
        public BeerBD(Beer beer)
        {
            _beer = beer;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos {_beer.Name} y {_beer.Brand}");
        }

    }
}
