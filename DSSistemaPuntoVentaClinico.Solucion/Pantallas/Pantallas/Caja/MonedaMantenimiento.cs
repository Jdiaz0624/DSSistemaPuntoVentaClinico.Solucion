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
    public partial class MonedaMantenimiento : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DE LA EMPRESA
        private void SacarDatosEmpresa(decimal IdInformacionEmpresa)
        {
            var Sa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in Sa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MANTENIMIENTO DE MONEDAS
        private void MANMonedas()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EMoneda Mantenimiento = new Logica.Entidades.EntidadesCaja.EMoneda();

            Mantenimiento.IdMoneda = VariablesGlobales.IdMantenimiento;
            Mantenimiento.CodigoMoneda = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.Moneda = txtMoneda.Text;
            Mantenimiento.Sigla = txtSigla.Text;
            Mantenimiento.Tasa = Convert.ToDecimal(txtTasa.Text);
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.PorDefault0 = cbPorDefecto.Checked;
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona0 = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica0 = DateTime.Now;

            var MAn = ObjDataCaja.Value.MantenimientoMoneda(Mantenimiento, VariablesGlobales.AccionTomar);
            if (cbPorDefecto.Checked)
            {
                var PorDefecto = ObjDataCaja.Value.MantenimientoMoneda(Mantenimiento, "DEFAULT");
            }
        }
        #endregion
        #region LimpiarControles
        private void LimpiarControles()
        {
            txtMoneda.Text = string.Empty;
            txtSigla.Text = string.Empty;
            txtTasa.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            cbPorDefecto.Checked = false;
            txtMoneda.Focus();
        }
#endregion
        public MonedaMantenimiento()
        {
            InitializeComponent();
        }
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja.MonedaListado Listado = new MonedaListado();
            Listado.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Listado.ShowDialog();
        }
        private void MonedaMantenimiento_Load(object sender, EventArgs e)
        {
            SacarDatosEmpresa(1);
            groupBox1.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            txtMoneda.ForeColor = Color.Black;
            txtSigla.ForeColor = Color.Black;
            txtTasa.ForeColor = Color.Black;
            cbEstatus.ForeColor = Color.Red;
            cbPorDefecto.ForeColor = Color.Red;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            cbPorDefecto.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                cbPorDefecto.Visible = true;
                var Sacardatos = ObjDataCaja.Value.BucaMoneda(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in Sacardatos)
                {
                    txtMoneda.Text = n.Moneda;
                    txtSigla.Text = n.Sigla;
                    txtTasa.Text = n.Tasa.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbPorDefecto.Checked = (n.PorDefault0.HasValue ? n.PorDefault0.Value : false);
                    if (cbEstatus.Checked == true)
                    {
                        cbEstatus.Visible = false;
                    }
                    else
                    {
                        cbEstatus.Visible = true;
                    }
                }
            }
        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked)
            {
                cbEstatus.ForeColor = Color.White;
            }
            else
            {
                cbEstatus.ForeColor = Color.Red;
            }
        }

        private void cbPorDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorDefecto.Checked)
            {
                cbPorDefecto.ForeColor = Color.White;
            }
            else
            {
                cbPorDefecto.ForeColor = Color.Red;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoneda.Text.Trim()) || string.IsNullOrEmpty(txtSigla.Text.Trim()) || string.IsNullOrEmpty(txtTasa.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MANMonedas();
                if (VariablesGlobales.AccionTomar != "INSERT")
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else
                {

                   MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres Agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
            }
        }

        private void MonedaMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
