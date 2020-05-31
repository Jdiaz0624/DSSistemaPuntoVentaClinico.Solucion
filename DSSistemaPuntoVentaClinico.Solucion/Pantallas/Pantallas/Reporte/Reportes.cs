using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System.Data.SqlClient;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

#region SACAR LAINFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
#endregion
        public void CargarReporteExternoPantalla(decimal NumeroConector)
        {
            try {
                ReportDocument Factura = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_FACTURA_VENTA] @NumeroConector";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@NumeroConector", SqlDbType.VarChar);

                comando.Parameters["@NumeroConector"].Value = NumeroConector;

                Factura.Load(@"" + VariablesGlobales.RutaReporte);
                Factura.SetParameterValue("@NumeroConector", NumeroConector);
                Factura.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = Factura;
                //Factura.PrintToPrinter(1, false, 0, 0);
            }
            catch (Exception) {
                MessageBox.Show("Error al cargar el reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GenerarCuadreCaja(decimal IdUsuario)
        {
            try {
                ReportDocument CuadreCaja = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = " EXEC [Reporte].[SP_GENERAR_REPORTE_CUADRE_CAJA] @IdUsuario";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.VarChar);

                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                CuadreCaja.Load(@"" + VariablesGlobales.RutaReporte);
                CuadreCaja.Refresh();
                CuadreCaja.SetParameterValue("@IdUsuario", IdUsuario);
                CuadreCaja.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = CuadreCaja;
            }
            catch (Exception) { MessageBox.Show("Error al cargar el reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void GenerarReorteGastosCirugia(decimal IdGastoCirugia)
        {
            try {
                ReportDocument GastoCirugia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_REPORTE_GASTOS_CIRUGIA] @IdProgramacionCirugia";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdProgramacionCirugia", SqlDbType.Decimal);

                comando.Parameters["@IdProgramacionCirugia"].Value = IdGastoCirugia;

                GastoCirugia.Load(@"" + VariablesGlobales.RutaReporte);
                GastoCirugia.Refresh();
                GastoCirugia.SetParameterValue("@IdProgramacionCirugia", IdGastoCirugia);
                GastoCirugia.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = GastoCirugia;



            }
            catch (Exception) { MessageBox.Show("Error al cargar el reporte de gastos de cirugia", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void GenerarReporteProductos(decimal IdUsuarioImprime)
        {
            try {
                ReportDocument ReporteProducto = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_PRODUCTOS] @IdUsuarioImprime";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuarioImprime", SqlDbType.Decimal);
                comando.Parameters["@IdUsuarioImprime"].Value = IdUsuarioImprime;

                ReporteProducto.Load(@"" + VariablesGlobales.RutaReporte);
                ReporteProducto.Refresh();
                ReporteProducto.SetParameterValue("@IdUsuarioImprime", IdUsuarioImprime);
                ReporteProducto.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = ReporteProducto;

            }
            catch (Exception) {
                MessageBox.Show("Error el cargar el reporte de productos", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarReporteFacturacionCirugia(decimal IdUsuarioImprime)
        {
            try {

                ReportDocument ReorteCirugia = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_FACTURACION_CIRUGIA] @IdUsuarioImprime";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuarioImprime", SqlDbType.Decimal);
                comando.Parameters["@IdUsuarioImprime"].Value = IdUsuarioImprime;

                ReorteCirugia.Load(@"" + VariablesGlobales.RutaReporte);
                ReorteCirugia.Refresh();
                ReorteCirugia.SetParameterValue("@IdUsuarioImprime", IdUsuarioImprime);
                ReorteCirugia.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = ReorteCirugia;
            }
            catch (Exception) {
                MessageBox.Show("Error al cargar el reporte");
            }


        }

        //CARGAMOS EL REPORTE DE LAS CUENTAS POR COBRAR
        public void GenerarReporteCuentasPorCobrar(decimal IdPaciente)
        {
            try {
                ReportDocument AntiguedadSaldo = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_ANTIGUEDAD_SALDO] @IdPaciente";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdPaciente", SqlDbType.Decimal);
                comando.Parameters["@IdPaciente"].Value = IdPaciente;

                AntiguedadSaldo.Load(@"" + VariablesGlobales.RutaReporte);
                AntiguedadSaldo.Refresh();
                AntiguedadSaldo.SetParameterValue("@IdPaciente", IdPaciente);
                AntiguedadSaldo.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = AntiguedadSaldo;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar el reporte", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //REPORTE DE RECIBO DE INGRESOS
        public void ReciboIngreso(string NumeroRecibo)
        {
            try {
                ReportDocument Recibo = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_BUSCAR_RECIBO_PAGO] @NumeroRecibo";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@NumeroRecibo", SqlDbType.VarChar);
                comando.Parameters["@NumeroRecibo"].Value = NumeroRecibo;

                Recibo.Load(@"" + VariablesGlobales.RutaReporte);
                Recibo.Refresh();
                Recibo.SetParameterValue("@NumeroRecibo", NumeroRecibo);
                Recibo.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = Recibo;

            }
            catch (Exception) {
                MessageBox.Show("Error al mostrar el recibo de ingresos", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReporteHistorialPagos(decimal IdUsuario)
        {
            try {
                ReportDocument HistorialPagos = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_MOSTRAR_REPORTE_HISTORIAL_PAGOS] @IdUsuario";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                HistorialPagos.Load(@"" + VariablesGlobales.RutaReporte);
                HistorialPagos.Refresh();
                HistorialPagos.SetParameterValue("@IdUsuario", IdUsuario);
                HistorialPagos.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = HistorialPagos;
            }
            catch (Exception) {
                MessageBox.Show("Error al cargar el reporte de historial de pagos", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MostrarReporteVentas(decimal IdUsuario)
        {
            try {
                ReportDocument ReporteVentas = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Historial].[SP_REPORTE_HISTORIAL_VENTAS] @IdUsuario";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                ReporteVentas.Load(@"" + VariablesGlobales.RutaReporte);
                ReporteVentas.Refresh();
                ReporteVentas.SetParameterValue("@IdUsuario", IdUsuario);
                ReporteVentas.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = ReporteVentas;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar el reporte, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarReporteComisionMedicoDetalle(decimal IdUsuario)
        {
            try {
                ReportDocument ReporteComisionDetale = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_COMISION_MEDICO_DETALLE] @IdUsuario";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                ReporteComisionDetale.Load(@"" + VariablesGlobales.RutaReporte);
                ReporteComisionDetale.Refresh();
                ReporteComisionDetale.SetParameterValue("@IdUsuario", IdUsuario);
                ReporteComisionDetale.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = ReporteComisionDetale;

            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar el reporte, Codigo de Error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarReporteComisionUnico(decimal IdComision)
        {
            try {
                ReportDocument ReporteComisionUnico = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_REPORTE_COMISION_MEDICO_UNICO] @IDComision";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IDComision", SqlDbType.Decimal);
                comando.Parameters["@IDComision"].Value = IdComision;

                ReporteComisionUnico.Load(@"" + VariablesGlobales.RutaReporte);
                ReporteComisionUnico.Refresh();
                ReporteComisionUnico.SetParameterValue("@IDComision", IdComision);
                ReporteComisionUnico.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = ReporteComisionUnico;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar el reporte" + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarReporteGastosGeneral(decimal IdUsuario)
        {
            try {
                ReportDocument Gastos = new ReportDocument();

                SqlCommand Comando = new SqlCommand();
                Comando.CommandText = "EXEC [Reporte].[SP_SACAR_GASTOS_CIRUGIA_GENERAL] @IdUsuario";
                Comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                Comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                Comando.Parameters["@IdUsuario"].Value = IdUsuario;

                Gastos.Load(@"" + VariablesGlobales.RutaReporte);
                Gastos.Refresh();
                Gastos.SetParameterValue("@IdUsuario", IdUsuario);
                Gastos.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = Gastos;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar reporte de gastos general, codigo de error--> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerarVolanteCaja(decimal IdVolante) {
            try {
                ReportDocument VolanteCaja = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_GENERAR_VOLANTE_MOVIMIENTO_CAJA]  @IdHistorialCaja";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdHistorialCaja", SqlDbType.Decimal);
                comando.Parameters["@IdHistorialCaja"].Value = IdVolante;

                VolanteCaja.Load(@"" + VariablesGlobales.RutaReporte);
                VolanteCaja.Refresh();
                VolanteCaja.SetParameterValue("@IdHistorialCaja", IdVolante);
                VolanteCaja.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = VolanteCaja;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar el volante de caja, codigo de error--> " + ex.Message);
            }
        }
        public void GenerarReciboPagoComision(decimal IdUsuario) {
            try {
                ReportDocument PagoComision = new ReportDocument();

                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Reporte].[SP_RECIBO_PAGO_COMISION] @IdUsuario";
                comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdUsuario", SqlDbType.Decimal);
                comando.Parameters["@IdUsuario"].Value = IdUsuario;

                PagoComision.Load(@"" + VariablesGlobales.RutaReporte);
                PagoComision.Refresh();
                PagoComision.SetParameterValue("@IdUsuario", IdUsuario);
                PagoComision.SetDatabaseLogon(VariablesGlobales.UsuarioBD, VariablesGlobales.ClaveBD);
                crystalReportViewer1.ReportSource = PagoComision;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al enerar el recibo de pago de comisión, codigo de error --> " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
        }
    }
}
