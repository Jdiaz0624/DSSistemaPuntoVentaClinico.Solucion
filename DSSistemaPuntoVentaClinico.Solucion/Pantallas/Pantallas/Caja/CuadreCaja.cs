using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja
{
    public partial class CuadreCaja : Form
    {
        public CuadreCaja()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjdataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA DATA DE LA INFORMACION DE LA EMPRESA
        private void SacarNombreEmpresa(int IdInformacionEmpresa)
        {
            var SacarData = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarData)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion


        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            SacarNombreEmpresa(1);
            gbSeleccionar.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Cuadre de Caja";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CuadreCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //LEEMOS DESDE EL PROCEDURE [Caja].[SP_MOSTRAR_HISTORIAL_CAJA]
            try
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Borrar = new Logica.Entidades.EntidadReporte.ECuadreCaja();
                Borrar.IdUsuario = VariablesGlobales.IdUsuario;
                var MAN2 = ObjDataHistorial.Value.CuadreCaja(Borrar, "DELETE");

                //SACAMOS LOS DATOS QUE SE VAN A GRABAR
                var SacarDatos = ObjdataCaja.Value.MostrarHistorialCaja(
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text));
                foreach (var n in SacarDatos)
                {
                    //GUARDAMOS LOS DATOS UTILIZANDO EL PROCEDURE SP_MANTENIMIENTO_CUADRE_CAJA
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.ECuadreCaja Cuadrar = new Logica.Entidades.EntidadReporte.ECuadreCaja();

                    Cuadrar.IdUsuario = VariablesGlobales.IdUsuario;
                    Cuadrar.Caja = n.Caja;
                    Cuadrar.CantidadFacturado = Convert.ToInt32(n.CantidadFacturado);
                    Cuadrar.Anuladas = Convert.ToInt32(n.Anuladas);
                    Cuadrar.TotalCantidadFacturado = Convert.ToInt32(n.TotalCantidadFacturado);
                    Cuadrar.CantidadCotizaciones = Convert.ToInt32(n.CantidadCotizaciones);
                    Cuadrar.CantidadCirugiasProgramadas = Convert.ToInt32(n.CantidadCirugiasProgramadas);
                    Cuadrar.Monto = Convert.ToDecimal(n.Monto);
                    Cuadrar.Concepto = n.Concepto;
                    Cuadrar.Fecha = n.Fecha;
                    Cuadrar.CreadoPor = n.CreadoPor;
                    Cuadrar.NumeroReferencia = n.NumeroReferencia;
                    Cuadrar.TipoPago = n.TipoPago;
                    Cuadrar.FechaDesde = Convert.ToDateTime(txtFechaDesde.Text);
                    Cuadrar.FechaHasta = Convert.ToDateTime(txtFechaHasta.Text);

                    var MAN = ObjDataHistorial.Value.CuadreCaja(Cuadrar, "INSERT");
                }

                //MOSTRAMOS EL REPORTE EN PANTALLA
                //SACAMOS LAS CREDENCIALES DEL SISTEMA
                var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(2);
                foreach (var n in SacarRutaReporte)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }
                ////MANDAMOS LOS PARAMETROS E INVOCAMOS EL REPORTE
                //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Cuadre = new Reporte.Reportes();

                //Cuadre.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                //Cuadre.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                //Cuadre.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                //Cuadre.GenerarCuadreCaja(VariablesGlobales.IdUsuario);
                //Cuadre.ShowDialog();

            }
            catch (Exception ex) {
                MessageBox.Show("Error al generar el reporte" + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
