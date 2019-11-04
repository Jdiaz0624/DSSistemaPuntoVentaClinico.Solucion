using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class TipoProductoMantenimiento : Form
    {
        public TipoProductoMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEMpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEMpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region CERRAR pANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProductoConsulta Consulta = new TipoProductoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region LIMPIAR PANTALLA
        private void LimpiarControles()
        {
            txtTipoProducto.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.Visible = true;
        }
#endregion
        private void TipoProductoMantenimiento_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
            groupBox1.ForeColor = Color.White;
            txtTipoProducto.ForeColor = Color.Black;
            cbEstatus.ForeColor = Color.White;
            btnAccion.ForeColor = Color.White;
            btnCerrar.ForeColor = Color.White;
            cbEstatus.Visible = false;
            cbEstatus.Checked = true;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataInventario.Value.BuscaTipoProducto(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtTipoProducto.Text = n.TipoProducto;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoProducto.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campio descripcion vacio para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoProducto Mantenimiento = new Logica.Entidades.EntidadInventario.ETipoProducto();

                Mantenimiento.IdTipoProducto = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoTipoProducto = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.TipoProducto = txtTipoProducto.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoTipoProducto(Mantenimiento, VariablesGlobales.AccionTomar);
                if (VariablesGlobales.AccionTomar != "INSERT")
                {
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void TipoProductoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
