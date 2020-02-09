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
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
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

            this.dataGridView1.Columns["FechaFacturacion"].Visible = false;
            this.dataGridView1.Columns["FechaVencimiento"].Visible = false;
            this.dataGridView1.Columns["DiasAtrasados"].Visible = false;
            this.dataGridView1.Columns["Estatus"].Visible = false;
            this.dataGridView1.Columns["DiasCredito"].Visible = false;
            this.dataGridView1.Columns["__0_30"].Visible = false;
            this.dataGridView1.Columns["__31_60"].Visible = false;
            this.dataGridView1.Columns["__61_90"].Visible = false;
            this.dataGridView1.Columns["__91_120"].Visible = false;
            this.dataGridView1.Columns["__121_o_Mas"].Visible = false;
        }

        #region MOSTRAR EL LISTADO DE LAS FACTURAS
        private void SacarListadoFacturas()
        {
            string _NumeroFactura = string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()) ? null : txtNumeroFactura.Text.Trim();

            var SacarPagosFactura = ObjDataCObtabilidad.Value.BuscaCuentasCobrarr(
                new Nullable<decimal>(),
                VariablesGlobales.IdMantenimiento.ToString(),
                null, null, _NumeroFactura, null, null, Convert.ToInt32(txtNumeroPagina.Value), Convert.ToInt32(txtNumeroRegistros.Value));
            dataGridView1.DataSource = SacarPagosFactura;
            OcultarColumnas();
        }
        #endregion

        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa(int IdInformacionEmpresa)
        {
            var SacarNombreEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarNombreEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        #region CARGAR LOS TIPOS DE PAGOS
        private void CargarTipoPago()
        {
            var Cargar = ObjDataListas.Value.ListaTipoPago();
            ddlTipoPago.DataSource = Cargar;
            ddlTipoPago.DisplayMember = "Descripcion";
            ddlTipoPago.ValueMember = "IdTipoPago";
        }
        #endregion

        #region APLICAR PAGOS A FACTURA
        private void AplicarPagosFActura(string Concepto, string Accion)
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EAplicarPagos Pago = new Logica.Entidades.EntidadesCaja.EAplicarPagos();

                Pago.NumeroRecibo = 0;
                Pago.NumeroFactura = Convert.ToDecimal(lbNoFactura.Text);
                Pago.FechaPago = DateTime.Now;
                Pago.MontoFactura = Convert.ToDecimal(lbMonto.Text);
                Pago.MontoPagado = Convert.ToDecimal(txtAbono.Text);
                Pago.Balance = 0;
                Pago.Concepto = Concepto;
                Pago.IdTipoPago = Convert.ToDecimal(ddlTipoPago.SelectedValue);
                Pago.IdUsuario = VariablesGlobales.IdUsuario;

                var MAN = ObjDataCaja.Value.AplicarPago(Pago, Accion);
            }
            catch (Exception) {
                MessageBox.Show("Error al aplicar el pago", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region VOLVER ATRAS
        private void VolverAtras()
        {
            SacarListadoFacturas();
            groupBox1.Enabled = false;
            rbPagoTotal.Checked = true;
        }
        #endregion

        #region MOSTRAR EL RECIBO DE INGRESOS EN PANTALLA
        private void MostrarReciboIngreso()
        {
            //SACAMOS EL NUMERO DE RECIBO MAS ALTO MEDIANTE LA FACTURA SELECCIONADA
            string NumeroReciboSacado = "";
            var SacarNumeroRecibo = ObjDataCaja.Value.SacarNumeroRecibo(Convert.ToDecimal(lbNoFactura.Text));
            foreach (var n in SacarNumeroRecibo)
            {
                NumeroReciboSacado = n.NumeroRecibo.ToString();
            }
            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataReporte.Value.SacarRutaReporte(8);
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

            //INVOCAMOS EL RECIBO
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes ReciboIngreso = new Reporte.Reportes();
            ReciboIngreso.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            ReciboIngreso.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            ReciboIngreso.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            ReciboIngreso.ReciboIngreso(NumeroReciboSacado);
            ReciboIngreso.ShowDialog();
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
            SacarNombreEmpresa(1);
            SacarDatosPaciente();
            SacarListadoFacturas();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            CargarTipoPago();
            lbTitulo.Text = "Pago a Factura";
            lbTitulo.ForeColor = Color.White;
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
            VolverAtras();
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            string Concepto = "";
            if (rbPagoTotal.Checked == true)
            {
                decimal Balance = Convert.ToDecimal(lbMonto.Text);
                if (Balance > 0)
                {
                    Concepto = "Pago a Factura - " + lbNoFactura.Text;
                    AplicarPagosFActura(Concepto, "INSERT");

                    MessageBox.Show("Pago aplicado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarReciboIngreso();
                    VolverAtras();
                }
                else
                {
                    MessageBox.Show("Esta Factura no tiene balance pendiente, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rbAbono.Checked == true)
            {
                if (string.IsNullOrEmpty(txtAbono.Text.Trim()))
                {
                    MessageBox.Show("EL campo abono no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    decimal Balance = Convert.ToDecimal(lbMonto.Text);
                    if (Balance > 0)
                    {
                        //VALIDAMOS QUE EL MONTO A APAGAR NO SEA MAYOR AL BALANCE DE LA FACTURA
                        decimal Abono = Convert.ToDecimal(txtAbono.Text);
                        if (Abono > Balance)
                        {
                            MessageBox.Show("El monto ingresado es mayor al balance de la factura selecionada, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //APLICAMOS EL PAGO
                            Concepto = "Abono a Factura - " + lbNoFactura.Text;
                            AplicarPagosFActura(Concepto, "INSERT");
                            MessageBox.Show("Pago aplicado exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarReciboIngreso();
                            VolverAtras();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esta Factura no tiene balance pendiente, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SacarListadoFacturas();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                SacarListadoFacturas();
            }
            else
            {
                SacarListadoFacturas();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                SacarListadoFacturas();
            }
            else
            {
                SacarListadoFacturas();
            }
        }
    }
}
