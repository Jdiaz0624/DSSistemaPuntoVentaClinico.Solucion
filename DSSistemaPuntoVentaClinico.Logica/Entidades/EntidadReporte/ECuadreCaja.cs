using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class ECuadreCaja
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public string Caja { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public string Concepto { get; set; }

        public string Fecha { get; set; }
    
        public string CreadoPor { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public string TipoPago { get; set; }

        public System.Nullable<System.DateTime> FechaDesde { get; set; }

        public System.Nullable<System.DateTime> FechaHasta { get; set; }
    }
}
