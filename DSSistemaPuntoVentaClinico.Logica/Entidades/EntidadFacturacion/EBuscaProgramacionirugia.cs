using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EBuscaProgramacionirugia
    {
        public decimal? IdProgramacionCirugia {get;set;}

        public string FechaCirugia {get;set;}

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public string CentroSalud {get;set;}

        public System.Nullable<decimal> IdMedico {get;set;}

        public string NombreMedico {get;set;}

        public System.Nullable<decimal> IdEstatusCirugia {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<decimal> NoFactura {get;set;}

        public System.Nullable<decimal> NoReferencia {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona0 {get;set;}

        public string FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public System.Nullable<System.DateTime> FechaModifica0 {get;set;}

        public string FechaModifica {get;set;}

        public System.Nullable<decimal> IdTipoFacturacion {get;set;}

        public string TipoComprobante {get;set;}

        public string Comprobante {get;set;}

        public string Paciente {get;set;}

        public string Telefono {get;set;}

        public System.Nullable<decimal> IdCentroSaludAnterior {get;set;}

        public string Sala {get;set;}

        public System.Nullable<decimal> IdMedicoAnterior {get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

        public string NumeroIdentificacion {get;set;}

        public string Direccion {get;set;}

        public System.Nullable<decimal> IdSexo {get;set;}

        public string Email {get;set;}

        public string ComentarioPaciente {get;set;}

        public System.Nullable<System.DateTime> FechaFacturacion0 {get;set;}

        public string FechaFacturacion {get;set;}

        public System.Nullable<decimal> IdUsuario {get;set;}
    }
}
