using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte
{
    public class EmantenimientoReporte
    {
        public System.Nullable<decimal> IdUsuarioImprime {get;set;}

        public System.Nullable<decimal> IdProducto {get;set;}

        public string CodigoProducto {get;set;}

        public string Almacen {get;set;}

        public string TipoProveedor {get;set;}

        public string Proveedor {get;set;}

        public string TipoEmpaque {get;set;}

        public string TipoProducto {get;set;}

        public string Producto {get;set;}

        public string Estatus {get;set;}

        public System.Nullable<int> CantidadAlmacen {get;set;}

        public System.Nullable<decimal> PrecioCompra {get;set;}

        public System.Nullable<decimal> PrecioVenta {get;set;}

        public System.Nullable<decimal> SegundoPrecio {get;set;}

        public System.Nullable<decimal> TercerPrecio {get;set;}

        public string FechaEntrada {get;set;}

        public string LlevaDescuento {get;set;}

        public System.Nullable<int> PorcientoDescuento {get;set;}

        public string CreadoPor {get;set;}

        public string FechaAdiciona {get;set;}

        public string ModificadoPor {get;set;}

        public string FechaModifica {get;set;}
    }
}
