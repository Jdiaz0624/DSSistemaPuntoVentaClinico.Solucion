using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaContabilidad
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDContabilidadDataContext Objdata = new Data.Conexiones.ConexionLINQ.BDContabilidadDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region GENERAR LOS COMPROBANTES FISCALES
        public List<Entidades.EntidadesContabilidad.EGeneraComprobanteFiscal> GenerarComprobantesFiscales(decimal? IdComprobante = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Generar = (from n in Objdata.SP_GENERAR_COMPROBANTE_FISCAL(IdComprobante)
                           select new Entidades.EntidadesContabilidad.EGeneraComprobanteFiscal
                           {
                               TipoComprobante=n.TipoComprobante,
                               Comprobante=n.Comprobante
                           }).ToList();
            return Generar;
        }
#endregion
    }
}
