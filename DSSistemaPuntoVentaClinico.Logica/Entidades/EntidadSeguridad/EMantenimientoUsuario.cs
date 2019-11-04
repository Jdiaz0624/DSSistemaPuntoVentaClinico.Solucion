using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad
{
    public class EMantenimientoUsuario
    {
        public System.Nullable<decimal> IdUsuario { get; set; }

        public string CodigoUsuario { get; set; }

        public System.Nullable<decimal> IdPerfil { get; set; }

        public string Usuario { get; set; }

        public string Clave { get; set; }

        public string Persona { get; set; }

        public System.Nullable<bool> Estatus { get; set; }

        public System.Nullable<decimal> UsuarioAdiciona { get; set; }

        public System.Nullable<System.DateTime> FechaAdiciona { get; set; }

        public System.Nullable<decimal> UsuarioModifica { get; set; }

        public System.Nullable<System.DateTime> FechaModifica { get; set; }
    }
}
