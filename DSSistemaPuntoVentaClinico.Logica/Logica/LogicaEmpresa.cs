using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaEmpresa
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDEmpresaDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDEmpresaDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE CENTRO DE SALUD
        //LISTADO DE CENTRO DE SALUD
        public List<Entidades.EntidadEmpresa.ECentroSalud> BuscaCentroSalus(decimal? IdCentroSalud = null, string CodigoCentroSalud = null, string Nombre = null, int? NumeroPagina = null, int? Numeroregistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_CENTRO_SALUD(IdCentroSalud, CodigoCentroSalud, Nombre, NumeroPagina, Numeroregistros)
                          select new Entidades.EntidadEmpresa.ECentroSalud
                          {
                              IdCentroSalud=n.IdCentroSalud,
                              CodigoCentroSalud=n.CodigoCentroSalud,
                              Nombre=n.Nombre,
                              Direccion=n.Direccion,
                              Telefonos=n.Telefonos,
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
        //MANTENIMIENTO DE CENTRO DE SALUD
        public Entidades.EntidadEmpresa.ECentroSalud MantenimientoCentroSalud(Entidades.EntidadEmpresa.ECentroSalud Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadEmpresa.ECentroSalud Mantenimiento = null;

            var CentroSalud = ObjData.SP_MANTENIMIENTO_CENTRO_SALUD(
                Item.IdCentroSalud,
                Item.CodigoCentroSalud,
                Item.Nombre,
                Item.Direccion,
                Item.Telefonos,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (CentroSalud != null)
            {
                Mantenimiento = (from n in CentroSalud
                                 select new Entidades.EntidadEmpresa.ECentroSalud
                                 {
                                     IdCentroSalud=n.IdCentroSalud,
                                     CodigoCentroSalud=n.CodigoCentroSalud,
                                     Nombre=n.Nombre,
                                     Direccion=n.Direccion,
                                     Telefonos=n.Telefonos,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE MEDICOS
        //BUSCA MEDICOS
        public List<Entidades.EntidadEmpresa.EMedico> BuscaMedicos(decimal? IdMedico = null, string CodigoMedico = null, string NombreMedico = null, decimal? IdCentroSalud = null, int? NumeroPagina = null, int? Numeroegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_MEDICO(IdMedico, CodigoMedico, NombreMedico, IdCentroSalud, NumeroPagina, Numeroegistros)
                          select new Entidades.EntidadEmpresa.EMedico
                          {
                              IdMedico=n.IdMedico,
                              CodigoMedico=n.CodigoMedico,
                              NombreMedico=n.NombreMedico,
                              Telefono=n.Telefono,
                              IdCentroSalud=n.IdCentroSalud,
                              CentroSalud=n.CentroSalud,
                              Email=n.Email,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioAdiciona,
                              ModificadoPor=n.ModificadoPor,
                              fechaModifica0=n.fechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE MEDICOS
        public Entidades.EntidadEmpresa.EMedico Mantenimientomedicos(Entidades.EntidadEmpresa.EMedico Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadEmpresa.EMedico Mantenimiento = null;

            var Medicos = ObjData.SP_MANTENIMIENTO_MEDICO(
                Item.IdMedico,
                Item.CodigoMedico,
                Item.NombreMedico,
                Item.IdCentroSalud,
                Item.Email,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.Telefono,
                Accion);
            if (Medicos != null)
            {
                Mantenimiento = (from n in Medicos
                                 select new Entidades.EntidadEmpresa.EMedico
                                 {
                                     IdMedico=n.IdMedico,
                                     CodigoMedico=n.CodigoMedico,
                                     NombreMedico=n.NombreMedico,
                                     IdCentroSalud=n.IdCentroSalud,
                                     Email=n.Email,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     fechaModifica0=n.FechaModifica,
                                     Telefono=n.Telefono
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE ARS
        public List<Entidades.EntidadEmpresa.EArs> BuscaARS(decimal? IdARS = null, string CodigoARS = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_ARS(IdARS, CodigoARS, Descripcion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadEmpresa.EArs
                          {
                              IdArs=n.IdArs,
                              CodigoARS=n.CodigoARS,
                              ARS=n.ARS,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica,
                              Representante=n.Representante,
                              RNC=n.RNC,
                              Telefono=n.Telefono,
                              Correo=n.Correo,
                              Direccion=n.Direccion
                          }).ToList();
            return Buscar;
        }
        public Entidades.EntidadEmpresa.EArs MantenimientoARs(Entidades.EntidadEmpresa.EArs Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadEmpresa.EArs Mantenimiento = null;

            var ARS = ObjData.SP_MANTENIMIENTO_ARS(
                Item.IdArs,
                Item.CodigoARS,
                Item.ARS,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.Representante,
                Item.RNC,
                Item.Telefono,
                Item.Correo,
                Item.Direccion,
                Accion);
            if (ARS != null)
            {
                Mantenimiento = (from n in ARS
                                 select new Entidades.EntidadEmpresa.EArs
                                 {
                                     IdArs=n.IdArs,
                                     CodigoARS=n.CodigoARS,
                                     ARS=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica,
                                     Representante=n.Representante,
                                     RNC=n.RNC,
                                     Telefono=n.Telefono,
                                     Correo=n.Correo,
                                     Direccion=n.Direccion
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE SALAS
        //LISTADO DE SALAS
        public List<Entidades.EntidadEmpresa.ESalas> BuscaSalas(decimal? IdSala = null, string CodigoSala = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_SALAS(IdSala, CodigoSala, Descripcion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadEmpresa.ESalas
                          {
                              IdSala=n.IdSala,
                              CodigoSala=n.CodigoSala,
                              Sala=n.Sala,
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
        //MANTENIMIENTO DE SALAS
        public Entidades.EntidadEmpresa.ESalas MantenimientoSalas(Entidades.EntidadEmpresa.ESalas Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;
            Entidades.EntidadEmpresa.ESalas Mantenimiento = null;

            var Salas = ObjData.SP_MANTENIMIENTO_SALAS(
                Item.IdSala,
                Item.CodigoSala,
                Item.Sala,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (Salas != null)
            {
                Mantenimiento = (from n in Salas
                                 select new Entidades.EntidadEmpresa.ESalas
                                 {
                                     IdSala=n.IdSala,
                                     CodigoSala=n.CodigoSala,
                                     Sala=n.Descripcion,
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

        #region MANTENIMIENTO DE PACIENTES
        //LISTADO DE PACIENTES
        public List<Entidades.EntidadEmpresa.EPacientes> BuscaClientes(decimal? IdPaciente = null, string CodigoPaciente = null, decimal? IdComprobante = null, string Nombre = null, decimal? IdCentroSalud = null, decimal? IdMedico = null,string TipoIdentificacion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_PACIENTES(IdPaciente, CodigoPaciente, IdComprobante, Nombre, IdCentroSalud, IdMedico, TipoIdentificacion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadEmpresa.EPacientes
                          {
                              IdPaciente=n.IdPaciente,
                              CodigoPaciente=n.CodigoPaciente,
                              IdComprobante=n.IdComprobante,
                              Comprobante=n.Comprobante,
                              Nombre=n.Nombre,
                              Telefono=n.Telefono,
                              MontoCredito=n.MontoCredito,
                              IdCentroSalud=n.IdCentroSalud,
                              CentroSalud=n.CentroSalud,
                              Sala=n.Sala,
                              IdMedico=n.IdMedico,
                              Medico=n.Medico,
                              IdTipoIdentificacion=n.IdTipoIdentificacion,
                              TipoIdentificaion=n.TipoIdentificaion,
                              NumeroIdentificacion=n.NumeroIdentificacion,
                              Direccion=n.Direccion,
                              IdSexo=n.IdSexo,
                              Sexo=n.Sexo,
                              Email=n.Email,
                              Comentario=n.Comentario,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE PACIENTES
        public Entidades.EntidadEmpresa.EPacientes MantenimientoPacientes(Entidades.EntidadEmpresa.EPacientes Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EPacientes Mantenimiento = null;

            var Paciente = ObjData.SP_MANTENIMIENTO_PACIENTES(
                Item.IdPaciente,
                Item.CodigoPaciente,
                Item.IdComprobante,
                Item.Nombre,
                Item.Telefono,
                Item.IdCentroSalud,
                Item.Sala,
                Item.IdMedico,
                Item.IdTipoIdentificacion,
                Item.TipoIdentificaion,
                Item.Direccion,
                Item.IdSexo,
                Item.Email,
                Item.Comentario,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.MontoCredito,
                Accion);
            if (Paciente != null)
            {
                Mantenimiento = (from n in Paciente
                                 select new Entidades.EntidadEmpresa.EPacientes
                                 {
                                     IdPaciente=n.IdPaciente,
                                     CodigoPaciente=n.CodigoPaciente,
                                     IdComprobante=n.IdComprobante,
                                     Nombre=n.Nombre,
                                     Telefono=n.Telefono,
                                     IdCentroSalud=n.IdCentroSalud,
                                     Sala=n.Sala,
                                     IdMedico=n.IdMedico,
                                     IdTipoIdentificacion=n.IdTipoIdentificacion,
                                     TipoIdentificaion=n.TipoIdentificacion,
                                     Direccion=n.Direccion,
                                     IdSexo=n.IdSexo,
                                     Email=n.Email,
                                     Comentario=n.Comentario,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica,
                                     MontoCredito=n.MontoCredito
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE ASISTENTE DE CIRUGIA
        //LISTADO DE ASISTENTE DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia> BuscaAsistenteCirugia(decimal? IdAsistenteCirugia = null, string CodigoAsistenteCirugia = null, string Nombre = null, int? NumeroPaina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_ASISTENTE_CIRUGIA(IdAsistenteCirugia, CodigoAsistenteCirugia, Nombre, NumeroPaina, NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia
                          {
                              IdAsistenteCirugia=n.IdAsistenteCirugia,
                              CodigoAsistenteCirugia=n.CodigoAsistenteCirugia,
                              Nombre=n.Nombre,
                              TipoIdentificacion=n.TipoIdentificacion,
                              NumeroIdentificacion=n.NumeroIdentificacion,
                              Telefono=n.Telefono,
                              Direccion=n.Direccion,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE ASISTENTE DE CIRUGIA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia MantenimeintoAsistenteCirugia(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia Mantenimiento = null;

            var AsistenteCirugia = ObjData.SP_MANTENIMIENTO_ASISTENTE_CIRUGIA(
                Item.IdAsistenteCirugia,
                Item.CodigoAsistenteCirugia,
                Item.Nombre,
                Item.TipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Telefono,
                Item.Direccion,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Accion);
            if (AsistenteCirugia != null)
            {
                Mantenimiento = (from n in AsistenteCirugia
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia
                                 {
                                     IdAsistenteCirugia=n.IdAsistenteCirugia,
                                     CodigoAsistenteCirugia=n.CodigoAsistenteCirugia,
                                     Nombre=n.Nombre,
                                     TipoIdentificacion=n.TipoIdentificacion,
                                     NumeroIdentificacion=n.NumeroIdentificacion,
                                     Telefono=n.Telefono,
                                     Direccion=n.Direccion,
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

        #region MANTENIMEINTO DE MONTO CREDITO GENERICO
        //GENERAR MONTO CREDITO GENERICO
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico> GenerarMontoCreditoGenerico(decimal? IdMontoCredito = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Generar = (from n in ObjData.SP_GENERAR_MONTO_CREDITO_GENERICO(IdMontoCredito)
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico
                           {
                               IdMontoCreditoGenerico=n.IdMontoCreditoGenerico,
                               MontoCredito=n.MontoCredito
                           }).ToList();
            return Generar;
        }
        //MANTENIMIENTO DE MONTO CREDITO GENBERICO
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico ModificarMontoCreditoGenerico(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico Modificar = null;

            var MontoCreditoGenerico = ObjData.SP_MODIFICAR_MONTO_CREDITO_GENERICO(
                Item.IdMontoCreditoGenerico,
                Item.MontoCredito,
                Accion);
            if (MontoCreditoGenerico != null)
            {
                Modificar = (from n in MontoCreditoGenerico
                             select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMontoCreditoGenerico
                             {
                                 IdMontoCreditoGenerico=n.IdMontoCreditoGenerico,
                                 MontoCredito=n.MontoCredito
                             }).FirstOrDefault();
            }
            return Modificar;
        }
        #endregion

        #region MANTENIMIENTO DE CLIENTES
        //LISTADO DE CLIENTES
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes> BuscaClientes(decimal? IdCliente = null, string NombreCliente = null, string RNC = null,int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_CLIENTES(IdCliente, NombreCliente, RNC,NumeroPagina,NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes
                          {
                              IdCliente=n.IdCliente,
                              IdComprobante=n.IdComprobante,
                              Nombre=n.Nombre,
                              MontoCredito=n.MontoCredito,
                              TipoComprobante=n.TipoComprobante,
                              Telefono=n.Telefono,
                              IdTipoIdentificacion=n.IdTipoIdentificacion,
                              TipoIdentificacion=n.TipoIdentificacion,
                              RNC=n.RNC,
                              Direccion=n.Direccion,
                              Email=n.Email,
                              Comentario=n.Comentario,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona=n.FechaAdiciona,
                              FechaCreado=n.FechaCreado,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica=n.FechaModifica,
                              FechaModificado=n.FechaModificado
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE CLIENTES
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes MantenimientoClientes(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes Mantenimiento = null;

            var Clientes = ObjData.SP_MANTENIMIENTO_CLIENTES(
                Item.IdCliente,
                Item.IdComprobante,
                Item.Nombre,
                Item.Telefono,
                Item.IdTipoIdentificacion,
                Item.RNC,
                Item.Direccion,
                Item.Email,
                Item.Comentario,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.MontoCredito,
                Accion);
            if (Clientes != null)
            {
                Mantenimiento = (from n in Clientes
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes
                                 {
                                     IdCliente = n.IdCliente,
                                     IdComprobante = n.IdComprobante,
                                     Nombre = n.Nombre,
                                     Telefono = n.Telefono,
                                     IdTipoIdentificacion = n.IdTipoIdentificacion,
                                     RNC = n.RNC,
                                     Direccion = n.Direccion,
                                     Email = n.Email,
                                     Comentario = n.Comentario,
                                     Estatus0 = n.Estatus,
                                     UsuarioAdiciona = n.UsuarioAdiciona,
                                     FechaAdiciona = n.FechaAdiciona,
                                     UsuarioModifica = n.UsuarioModifica,
                                     FechaModifica = n.FechaModifica,
                                     MontoCredito = n.MontoCredito,
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
    }
}
