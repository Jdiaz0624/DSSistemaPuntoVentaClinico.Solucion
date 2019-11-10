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
    public partial class ClienteCFonsulta : Form
    {
        public ClienteCFonsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjdataEmpres = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarinformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS PACIENTES
        private void MostrarPacientes()
        {
            string _Nombre = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Consultar = ObjdataEmpres.Value.BuscaClientes(
                new Nullable<decimal>(),
                _Codigo,
                null,
                _Nombre,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Consultar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdPaciente"].Visible = false;
            this.dtListado.Columns["IdComprobante"].Visible = false;
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["IdMedico"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdSexo"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;

        }
        #endregion
        #region RESTABLECER PANTALLA
        private void Restablecerpantalla()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
            txtClaveSeguridad.Visible = false;
            MostrarPacientes();
        }
#endregion
        private void ClienteCFonsulta_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            lbClaveSeguridad.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            SacarinformacionEmpresa(1);
            MostrarPacientes();
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Pacientes";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.PacienteMantenimiento Mantenimiento = new PacienteMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarPacientes();
            }
            else
            {
                MostrarPacientes();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarPacientes();
            }
            else
            {
                MostrarPacientes();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdPaciente"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoPaciente"].Value.ToString());

                    var Buscar = ObjdataEmpres.Value.BuscaClientes(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, null, null, null, 1, 1);
                    dtListado.DataSource = Buscar;
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
                }
            }
            catch (Exception) { }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecerpantalla();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validarclave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario,
                    1, 1);
                if (Validarclave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, o el usuario no es el dueño de la clave ingresada", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    //DESHABILITAMOS
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EPacientes Deshabilitar = new Logica.Entidades.EntidadEmpresa.EPacientes();

                    Deshabilitar.IdPaciente = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoPaciente = VariablesGlobales.CodigoMantenimiento;
                    Deshabilitar.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                    Deshabilitar.FechaAdiciona0 = DateTime.Now;
                    Deshabilitar.UsuarioModifica = VariablesGlobales.IdUsuario;
                    Deshabilitar.FechaModifica0 = DateTime.Now;

                    var MAn = ObjdataEmpres.Value.MantenimientoPacientes(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restablecerpantalla();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.PacienteMantenimiento Mantenimiento = new PacienteMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.ShowDialog();
        }

        private void ClienteCFonsulta_FormClosing(object sender, FormClosingEventArgs e)
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
