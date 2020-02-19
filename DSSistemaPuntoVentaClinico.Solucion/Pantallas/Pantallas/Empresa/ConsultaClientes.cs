using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class ConsultaClientes : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL NOMBRE DE LA EMPRESA
        private void MostrarInformacionEmpresa(int idInformacionEMpresa)
        {
          var NombreEMpresa=  ObjDataConfiguracion.Value.BuscaInformacionEmpresa(idInformacionEMpresa);
            foreach (var n in NombreEMpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS CLIENTES
        private void MostrarListadoClientes()
        {
            string _Nombre = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
            string _RNC = string.IsNullOrEmpty(txtRNC.Text.Trim()) ? null : txtRNC.Text.Trim();

            var MostrarListado = ObjDataEmpresa.Value.BuscaClientes(
                new Nullable<decimal>(),
                _Nombre,
                _RNC,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = MostrarListado;
            OcultarColumnas();
        }
        #endregion
        #region OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdCliente"].Visible = false;
            this.dtListado.Columns["IdComprobante"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
        }
        #endregion
        #region RESTABLECER LA PANTALLA
        private void RestablecerPantalla()
        {
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            btnConsultar.Enabled = true;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNombre.Text = string.Empty;
            txtRNC.Text = string.Empty;
            MostrarListadoClientes();
            btnRestablecer.Enabled = false;
        }
        #endregion
        public ConsultaClientes()
        {
            InitializeComponent();
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            lbTitulo.Text = "Consulta de Clientes";
            lbTitulo.ForeColor = Color.White;
            MostrarInformacionEmpresa(1);
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarListadoClientes();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListadoClientes();
            }
            else
            {
                MostrarListadoClientes();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value<1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListadoClientes();
            }
            else
            {
                MostrarListadoClientes();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCliente"].Value.ToString());

                //BUSCAMOS EL REGISTRO SELECCIONADO Y ACTIVAMOS LOS CAMPOS NECESARIOS
                var BuscarProductoSeleccionado = ObjDataEmpresa.Value.BuscaClientes(
                    VariablesGlobales.IdMantenimiento,
                    null, null, 1, 1);
                dtListado.DataSource = BuscarProductoSeleccionado;
                OcultarColumnas();

                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
                btnConsultar.Enabled = false;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                btnRestablecer.Enabled = true;
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                }
                else
                {
                    this.Hide();
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.MantenimientoClientes mantenimiento = new MantenimientoClientes();
                    mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
                    mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
                    mantenimiento.ShowDialog();
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                }
                else
                {
                    this.Hide();
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.MantenimientoClientes mantenimiento = new MantenimientoClientes();
                    mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    mantenimiento.VariablesGlobales.AccionTomar = "DISABLE";
                    mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
                    mantenimiento.ShowDialog();
                }
            }
        }

        private void ConsultaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.MantenimientoClientes mantenimiento = new MantenimientoClientes();
            mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            mantenimiento.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
