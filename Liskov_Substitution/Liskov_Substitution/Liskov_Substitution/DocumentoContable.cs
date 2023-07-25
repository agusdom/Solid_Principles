using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public abstract class DocumentoContable
    {
        protected String _sigla;

        public DocumentoContable(int numero,DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }

        public int Numero { get; set;}
        public DateTime Fecha { get; set;}

        public String Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual String Descripcion()
        {
            return $"{_sigla} nro°{Numero} de la fecha {Fecha.ToShortDateString()}";
        }
    }
}
