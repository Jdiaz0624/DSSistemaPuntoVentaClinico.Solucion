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
                                 EstatusCirugia=n.EstatusCirugia

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
        public Entidades.EntidadReporte.ERutaReporte MantenimientoRutaReporte(Entidades.EntidadReporte.ERutaReporte Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadReporte.ERutaReporte Mantenimiento = null;

            var RutaReporte = ObjData.SP_MANTENIMIENTO_RUTA_REPORTES(
                Mantenimiento.IdReporte,
                Mantenimiento.DescripcionReporte,
                Mantenimiento.RutaReporte,
                Accion);
            if (RutaReporte != null)
            {
                Mantenimiento = (from n in RutaReporte
                                 select new Entidades.EntidadReporte.ERutaReporte
                                 {
                                     IdReporte=n.IdReporte,
                                     DescripcionReporte=n.DescripcionReporte,
                                     RutaReporte=n.RutaReporte
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
                                     Monto=n.Monto,
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
    }
}
