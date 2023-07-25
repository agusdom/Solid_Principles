using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class Cobranza : IImprimible
    {
        public double Importe { get; set; }
        public int Numero { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo cobranza N°{Numero} con un importe de ${Importe}");
        }
    }
}
