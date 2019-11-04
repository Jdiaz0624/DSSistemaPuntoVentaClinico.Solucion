using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion
{
    public class EInformacionEmpresa
    {
        public decimal? IdInformacionEmpresa { get; set; }

        public string CodigoInformacionEmpresa { get; set; }

        public string NombreEmpresa { get; set; }

        public string RNC { get; set; }

        public string Direccion { get; set; }

        public string Email { get; set; }

        public string Email2 { get; set; }

        public string Facebook { get; set; }

        public string Instagran { get; set; }

        public string Telefonos { get; set; }

        public string Fac { get; set; }

        public System.Nullable<decimal> IdLogoEmpresa { get; set; }

        public string DescripcionLogo { get; set; }

        public System.Data.Linq.Binary LogoEmpresa { get; set; }
    }
}
