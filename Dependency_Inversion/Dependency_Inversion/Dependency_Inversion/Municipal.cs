using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe,String partida) : base(importe)
        {
            Partida = partida;
        }

        public String Partida { get; set; }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo impuesto municipal de partida N°{Partida} por un importe de ${Importe}");
        }
    }
}
