using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa
{
    public class EMedico
    {

        public decimal? IdMedico {get;set;}

        public string CodigoMedico {get;set;}

        public string NombreMedico {get;set;}

        public string Telefono {get;set;}

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public string CentroSalud {get;set;}

        public string Email {get;set;}

        public System.Nullable<bool> Estatus0 {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public string CreadoPor {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona0 {get;set;}

        public string FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public string ModificadoPor {get;set;}

        public System.Nullable<System.DateTime> fechaModifica0 {get;set;}

        public string FechaModifica {get;set;}
        public System.Nullable<decimal> PorcComision { get; set; }
    }
}
