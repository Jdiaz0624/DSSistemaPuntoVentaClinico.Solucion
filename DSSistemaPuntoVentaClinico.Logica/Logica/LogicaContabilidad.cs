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

        #region MANTENIMIENTO DE CUENTAS POR PAGAR
        //GUARDAR LOS DATOS PARA LAS CUENTAS POR PAGAR
        public Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar GuardarCuentasPorPagar(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar Item, string Accion)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar Guardar = null;

            var CuentasPorPagar = Objdata.SP_GUARDAR_CUENTA_POR_PAGAR(
                Item.IdCuentaPorPagar,
                Item.IdPaciente,
                Item.NumeroConector,
                Item.BalanceInicial,
                Item.BalanceActual,
                Item.CantidadPagos,
                0,
                Accion);

            if (CuentasPorPagar != null)
            {
                Guardar = (from n in CuentasPorPagar
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar
                           {
                               IdCuentaPorPagar=n.IdCuentaPorPagar,
                               IdPaciente=n.IdPaciente,
                               NumeroConector=n.NumeroConector,
                               BalanceInicial=n.BalanceInicial,
                               BalanceActual=n.BalanceActual,
                               CantidadPagos=n.CantidadPagos
                           }).FirstOrDefault();
            }
            return Guardar;
        }

        //BUSCA LAS CUENTAS POR PAGAR
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EBuscaCuentasPorCobrar> BuscaCuentasCobrarr(decimal? IdCuentaCobrar = null, string IdPaciente = null, string RNC = null, decimal? NumeroConector = null, string NumeroFactura = null, DateTime? FechaDesde = null, DateTime? FechaHasta = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_CUENTAS_POR_COBRAR(IdCuentaCobrar, IdPaciente, RNC, NumeroConector, NumeroFactura, FechaDesde, FechaHasta, NumeroPagina, NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EBuscaCuentasPorCobrar
                          {
                              IdCuentaPorPagar=n.IdCuentaPorPagar,
                              IdPaciente=n.IdPaciente,
                              Paciente=n.Paciente,
                              TipoIdentificacion=n.TipoIdentificacion,
                              NoIdentificacion=n.NoIdentificacion,
                              Secuencia=n.Secuencia,
                              Fecha0=n.Fecha0,
                              NumeroConector=n.NumeroConector,
                              NombrePaciente=n.NombrePaciente,
                              TipoComprobante=n.TipoComprobante,
                              ValidoHasta=n.ValidoHasta,
                              Comprobante=n.Comprobante,
                              BalanceInicial=n.BalanceInicial,
                              BalanceActual=n.BalanceActual,
                              MontoPagado=n.MontoPagado,
                              Concepto=n.Concepto,
                              NumeroFactura=n.NumeroFactura,
                              FechaFacturacion=n.FechaFacturacion,
                              FechaVencimiento=n.FechaVencimiento,
                              DiasAtrasados=n.DiasAtrasados,
                              Estatus=n.Estatus,
                              DiasCredito=n.DiasCredito,
                              Monto=n.Monto,
                              Abono=n.Abono,
                              Pendiente=n.Pendiente,
                              __0_30=n._0_30,
                              __31_60=n._31_60,
                              __61_90=n._61_90,
                              __91_120=n._91_120,
                              __121_o_Mas=n._121_o_Mas
                          }).ToList();
            return Buscar;
        }
        #endregion

        #region MANTENIMIENTO DE COMISION DE MEDICO
        //BUSCA LAS COMISIONES DE LOS MEDICOS
        public List<DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EBuscaComisionesMedicos> BuscaComisionesMedicos(decimal? IDComision = null, decimal? IdProgramacionCirugia = null, decimal? NumeroFactura = null, decimal? NumeroReferencia = null, decimal? IdCentroSalud = null, decimal? IdMedico = null, string NombreMedico = null, decimal? IdAsistente = null, DateTime? FechaCirugiaDesde = null, DateTime? FechaCirugiaHasta = null, bool? ComisionPagada = null, int? NumeroPagina = null, int? NumeroRegistros = null)
        {
            Objdata.CommandTimeout = 999999999;

            var Buscar = (from n in Objdata.SP_BUSCA_COMISIONES_MEDICOS(IDComision, IdProgramacionCirugia, NumeroFactura, NumeroReferencia, IdCentroSalud, IdMedico, NombreMedico, IdAsistente, FechaCirugiaDesde, FechaCirugiaHasta, ComisionPagada, NumeroPagina, NumeroRegistros)
                          select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EBuscaComisionesMedicos
                          {
                              IDComision=n.IDComision,
                              IdProgramacionCirugia=n.IdProgramacionCirugia,
                              NumeroFactura=n.NumeroFactura,
                              Cliente=n.Cliente,
                              Paciente=n.Paciente,
                              NumeroReferencia=n.NumeroReferencia,
                              IdCentroSalud=n.IdCentroSalud,
                              CentroSalud=n.CentroSalud,
                              Telefonos=n.Telefonos,
                              Direccion=n.Direccion,
                              Idmedico=n.Idmedico,
                              Medico=n.Medico,
                              PorcComisionMedico=n.PorcComisionMedico,
                              Impuesto=n.Impuesto,
                              TipoVenta0=n.TipoVenta0,
                              TipoVenta=n.TipoVenta,
                              MontoFactura=n.MontoFactura,
                              MontoFacturaNeta=n.MontoFacturaNeta,
                              ComisionPagar=n.ComisionPagar,
                              IdAsistente=n.IdAsistente,
                              FechaCirugia0=n.FechaCirugia0,
                              FechaCirugia=n.FechaCirugia,
                              Hora=n.Hora,
                              ComisionPagada0=n.ComisionPagada0,
                              ComisionPagada=n.ComisionPagada,
                              FechapagoComision0=n.FechapagoComision0,
                              FechapagoComision=n.FechapagoComision,
                              MontoPagado=n.MontoPagado
                          }).ToList();
            return Buscar;
        }
        //GUARDAR LOS DATOS DE LA COMISIONES DE LOS MEDICOS
        public DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico GuardarComisionesMedicos(DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico Item, string Accion)
        {
            Objdata.CommandTimeout = 999999999;

            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico Guardar = null;

            var ComisionMedico = Objdata.SP_GUARDAR_COMISION_MEDICO(
                Item.IDComision,
                Item.IdProgramacionCirugia,
                Item.NumeroFactura,
                Item.NumeroReferencia,
                Item.IdCentroSalud,
                Item.Idmedico,
                Item.IdAsistente,
                Item.FechaCirugia,
                Item.ComisionPagada,
                Item.MontoPagado,
                Accion);
            if (ComisionMedico != null)
            {
                Guardar = (from n in ComisionMedico
                           select new DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarComisionesMedico
                           {
                               IDComision=n.IDComision,
                               IdProgramacionCirugia=n.IdProgramacionCirugia,
                               NumeroFactura=n.NumeroFactura,
                               NumeroReferencia=n.NumeroReferencia,
                               IdCentroSalud=n.IdCentroSalud,
                               Idmedico=n.Idmedico,
                               IdAsistente=n.IdAsistente,
                               FechaCirugia=n.FechaCirugia,
                               ComisionPagada=n.ComisionPagada,
                               MontoPagado=n.MontoPagado,
                               FechapagoComision=n.FechapagoComision
                           }).FirstOrDefault();
            }
            return Guardar;
        }
        #endregion


    }
}
