using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaSeguridad
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDSeguridadDataContext ObData = new Data.Conexiones.ConexionLINQ.BDSeguridadDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE USUARIOS
        //SACAR EL LISTADO DE LOS USUARIOS
        public List<Entidades.EntidadSeguridad.EUsuario> BuscaUsuario(decimal? IdUsuario = null, string CodigoUsuario = null, decimal? IdPerfil = null, string Usuario = null, string UsuarioLogin = null, string Clave = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObData.CommandTimeout = 999999999;

            var Buscar = (from n in ObData.SP_BUSCA_USUARIOS(IdUsuario, CodigoUsuario, IdPerfil, Usuario, UsuarioLogin, Clave, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadSeguridad.EUsuario
                          {
                              IdUsuario=n.IdUsuario,
                              CodigoUsuario=n.CodigoUsuario,
                              IdPerfil=n.IdPerfil,
                              Perfil=n.Perfil,
                              Usuario=n.Usuario,
                              Clave=n.Clave,
                              Persona=n.Persona,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaModifica0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE USUARIOS
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario MantenimientoUsuario(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario Item, string Accion)
        {
            ObData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario Mantenimiento = null;

            var Usuario = ObData.SP_MANTENIMIENTO_USUARIO(
                Item.IdUsuario,
                Item.CodigoUsuario,
                Item.IdPerfil,
                Item.Usuario,
                Item.Clave,
                Item.Persona,
                Item.Estatus,
                Item.UsuarioAdiciona,
                Accion);
            if (Usuario != null)
            {
                Mantenimiento = (from n in Usuario
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario
                                 {
                                     IdUsuario=n.IdUsuario,
                                     CodigoUsuario=n.CodigoUsuario,
                                     IdPerfil=n.IdPerfil,
                                     Usuario=n.Usuario,
                                     Clave=n.Clave,
                                     Persona=n.Persona,
                                     Estatus=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region EJECUTAR USUARIOS
        //BUSCA EL LISTADO DE EJECUTAR USUARIOS
        public List<Entidades.EntidadSeguridad.EEjecutarUsuarios> EjecutarUsuarios(decimal? IdUsuarios = null)
        {
            ObData.CommandTimeout = 999999999;

            var Buscar = (from n in ObData.SP_BUSCAR_EJECUTAR_USUARIO(IdUsuarios)
                          select new Entidades.EntidadSeguridad.EEjecutarUsuarios
                          {
                              IdRegistro=n.IdRegistro,
                              IdUsuario=n.IdUsuario,
                              CantidadIntentos=n.CantidadIntentos
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIENTO DE EJECUTAR USUARIOS
        public Entidades.EntidadSeguridad.EEjecutarUsuarios MantenimientoEjecutarUsuarios(Entidades.EntidadSeguridad.EEjecutarUsuarios Item, string Accion)
        {
            ObData.CommandTimeout = 999999999;

            Entidades.EntidadSeguridad.EEjecutarUsuarios Mantenimiento = null;

            var EjecutarUsuarios = ObData.SP_MANTENIMINTO_EJECUTAR_USUARIO(
                Item.IdRegistro,
                Item.IdUsuario,
                Item.CantidadIntentos,
                Accion);
            if (EjecutarUsuarios != null)
            {
                Mantenimiento = (from n in EjecutarUsuarios
                                 select new Entidades.EntidadSeguridad.EEjecutarUsuarios
                                 {
                                     IdRegistro=n.IdRegistro,
                                     IdUsuario=n.IdUsuario,
                                     CantidadIntentos=n.CantidadIntentos
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE CLAVE DE SEGURIDAD
        //LISTADO DE CLAVE DE SEGURIDAD
        public List<Entidades.EntidadSeguridad.EClaveSeguridad> BuscaClaveSeguridad(string Clave = null, decimal? IdUsuario = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObData.CommandTimeout = 999999999;

            var Buscar = (from n in ObData.SP_BUSCA_CLAVE_SEGURIDAD(Clave, IdUsuario, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadSeguridad.EClaveSeguridad
                          {
                              IdClaveSeguridad=n.IdClaveSeguridad,
                              IdUsuario=n.IdUsuario,
                              Persona=n.Persona,
                              Perfil=n.Perfil,
                              Clave=n.Clave,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaModifica0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE CLAVE DE SEGURIDAD
        public Entidades.EntidadSeguridad.EClaveSeguridad MantenimientoClaveSeguridad(Entidades.EntidadSeguridad.EClaveSeguridad Item, string Accion)
        {
            ObData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EClaveSeguridad Mantenimiento = null;

            var ClaveSeguridad = ObData.SP_MANTENIMIENTO_CLAVE_SEGURIDAD(
                Item.IdClaveSeguridad
                , Item.IdUsuario
                , Item.Clave
                , Item.Estatus0
                , Item.UsuarioAdiciona
                , Accion);
            if (ClaveSeguridad != null)
            {
                Mantenimiento = (from n in ClaveSeguridad
                                 select new Entidades.EntidadSeguridad.EClaveSeguridad
                                 {
                                     IdClaveSeguridad=n.IdClaveSeguridad,
                                     IdUsuario=n.IdUsuario,
                                     Clave=n.Clave,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region SACAR EL USUARIO Y LA CLAVE DE LA BASE DE DATOA
        public List<Entidades.EntidadSeguridad.ELogonReporte> SacarLogonBD(decimal? IdLogonBd = null)
        {
            ObData.CommandTimeout = 999999999;

            var SacarDatos = (from n in ObData.SP_SACAR_LOGON_BD(IdLogonBd)
                              select new Entidades.EntidadSeguridad.ELogonReporte
                              {
                                  IdLogonBd=n.IdLogonBd,
                                  Usuario=n.Usuario,
                                  Clave=n.Clave
                              }).ToList();
            return SacarDatos;
        }
        #endregion
        #region MODIFICAR LAS CREDENCIALES DEL USUARIO DE LA BASE DE DATOS
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EModificarLogonReporte Credenciales(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EModificarLogonReporte Item, string Accion)
        {
            ObData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EModificarLogonReporte Modificar = null;

            var CredencialesBD = ObData.SP_MODIFICAR_LOGON_REPORTE(
                Item.IdLogonBd,
                Item.Usuario,
                Item.Clave,
                Accion);
            if (CredencialesBD != null)
            {
                Modificar = (from n in CredencialesBD
                             select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EModificarLogonReporte
                             {
                                 IdLogonBd=n.IdLogonBd,
                                 Usuario=n.Usuario,
                                 Clave=n.Clave
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion
    }
}
