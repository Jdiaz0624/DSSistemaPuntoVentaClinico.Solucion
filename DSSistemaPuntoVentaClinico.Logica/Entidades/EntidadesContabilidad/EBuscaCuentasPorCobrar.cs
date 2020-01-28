using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad
{
    public class EBuscaCuentasPorCobrar
    {
        public decimal? IdCuentaPorPagar { get; set; }

        public decimal? IdPaciente { get; set; }

        public string Paciente { get; set; }

        public string TipoIdentificacion { get; set; }

        public string NoIdentificacion { get; set; }

        public decimal? Secuencia { get; set; }

        public System.Nullable<System.DateTime> Fecha0 { get; set; }

        public System.Nullable<decimal> NumeroConector { get; set; }

        public string NombrePaciente { get; set; }

        public string TipoComprobante { get; set; }

        public string ValidoHasta { get; set; }

        public string Comprobante { get; set; }

        public System.Nullable<decimal> BalanceInicial { get; set; }

        public System.Nullable<decimal> BalanceActual { get; set; }

        public System.Nullable<decimal> MontoPagado { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<decimal> NumeroFactura { get; set; }

        public string FechaFacturacion { get; set; }

        public string FechaVencimiento { get; set; }

        public System.Nullable<int> DiasAtrasados { get; set; }

        public string Estatus { get; set; }

        public System.Nullable<int> DiasCredito { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public System.Nullable<decimal> Abono { get; set; }

        public System.Nullable<decimal> Pendiente { get; set; }

        public System.Nullable<decimal> @__0_30 { get; set; }

        public System.Nullable<decimal> @__31_60 { get; set; }

        public System.Nullable<decimal> @__61_90 { get; set; }

        public System.Nullable<decimal> @__91_120 { get; set; }

        public System.Nullable<decimal> @__121_o_Mas { get; set; }
    }
}
