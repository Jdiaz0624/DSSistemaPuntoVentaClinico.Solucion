using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa
{
    public class EPacientes
    {
        public decimal? IdPaciente {get;set;}

        public string CodigoPaciente {get;set;}

        public System.Nullable<decimal> IdComprobante {get;set;}

        public string Comprobante {get;set;}

        public string Nombre {get;set;}

        public string Telefono {get;set;}
        public System.Nullable<decimal> MontoCredito { get; set; }

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public string CentroSalud {get;set;}

        public string Sala {get;set;}

        public System.Nullable<decimal> IdMedico {get;set;}

        public string Medico {get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

        public string TipoIdentificaion {get;set;}

        public string NumeroIdentificacion {get;set;}

        public string Direccion {get;set;}

        public System.Nullable<decimal> IdSexo {get;set;}

        public string Sexo {get;set;}

        public string Email {get;set;}

        public string Comentario {get;set;}

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
