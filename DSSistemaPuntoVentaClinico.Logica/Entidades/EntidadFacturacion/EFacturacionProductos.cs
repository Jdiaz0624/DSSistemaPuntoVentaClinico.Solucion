using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EFacturacionProductos
    {
        public System.Nullable<decimal> NumeroConector {get;set;}

        public System.Nullable<decimal> IdProducto {get;set;}

        public System.Nullable<decimal> Precio {get;set;}

        public System.Nullable<decimal> Cantidad {get;set;}

        public System.Nullable<decimal> DescuentoAplicado {get;set;}

        public System.Nullable<decimal> Total {get;set;}

        public System.Nullable<decimal> Secuencial {get;set;}

        public System.Nullable<decimal> NumeroPago {get;set;}
    }
}
