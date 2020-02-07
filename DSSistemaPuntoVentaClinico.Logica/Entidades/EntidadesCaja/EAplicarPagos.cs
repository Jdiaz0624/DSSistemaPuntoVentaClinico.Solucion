using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja
{
    public class EAplicarPagos
    {
        public System.Nullable<decimal> NumeroRecibo { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public System.Nullable<decimal> IdPaciente { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public System.Nullable<decimal> Balance { get; set; }

        public System.Nullable<decimal> Pendiente { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }

        public System.Nullable<decimal> Cambio { get; set; }

        public System.Nullable<System.DateTime> FechaPago { get; set; }
    }
}
