using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad
{
    public class EBuscaComisionesMedicos
    {
        public decimal? IDComision {get;set;}

        public decimal? IdProgramacionCirugia {get;set;}

        public decimal? NumeroFactura {get;set;}

        public string Cliente {get;set;}

        public string Paciente {get;set;}

        public decimal? NumeroReferencia {get;set;}

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public string CentroSalud {get;set;}

        public string Telefonos {get;set;}

        public string Direccion {get;set;}

        public System.Nullable<decimal> Idmedico {get;set;}

        public string Medico {get;set;}

        public System.Nullable<decimal> PorcComisionMedico {get;set;}

        public System.Nullable<decimal> Impuesto {get;set;}

        public System.Nullable<decimal> TipoVenta0 {get;set;}

        public string TipoVenta {get;set;}

        public System.Nullable<decimal> MontoFactura {get;set;}

        public System.Nullable<decimal> MontoFacturaNeta {get;set;}

        public System.Nullable<decimal> ComisionPagar {get;set;}

        public System.Nullable<decimal> IdAsistente {get;set;}

        public System.Nullable<System.DateTime> FechaCirugia0 {get;set;}

        public string FechaCirugia {get;set;}

        public string Hora {get;set;}

        public System.Nullable<bool> ComisionPagada0 {get;set;}

        public string ComisionPagada {get;set;}

        public System.Nullable<System.DateTime> FechapagoComision0 {get;set;}

        public string FechapagoComision {get;set;}

        public System.Nullable<decimal> MontoPagado {get;set;}
    }
}
