using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Producto
    {
        public Producto(String descripcion,double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }

        public String Descripcion { get; set; }
        public double Precio { get; set;}
    }
}
