using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad
{
    public class EEjecutarUsuarios
    {
        public decimal? IdRegistro { get; set; }

        public decimal? IdUsuario { get; set; }

        public System.Nullable<int> CantidadIntentos { get; set; }
    }
}
