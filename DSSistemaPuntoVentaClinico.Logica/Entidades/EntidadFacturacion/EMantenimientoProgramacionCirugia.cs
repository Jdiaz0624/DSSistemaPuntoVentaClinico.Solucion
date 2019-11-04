using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion
{
    public class EMantenimientoProgramacionCirugia
    {
        public System.Nullable<decimal> IdProgramacionCirugia {get;set;}

        public System.Nullable<System.DateTime> FechaCirugia {get;set;}

        public System.Nullable<decimal> IdCentroSalud {get;set;}

        public System.Nullable<decimal> IdMedico {get;set;}

        public System.Nullable<decimal> IdEstatusCirugia {get;set;}

        public System.Nullable<decimal> NoFactura {get;set;}

        public System.Nullable<decimal> NoReferencia {get;set;}

        public System.Nullable<decimal> UsuarioAdiciona {get;set;}

        public System.Nullable<System.DateTime> FechaAdiciona {get;set;}

        public System.Nullable<decimal> UsuarioModifica {get;set;}

        public System.Nullable<System.DateTime> FechaModifica {get;set;}
    }
}
