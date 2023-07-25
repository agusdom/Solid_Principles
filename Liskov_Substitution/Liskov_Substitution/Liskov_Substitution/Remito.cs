using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Remito
    {
        public Remito(int numero, DateTime fecha, int bultos)
        {
            CantBultos = bultos;
            Numero = numero;
            Fecha = fecha;
        }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantBultos { get; set; }

        public string Descripcion()
        {
            return $"Rto nro°{Numero} de la fecha {Fecha.ToShortDateString()} con {CantBultos} bultos";
        }

        public String Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

    }
}
