using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class ETipoPago
    {
        public System.Nullable<decimal> IdTipoPago {get;set;}

        public string CodigoTipoPago {get;set;}

        public string TipoPago {get;set;}

        public System.Nullable<bool> Estatus0 {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<bool> BloqueaMontoPagar0 {get;set;}

        public string BloqueaMontoPagar {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona0 {get;set;}

        public string CreadoPor {get;set;}

        public string FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaModifica0 {get;set;}

        public string FechaModifica {get;set;}
    }
}
