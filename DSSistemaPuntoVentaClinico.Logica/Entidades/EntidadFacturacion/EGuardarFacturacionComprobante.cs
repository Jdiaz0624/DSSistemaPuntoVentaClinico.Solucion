using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EGuardarFacturacionComprobante
    {
        public System.Nullable<decimal> IdFacturacion { get; set; }

        public string CodigoFacturacion { get; set; }

        public System.Nullable<decimal> NumeroConector { get; set; }

        public string TipoComprobante { get; set; }

        public string Comprobante { get; set; }
    }
}
