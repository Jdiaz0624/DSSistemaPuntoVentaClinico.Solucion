using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa
{
    public class ECentroSalud
    {
        public decimal? IdCentroSalud {get;set;}

        public string CodigoCentroSalud {get;set;}

        public string Nombre {get;set;}

        public string Direccion {get;set;}

        public string Telefonos {get;set;}

        public System.Nullable<bool> Estatus0 {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public string CreadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona0 {get;set;}

        public string FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaModifica0 {get;set;}

        public string FechaModifica {get;set;}
    }
}
