﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero) : base(numero) { }

        public override string Descripcion()
        {
            return $"FC N°{Numero}";
        }
    }
}
