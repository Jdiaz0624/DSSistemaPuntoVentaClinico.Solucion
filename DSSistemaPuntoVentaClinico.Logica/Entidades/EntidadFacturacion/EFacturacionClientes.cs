using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EFacturacionClientes
    {
        public System.Nullable<decimal> NumeroFactura  {get;set;}

        public System.Nullable<decimal> IdEstatusFacturacion  {get;set;}

        public string CodigoFacturacion  {get;set;}

        public System.Nullable<decimal> NumeroConector  {get;set;}

        public System.Nullable<decimal> IdTipoFacturacion  {get;set;}

        public string NombrePaciente  {get;set;}

        public string Telefono  {get;set;}

        public System.Nullable<decimal> IdCentroSalud  {get;set;}

        public string Sala  {get;set;}

        public System.Nullable<decimal> IdMedico  {get;set;}

        public System.Nullable<decimal> IdTipoIdentificacion  {get;set;}

        public string NumeroIdentificacion  {get;set;}

        public string Direccion  {get;set;}

        public System.Nullable<decimal> IdSexo  {get;set;}

        public string Email  {get;set;}

        public string ComentarioPaciente  {get;set;}

        public System.Nullable<System.DateTime> FechaFacturacion  {get;set;}

        public System.Nullable<decimal> IdUsuario  {get;set;}
        public string Paciente { get; set; }

        public string CedulaPaciente { get; set; }
        public string DescripcionTipoCliente { get; set; }
    }
}
