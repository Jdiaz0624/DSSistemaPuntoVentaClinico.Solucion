using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EGuardarPagoComisionReporte
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IdComision { get; set; }

        public System.Nullable<decimal> IdProgramacionCirugia { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public System.Nullable<decimal> IdCentroSalud { get; set; }

        public System.Nullable<decimal> IdMedico { get; set; }

        public System.Nullable<decimal> IdAsistente { get; set; }

        public System.Nullable<System.DateTime> FechaCirugia { get; set; }

        public System.Nullable<bool> ComisionPagada { get; set; }

        public System.Nullable<System.DateTime> FechaPagoComision { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }
    }
}
