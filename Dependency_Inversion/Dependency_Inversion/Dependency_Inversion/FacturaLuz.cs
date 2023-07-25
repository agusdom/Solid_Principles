using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe,String codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public String CodigoPago { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con codigo de pago N°{CodigoPago} por un importe de ${Importe}");
        }
    }
}
