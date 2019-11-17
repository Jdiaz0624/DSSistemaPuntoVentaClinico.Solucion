using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad
{
    public class EMantenimientoComprobantesFiscales
    {
        public System.Nullable<decimal> IdComprobante { get; set; }

        public string Comprobante { get; set; }

        public string Serie { get; set; }

        public string TipoComprobante { get; set; }

        public System.Nullable<long> Secuencial { get; set; }

        public System.Nullable<long> SecuenciaInicial { get; set; }

        public System.Nullable<long> SecuenciaFinal { get; set; }

        public System.Nullable<long> Limite { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }

        public string ValidoHasta { get; set; }

        public System.Nullable<bool> PorDefecto0 { get; set; }

        public string PorDefecto { get; set; }

        public System.Nullable<long> Posiciones { get; set; }
    }
}
