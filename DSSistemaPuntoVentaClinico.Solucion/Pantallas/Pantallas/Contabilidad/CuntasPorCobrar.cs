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
    public partial class CuntasPorCobrar : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjDataCObtabilidad = new Lazy<Logica.Logica.LogicaContabilidad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataReporte = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa(int IdInformacionEmpresa)
        {
            var SacarNombre = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarNombre)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        #region MOSTRAR CONSULTA
        private void MostrarConsulta()
        {
            try {
                string _CodigoPaciente = string.IsNullOrEmpty(txtCodigoPaciente.Text.Trim()) ? null : txtCodigoPaciente.Text.Trim();
                string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();
                string _NumeroFactura = string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()) ? null : txtNumeroFactura.Text.Trim();

                var Buscar = ObjDataCObtabilidad.Value.BuscaCuentasCobrarr(
                    new Nullable<decimal>(),
                    _CodigoPaciente,
                    _RNC,
                    null,
                    _NumeroFactura,
                    null,
                    null,
                    Convert.ToInt32(txtNumeroPagina.Value),
                    Convert.ToInt32(txtNumeroRegistros.Value));
                dataGridView1.DataSource = Buscar;
                OcultarColumnas();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "Error al mostrar la consulta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void OcultarColumnas()
        {
            this.dataGridView1.Columns["IdCuentaPorPagar"].Visible = false;
            this.dataGridView1.Columns["Secuencia"].Visible = false;
            this.dataGridView1.Columns["Fecha0"].Visible = false;
            this.dataGridView1.Columns["NumeroConector"].Visible = false;
            this.dataGridView1.Columns["TipoComprobante"].Visible = false;
            this.dataGridView1.Columns["ValidoHasta"].Visible = false;
            this.dataGridView1.Columns["Comprobante"].Visible = false;
            this.dataGridView1.Columns["Paciente"].Visible = false;
            this.dataGridView1.Columns["FechaVencimiento"].Visible = false;
            this.dataGridView1.Columns["DiasAtrasados"].Visible = false;
            this.dataGridView1.Columns["Estatus"].Visible = false;
            this.dataGridView1.Columns["DiasCredito"].Visible = false;
            this.dataGridView1.Columns["Monto"].Visible = false;
            this.dataGridView1.Columns["Abono"].Visible = false;
            this.dataGridView1.Columns["Pendiente"].Visible = false;
            this.dataGridView1.Columns["__0_30"].Visible = false;
            this.dataGridView1.Columns["__31_60"].Visible = false;
            this.dataGridView1.Columns["__61_90"].Visible = false;
            this.dataGridView1.Columns["__91_120"].Visible = false;
            this.dataGridView1.Columns["__121_o_Mas"].Visible = false;
        }
        #endregion

        
        public CuntasPorCobrar()
        {
            InitializeComponent();
        }

        private void CuntasPorCobrar_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            SacarNombreEmpresa(1);
            lbTitulo.Text = "Cuentas Por Cobrar";
            lbTitulo.ForeColor = Color.White;
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            MostrarConsulta();
            btnReporte.Enabled = false;
            btnPago.Enabled = false;
            VariablesGlobales.IdMantenimiento = 0;
        }

        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CuntasPorCobrar_FormClosing(object sender, FormClosingEventArgs e)
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
            try {
                if (MessageBox.Show("¿Quieres seleccioanr este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (cbRegistroUnico.Checked == true)
                    {

                    }
                    else
                    {
                        this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdPaciente"].Value.ToString());
                        btnReporte.Enabled = true;
                        btnPago.Enabled = true;
                        var BuscarRegistroSeleccionado = ObjDataCObtabilidad.Value.BuscaCuentasCobrarr(
                            new Nullable<decimal>(),
                            VariablesGlobales.IdMantenimiento.ToString(),
                            null, null, null, null, null, 1, 9999);
                        dataGridView1.DataSource = BuscarRegistroSeleccionado;
                        OcultarColumnas();
                    }
                }
            }
            catch (Exception) { }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarConsulta();
            }
            else
            {
                MostrarConsulta();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no peude ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarConsulta();
            }
            else
            {
                MostrarConsulta();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataReporte.Value.SacarRutaReporte(7);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //SACAMOS LAS CREDENCIALS DE BASE DE DATOS
            var SacarCredenciales = ObjDataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            ////INVOCAMOS EL REPORTE
            //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Antiguedad = new Reporte.Reportes();
            //Antiguedad.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            //Antiguedad.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            //Antiguedad.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            //Antiguedad.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            //Antiguedad.GenerarReporteCuentasPorCobrar(VariablesGlobales.IdMantenimiento);
            //Antiguedad.ShowDialog();
                //GenerarReporteCuentasPorCobrar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad.PagosFacturasPendientes cxc = new PagosFacturasPendientes();
            cxc.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            cxc.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            cxc.ShowDialog();
        }
    }
}
