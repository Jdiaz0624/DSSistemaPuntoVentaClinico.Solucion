using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSistemaPuntoVentaClinico.Logica.Logica
{
    public class LogicaCaja
    {
        DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionLINQ.BDCajaDataContext ObjData = new Data.Conexiones.ConexionLINQ.BDCajaDataContext(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);

        #region MANTENIMIENTO DE MONEDA
        //listado de monedas
        public List<Entidades.EntidadesCaja.EMoneda> BucaMoneda(decimal? IdMoneda = null, string CodigoMoneda = null, string Descripcion = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCA_MONEDA(IdMoneda, CodigoMoneda, Descripcion, NumeroPagina, NumeroRegistros)
                          select new Entidades.EntidadesCaja.EMoneda
                          {
                              IdMoneda=n.IdMoneda,
                              CodigoMoneda=n.CodigoMoneda,
                              Moneda=n.Moneda,
                              Sigla=n.Sigla,
                              Tasa=n.Tasa,
                              Estatus0=n.Estatus0,
                              Estatus=n.Estatus,
                              PorDefault0=n.PorDefault0,
                              PorDefecto=n.PorDefecto,
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
        //MANTENIMIENTO DE MONEDAS
        public Entidades.EntidadesCaja.EMoneda MantenimientoMoneda(Entidades.EntidadesCaja.EMoneda Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadesCaja.EMoneda Mantenimiento = null;

            var Moneda = ObjData.SP_MANTENIMIENTO_MONEDAS(
                Item.IdMoneda,
                Item.CodigoMoneda,
                Item.Moneda,
                Item.Sigla,
                Item.Tasa,
                Item.Estatus0,
                Item.PorDefault0,
                Item.UsuarioAdiciona,
                Accion);
            if (Moneda != null)
            {
                Mantenimiento = (from n in Moneda
                                 select new Entidades.EntidadesCaja.EMoneda
                                 {
                                     IdMoneda=n.IdMoneda,
                                     CodigoMoneda=n.CodigoMoneda,
                                     Moneda=n.Descripcion,
                                     Sigla=n.Sigla,
                                     Tasa=n.Tasa,
                                     Estatus0=n.Estatus,
                                     PorDefault0=n.PorDefault,
                                     UsuarioAdiciona=n.UsuarioAdiciona,
                                     FechaAdiciona0=n.FechaAdiciona,
                                     UsuarioModifica=n.UsuarioModifica,
                                     FechaModifica0=n.FechaModifica
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE CAJA
        //SACAR EL LISTADO DE LA CAja
        public List<Entidades.EntidadesCaja.ECaja> BuscaCaja(decimal? IdCaja = null, string CodigoCaja = null)
        {
            ObjData.CommandTimeout = 999999999;

            var SacarDatosCaja = (from n in ObjData.SP_BUSCA_CAJA(IdCaja, CodigoCaja)
                                  select new Entidades.EntidadesCaja.ECaja
                                  {
                                      IdCaja=n.IdCaja,
                                      CodigoCaja=n.CodigoCaja,
                                      Descripcion=n.Descripcion,
                                      MontoActual=n.MontoActual,
                                      Estatus0=n.Estatus0,
                                      Estatus=n.Estatus
                                  }).ToList();
            return SacarDatosCaja;
        }
        //MANTENIMIENTO DE CAJA
        public Entidades.EntidadesCaja.ECaja MantenimientoCaja(Entidades.EntidadesCaja.ECaja Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            Entidades.EntidadesCaja.ECaja Mantenimiento = null;

            var Caja = ObjData.SP_MANTENIMIENTO_CAJA(
                Item.IdCaja,
                Item.CodigoCaja,
                Item.Descripcion,
                Item.MontoActual,
                Item.Estatus0,
                Accion);
            if (Caja != null)
            {
                Mantenimiento = (from n in Caja
                                 select new Entidades.EntidadesCaja.ECaja
                                 {
                                     IdCaja=n.IdCaja,
                                     CodigoCaja=n.CodigoCaja,
                                     Descripcion=n.Descripcion,
                                     MontoActual=n.MontoActual,
                                     Estatus0=n.Estatus
                                 }).FirstOrDefault();

            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE HISTORIAL DE CAJA
        //LISTADO DE HISTORIAL DE CAJA
        public List<Entidades.EntidadesCaja.EHistorialCaja> MostrarHistorialCaja(DateTime? FechaDesde = null, DateTime? FechaHasta = null)
        {
            ObjData.CommandTimeout = 999999999;

            var buscar = (from n in ObjData.SP_MOSTRAR_HISTORIAL_CAJA(FechaDesde, FechaHasta)
                          select new Entidades.EntidadesCaja.EHistorialCaja
                          {
                              IdistorialCaja = n.IdistorialCaja,
                              IdCaja = n.IdCaja,
                              CantidadFacturado=n.CantidadFacturado,
                              Anuladas=n.Anuladas,
                              TotalCantidadFacturado=n.TotalCantidadFacturado,
                              CantidadCotizaciones=n.CantidadCotizaciones,
                              CantidadCirugiasProgramadas=n.CantidadCirugiasProgramadas,
                              Caja = n.Caja,
                              Monto = n.Monto,
                              Concepto = n.Concepto,
                              Fecha0 = n.Fecha0,
                              Fecha = n.Fecha,
                              IdUsuario = n.IdUsuario,
                              CreadoPor = n.CreadoPor,
                              NumeroReferencia = n.NumeroReferencia,
                              IdTipoPago = n.IdTipoPago,
                              TipoPago = n.TipoPago
                          }).ToList();
            return buscar;
        }
        //MANTENIMIENTO DE HISTORIAL DE CAJA
        public Entidades.EntidadesCaja.EHistorialCaja MantenimientoHistorialCaja(Entidades.EntidadesCaja.EHistorialCaja Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EHistorialCaja Mantenimiento = null;

            var HistorialCaja = ObjData.SP_MANTENIMIENTO_HISTORIAL_CAJA(
                Item.IdistorialCaja,
                Item.IdCaja,
                Item.Monto,
                Item.Concepto,
                Item.IdUsuario,
                Item.NumeroReferencia,
                Item.IdTipoPago,
                Accion);
            if (HistorialCaja != null)
            {
                Mantenimiento = (from n in HistorialCaja
                                 select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EHistorialCaja
                                 {
                                     IdistorialCaja=n.IdistorialCaja,
                                     IdCaja=n.IdCaja,
                                     Monto=n.Monto,
                                     Concepto=n.Concepto,
                                     Fecha0=n.Fecha,
                                     IdUsuario=n.IdUsuario,
                                     NumeroReferencia=n.NumeroReferencia,
                                     IdTipoPago=n.IdTipoPago
                                 }).FirstOrDefault();
            }
            return Mantenimiento;
        }
        #endregion
        #region MANTENIMIENTO DE PAGOS A FACTURA
        //BUSCAR EL LISTADO DE PAGOS A FACTURAS
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EBuscaPagosFacturas> BuscarPagoFacturas(string NumeroRecibo = null, string NumeroFactura = null, string RNC = null, DateTime? FechaPagoDesde = null, DateTime? FechaPagoHasta = null,int? NumeroPagina = null,int? NumeroRegistros = null)
        {
            ObjData.CommandTimeout = 999999999;

            var Buscar = (from n in ObjData.SP_BUSCAR_PAGOS_FACTURAS(NumeroRecibo, NumeroFactura, RNC, FechaPagoDesde, FechaPagoHasta,NumeroPagina,NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EBuscaPagosFacturas
                          {
                              NumeroRecibo=n.NumeroRecibo,
                              PagandoA=n.PagandoA,
                              NombrePaciente=n.NombrePaciente,
                              NumeroIdentificacion=n.NumeroIdentificacion,
                              Telefono=n.Telefono,
                              Direccion=n.Direccion,
                              Email=n.Email,
                              FechaPago=n.FechaPago,
                              MontoFactura=n.MontoFactura,
                              MontoPagado=n.MontoPagado,
                              Balance=n.Balance,
                              Concepto=n.Concepto,
                              IdTipoPago=n.IdTipoPago,
                              TipoPago=n.TipoPago,
                              IdUsuario=n.IdUsuario,
                              CreadoPor=n.CreadoPor
                          }).ToList();
            return Buscar;
        }

        //APLICAR PAGOS A FACTURA
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EAplicarPagos AplicarPago(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EAplicarPagos Item, string Accion)
        {
            ObjData.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EAplicarPagos Aplicar = null;

            var Pagos = ObjData.SP_APLICAR_PAGOS_FACTURAS(
                Item.NumeroRecibo,
                Item.NumeroFactura,
                Item.MontoFactura,
                Item.MontoPagado,
                Item.Concepto,
                Item.IdTipoPago,
                Item.IdUsuario,
                Accion);
            if (Pagos != null)
            {
                Aplicar = (from n in Pagos
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EAplicarPagos
                           {
                              NumeroRecibo=n.NumeroRecibo,
                              NumeroFactura=n.NumeroFactura,
                              MontoFactura=n.MontoFactura,
                              MontoPagado=n.MontoPagado,
                              Concepto=n.Concepto,
                              IdTipoPago=n.IdTipoPago,
                              IdUsuario=n.IdUsuario
                           }).FirstOrDefault();
            }
            return Aplicar;
        }
        #endregion
        #region SACAR EL NUMERO DE RECIBO MAS ALTO
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ESacarNumeroRecibo> SacarNumeroRecibo(decimal? NumeroFactura = null)
        {
            ObjData.CommandTimeout = 999999999;

            var SacarNumero = (from n in ObjData.SP_SACAR_NUMERO_RECIBO(NumeroFactura)
                               select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ESacarNumeroRecibo
                               {
                                   NumeroRecibo=n.NumeroRecibo
                               }).ToList();
            return SacarNumero;
        }
        #endregion
    }
}
