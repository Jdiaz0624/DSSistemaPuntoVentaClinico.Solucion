using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaHistorial
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDHistorialDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDHistorialDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region HISTORIAL DE FACTURACION Y COTIZACION
        public List<Entidades.EntidadHistorial.EHistorialFacturacionCotizacion> HistorialFacturacionCotizacion(decimal? NumeroFactura = null, decimal? NumeroConector = null, string NombrePaciente = null, decimal? IdEstatusFacturacion = null, string CodigoFacturacion = null, decimal? IdTipoFacturacion = null, decimal? IdCentroSalud = null, decimal? IdMedico = null, decimal? IdTipoPago = null, DateTime? FechaFacturacionDesde = null, DateTime? FechaFacturacionHasta = null,decimal? IdEstatusCirugia = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Historial = (from n in ObjData.SP_HISTORIAL_FACTURACION_COTIZACION(NumeroFactura, NumeroConector, NombrePaciente, IdEstatusFacturacion, CodigoFacturacion, IdTipoFacturacion, IdCentroSalud, IdMedico, IdTipoPago, FechaFacturacionDesde, FechaFacturacionHasta,IdEstatusCirugia, NumeroPagina, NumeroRegistros)
                             select new Entidades.EntidadHistorial.EHistorialFacturacionCotizacion
                             {
                                 NumeroFactura = n.NumeroFactura,
                                 NombrePaciente =n.NombrePaciente,
                                 IdTipoIdentificacion =n.IdTipoIdentificacion,
                                 TipoIdentificacion =n.TipoIdentificacion,
                                 NumeroIdentificacion =n.NumeroIdentificacion,
                                 IdEstatusFacturacion=n.IdEstatusFacturacion,
                                 Estatus =n.Estatus,
                                 CodigoFacturacion=n.CodigoFacturacion,
                                 NumeroConector=n.NumeroConector,
                                 IdTipoFacturacion =n.IdTipoFacturacion,
                                 TipoComprobante=n.TipoComprobante,
                                 ValidoHasta=n.ValidoHasta,
                                 Comprobante=n.Comprobante,
                                 Telefono=n.Telefono,
                                 IdCentroSalud=n.IdCentroSalud,
                                 CentroSalud=n.CentroSalud,
                                 Sala=n.Sala,
                                 IdMedico=n.IdMedico,
                                 Medico=n.Medico,
                                 Direccion=n.Direccion,
                                 IdSexo=n.IdSexo,
                                 Sexo=n.Sexo,
                                 Email=n.Email,
                                 ComentarioPaciente=n.ComentarioPaciente,
                                 FechaFacturacion0=n.FechaFacturacion0,
                                 FechaFacturacion=n.FechaFacturacion,
                                 FechaVencimiento0=n.FechaVencimiento0,
                                 FechaVencimiento=n.FechaVencimiento,
                                 CantidadDias=n.CantidadDias,
                                 DiasDiferencia=n.DiasDiferencia,
                                 EstatusDias=n.EstatusDias,
                                 IdUsuario=n.IdUsuario,
                                 Creadopor=n.Creadopor,
                                 IdProducto=n.IdProducto,
                                 TipoProducto=n.TipoProducto,
                                 ProDucto=n.ProDucto,
                                 Cantidad=n.Cantidad,
                                 Precio=n.Precio,
                                 DescuentoAplicado=n.DescuentoAplicado,
                                 Total=n.Total,
                                 CantidadArticulos=n.CantidadArticulos,
                                 TotalDescuento=n.TotalDescuento,
                                 Subtotal=n.Subtotal,
                                 Impuesto=n.Impuesto,
                                 TotalGeneral=n.TotalGeneral,
                                 IdTipoPago=n.IdTipoPago,
                                 TipoPago=n.TipoPago,
                                 MontoPagado=n.MontoPagado,
                                 IdEstatusCirugia=n.IdEstatusCirugia,
                                 EstatusCirugia=n.EstatusCirugia,
                                 CirugiaProgramada0=n.CirugiaProgramada0,
                                 CirugiaProgramada=n.CirugiaProgramada,
                                 TipoVenta0=n.TipoVenta0,
                                 TipoVenta01=n.TipoVenta01,
                                 TipoVenta=n.TipoVenta,
                                 IdCantidadias=n.IdCantidadias,
                                 CodigoPaciente=n.CodigoPaciente,
                                 Nombre=n.Nombre,
                                 Balance=n.Balance,
                                 Paciente=n.Paciente,
                                 CedulaPaciente=n.CedulaPaciente

                             }).ToList();
            return Historial;
        }
        #endregion
        #region MANTENIMIENTO DE LA RUTA DE REPORTE
        //LISTADO DE RUTA DE REPORTE
        public List<Entidades.EntidadReporte.ERutaReporte> SacarRutaReporte(decimal? IdReporte = null)
        {
            ObjData.CommandTimeout = 999999999;

            var SacarRuta = (from n in ObjData.SP_SACAR_RUTA_REPORTE(IdReporte)
                             select new Entidades.EntidadReporte.ERutaReporte
                             {
                                 IdReporte=n.IdReporte,
                                 DescripcionReporte=n.DescripcionReporte,
                                 RutaReporte=n.RutaReporte
                             }).ToList();
            return SacarRuta;
        }
        //MATENIMIENTO DE RUTA DE REPORTE
        public Entidades.EntidadReporte.EMantenimientoRutaReporte MantenimientoRutaReporte(Entidades.EntidadReporte.EMantenimientoRutaReporte Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EMantenimientoRutaReporte Mantenimiento = null;

            var RutaReporte = ObjData.SP_MANTENIMIENTO_RUTA_REPORTES(
                Item.IdReporte,
                Item.DescripcionReporte,
                Item.RutaReporte,
                Accion);
            if (RutaReporte != null)
            {
                Mantenimiento = (from n in RutaReporte
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EMantenimientoRutaReporte
                                 {
                                     IdReporte = n.IdReporte,
                                     DescripcionReporte = n.DescripcionReporte,
                                     RutaReporte = n.RutaReporte
                                 }).FirstOrDefault();
            }
            return Mantenimiento;


        }
        #endregion
        #region MANTENIMIENTO DE HISTORIAL DE FACTURACION COTIZACION
        public Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion MantenimientoHistorialFacturacionCotizacion(Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion Mantenimiento = null;

            var Historial = ObjData.SP_MANTENIMIENTO_HISTORIAL_FACTURACION_COTIZACION(
                Item.IdUsuario,
                Item.NumeroFactura,
                Item.NombrePaciente,
                Item.IdTipoIdentificacion,
                Item.TipoIdentificacion,
                Item.NumeroIdentificacion,
                Item.IdEstatusFacturacion,
                Item.Estatus,
                Item.CodigoFacturacion,
                Item.NumeroConector,
                Item.IdTipoFacturacion,
                Item.TipoComprobante,
                Item.ValidoHasta,
                Item.Comprobante,
                Item.Telefono,
                Item.IdCentroSalud,
                Item.CentroSalud,
                Item.Sala,
                Item.IdMedico,
                Item.Medico,
                Item.Direccion,
                Item.IdSexo,
                Item.Sexo,
                Item.Email,
                Item.ComentarioPaciente,
                Item.FechaFacturacion0,
                Item.FechaFacturacion,
                Item.IdUsuarioCrea,
                Item.Creadopor,
                Item.IdProducto,
                Item.TipoProducto,
                Item.ProDucto,
                Item.Cantidad,
                Item.Precio,
                Item.DescuentoAplicado,
                Item.Total,
                Item.CantidadArticulos,
                Item.TotalDescuento,
                Item.Subtotal,
                Item.Impuesto,
                Item.TotalGeneral,
                Item.IdTipoPago,
                Item.TipoPago,
                Item.MontoPagado,
                Accion);
            if (Historial != null)
            {
                Mantenimiento = (from n in Historial
                                 select new Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion
                                 {
                                        IdUsuario =n.IdUsuario,
                                        NumeroFactura = n.NumeroFactura,
                                        NombrePaciente = n.NombrePaciente,
                                        IdTipoIdentificacion = n.IdTipoIdentificacion,
                                        TipoIdentificacion = n.TipoIdentificacion,
                                        NumeroIdentificacion = n.NumeroIdentificacion,
                                        IdEstatusFacturacion = n.IdEstatusFacturacion,
                                        Estatus = n.Estatus,
                                        CodigoFacturacion = n.CodigoFacturacion,
                                        NumeroConector = n.NumeroConector,
                                        IdTipoFacturacion = n.IdTipoFacturacion,
                                        TipoComprobante = n.TipoComprobante,
                                        ValidoHasta = n.ValidoHasta,
                                        Comprobante = n.Comprobante,
                                        Telefono = n.Telefono,
                                        IdCentroSalud = n.IdCentroSalud,
                                        CentroSalud = n.CentroSalud,
                                        Sala = n.Sala,
                                        IdMedico = n.IdMedico,
                                        Medico = n.Medico,
                                        Direccion = n.Direccion,
                                        IdSexo = n.IdSexo,
                                        Sexo = n.Sexo,
                                        Email = n.Email,
                                        ComentarioPaciente = n.ComentarioPaciente,
                                        FechaFacturacion0 = n.FechaFacturacion0,
                                        FechaFacturacion = n.FechaFacturacion,
                                        IdUsuarioCrea = n.IdUsuarioCrea,
                                        Creadopor = n.Creadopor,
                                        IdProducto = n.IdProducto,
                                        TipoProducto = n.TipoProducto,
                                        ProDucto = n.ProDucto,
                                        Cantidad = n.Cantidad,
                                        Precio = n.Precio,
                                        DescuentoAplicado = n.DescuentoAplicado,
                                        Total = n.Total,
                                        CantidadArticulos = n.CantidadArticulos,
                                        TotalDescuento = n.TotalDescuento,
                                        Subtotal = n.Subtotal,
                                        Impuesto = n.Impuesto,
                                        TotalGeneral = n.TotalGeneral,
                                        IdTipoPago = n.IdTipoPago,
                                        TipoPago = n.TipoPago,
                                        MontoPagado = n.MontoPagado
                                 }).FirstOrDefault(); 
            }
            return Mantenimiento;
        }
        public List<Entidades.EntidadHistorial.EMontoFacturacionCotizacion> MontoFacturacionCotizacion(decimal? NumeroConector = null)
        {
            ObjData.CommandTimeout = 999999999;
         
            var Buscar = (from n in ObjData.SP_MONTO_FACTURACION_COTIZACION(NumeroConector)
                          select new Entidades.EntidadHistorial.EMontoFacturacionCotizacion
                          {
                              Total = n.Total
                      }).ToList();
            return Buscar;
        }
        #endregion
        #region MANTENIMIENTO DE CUADRE DE CAJA
        //MANTENIMIENT DE CUADRE DE CAJA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja CuadreCaja(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Mantenimiento = null;

            var CuadreCaja = ObjData.SP_MANTENIMIENTO_CUADRE_CAJA(
                Item.IdUsuario,
                Item.Caja,
                Item.CantidadFacturado,
                Item.Anuladas,
                Item.TotalCantidadFacturado,
                Item.CantidadCotizaciones,
                Item.CantidadCirugiasProgramadas,
                Item.Monto,
                Item.Concepto,
                Item.Fecha,
                Item.CreadoPor,
                Item.NumeroReferencia,
                Item.TipoPago,
                Item.FechaDesde,
                Item.FechaHasta,
                Accion);
            if (CuadreCaja != null)
            {
                Mantenimiento = (from n in CuadreCaja
                                 select new Entidades.EntidadReporte.ECuadreCaja
                                 {
                                     IdUsuario=n.IdUsuario,
                                     Caja=n.Caja,
                                     CantidadFacturado=n.CantidadFacturado,
                                     Anuladas=n.Anuladas,
                                     TotalCantidadFacturado=n.TotalCantidadFacturado,
                                     CantidadCotizaciones=n.CantidadCotizaciones,
                                     CantidadCirugiasProgramadas=n.CantidadCirugiasProgramadas,
                                     Monto =n.Monto,
                                     Concepto=n.Concepto,
                                     Fecha=n.Fecha,
                                     CreadoPor=n.CreadoPor,
                                     NumeroReferencia=n.NumeroReferencia,
                                     TipoPago=n.TipoPago,
                                     FechaDesde=n.FechaDesde,
                                     FechaHasta=n.FechaHasta
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE REPORTES
        //REPORTE DE PRODUCTOS 
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte MantenimientoReporteProducto(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte Mantenimiento = null;

            var Producto = ObjData.SP_MANTENIMIENTO_REPORTE_PRODUCTO(
                Item.IdUsuarioImprime,
                Item.IdProducto,
                Item.CodigoProducto,
                Item.Almacen,
                Item.TipoProveedor,
                Item.Proveedor,
                Item.TipoEmpaque,
                Item.TipoProducto,
                Item.Producto,
                Item.Estatus,
                Item.CantidadAlmacen,
                Item.PrecioCompra,
                Item.PrecioVenta,
                Item.SegundoPrecio,
                Item.TercerPrecio,
                Item.FechaEntrada,
                Item.LlevaDescuento,
                Item.PorcientoDescuento,
                Item.CreadoPor,
                Item.FechaAdiciona,
                Item.ModificadoPor,
                Item.FechaModifica,
                Accion);
            if (Producto != null)
            {
                Mantenimiento = (from n in Producto
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte
                                 {
                                     IdUsuarioImprime =n.IdUsuarioImprime,
                                     IdProducto = n.IdProducto,
                                     CodigoProducto = n.CodigoProducto,
                                     Almacen = n.Almacen,
                                     TipoProveedor = n.TipoProveedor,
                                     Proveedor = n.Proveedor,
                                     TipoEmpaque = n.TipoEmpaque,
                                     TipoProducto = n.TipoProducto,
                                     Producto = n.Producto,
                                     Estatus = n.Estatus,
                                     CantidadAlmacen = n.CantidadAlmacen,
                                     PrecioCompra = n.PrecioCompra,
                                     PrecioVenta = n.PrecioVenta,
                                     SegundoPrecio = n.SegundoPrecio,
                                     TercerPrecio = n.TercerPrecio,
                                     FechaEntrada = n.FechaEntrada,
                                     LlevaDescuento = n.LlevaDescuento,
                                     PorcientoDescuento = n.PorcientoDescuento,
                                     CreadoPor = n.CreadoPor,
                                     FechaAdiciona = n.FechaAdiciona,
                                     ModificadoPor = n.ModificadoPor,
                                     FechaModifica = n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }

        #endregion
        #region MANTENIMEINTO DE FACTURACION DE CIRUGIA
        //SACAR LOS DATOS DE LA FACTURACION DE CIRUGIA
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EMantenimientoFacturacionCirugia> SacarDatosFacturacionCirugia(DateTime? FechaDesde = null, DateTime? FechaHasta = null, bool? CirugiaProgramada = null)
        {
            ObjData.CommandTimeout = 999999999;

            var SacarDatos = (from n in ObjData.SP_SACAR_DATOS_FACTURACION_CIRUGIA(FechaDesde, FechaHasta, CirugiaProgramada)
                              select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EMantenimientoFacturacionCirugia
                              {
                                  NumeroFactura=n.NumeroFactura,
                                  NumeroConector=n.NumeroConector,
                                  FechaFacturacion=n.FechaFacturacion,
                                  CirugiaProgramada=n.CirugiaProgramada
                              }).ToList();
            return SacarDatos;
        }
        //MANTENIMIENTO DE CIRUGIA PROGRAMADA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia MantenimientoFacturacionCirugia(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia Mantenimiento = null;

            var ReporteProgramacionCirugia = ObjData.SP_MANTENIMIENTO_FACTURACION_CIRUGIA(
                Item.IdUsuarioImprime,
                Item.NumeroFactura,
                Accion);
            if (ReporteProgramacionCirugia != null)
            {
                Mantenimiento = (from n in ReporteProgramacionCirugia
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EProcesarMantenimientoProgramacionCirugia
                                 {
                                     IdUsuarioImprime=n.IdUsuarioImprime,
                                     NumeroFactura=n.NumeroFactura
                                 }).FirstOrDefault();
               
            }
            return Mantenimiento;
        }
        #endregion
        #region GUARDAR HISTORIAL DE PAGOS
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos GuardarHistorialPagos(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos Guardar = null;

            var HistorialPagos = ObjData.SP_GUARDAR_HISTORIAL_PAGOS(
                Item.IdUsuario,
                Item.NumeroRecibo,
                Item.NumeroFactura,
                Item.FechaPago,
                Item.MontoFactura,
                Item.MontoPagado,
                Item.Balance,
                Item.Concepto,
                Item.TipoPago,
                Item.CreadoPor,
                Accion);
            if (HistorialPagos != null)
            {
                Guardar = (from n in HistorialPagos
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos
                           {
                               IdUsuario=n.IdUsuario,
                               NumeroRecibo=n.NumeroRecibo,
                               NumeroFactura=n.NumeroFactura,
                               FechaPago=n.FechaPago,
                               MontoFactura=n.MontoFactura,
                               MontoPagado=n.MontoPagado,
                               Balance=n.Balance,
                               Concepto=n.Concepto,
                               TipoPago=n.TipoPago,
                               CreadoPor=n.CreadoPor
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion
        #region GUARDAR HISTORIAL DE REPORTE DE VENTAS
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas GuardarReporteVentas(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas Guardar = null;

            var ReporteVentas = ObjData.SP_GUARDAR_REPORTE_VENTAS(
                Item.IdUsuario,
                Item.NumeroFactura,
                Item.NombrePaciente,
                Item.TipoIdentificacion,
                Item.Numeroidentificacion,
                Item.Estatus,
                Item.TipoComprobante,
                Item.Telefono,
                Item.CentroSalud,
                Item.Sala,
                Item.Medico,
                Item.Direccion,
                Item.Sexo,
                Item.Email,
                Item.ComentarioPaciente,
                Item.FechaFacturacion,
                Item.FechaVencimiento,
                Item.CantidadDias,
                Item.DiasDiferencia,
                Item.EstatusDias,
                Item.CreadoPor,
                Item.TipoProducto,
                Item.Producto,
                Item.Cantidad,
                Item.Precio,
                Item.DescuentoAplicado,
                Item.Total,
                Item.TotalDescuento,
                Item.SubTotal,
                Item.Impuesto,
                Item.TotalGeneral,
                Item.TipoPago,
                Item.MontoPagado,
                Item.EstatusCirugia,
                Item.TipoVenta,
                Item.Balance,
                Accion);
            if (ReporteVentas != null)
            {
                Guardar = (from n in ReporteVentas
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadHistorial.EGuardarReporteVentas
                           {
                               IdUsuario=n.IdUsuario,
                               NumeroFactura=n.NumeroFactura,
                               NombrePaciente=n.NombrePaciente,
                               TipoIdentificacion=n.TipoIdentificacion,
                               Numeroidentificacion=n.Numeroidentificacion,
                               Estatus=n.Estatus,
                               TipoComprobante=n.TipoComprobante,
                               Telefono=n.Telefono,
                               CentroSalud=n.CentroSalud,
                               Sala=n.Sala,
                               Medico=n.Medico,
                               Direccion=n.Direccion,
                               Sexo=n.Sexo,
                               Email=n.Email,
                               ComentarioPaciente=n.ComentarioPaciente,
                               FechaFacturacion=n.FechaFacturacion,
                               FechaVencimiento=n.FechaVencimiento,
                               CantidadDias=n.CantidadDias,
                               DiasDiferencia=n.DiasDiferencia,
                               EstatusDias=n.EstatusDias,
                               CreadoPor=n.CreadoPor,
                               TipoProducto=n.TipoProducto,
                               Producto=n.Producto,
                               DescuentoAplicado=n.DescuentoAplicado,
                               Total=n.Total,
                               TotalDescuento=n.TotalDescuento,
                               SubTotal=n.SubTotal,
                               Impuesto=n.Impuesto,
                               TotalGeneral=n.TotalGeneral,
                               TipoPago=n.TipoPago,
                               MontoPagado=n.MontoPagado,
                               EstatusCirugia=n.EstatusCirugia,
                               TipoVenta=n.TipoVenta,
                               Balance=n.Balance
                           }).FirstOrDefault();
            }
            return Guardar;
                 
        }
        #endregion
        #region GUARDAR LOS DATOS PARA EL REPORTE DE COMISION DE MEDICO DETALLE
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle GuardarComisionMedicoDetalle(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle Guardar = null;

            var ReporteComisionMedicoDetalle = ObjData.SP_GUARDAR_REPORTE_COMISION_MEDICO_DETALLE(
                  Item.IdUsuario
                , Item.IDComision
                , Item.IdProgramacionCirugia
                , Item.NumeroFactura
                , Item.NumeroReferencia
                , Item.CentroSalud
                , Item.Medico
                , Item.PorcComisionMedico
                , Item.MontoFactura
                , Item.MontoFacturaNeta
                , Item.ComisionPagar
                , Item.FechaCirugia
                , Item.Hora
                , Item.ComisionPagada
                , Item.FechaPagoComision
                , Item.MontoPagado
                , Accion);
            if (ReporteComisionMedicoDetalle != null)
            {
                Guardar = (from n in ReporteComisionMedicoDetalle
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarReporteComisionMedicoDetalle
                           {
                               IdUsuario=n.IdUsuario,
                               IDComision=n.IDComision,
                               IdProgramacionCirugia=n.IdProgramacionCirugia,
                               NumeroFactura=n.NumeroFactura,
                               NumeroReferencia=n.NumeroReferencia,
                               CentroSalud=n.CentroSalud,
                               Medico=n.Medico,
                               PorcComisionMedico=n.PorcComisionMedico,
                               MontoFactura=n.MontoFactura,
                               MontoFacturaNeta=n.MontoFacturaNeta,
                               ComisionPagar=n.ComisionPagar,
                               FechaCirugia=n.FechaCirugia,
                               Hora=n.Hora,
                               ComisionPagada=n.ComisionPagada,
                               FechaPagoComision=n.FechaPagoComision,
                               MontoPagado=n.MontoPagado
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion
    }
}
