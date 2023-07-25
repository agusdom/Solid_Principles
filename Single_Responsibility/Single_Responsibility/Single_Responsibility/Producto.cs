using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Producto
    {
        public Producto(String nombre,double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public String Nombre { get; set;}
        public double Precio{ get; set; }
    }
}
