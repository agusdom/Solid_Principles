using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Apellido = "Lopez";
            cliente.Nombre = "Diego";
            Factura factura = new Factura(21332,cliente);

            Item item1 = new Item(new Producto("Arroz", 10),5);
            Item item2 = new Item(new Producto("Queso", 90), 1);
            Item item3 = new Item(new Producto("Gaseosa", 70), 2);

            factura.Items.Add(item1);
            factura.Items.Add(item2);
            factura.Items.Add(item3);

            Console.WriteLine($"El total de la factura es ${factura.Total()}");

            Console.ReadKey();
        }
    }
}
