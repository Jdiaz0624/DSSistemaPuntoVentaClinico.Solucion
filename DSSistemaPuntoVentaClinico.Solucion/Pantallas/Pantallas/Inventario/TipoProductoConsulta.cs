using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class TipoProductoConsulta : Form
    {
        public TipoProductoConsulta()
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
        #region METODOS PARA PODER MOVER EL MENU PRINCIPAL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        #region MOSTRAR EL LISTADO DE LA CONSULTA
        private void ListadoTipoProducto()
        {
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaTipoProducto(
                new Nullable<decimal>(),
                null, _Descripcion,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdTipoProducto"].Visible = false;
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
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRestablecer.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            lbClave.Visible = false;
            txtClave.Text = string.Empty;
            txtClave.Visible = false;
            txtDescripcion.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            ListadoTipoProducto();
        }
#endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TipoProductoConsulta_Load(object sender, EventArgs e)
        {
            gbBuscar.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            lbUsuarioConectado.ForeColor = Color.Black;
            lbPerfilUsuarioConectado.ForeColor = Color.Black;
            ListadoTipoProducto();
            SacarInformacionEmpresa(1);
            txtClave.PasswordChar = '•';
            dtListado.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Tipo de Producto";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ListadoTipoProducto();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdTipoProducto"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoTipoProducto"].Value.ToString());

                var SacarDatos = ObjDataInventario.Value.BuscaTipoProducto(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                dtListado.DataSource = SacarDatos;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnConsultar.Enabled = false;
                btnDeshabilitar.Enabled = true;
                btnModificar.Enabled = true;
                btnRestablecer.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                lbClave.Visible = true;
                txtClave.Visible = true;
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void TipoProductoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS AL CLAVE DE SEGURIDAD
            if (string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede star vacio para deshabilitar el registro seleccionado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS SI LA CLAVE INGRESADA ES VALIDA
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);

                var Verificar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario,
                    1, 1);
                if (Verificar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Text = string.Empty;
                    txtClave.Focus();
                }
                else
                {
                    //DESHABILITAMOS EL REGISTRO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.ETipoProducto Deshabilitar = new Logica.Entidades.EntidadInventario.ETipoProducto();

                    Deshabilitar.IdTipoProducto = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoTipoProducto = VariablesGlobales.CodigoMantenimiento;
                    Deshabilitar.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                    Deshabilitar.FechaModifica0 = DateTime.Now;

                    var MAN = ObjDataInventario.Value.MantenimientoTipoProducto(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestablecerPantalla();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProductoMantenimiento Mantenimiento = new TipoProductoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProductoMantenimiento Mantenimiento = new TipoProductoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                ListadoTipoProducto();
            }
            else
            {
                ListadoTipoProducto();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                ListadoTipoProducto();
            }
            else
            {
                ListadoTipoProducto();
            }
        }
    }
}
