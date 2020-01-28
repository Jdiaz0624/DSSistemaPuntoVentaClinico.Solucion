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
    public partial class PagosFacturasPendientes : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjDataCObtabilidad = new Lazy<Logica.Logica.LogicaContabilidad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataReporte = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void SacarDatosPaciente()
        {
            var SacarDataEmpresa = ObjDataEmpresa.Value.BuscaClientes(
                VariablesGlobales.IdMantenimiento,
                null,
                null,
                null,
                null,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value), 
                Convert.ToInt32(txtNumeroRegistros.Value));
            foreach (var n in SacarDataEmpresa)
            {
                lbNombre.Text = n.Nombre;
                lbDireccion.Text = n.Direccion;
                lbzRNC.Text = n.NumeroIdentificacion;
            }

        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns["IdCuentaPorPagar"].Visible = false;
            this.dataGridView1.Columns["Secuencia"].Visible = false;
            this.dataGridView1.Columns["Fecha0"].Visible = false;
            this.dataGridView1.Columns["NumeroConector"].Visible = false;
            this.dataGridView1.Columns["NombrePaciente"].Visible = false;
            this.dataGridView1.Columns["TipoComprobante"].Visible = false;
            this.dataGridView1.Columns["ValidoHasta"].Visible = false;
            this.dataGridView1.Columns["Comprobante"].Visible = false;
            this.dataGridView1.Columns["Concepto"].Visible = false;
            this.dataGridView1.Columns["BalanceInicial"].Visible = false;
            this.dataGridView1.Columns["BalanceActual"].Visible = false;
            this.dataGridView1.Columns["MontoPagado"].Visible = false;
            this.dataGridView1.Columns["IdPaciente"].Visible = false;
            this.dataGridView1.Columns["paciente"].Visible = false;
            this.dataGridView1.Columns["TipoIdentificacion"].Visible = false;
            this.dataGridView1.Columns["NoIdentificacion"].Visible = false;
        }

        #region MOSTRAR EL LISTADO DE LAS FACTURAS
        private void SacarListadoFacturas()
        {
            var SacarPagosFactura = ObjDataCObtabilidad.Value.BuscaCuentasCobrarr(
                new Nullable<decimal>(),
                VariablesGlobales.IdMantenimiento.ToString(),
                null, null, null, null, null, Convert.ToInt32(txtNumeroPagina.Value), Convert.ToInt32(txtNumeroRegistros.Value));
            dataGridView1.DataSource = SacarPagosFactura;
            OcultarColumnas();
        }
        #endregion
        public PagosFacturasPendientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad.CuntasPorCobrar cxc = new CuntasPorCobrar();
            cxc.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            cxc.ShowDialog();
        }

        private void PagosFacturasPendientes_Load(object sender, EventArgs e)
        {
            SacarDatosPaciente();
            SacarListadoFacturas();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
        }

        private void PagosFacturasPendientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento2 = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdPaciente"].Value.ToString());
                this.VariablesGlobales.Numerofactura = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["NumeroFactura"].Value.ToString());

                var SacarDatos = ObjDataCObtabilidad.Value.BuscaCuentasCobrarr(
                    new Nullable<decimal>(),
                    VariablesGlobales.IdMantenimiento2.ToString(),
                    null,
                    null,
                    VariablesGlobales.Numerofactura.ToString(),
                    null,
                    null,
                    1, 9999);
                dataGridView1.DataSource = SacarDatos;
                OcultarColumnas();
                foreach (var n in SacarDatos)
                {
                    lbNoFactura.Text = n.NumeroFactura.ToString();
                    decimal Monto = Convert.ToDecimal(n.Pendiente);
                    lbMonto.Text = Monto.ToString("N2");
                    txtAbono.Text = Monto.ToString("N2");
                }
                groupBox1.Enabled = true;
                rbPagoTotal.Checked = true;
            }
        }

        private void rbAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                txtAbono.Text = string.Empty;
                txtAbono.Enabled = true;
                txtAbono.Focus();
            }
            else
            {
                txtAbono.Enabled = false;
                txtAbono.Text = string.Empty;
                txtAbono.Text = lbMonto.Text;
            }
        }

        private void rbPagoTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagoTotal.Checked)
            {
                txtAbono.Enabled = false;
                txtAbono.Text = string.Empty;
                txtAbono.Text = lbMonto.Text;
            }
            else
            {
                

                txtAbono.Text = string.Empty;
                txtAbono.Enabled = true;
                txtAbono.Focus();

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SacarListadoFacturas();
            groupBox1.Enabled = false;
            rbPagoTotal.Checked = true;
        }
    }
}
