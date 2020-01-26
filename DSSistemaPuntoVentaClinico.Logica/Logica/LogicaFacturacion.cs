using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaFacturacion
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDFacturacionDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDFacturacionDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE TIPO DE PAGO
        //LISTADO DE TIPO DE PAGO
        public List<Entidades.EntidadFacturacion.ETipoPago> ListadoTipoPago(decimal? IdTipoPago = null, string CodigoTipoPago = null, string Descripcion = null, int? NumeroPagona = null, int? Numeroregistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_TIPO_PAGO(IdTipoPago, CodigoTipoPago, Descripcion, NumeroPagona, Numeroregistros)
                          select new Entidades.EntidadFacturacion.ETipoPago
                          {
                              IdTipoPago=n.IdTipoPago,
                              CodigoTipoPago=n.CodigoTipoPago,
                              TipoPago=n.TipoPago,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              BloqueaMontoPagar0=n.BloqueaMontoPagar0,
                              BloqueaMontoPagar=n.BloqueaMontoPagar,
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
        //MANTENIMIENTO DE TIPO DE PAGO
        public Entidades.EntidadFacturacion.ETipoPago MantenimientoTipoPago(Entidades.EntidadFacturacion.ETipoPago Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.ETipoPago Mantenimiento = null;

            var TipoPago = ObjData.SP_MANTENIMIENTO_TIPO_PAGO(
                Item.IdTipoPago,
                Item.CodigoTipoPago,
                Item.TipoPago,
                Item.Estatus0,
                Item.UsuarioAdiciona,
                Item.BloqueaMontoPagar0,
                Accion);
            if (TipoPago != null)
            {
                Mantenimiento = (from n in TipoPago
                                 select new Entidades.EntidadFacturacion.ETipoPago
                                 {
                                     IdTipoPago=n.IdTipoPago,
                                     CodigoTipoPago=n.CodigoTipoPago,
                                     TipoPago=n.Descripcion,
                                     Estatus0=n.Estatus,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica,
                                     BloqueaMontoPagar0=n.BloqueaMontoPagar
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region GUARDAR LOS DATOS DE LA FACTURACION
        //GUARDAR LOS DATOS DE LA FACTURACION
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes GuararFacturacionCliete(Entidades.EntidadFacturacion.EFacturacionClientes Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes Mantenimiento = new Entidades.EntidadFacturacion.EFacturacionClientes();

            var FacturacionCliente = ObjData.SP_GUARDAR_DATOS_FACTURACION_CLIENTE(
                Item.NumeroFactura,
                Item.IdEstatusFacturacion,
                Item.CodigoFacturacion,
                Item.NumeroConector,
                Item.IdTipoFacturacion,
                Item.NombrePaciente,
                Item.Telefono,
                Item.IdCentroSalud,
                Item.Sala,
                Item.IdMedico,
                Item.IdTipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Direccion,
                Item.IdSexo,
                Item.Email,
                Item.ComentarioPaciente,
                Item.FechaFacturacion,
                Item.IdUsuario,
                Accion);
            if (FacturacionCliente != null)
            {
                Mantenimiento = (from n in FacturacionCliente
                                 select new Entidades.EntidadFacturacion.EFacturacionClientes
                                 {
                                     NumeroFactura=n.NumeroFactura,
                                     IdEstatusFacturacion=n.IdEstatusFacturacion,
                                     CodigoFacturacion=n.CodigoFacturacion,
                                     NumeroConector=n.NumeroConector,
                                     IdTipoFacturacion=n.IdTipoFacturacion,
                                     NombrePaciente=n.NombrePaciente,
                                     Telefono=n.Telefono,
                                     IdCentroSalud=n.IdCentroSalud,
                                     Sala=n.Sala,
                                     IdMedico=n.IdMedico,
                                     IdTipoIdentificacion=n.IdTipoIdentificacion,
                                     NumeroIdentificacion=n.NumeroIdentificacion,
                                     Direccion=n.Direccion,
                                     IdSexo=n.IdSexo,
                                     Email=n.Email,
                                     ComentarioPaciente=n.ComentarioPaciente,
                                     FechaFacturacion=n.FechaFacturacion,
                                     IdUsuario=n.IdUsuario
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        //MOSTRAR LOS PRODUCTOS AGREGADOS
        public List<Entidades.EntidadFacturacion.EBuscarProductosAgregados> BuscarProductosAgregados(decimal? NumeroConector = null, decimal? Secuencial = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_PRODUCTOS_AGREGADOS_FACTURA(NumeroConector,Secuencial)
                          select new Entidades.EntidadFacturacion.EBuscarProductosAgregados
                          {
                                NumeroConector=n.NumeroConector
                              , IdProducto=n.IdProducto
                              , CodigoProducto=n.CodigoProducto
                              , Descripcion=n.Descripcion
                              , PrecioCompra=n.PrecioCompra
                              , Precio=n.Precio
                              , LlevaDescuento0=n.LlevaDescuento0
                              , _LlevaDescuento=n.LlevaDescuento
                              , PorcientoDescuento=n.PorcientoDescuento
                              , Cantidad=n.Cantidad
                              , DescuentoAplicado=n.DescuentoAplicado
                              , Total=n.Total
                              , Secuencial = n.Secuencial
                              , NumeroPago=n.NumeroPago
                          }).ToList();
            return Buscar;
        }

        //GUARDAR LOS DATOS DE LOS PRODUCTOS
        public Entidades.EntidadFacturacion.EFacturacionProductos GuardarFacturacionProductos(Entidades.EntidadFacturacion.EFacturacionProductos Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadFacturacion.EFacturacionProductos Guardar = null;

            var FactuacionProductos = ObjData.SP_GUARDAR_FACTURACION_PRODUCTO(
                Item.NumeroConector,
                Item.IdProducto,
                Item.Precio,
                Item.Cantidad,
                Item.DescuentoAplicado,
                Item.Total,
                Item.Secuencial,
                Item.NumeroPago,
                Accion);
            if (FactuacionProductos != null)
            {
                Guardar = (from n in FactuacionProductos
                           select new Entidades.EntidadFacturacion.EFacturacionProductos
                           {
                               NumeroConector=n.NumeroConector,
                               IdProducto=n.IdProducto,
                               Precio=n.Precio,
                               Cantidad=n.Cantidad,
                               DescuentoAplicado=n.DescuentoAplicado,
                               Total=n.Total,
                               Secuencial=n.Secuencial,
                               NumeroPago=n.NumeroPago
                           }).FirstOrDefault();
            }
            return Guardar;
        }

        //SACAR LOS CALCULOS DE LA FACTURACION
        public List<Entidades.EntidadFacturacion.ESacarCalculosFacturacion> SacarCalculosFacturacion(decimal? NumeroConector = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Sacar = (from n in ObjData.SP_SACAR_CALCULOS_FACTURACION(NumeroConector)
                         select new Entidades.EntidadFacturacion.ESacarCalculosFacturacion
                         {
                             CantidadArticulos=n.CantidadArticulos,
                             ToTalDescuento=n.ToTalDescuento,
                             Total=n.Total,
                             PorcientoAplicado=n.PorcientoAplicado,
                             Impuesto=n.Impuesto,
                             SubTotal=n.SubTotal,

                         }).ToList();
            return Sacar;
        }
        //GUARDAR LOS DATOS DE LA FACTURACION CALCULOS
        public Entidades.EntidadFacturacion.EFacturacionCalculos GuardarFacturacionCalculos(Entidades.EntidadFacturacion.EFacturacionCalculos Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadFacturacion.EFacturacionCalculos Mantenimiento = null;

            var FacturacionCalculos = ObjData.SP_GUARDAR_DATOS_FACTURACION_CALCULOS(
                Item.NumeroConector,
                Item.CantidadArticulos,
                Item.TotalDescuento,
                Item.Subtotal,
                Item.Impuesto,
                Item.Total,
                Item.IdTipoPago,
                Item.MontoPagado,
                Item.IdEstatusCirugia,
                Item.CirugiaProgramada,
                Item.TipoVenta,
                Item.IdCantidadDias,
                Item.CodigoPaciente,
                Item.Balance,
                Accion);
            if (FacturacionCalculos != null)
            {
                Mantenimiento = (from n in FacturacionCalculos
                                 select new Entidades.EntidadFacturacion.EFacturacionCalculos
                                 {
                                    NumeroConector=n.NumeroConector,
                                    CantidadArticulos=n.CantidadArticulos,
                                    TotalDescuento=n.TotalDescuento,
                                    Subtotal=n.Subtotal,
                                    Impuesto=n.Impuesto,
                                    Total=n.Total,
                                    IdTipoPago=n.IdTipoPago,
                                    MontoPagado=n.MontoPagado,
                                    IdEstatusCirugia=n.IdEstatusCirugia,
                                    CirugiaProgramada=n.CirugiaProgramada,
                                    TipoVenta=n.TipoVenta,
                                    IdCantidadDias=n.IdCantidadDias,
                                    CodigoPaciente=n.CodigoPaciente,
                                    Balance=n.Balance
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region MANTENIMIENTO DE LOS DATOS DE LA FACTURACION DE EMPRESA

        //BUSCAR LOS DATOS DE LA FACTURACION ESPEJO
        public List<Entidades.EntidadFacturacion.EBuscaDatosFacturacionEspejo> BuscaDatosFacturacionEspejo(decimal? NumeroConector = null, decimal? IdUsuario = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_DATOS_FACTURACION_ESPEJO(NumeroConector, IdUsuario)
                          select new Entidades.EntidadFacturacion.EBuscaDatosFacturacionEspejo
                          {
                              NumeroConector=n.NumeroConector,
                              IdUsuario=n.IdUsuario,
                              Usuario= n.Usuario,
                              IdTipoFacturacion=n.IdTipoFacturacion,
                              TipoFacturacion=n.TipoFacturacion,
                              NombrePaciente=n.NombrePaciente,
                              Telefono=n.Telefono,
                              IdCentroSalud=n.IdCentroSalud,
                              CentroSalud=n.CentroSalud,
                              Sala=n.Sala,
                              IdMedico=n.IdMedico,
                              Medico=n.Medico,
                              IdTipoIdentificacion=n.IdTipoIdentificacion,
                              TipoIdentificacion=n.TipoIdentificacion,
                              NumeroIdentificacion=n.NumeroIdentificacion,
                              Direccion=n.Direccion,
                              IdSexo=n.IdSexo,
                              Sexo=n.Sexo,
                              Email=n.Email,
                              Comentario=n.Comentario,
                              GuardarCliente=n.GuardarCliente,
                              TipoProceso=n.TipoProceso,
                              IdTipoPago=n.IdTipoPago,
                              TipoPago=n.TipoPago,
                              IdEstatusirugia=n.IdEstatusirugia,
                              EstatusCirugia=n.EstatusCirugia,
                              IdTipoVenta=n.IdTipoVenta,
                              TipoVenta=n.TipoVenta,
                              IdCantidadDias=n.IdCantidadDias,
                              CantidadDias=n.CantidadDias,
                              CodigoPaciente=n.CodigoPaciente
                          }).ToList();
            return Buscar;
        }
        //MANTENIMIENTO DE LOS DATOS DE LA FACTURACION DE LA EMPRESA
        public Entidades.EntidadFacturacion.EDatosFacturacionEspejo MantenimientoDatosFacturacionEspejo(Entidades.EntidadFacturacion.EDatosFacturacionEspejo Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadFacturacion.EDatosFacturacionEspejo Mantenimiento = null;

            var DatosFacturacionEspejo = ObjData.SP_MANTENIMIENTO_DATOS_FACTURACION_ESPEJO(
                Item.NumeroConector,
                Item.IdUsuario,
                Item.IdTipoFacturacion,
                Item.NombrePaciente,
                Item.Telefono,
                Item.IdCentroSalud,
                Item.Sala,
                Item.IdMedico,
                Item.IdTipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.Direccion,
                Item.IdSexo,
                Item.Email,
                Item.Comentario,
                Item.GuardarCliente,
                Item.TipoProceso,
                Item.IdTipoPago,
                Item.IdEstatusirugia,
                Item.IdTipoVenta,
                Item.IdCantidadDias,
                Item.CodigoPaciente,
                Accion);
            if (DatosFacturacionEspejo != null)
            {
                Mantenimiento = (from n in DatosFacturacionEspejo
                                 select new Entidades.EntidadFacturacion.EDatosFacturacionEspejo
                                 {
                                     NumeroConector=n.NumeroConector,
                                     IdUsuario=n.IdUsuario,
                                     IdTipoFacturacion=n.IdTipoFacturacion,
                                     NombrePaciente=n.NombrePaciente,
                                     Telefono=n.Telefono,
                                     IdCentroSalud=n.IdCentroSalud,
                                     Sala=n.Sala,
                                     IdMedico=n.IdMedico,
                                     IdTipoIdentificacion=n.IdTipoIdentificacion,
                                     NumeroIdentificacion=n.NumeroIdentificacion,
                                     Direccion=n.Direccion,
                                     IdSexo=n.IdSexo,
                                     Email=n.Email,
                                     Comentario=n.Comentario,
                                     GuardarCliente=n.GuardarCliente,
                                     TipoProceso=n.TipoProceso,
                                     IdTipoPago=n.IdTipoPago,
                                     IdEstatusirugia=n.IdEstatusirugia,
                                     IdTipoVenta=n.IdTipoVenta,
                                     IdCantidadDias=n.IdCantidadDias,
                                     CodigoPaciente=n.CodigoPaciente
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion

        #region GUARDAR LA FACTURACION COMPROBANTE
        public Entidades.EntidadFacturacion.EGuardarFacturacionComprobante GuardarFacturacionComprobante(Entidades.EntidadFacturacion.EGuardarFacturacionComprobante Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGuardarFacturacionComprobante Guardar = null;

            var FacturacionComprobante = ObjData.SP_GUARDAR_FACTURACION_COMPROBANTES(
                Item.IdFacturacion,
                Item.CodigoFacturacion,
                Item.NumeroConector,
                Item.TipoComprobante,
                Item.Comprobante,
                Accion);
            if (FacturacionComprobante != null)
            {
                Guardar = (from n in FacturacionComprobante
                           select new Entidades.EntidadFacturacion.EGuardarFacturacionComprobante
                           {
                               IdFacturacion=n.IdFacturacion,
                               CodigoFacturacion=n.CodigoFacturacion,
                               NumeroConector=n.NumeroConector,
                               TipoComprobante=n.TipoComprobante,
                               Comprobante=n.Comprobante
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion

        #region MANTENIMEINTO DE PROGRAMACION DE CIRUGIA
        //LISTADO DE PROGRAMACION DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EBuscaProgramacionirugia> BuscaProgramacionCirugia(decimal? IdProgramacionCirugia = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, decimal? IdCentroSalud = null, decimal? IdMedico = null, decimal? IdEstatusCirugia = null, decimal? NumeroFactura = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_PROGRAMACION_CIRUGIA(IdProgramacionCirugia, FechaDesde, FechaHasta, IdCentroSalud, IdMedico, IdEstatusCirugia, NumeroFactura, NumeroPagina, NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EBuscaProgramacionirugia
                          {
                              IdProgramacionCirugia=n.IdProgramacionCirugia,
                              FechaCirugia0=n.FechaCirugia0,
                              FechaCirugia=n.FechaCirugia,
                              IdCentroSalud=n.IdCentroSalud,
                              CentroSalud=n.CentroSalud,
                              IdMedico=n.IdMedico,
                              NombreMedico=n.NombreMedico,
                              IdAuxiliarCirugia=n.IdAuxiliarCirugia,
                              AuxiliarCirugia=n.AuxiliarCirugia,
                              IdHoraCirugia=n.IdHoraCirugia,
                              Hora=n.Hora,
                              IdEstatusCirugia=n.IdEstatusCirugia,
                              Estatus=n.Estatus,
                              NoFactura=n.NoFactura,
                              NoReferencia=n.NoReferencia,
                              UsuarioAdiciona=n.UsuarioAdiciona,
                              CreadoPor=n.CreadoPor,
                              FechaAdiciona0=n.FechaAdiciona0,
                              FechaAdiciona=n.FechaAdiciona,
                              UsuarioModifica=n.UsuarioModifica,
                              ModificadoPor=n.ModificadoPor,
                              FechaModifica0=n.FechaModifica0,
                              FechaModifica=n.FechaModifica,
                              IdTipoFacturacion=n.IdTipoFacturacion,
                              TipoComprobante=n.TipoComprobante,
                              Comprobante=n.Comprobante,
                              Paciente=n.Paciente,
                              Telefono=n.Telefono,
                              IdCentroSaludAnterior=n.IdCentroSaludAnterior,
                              Sala=n.Sala,
                              IdMedicoAnterior=n.IdMedicoAnterior,
                              IdTipoIdentificacion=n.IdTipoIdentificacion,
                              NumeroIdentificacion=n.NumeroIdentificacion,
                              Direccion=n.Direccion,
                              IdSexo=n.IdSexo,
                              Email=n.Email,
                              ComentarioPaciente=n.ComentarioPaciente,
                              FechaFacturacion0=n.FechaFacturacion0,
                              FechaFacturacion=n.FechaFacturacion,
                              IdUsuario=n.IdUsuario,
                              Comentario=n.Comentario
                          }).ToList();
            return Buscar;
        }

        //MANTENIMEINTO DE PROGRAMACION DE CIRUGIA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia MantenimientoProgramacionCirugia(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia Mantenimiento = null;

            var ProgramacionCirugia = ObjData.SP_MANTENIMIENTO_PROGRAMACION_CIRUGIA(
                Item.IdProgramacionCirugia,
                Item.FechaCirugia,
                Item.IdCentroSalud,
                Item.IdMedico,
                Item.IdAuxiliarCirugia,
                Item.IdHoraCirugia,
                Item.IdEstatusCirugia,
                Item.NoFactura,
                Item.NoReferencia,
                Item.UsuarioAdiciona,
                Item.Comentario,
                Accion);
            if (ProgramacionCirugia != null)
            {
                Mantenimiento = (from n in ProgramacionCirugia
                                 select new Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia
                                 {
                                     IdProgramacionCirugia=n.IdProgramacionCirugia,
                                     FechaCirugia=n.FechaCirugia,
                                     IdCentroSalud=n.IdCentroSalud,
                                     IdMedico=n.IdMedico,
                                     IdAuxiliarCirugia=n.IdAuxiliarCirugia,
                                     IdHoraCirugia=n.IdHoraCirugia,
                                     IdEstatusCirugia=n.IdEstatusCirugia,
                                     NoFactura=n.NoFactura,
                                     NoReferencia=n.NoReferencia,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica=n.FechaModifica,
                                     Comentario=n.Comentario
                                 }).FirstOrDefault();
            }
            return Mantenimiento = null;
        }
        #endregion

        #region MANTENIMIENTO DE GASTOS DE CIRUGIA
        //LISTADO DE GASTOS DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia> BuscaGastoCirugia(decimal? IdGastosCirugia = null, decimal? IdProgramacionCirugia = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_GASTOS_CIRUGIA(IdGastosCirugia, IdProgramacionCirugia, NumeroPagina, NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia
                          {
                              IdGastosCirugia=n.IdGastosCirugia,
                              IdProgramacionCirugia=n.IdProgramacionCirugia,
                              Descripcion=n.Descripcion,
                              Cantidad=n.Cantidad,
                              Comentario=n.Comentario
                          }).ToList();
            return Buscar;
        }

        //MANTENIMIENTO DE GASTOS DE CIRUGIA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia MantenimientoGastosCirugia(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia Mantenimiento = null;

            var GastoCirugia = ObjData.SP_MANTENIMIENTO_GASTOS_CIRUGIA(
                Item.IdGastosCirugia,
                Item.IdProgramacionCirugia,
                Item.Descripcion,
                Item.Cantidad,
                Item.Comentario,
                Accion);
            if (GastoCirugia != null)
            {
                Mantenimiento = (from n in GastoCirugia
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGastosCirugia
                                 {
                                     IdGastosCirugia=n.IdGastosCirugia,
                                     IdProgramacionCirugia=n.IdProgramacionCirugia,
                                     Descripcion=n.Descripcion,
                                     Cantidad=n.Cantidad,
                                     Comentario=n.Comentario
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion


    }
}
