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
    public partial class MantenimientoClientes : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL NOMBRE DE LA EMPRESA
        private void MostrarInformacionEmpresa(int idInformacionEMpresa)
        {
            var NombreEMpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(idInformacionEMpresa);
            foreach (var n in NombreEMpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS COMPROBANTES FISCALES
        private void MostrarListadoCOmprobantes()
        {
            var MostrarListado = ObjdataListas.Value.ListadoComprobantes();
            ddlTipoComprobante.DataSource = MostrarListado;
            ddlTipoComprobante.DisplayMember = "Descripcion";
            ddlTipoComprobante.ValueMember = "IdComprobante";
        }
        #endregion
        #region CARGAR EL LISTADO DE LOS TIPO DE IDENTIFICACION
        private void CargarTipoIdentificacion()
        {
            var CargarListado = ObjdataListas.Value.ListaTipoIdentificacion();
            ddlTipoIdentificacion.DataSource = CargarListado;
            ddlTipoIdentificacion.DisplayMember = "Descripcion";
            ddlTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region MANTENIMIENTO DE CLIENTES
        private void MANClientes()
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EClientes Mantenimiento = new Logica.Entidades.EntidadEmpresa.EClientes();

                Mantenimiento.IdCliente = VariablesGlobales.IdMantenimiento;
                Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoComprobante.SelectedValue);
                Mantenimiento.Nombre = txtNombrePaciente.Text;
                Mantenimiento.Telefono = txtTelefonopaciente.Text;
                Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
                Mantenimiento.RNC = txtRNC.Text;
                Mantenimiento.Direccion = txtDireccion.Text;
                Mantenimiento.Email = txtEmail.Text;
                Mantenimiento.Comentario = txtComentario.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica = DateTime.Now;
                Mantenimiento.MontoCredito = Convert.ToDecimal(txtLimiteCredito.Text);

                var MAn = ObjDataEmpresa.Value.MantenimientoClientes(Mantenimiento, VariablesGlobales.AccionTomar);

            }
            catch (Exception) {
                MessageBox.Show("Error al realiar el mantenimiento de cliente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ConsultaClientes Consulta = new ConsultaClientes();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region LIMPIAR CONTROLES
        private void LimpiarControles()
        {
            MostrarListadoCOmprobantes();
            txtNombrePaciente.Text = string.Empty;
            txtTelefonopaciente.Text = string.Empty;
            CargarTipoIdentificacion();
            txtRNC.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtComentario.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLimiteCredito.Text = string.Empty;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
        }
        #endregion
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            MostrarInformacionEmpresa(1);
            MostrarListadoCOmprobantes();
            CargarTipoIdentificacion();
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatosCliente = ObjDataEmpresa.Value.BuscaClientes(
                    VariablesGlobales.IdMantenimiento,
                    null, null, 1, 1);
                foreach (var n in SacarDatosCliente)
                {
                    ddlTipoComprobante.Text = n.TipoComprobante;
                    txtNombrePaciente.Text = n.Nombre;
                    txtTelefonopaciente.Text = n.Telefono;
                    ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtRNC.Text = n.RNC;
                    txtDireccion.Text = n.Direccion;
                    txtComentario.Text = n.Comentario;
                    txtEmail.Text = n.Email;
                    txtLimiteCredito.Text = n.MontoCredito.ToString();
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
            if (VariablesGlobales.AccionTomar == "DISABLE")
            {
                groupBox1.Enabled = false;
            }

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlTipoComprobante.Text.Trim()) || string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()) || string.IsNullOrEmpty(ddlTipoIdentificacion.Text.Trim()) || string.IsNullOrEmpty(txtRNC.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar este proceso, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MANClientes();
                MessageBox.Show("Operación realzada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (VariablesGlobales.AccionTomar == "INSERT")
                {
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
                else
                {
                    CerrarPantalla();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoClientes_FormClosing(object sender, FormClosingEventArgs e)
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
