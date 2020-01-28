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
           // this.dataGridView1.Columns["FechaFacturacion"].Visible = false;
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
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            MostrarConsulta();
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
            if (MessageBox.Show("¿Quieres seleccioanr este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cbRegistroUnico.Checked == true)
                {

                }
                else
                {

                }
            }
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
    }
}
