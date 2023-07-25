using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public class FacturaElectronica : Documento, IEmaileable
    {
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha) { }

        public String CAE { get; set; }

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por email la factura electronica {Numero} del dia {Fecha.ToShortDateString()} con CAE N°{CAE}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAE N°{CAE}");
        } 
    }
}
