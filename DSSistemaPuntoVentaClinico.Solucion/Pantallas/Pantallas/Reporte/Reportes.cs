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
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        public void CargarReporteExternoPantalla(decimal NumeroConector)
        {
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
        public void GenerarCuadreCaja(decimal IdUsuario)
        {
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
        private void Reportes_Load(object sender, EventArgs e)
        {

        }
    }
}
