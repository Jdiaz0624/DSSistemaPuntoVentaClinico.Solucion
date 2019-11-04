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
    public partial class ProveedorMantenimiento : Form
    {
        public ProveedorMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> objDataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuario(decimal IdUsuario)
        {

        }
        #endregion
        #region CARGAR LOS TIPOS DE PROVEEDORES
        private void CargarTipoProveedores()
        {
            var Cargar = objDataListas.Value.ListaTipoProveedor();
            ddlTipoProveedor.DataSource = Cargar;
            ddlTipoProveedor.ValueMember = "IdTipoProveedor";
            ddlTipoProveedor.DisplayMember = "Descripcion";

        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProveedorConsulta Consulta = new ProveedorConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        private void limpiarControles()
        {
            CargarTipoProveedores();
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefonos.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtContacto.Text = string.Empty;
        }
        #endregion
        private void SacarInformacionEMpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        private void ProveedorMantenimiento_Load(object sender, EventArgs e)
        {
            SacarInformacionEMpresa(1);
            cbEstatus.Checked = true;
            cbLlevaComision.Checked = true;
            cbLlevaComision.Visible = false;
            cbEstatus.Visible = false;
            txtContacto.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtFax.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            txtTelefonos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.White;
            btnCerrar.ForeColor = Color.White;
            CargarTipoProveedores();
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataInventario.Value.BuscaProveedor(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    ddlTipoProveedor.Text = n.TipoProveedor;
                    txtNombre.Text = n.Nombre;
                    txtDireccion.Text = n.Direccion;
                    txtTelefonos.Text = n.Telefonos;
                    txtFax.Text = n.Fax;
                    txtContacto.Text = n.Contacto;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbLlevaComision.Checked = (n.LlevaComision0.HasValue ? n.LlevaComision0.Value : false);
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
            if (string.IsNullOrEmpty(ddlTipoProveedor.Text.Trim()) || string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //REALIZAMOS EL MANTENIMIENTO
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EProveedor Mantenimiento = new Logica.Entidades.EntidadInventario.EProveedor();

                Mantenimiento.IdProveedor = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoProveedor = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.IdTipoProveedor = Convert.ToDecimal(ddlTipoProveedor.SelectedValue);
                Mantenimiento.Nombre = txtNombre.Text;
                Mantenimiento.Direccion = txtDireccion.Text;
                Mantenimiento.Telefonos = txtTelefonos.Text;
                Mantenimiento.Fax = txtFax.Text;
                Mantenimiento.Contacto = txtContacto.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.LlevaComision0 = cbLlevaComision.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoProveedor(Mantenimiento, VariablesGlobales.AccionTomar);
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
                        limpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }


            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
