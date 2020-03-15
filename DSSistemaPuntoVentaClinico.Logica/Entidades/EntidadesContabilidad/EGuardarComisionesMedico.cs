using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad
{
    public class EGuardarComisionesMedico
    {

        public System.Nullable<decimal> IDComision { get; set; }

        public System.Nullable<decimal> IdProgramacionCirugia { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public System.Nullable<decimal> IdCentroSalud { get; set; }

        public System.Nullable<decimal> Idmedico { get; set; }

        public System.Nullable<decimal> IdAsistente { get; set; }

        public System.Nullable<System.DateTime> FechaCirugia { get; set; }

        public System.Nullable<bool> ComisionPagada { get; set; }

        public System.Nullable<System.DateTime> FechapagoComision { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }
    }
}
