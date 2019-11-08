using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaConfiguracion
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDConfiguracionDataContext Objdata = new Data.Conexiones.ConexionLINQ.BDConfiguracionDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE INFORMACION DE EMPRESA
        //LISTADO DE INFORMACION DE EMPRESA
        public List<Entidades.EntidadesConfiguracion.EInformacionEmpresa> BuscaInformacionEmpresa(decimal? IdInformacionEmpresa = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_SACAR_INFORMACION_EMPRESA(IdInformacionEmpresa)
                          select new Entidades.EntidadesConfiguracion.EInformacionEmpresa
                          {
                              IdInformacionEmpresa=n.IdInformacionEmpresa,
                              CodigoInformacionEmpresa=n.CodigoInformacionEmpresa,
                              NombreEmpresa=n.NombreEmpresa,
                              RNC=n.RNC,
                              Direccion=n.Direccion,
                              Email=n.Email,
                              Email2=n.Email2,
                              Facebook=n.Facebook,
                              Instagran=n.Instagran,
                              Telefonos=n.Telefonos,
                              Fac=n.Fac,
                              IdLogoEmpresa=n.IdLogoEmpresa,
                              DescripcionLogo=n.DescripcionLogo,
                              LogoEmpresa=n.LogoEmpresa
                          }).ToList();
            return Buscar;
        }

        //MANTENMIENTO DE INFORMACION DE EMPRESA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa MantenimientoInformacionEmpresa(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa Mantenimiento = null;

            var InformacionEmpresa = Objdata.SP_MANTENIMIENTO_INFORMACION_EMPRESA(
                Item.IdInformacionEmpresa,
                Item.CodigoInformacionEmpresa,
                Item.NombreEmpresa,
                Item.RNC,
                Item.Direccion,
                Item.Email,
                Item.Email2,
                Item.Facebook,
                Item.Instagran,
                Item.Telefonos,
                Item.Fac,
                Item.IdLogoEmpresa,
                Accion);
            if (InformacionEmpresa != null)
            {
                Mantenimiento = (from n in InformacionEmpresa
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa
                                 {
                                     IdInformacionEmpresa=n.IdInformacionEmpresa,
                                     CodigoInformacionEmpresa=n.CodigoInformacionEmpresa,
                                     NombreEmpresa=n.NombreEmpresa,
                                     RNC=n.RNC,
                                     Direccion=n.Direccion,
                                     Email=n.Email,
                                     Email2=n.Email2,
                                     Facebook=n.Facebook,
                                     Instagran=n.Instagran,
                                     Telefonos=n.Telefonos,
                                     Fac=n.Fac,
                                     IdLogoEmpresa=n.IdLogoEmpresa
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        #endregion

        #region MANTENIMIENTO DE LA CONFIGURACION GENERAL DEL SISTEMA
        //SACAR LA CONFIGURACION GENERAL DEL SISTEMA
        public List<Entidades.EntidadesConfiguracion.EConfiguracionGeneralSistema> ConfiguracionGeneralSistema(int? IdConfiguracionGeneral = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.ConfiguracionGeneralSistema(IdConfiguracionGeneral)
                          select new Entidades.EntidadesConfiguracion.EConfiguracionGeneralSistema
                          {
                              IdConfiguracionGeneral = n.IdConfiguracionGeneral,
                              CantidadIntentoLogin = n.CantidadIntentoLogin,
                              LlevaComprobantes = n.LlevaComprobantes
                          }).ToList();
            return Buscar;
        }
        #endregion

        #region BUSCA LISTAS
        public List<Entidades.EntidadesConfiguracion.EBuscaListas> BuscaListas(string NombreLista = null, string PrimerFiltro = null, string SegundoFiltro = null, string TercerFiltro = null, string CuartoFiltro = null, string QuintoFiltro = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_LISTAS(NombreLista, PrimerFiltro, SegundoFiltro, TercerFiltro, CuartoFiltro, QuintoFiltro)
                          select new Entidades.EntidadesConfiguracion.EBuscaListas
                          {
                              Descripcion =n.Descripcion,
                              PrimerValor=n.PrimerValor,
                              SegundoValor=n.SegundoValor,
                              TerceValor=n.TerceValor
                          }).ToList();
            return Buscar;
        }
#endregion
    }
}
