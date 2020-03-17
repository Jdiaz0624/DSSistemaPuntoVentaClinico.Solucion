using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EGuardarReporteComisionMedicoDetalle
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IDComision { get; set; }

        public System.Nullable<decimal> IdProgramacionCirugia { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public string CentroSalud { get; set; }

        public string Medico { get; set; }

        public System.Nullable<decimal> PorcComisionMedico { get; set; }

        public System.Nullable<decimal> MontoFactura { get; set; }

        public System.Nullable<decimal> MontoFacturaNeta { get; set; }

        public System.Nullable<decimal> ComisionPagar { get; set; }

        public string FechaCirugia { get; set; }

        public string Hora { get; set; }

        public string ComisionPagada { get; set; }

        public string FechaPagoComision { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }
    }
}
