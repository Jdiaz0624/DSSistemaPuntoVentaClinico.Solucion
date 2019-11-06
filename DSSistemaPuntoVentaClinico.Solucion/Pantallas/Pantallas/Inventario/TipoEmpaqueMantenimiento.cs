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
    public partial class TipoEmpaqueMantenimiento : Form
    {
        public TipoEmpaqueMantenimiento()
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
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoEmpaqueConsulta Consulta = new TipoEmpaqueConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region LIMPIAR PANTALLA
        private void LimpiarPantalla()
        {
            txtTipoEmpaque.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
        }
        #endregion
        private void TipoEmpaqueMantenimiento_Load(object sender, EventArgs e)
        {
            SacarInformacionEmpresa(1);
            gbDatos.ForeColor = Color.Black;
            txtTipoEmpaque.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataInventario.Value.BuscaTipoEmpaque(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtTipoEmpaque.Text = n.TipoEmpaque;
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

        private void TipoEmpaqueMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoEmpaque.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo Tipo de empaque vacio para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //PROCEDEMOS A REALIZAR EL MANTENIMIETO
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoEmpaque MAntenimiento = new Logica.Entidades.EntidadInventario.ETipoEmpaque();

                MAntenimiento.IdTipoEmpaque = VariablesGlobales.IdMantenimiento;
                MAntenimiento.CodigoTipoEmpaque = VariablesGlobales.CodigoMantenimiento;
                MAntenimiento.TipoEmpaque = txtTipoEmpaque.Text;
                MAntenimiento.Estatus0 = cbEstatus.Checked;
                MAntenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                MAntenimiento.FechaAdiciona0 = DateTime.Now;
                MAntenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                MAntenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoTipoEmpaque(MAntenimiento, VariablesGlobales.AccionTomar);
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
                        LimpiarPantalla();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
            }
        }
    }
}
