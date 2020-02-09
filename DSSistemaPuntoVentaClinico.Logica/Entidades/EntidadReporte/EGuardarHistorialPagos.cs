using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EGuardarHistorialPagos
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> NumeroRecibo { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public string FechaPago { get; set; }

        public System.Nullable<decimal> MontoFactura { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }

        public System.Nullable<decimal> Balance { get; set; }

        public string Concepto { get; set; }

        public string TipoPago { get; set; }

        public string CreadoPor { get; set; }
    }
}
