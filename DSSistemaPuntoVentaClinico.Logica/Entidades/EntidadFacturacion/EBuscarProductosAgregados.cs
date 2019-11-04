using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EBuscarProductosAgregados
    {
        public System.Nullable<decimal> NumeroConector { get; set; }

        public System.Nullable<decimal> IdProducto { get; set; }

        public string CodigoProducto { get; set; }

        public string Descripcion { get; set; }

        public System.Nullable<decimal> PrecioCompra { get; set; }

        public System.Nullable<decimal> Precio { get; set; }

        public System.Nullable<bool> LlevaDescuento0 { get; set; }

        public string _LlevaDescuento { get; set; }

        public System.Nullable<int> PorcientoDescuento { get; set; }

        public System.Nullable<decimal> Cantidad { get; set; }

        public System.Nullable<decimal> DescuentoAplicado { get; set; }

        public System.Nullable<decimal> Total { get; set; }

        public System.Nullable<decimal> Secuencial { get; set; }

        public System.Nullable<decimal> NumeroPago { get; set; }
    }
}
