using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_S
{
    public class Beer
    {
        public String Name {get; set;}
        public String Brand {get; set;}
        public int Alcohol { get; set;}
        public Beer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }
    }
}
