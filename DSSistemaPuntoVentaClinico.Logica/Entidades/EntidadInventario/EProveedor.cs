using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario
{
    public class EProveedor
    {
        public System.Nullable<decimal> IdProveedor {get;set;}

        public string CodigoProveedor {get;set;}

        public System.Nullable<decimal> IdTipoProveedor {get;set;}

        public string TipoProveedor {get;set;}

        public string Nombre {get;set;}

        public string Direccion {get;set;}

        public string Telefonos {get;set;}

        public string Fax {get;set;}

        public string Contacto {get;set;}

        public System.Nullable<bool> LlevaComision0 {get;set;}

        public string LlevaComision {get;set;}

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
