using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class ESacarCalculosFacturacion
    {
        public System.Nullable<decimal> CantidadArticulos { get; set; }

        public System.Nullable<decimal> ToTalDescuento { get; set; }

        public System.Nullable<decimal> Total { get; set; }

        public System.Nullable<decimal> PorcientoAplicado { get; set; }

        public System.Nullable<decimal> Impuesto { get; set; }

        public System.Nullable<decimal> SubTotal { get; set; }
    }
}
