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

        #region MANTEIMIENTO DE COMPROBANTES FISCALES
        //LISTADO DE COMPROBANTES FISCALES
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales> ListadoComprobantes(decimal? IdComprobante = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Listado = (from n in Objdata.SP_BUSCA_COMPROBANTES_FISCALES(IdComprobante)
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales
                           {
                               IdComprobante=n.IdComprobante,
                               Comprobante=n.Comprobante,
                               Serie=n.Serie,
                               TipoComprobante=n.TipoComprobante,
                               Secuencial=n.Secuencial,
                               SecuenciaInicial=n.SecuenciaInicial,
                               SecuenciaFinal=n.SecuenciaFinal,
                               Limite=n.Limite,
                               Estatus0=n.Estatus0,
                               Estatus=n.Estatus,
                               ValidoHasta=n.ValidoHasta,
                               PorDefecto0=n.PorDefecto0,
                               PorDefecto=n.PorDefecto,
                               Posiciones=n.Posiciones
                           }).ToList();
            return Listado;
        }

        //MANTENIMIENTO DE COMPROBANTES FISCALES
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales MantenimientoComprobantesFiscales(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales Mantenimiento = null;

            var ComprobantesFiscales = Objdata.SP_MANTENIMIENTO_COMPROBANTE_FISCALES(
                Item.IdComprobante,
                Item.Comprobante,
                Item.Serie,
                Item.TipoComprobante,
                Item.Secuencial,
                Item.SecuenciaInicial,
                Item.SecuenciaFinal,
                Item.Limite,
                Item.Estatus0,
                Item.ValidoHasta,
                Item.PorDefecto0,
                Item.Posiciones,
                Accion);
            if (ComprobantesFiscales != null)
            {
                Mantenimiento = (from n in ComprobantesFiscales
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales
                                 {
                                     IdComprobante = n.IdComprobante,
                                     Comprobante = n.Descripcion,
                                     Serie = n.Serie,
                                     TipoComprobante = n.TipoComprobante,
                                     Secuencial = n.Secuencial,
                                     SecuenciaInicial = n.SecuenciaInicial,
                                     SecuenciaFinal = n.SecuenciaFinal,
                                     Limite = n.Limite,
                                     Estatus0 = n.Estatus,
                                     ValidoHasta = n.ValidoHasta,
                                     PorDefecto0 = n.PorDefecto,
                                     Posiciones = n.Posiciones
                                 }).FirstOrDefault();
            }
            return Mantenimiento;

        }
        #endregion
    }
}
