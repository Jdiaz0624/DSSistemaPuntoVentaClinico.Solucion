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
    }
}
