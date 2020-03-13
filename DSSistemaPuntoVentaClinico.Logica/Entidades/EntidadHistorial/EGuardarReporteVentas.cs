using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial
{
    public class EGuardarReporteVentas
    {
        public System.Nullable<decimal> IdUsuario {get;set;}

        public System.Nullable<decimal> NumeroFactura {get;set;}

        public string NombrePaciente {get;set;}

        public string TipoIdentificacion {get;set;}

        public string Numeroidentificacion {get;set;}

        public string Estatus {get;set;}

        public string TipoComprobante {get;set;}

        public string Telefono {get;set;}

        public string CentroSalud {get;set;}

        public string Sala {get;set;}

        public string Medico {get;set;}

        public string Direccion {get;set;}

        public string Sexo {get;set;}

        public string Email {get;set;}

        public string ComentarioPaciente {get;set;}

        public string FechaFacturacion {get;set;}

        public string FechaVencimiento {get;set;}

        public System.Nullable<int> CantidadDias {get;set;}

        public System.Nullable<int> DiasDiferencia {get;set;}

        public string EstatusDias {get;set;}

        public string CreadoPor {get;set;}

        public string TipoProducto {get;set;}

        public string Producto {get;set;}

        public System.Nullable<int> Cantidad {get;set;}

        public System.Nullable<decimal> Precio {get;set;}

        public System.Nullable<decimal> DescuentoAplicado {get;set;}

        public System.Nullable<decimal> Total {get;set;}

        public System.Nullable<decimal> TotalDescuento {get;set;}

        public System.Nullable<decimal> SubTotal {get;set;}

        public System.Nullable<decimal> Impuesto {get;set;}

        public System.Nullable<decimal> TotalGeneral {get;set;}

        public string TipoPago {get;set;}

        public System.Nullable<decimal> MontoPagado {get;set;}

        public string EstatusCirugia {get;set;}

        public string TipoVenta {get;set;}

        public System.Nullable<decimal> Balance {get;set;}
    }
}
