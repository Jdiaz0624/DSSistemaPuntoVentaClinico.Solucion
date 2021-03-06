﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EFacturacionCalculos
    {
        public System.Nullable<decimal> NumeroConector { get; set; }

        public System.Nullable<decimal> CantidadArticulos { get; set; }

        public System.Nullable<decimal> TotalDescuento { get; set; }

        public System.Nullable<decimal> Subtotal { get; set; }

        public System.Nullable<decimal> Impuesto { get; set; }
    
        public System.Nullable<decimal> Total { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }

        public System.Nullable<decimal> IdEstatusCirugia { get; set; }
    
        public System.Nullable<bool> CirugiaProgramada { get; set; }

        public System.Nullable<decimal> TipoVenta { get; set; }

        public System.Nullable<int> IdCantidadDias { get; set; }

        public System.Nullable<decimal> CodigoPaciente { get; set; }
        public System.Nullable<decimal> Balance { get; set; }
    }
}
