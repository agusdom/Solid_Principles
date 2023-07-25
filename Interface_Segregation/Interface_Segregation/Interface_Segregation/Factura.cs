using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public class Factura : Documento
    {
        public Factura(int numero,DateTime fecha) : base(numero,fecha){ }

        public String CAI { get; set; }


        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAI N°{CAI}");
        }

    }
}
