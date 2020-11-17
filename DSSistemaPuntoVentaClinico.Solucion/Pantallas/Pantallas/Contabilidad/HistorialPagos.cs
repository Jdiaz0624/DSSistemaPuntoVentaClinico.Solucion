using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class HistorialPagos : Form
    {
        public HistorialPagos()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL HISTORIAL DE PAGOS
        private void MostrarHistorialPagos()
        {
            string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();
            string _NumeroRecibo = string.IsNullOrEmpty(txtRecibo.Text.Trim()) ? null : txtRecibo.Text.Trim();
            string _NumeroFactura = string.IsNullOrEmpty(txtFactura.Text.Trim()) ? null : txtFactura.Text.Trim();

            if (cbRangoFecha.Checked)
            {
                var MostrarListado = ObjDataCaja.Value.BuscarPagoFacturas(
                    _NumeroRecibo,
                    _NumeroFactura,
                    _RNC,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarListado;
            }
            else
            {
                var MostrarListado = ObjDataCaja.Value.BuscarPagoFacturas(
                    _NumeroRecibo,
                    _NumeroFactura,
                    _RNC,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarListado;
            }
            OcultarColumnas();
        }
        #endregion
        #region OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdTipoPago"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["NumeroIdentificacion"].Visible = false;
            this.dtListado.Columns["Telefono"].Visible = false;
            this.dtListado.Columns["Direccion"].Visible = false;
            this.dtListado.Columns["Email"].Visible = false;
        }
        #endregion
        #region SACAR L NOMBRE DE LA EMPRESA
        private void SacarInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarDatosEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarDatosEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region GUARDAR HISTORIAL PAGOS
        private void MostrarReporteHsitorialPagos()
        {
            //ELIMINAMOS LOS REISTROS
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos Eliminar = new Logica.Entidades.EntidadReporte.EGuardarHistorialPagos();
            Eliminar.IdUsuario = VariablesGlobales.IdUsuario;
            var MAN = ObjDataHistorial.Value.GuardarHistorialPagos(Eliminar, "DELETE");


            string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();
            string _NumeroRecibo = string.IsNullOrEmpty(txtRecibo.Text.Trim()) ? null : txtRecibo.Text.Trim();
            string _NumeroFactura = string.IsNullOrEmpty(txtFactura.Text.Trim()) ? null : txtFactura.Text.Trim();

            if (cbRangoFecha.Checked)
            {
                var MostrarListado = ObjDataCaja.Value.BuscarPagoFacturas(
                    _NumeroRecibo,
                    _NumeroFactura,
                    _RNC,
                    Convert.ToDateTime(txtFechaDesde.Text),
                    Convert.ToDateTime(txtFechaHasta.Text),
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                foreach (var n in MostrarListado)
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos Guardar = new Logica.Entidades.EntidadReporte.EGuardarHistorialPagos();
                    Guardar.IdUsuario = VariablesGlobales.IdUsuario;
                    Guardar.NumeroRecibo = Convert.ToDecimal(n.NumeroRecibo);
                    Guardar.NumeroFactura = Convert.ToDecimal(n.PagandoA);
                    Guardar.FechaPago = n.FechaPago;
                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);
                    Guardar.Balance = Convert.ToDecimal(n.Balance);
                    Guardar.Concepto = n.Concepto;
                    Guardar.TipoPago = n.TipoPago;
                    Guardar.CreadoPor = n.CreadoPor;

                    var MANGuardar = ObjDataHistorial.Value.GuardarHistorialPagos(Guardar, "INSERT");
                }
                MostrarReporte();
               
            }
            else
            {
                var MostrarListado = ObjDataCaja.Value.BuscarPagoFacturas(
                    _NumeroRecibo,
                    _NumeroFactura,
                    _RNC,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                foreach (var n in MostrarListado)
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EGuardarHistorialPagos Guardar = new Logica.Entidades.EntidadReporte.EGuardarHistorialPagos();
                    Guardar.IdUsuario = VariablesGlobales.IdUsuario;
                    Guardar.NumeroRecibo = Convert.ToDecimal(n.NumeroRecibo);
                    Guardar.NumeroFactura = Convert.ToDecimal(n.PagandoA);
                    Guardar.FechaPago = n.FechaPago;
                    Guardar.MontoFactura = Convert.ToDecimal(n.MontoFactura);
                    Guardar.MontoPagado = Convert.ToDecimal(n.MontoPagado);
                    Guardar.Balance = Convert.ToDecimal(n.Balance);
                    Guardar.Concepto = n.Concepto;
                    Guardar.TipoPago = n.TipoPago;
                    Guardar.CreadoPor = n.CreadoPor;

                    var MANGuardar = ObjDataHistorial.Value.GuardarHistorialPagos(Guardar, "INSERT");
                }
                MostrarReporte();
            }
        }
        #endregion
        #region MOSTRAR REPORTE EN PANTALLA
        private void MostrarReporte()
        {
            //INVOCAMOS EL REPORTE
            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(9);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //SACAMOS LA CREDENCIALES
            var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            ////INVOAMOS EL REPORTE
            //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Historial = new Reporte.Reportes();
            //Historial.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            //Historial.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            //Historial.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            //Historial.ReporteHistorialPagos(VariablesGlobales.IdUsuario);
            //Historial.ShowDialog();
        }
        #endregion
        #region MOSTRAR RECIBO DE INGRESO
        private void MostrarReciboIngreso(string NumeroReciboSacado)
        {
            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(8);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //SACAMOS LAS CREDENCIALES DE BASE DE DATOS
            var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            ////INVOCAMOS EL RECIBO
            //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes ReciboIngreso = new Reporte.Reportes();
            //ReciboIngreso.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            //ReciboIngreso.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            //ReciboIngreso.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            //ReciboIngreso.ReciboIngreso(NumeroReciboSacado);
            //ReciboIngreso.ShowDialog();
        }
#endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HistorialPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void HistorialPagos_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Historial de Pagos";
            SacarInformacionEmpresa(1);
        }

        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarHistorialPagos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarHistorialPagos();
            }
            else
            {
                MostrarHistorialPagos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarHistorialPagos();
            }
            else
            {
                MostrarHistorialPagos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarReporteHsitorialPagos();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres mostrar el recibo de este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroRecibo"].Value.ToString());
                MostrarReciboIngreso(VariablesGlobales.IdMantenimiento.ToString());
            }
        }
    }
}
