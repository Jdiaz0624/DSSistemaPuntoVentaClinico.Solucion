using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion
{
    public class EConfiguracionGeneralSistema
    {
        public int? IdConfiguracionGeneral { get; set; }

        public System.Nullable<int> CantidadIntentoLogin { get; set; }

        public System.Nullable<bool> LlevaComprobantes { get; set; }
    }
}
