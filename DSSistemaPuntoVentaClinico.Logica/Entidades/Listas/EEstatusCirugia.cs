using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.Listas
{
    public class EEstatusCirugia
    {
        public decimal? IdEstatusCirugia { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<bool> Estatus { get; set; }
    }
}
