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
    public partial class ProveedorConsulta : Form
    {
        public ProveedorConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> objDataListas = new Lazy<Logica.Logica.LogicaListas>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuario(decimal IdUsuario)
        {
            
        }
        #endregion
        #region SACAR EL LISTADO DE ALMACENES

        
        #endregion
        #region RESTABLECER PANTALLA
        private void Restablecer()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            CargarTipoProveedores();
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            CargarProveedores();
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
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
        #region CARGAR EL LISTADO DE LOS PROVEEDORES
        private void CargarProveedores()
        {
            //     decimal? IdOficina = ddlOficinaConsulta.SelectedValue != "-1" ? decimal.Parse(ddlOficinaConsulta.SelectedValue) : new Nullable<decimal>();
           // decimal? _IdTipoProveedor = ddlTipoProveedor.SelectedValue.ToString() != "-1" ? decimal.Parse(ddlTipoProveedor.SelectedValue.ToString()) : new Nullable<decimal>();
            string _Nombre = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
            string _Apellido = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaProveedor(
                new Nullable<decimal>(),
                _Apellido,
                null,
                _Nombre,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdProveedor"].Visible = false;
            this.dtListado.Columns["IdTipoProveedor"].Visible = false;
            this.dtListado.Columns["LlevaComision0"].Visible = false;
            this.dtListado.Columns["LlevaComision"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion

        private void ProveedorConsulta_Load(object sender, EventArgs e)
        {
            CargarTipoProveedores();
            CargarProveedores();
            gbListado.ForeColor = Color.White;
            gbOpciones.ForeColor = Color.White;
            groupBox1.ForeColor = Color.White;
            lbNumeroPagina.ForeColor = Color.White;
            lbNumeroRegistros.ForeColor = Color.White;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                CargarProveedores();
            }
            else
            {
                CargarProveedores();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value<1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                CargarProveedores();
            }
            else
            {
                CargarProveedores();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProveedor"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoProveedor"].Value.ToString());

                //SACAMOS LOS DATOS DEL PROVEEDOR
                var SacarDatos = ObjDataInventario.Value.BuscaProveedor(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, null, 1, 1);
                dtListado.DataSource = SacarDatos;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnConsultar.Enabled = false;
                btnRestablecer.Enabled = true;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                txtClaveSeguridad.Focus();
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS LA CLAVE
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Verificar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario, 1, 1);
                if (Verificar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //DESHABILITAMOS EL REGISTRO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EProveedor Deshabilitar = new Logica.Entidades.EntidadInventario.EProveedor();

                    Deshabilitar.IdProveedor = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoProveedor = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjDataInventario.Value.MantenimientoProveedor(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClaveSeguridad.Clear();
                    Restablecer();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProveedorMantenimiento Mantenimiento = new ProveedorMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProveedorMantenimiento Mantenimiento = new ProveedorMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void ProveedorConsulta_FormClosing(object sender, FormClosingEventArgs e)
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
