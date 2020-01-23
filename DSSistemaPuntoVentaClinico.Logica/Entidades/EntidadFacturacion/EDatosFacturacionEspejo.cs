using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EDatosFacturacionEspejo
    {
        public System.Nullable<decimal> NumeroConector { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public System.Nullable<decimal> IdTipoFacturacion { get; set; }

        public string NombrePaciente { get; set; }

        public string Telefono { get; set; }

        public System.Nullable<decimal> IdCentroSalud { get; set; }

        public string Sala { get; set; }

        public System.Nullable<decimal> IdMedico { get; set; }

        public System.Nullable<decimal> IdTipoIdentificacion { get; set; }

        public string NumeroIdentificacion { get; set; }

        public string Direccion { get; set; }

        public System.Nullable<decimal> IdSexo { get; set; }

        public string Email { get; set; }

        public string Comentario { get; set; }

        public System.Nullable<bool> GuardarCliente { get; set; }

        public System.Nullable<bool> TipoProceso { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }

        public System.Nullable<decimal> IdEstatusirugia { get; set; }

        public System.Nullable<decimal> IdTipoVenta { get; set; }

        public System.Nullable<decimal> IdCantidadDias { get; set; }
    }
}
