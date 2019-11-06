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
    public partial class TipoEmpaqueConsulta : Form
    {
        public TipoEmpaqueConsulta()
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
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            ListadoTipoEmpaque();
        }
        #endregion
        #region VALIDAR PAGINACION
        private void ValidarNumeroPagina()
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                ListadoTipoEmpaque();
            }
            else
            {
                ListadoTipoEmpaque();
            }
        }
        private void ValidarNumeroRegistros()
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                ListadoTipoEmpaque();
            }
            else
            {
                ListadoTipoEmpaque();
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE TIPO DE EMPAQUE
        private void ListadoTipoEmpaque()
        {
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaTipoEmpaque(
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
            this.dtListado.Columns["IdTipoEmpaque"].Visible = false;
            this.dtListado.Columns["CodigoTipoEmpaque"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
#endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TipoEmpaqueConsulta_Load(object sender, EventArgs e)
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
            ListadoTipoEmpaque();
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void TipoEmpaqueConsulta_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ListadoTipoEmpaque();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoEmpaque"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoTipoEmpaque"].Value.ToString());

                var Buscar = ObjDataInventario.Value.BuscaTipoEmpaque(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                dtListado.DataSource = Buscar;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnRestablecer.Enabled = true;
                btnConsultar.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo clave de seguridad vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //PROEDEMOS A DESHABILITAR
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoEmpaque Deshabilitar = new Logica.Entidades.EntidadInventario.ETipoEmpaque();

                    Deshabilitar.IdTipoEmpaque = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoTipoEmpaque = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjDataInventario.Value.MantenimientoTipoEmpaque(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestablecerPantalla();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoEmpaqueMantenimiento Mantenimiento = new TipoEmpaqueMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoEmpaqueMantenimiento Mantenimiento = new TipoEmpaqueMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }
    }
}
