using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EGastosCirugia
    {
        public System.Nullable<decimal> IdGastosCirugia { get; set; }

        public System.Nullable<decimal> IdProgramacionCirugia { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<int> Cantidad { get; set; }

        public string Comentario { get; set; }
    }
}
