using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja
{
    public class ECaja
    {
        public System.Nullable<decimal> IdCaja { get; set; }

        public string CodigoCaja { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<decimal> MontoActual { get; set; }

        public System.Nullable<bool> Estatus0 { get; set; }

        public string Estatus { get; set; }
    }
}
