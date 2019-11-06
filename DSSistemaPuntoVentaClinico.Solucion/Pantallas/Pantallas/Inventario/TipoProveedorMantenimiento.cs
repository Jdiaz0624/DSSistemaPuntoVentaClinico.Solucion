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
    public partial class TipoProveedorMantenimiento : Form
    {
        public TipoProveedorMantenimiento()
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
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProveedorConsulta Consulta = new TipoProveedorConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion
        private void TipoProveedorMantenimiento_Load(object sender, EventArgs e)
        {
            gbDatos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            txtTipoProveedor.ForeColor = Color.Black;
            SacarInformacionEmpresa(1);
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataInventario.Value.BuscaTipoProveedor(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtTipoProveedor.Text = n.TipoProveedor;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoProveedor.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo tipo de proveedor vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //HACEMOS EL MANTENIMIENTOS
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoProveedor Mantenimiento = new Logica.Entidades.EntidadInventario.ETipoProveedor();

                Mantenimiento.IdTipoProveedor = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoTipoProveedor = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.TipoProveedor = txtTipoProveedor.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoTipoProveedor(Mantenimiento, VariablesGlobales.AccionTomar);
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
                        txtTipoProveedor.Text = string.Empty;
                        cbEstatus.Checked = true;
                        cbEstatus.Visible = false;
                    }
                    else
                    {
                        CerrarPantalla();
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

        private void TipoProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
