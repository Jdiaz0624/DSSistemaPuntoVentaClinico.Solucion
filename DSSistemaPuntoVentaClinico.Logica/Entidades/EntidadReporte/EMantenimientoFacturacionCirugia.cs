using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EMantenimientoFacturacionCirugia
    {
        public System.Nullable<decimal> NumeroFactura { get; set; }

        public System.Nullable<decimal> NumeroConector { get; set; }

        public System.Nullable<System.DateTime> FechaFacturacion { get; set; }

        public System.Nullable<bool> CirugiaProgramada { get; set; }
    }
}
