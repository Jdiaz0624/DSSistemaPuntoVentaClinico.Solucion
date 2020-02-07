using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja
{
    public class EBuscaPagosFacturas
    {
        public System.Nullable<decimal> NumeroRecibo { get; set; }

        public System.Nullable<decimal> PagandoA { get; set; }

        public string NombrePaciente { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string FechaPago { get; set; }

        public System.Nullable<decimal> MontoFactura { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }

        public System.Nullable<decimal> Balance { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }

        public string TipoPago { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public string CreadoPor { get; set; }
    }
}
