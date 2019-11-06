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
    public partial class TipoProveedorConsulta : Form
    {
        public TipoProveedorConsulta()
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
        #region SACAR EL PERFIL DEL USUARIO
        private void SacarPerfilUsuario(decimal IdUsuario)
        {
            var SacarPerfil = ObjDataSeguridad.Value.BuscaUsuario(
                IdUsuario, null, null, null, null, null, 1, 1);
            foreach (var n in SacarPerfil)
            {
                VariablesGlobales.IdPerfil = Convert.ToDecimal(n.IdPerfil);
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE TIPO DE PROVEEDORES
        private void MostrarListadoTipoProveedores()
        {
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaTipoProveedor(
                new Nullable<decimal>(),
                _Codigo,
                _Descripcion,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdTipoProveedor"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtDescripcion.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarListadoTipoProveedores();

        }
        #endregion
        #region VALIDAR PAGINACION
        private void ValidarNumeroPagina()
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListadoTipoProveedores();
            }
            else
            {
                MostrarListadoTipoProveedores();
            }
        }
        private void ValidarNumeroRegistros()
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListadoTipoProveedores();
            }
            else
            {
                MostrarListadoTipoProveedores();
            }
        }
#endregion

        private void TipoProveedorConsulta_Load(object sender, EventArgs e)
        {
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            SacarInformacionEmpresa(1);
            SacarPerfilUsuario(VariablesGlobales.IdUsuario);
            MostrarListadoTipoProveedores();
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarListadoTipoProveedores();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoProveedor"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoTipoProveedor"].Value.ToString());

                //CONSULTAMOS EL REGISTRO
                var Buscar = ObjDataInventario.Value.BuscaTipoProveedor(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnConsultar.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida o no pertenece al usuario conectado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //DESHABILITAMOS EL REGISTRO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoProveedor Deshabilitar = new Logica.Entidades.EntidadInventario.ETipoProveedor();

                    Deshabilitar.IdTipoProveedor = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoTipoProveedor = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjDataInventario.Value.MantenimientoTipoProveedor(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestablecerPantalla();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProveedorMantenimiento Mantenimiento = new TipoProveedorMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProveedorMantenimiento Mantenimiento = new TipoProveedorMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void TipoProveedorConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            ValidarNumeroPagina();
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            ValidarNumeroRegistros();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
