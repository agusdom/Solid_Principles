using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero,DateTime fecha) : base(numero,fecha)
        {
            _sigla = "FC";
        }
    }
}
