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
        private void Reportes_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
        }
    }
}
