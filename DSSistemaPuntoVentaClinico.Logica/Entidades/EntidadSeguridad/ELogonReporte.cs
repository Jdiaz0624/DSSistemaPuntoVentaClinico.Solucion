using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad
{
    public class ELogonReporte
    {
        public decimal? IdLogonBd { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }
    }
}
