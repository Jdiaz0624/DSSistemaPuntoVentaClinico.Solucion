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
    public partial class PacienteMantenimiento : Form
    {
        public PacienteMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> OjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS TIPOS DE COMPROBANTES
        private void MostrarTipocomprobante()
        {
            var Listado = OjdataListas.Value.ListadoComprobantes();
            ddlTipoComprobante.DataSource = Listado;
            ddlTipoComprobante.DisplayMember = "Descripcion";
            ddlTipoComprobante.ValueMember = "IdComprobante";
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS CENTROS DE SALUS
        private void MostrarCentroSalud()
        {
            var Listado = OjdataListas.Value.ListaCentrosalud();
            ddlCentroSalud.DataSource = Listado;
            ddlCentroSalud.DisplayMember = "Nombre";
            ddlCentroSalud.ValueMember = "IdCentroSalud";
        }
        #endregion
        #region CARGAR EL LISTADO DE LOS MEDICOS
        private void CargarMedicos()
        {
            try {
                var CargarMedicos = OjdataListas.Value.ListaMedicos(
                    Convert.ToDecimal(ddlCentroSalud.SelectedValue));
                ddlMedico.DataSource = CargarMedicos;
                ddlMedico.DisplayMember = "NombreMedico";
                ddlMedico.ValueMember = "IdMedico";
            }
            catch (Exception) { }
        }
        #endregion
        #region CARGAR LOS TIPOS DE IDENTIFICACION
        private void CargarTipoIdentificacion()
        {
            var Listado = OjdataListas.Value.ListaTipoIdentificacion();
            ddlTipoIdentificacion.DataSource = Listado;
            ddlTipoIdentificacion.DisplayMember = "Descripcion";
            ddlTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region CARGAR LOS SEXOS
        private void CargarLosSexos()
        {
            var Listado = OjdataListas.Value.ListaSexos();
            ddlSexo.DataSource = Listado;
            ddlSexo.DisplayMember = "Descripcion";
            ddlSexo.ValueMember = "IdSexo";
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ClienteCFonsulta Consulta = new ClienteCFonsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region LIMPIAR LOS CONTROLES
        private void LimpiarControles()
        {
            MostrarTipocomprobante();
            MostrarCentroSalud();
            CargarMedicos();
            CargarTipoIdentificacion();
            CargarLosSexos();
            cbEstatus.ForeColor = Color.White;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            txtComentario.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtNombrePaciente.Text = string.Empty;
            txtSala.Text = string.Empty;
            txtTelefonopaciente.Text = string.Empty;
            txtNombrePaciente.Focus();
        }
        #endregion
        #region MANTENIMIENTO DE PACIENTES
        private void MANPaciente()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EPacientes Mantenimiento = new Logica.Entidades.EntidadEmpresa.EPacientes();

            Mantenimiento.IdPaciente = VariablesGlobales.IdMantenimiento;
            Mantenimiento.CodigoPaciente = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.IdComprobante = Convert.ToDecimal(ddlTipoComprobante.SelectedValue);
            Mantenimiento.Nombre = txtNombrePaciente.Text;
            Mantenimiento.Telefono = txtTelefonopaciente.Text;
            Mantenimiento.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
            Mantenimiento.Sala = txtSala.Text;
            Mantenimiento.IdMedico = Convert.ToDecimal(ddlMedico.SelectedValue);
            Mantenimiento.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            Mantenimiento.TipoIdentificaion = txtIdentificacion.Text;
            Mantenimiento.Direccion = txtDireccion.Text;
            Mantenimiento.IdSexo = Convert.ToDecimal(ddlSexo.SelectedValue);
            Mantenimiento.Email = txtEmail.Text;
            Mantenimiento.Comentario = txtComentario.Text;
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona0 = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica0 = DateTime.Now;

            var MAN = ObjDataEmpresa.Value.MantenimientoPacientes(Mantenimiento, VariablesGlobales.AccionTomar);
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
            else
            {
                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarControles();
                }
                else
                {
                    CerrarPantalla();
                }
            }
        }
        #endregion
        private void PacienteMantenimiento_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.White;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtSala.ForeColor = Color.Black;
            txtTelefonopaciente.ForeColor = Color.Black;
            SacarInformacionEmpresa(1);
            MostrarTipocomprobante();
            MostrarCentroSalud();
            CargarMedicos();
            CargarTipoIdentificacion();
            CargarLosSexos();
            cbEstatus.ForeColor = Color.White;
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var GetData = ObjDataEmpresa.Value.BuscaClientes(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null,
                    null,
                    null,
                    null, 1, 1);
                foreach (var n in GetData)
                {
                    ddlTipoComprobante.Text = n.Comprobante;
                    txtNombrePaciente.Text = n.Nombre;
                    txtTelefonopaciente.Text = n.Telefono;
                    ddlCentroSalud.Text = n.CentroSalud;
                    txtSala.Text = n.Sala;
                    ddlMedico.Text = n.Medico;
                    ddlTipoIdentificacion.Text = n.TipoIdentificaion;
                    txtIdentificacion.Text = n.NumeroIdentificacion;
                    txtDireccion.Text = n.Direccion;
                    ddlSexo.Text = n.Sexo;
                    txtComentario.Text = n.Comentario;
                    txtEmail.Text = n.Email;
                }
            }
        }

        private void ddlCentroSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void ddlTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoIdentificacion.Text == "Cedula")
            {
                txtIdentificacion.Text = string.Empty;
                txtIdentificacion.Mask = "000-0000000-0";
            }
            else
            {
                txtIdentificacion.Text = string.Empty;
                txtIdentificacion.Mask = "";
            }
        }

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked == true)
            {
                cbEstatus.ForeColor = Color.White;
            }
            else
            {
                cbEstatus.ForeColor = Color.Red;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ddlCentroSalud.Text.Trim()) || string.IsNullOrEmpty(ddlMedico.Text.Trim()) || string.IsNullOrEmpty(ddlSexo.Text.Trim()) || string.IsNullOrEmpty(ddlTipoComprobante.Text.Trim()) || string.IsNullOrEmpty(ddlTipoIdentificacion.Text.Trim()) || string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MANPaciente();
                
            }
        }

        private void PacienteMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
