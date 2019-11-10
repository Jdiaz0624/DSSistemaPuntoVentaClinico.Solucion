using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL LISTADO DE LOS USUARIOS
        private void MostrarListadoUsuarios()
        {
            string _usuario = string.IsNullOrEmpty(txtUsuaio.Text.Trim()) ? null : txtUsuaio.Text.Trim();
            string _Persona = string.IsNullOrEmpty(txtPersona.Text.Trim()) ? null : txtPersona.Text.Trim();

            var Listado = ObjdataSeguridad.Value.BuscaUsuario(
                new Nullable<decimal>(),
                null,
                null,
                _usuario,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Listado;
            OcultarColumnas();
                
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["CodigoUsuario"].Visible = false;
            this.dtListado.Columns["IdPerfil"].Visible = false;
            this.dtListado.Columns["Perfil"].Visible = false;
            this.dtListado.Columns["Clave"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion
        #region RESTABLECER LA PANTALLA
        private void Rstablcer()
        {
            btnRestablecer.Enabled = false;
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtClaveSeguridad.Text = string.Empty;
            txtUsuaio.Text = string.Empty;
            MostrarListadoUsuarios();
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
        }
#endregion
        private void ListadoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            gbConsulta.ForeColor = Color.White;
            gbOpciones.ForeColor = Color.White;
            gbListado.ForeColor = Color.White;
            txtUsuaio.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Usuarios";
            dtListado.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarListadoUsuarios();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListadoUsuarios();
            }
            else
            {
                MostrarListadoUsuarios();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListadoUsuarios();
            }
            else
            {
                MostrarListadoUsuarios();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres selccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdUsuario"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoUsuario"].Value.ToString());

                //MOSTRAMOS EL REGISTRO SELECCIONADO

                var Mostrar = ObjdataSeguridad.Value.BuscaUsuario(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, null, null, null, 1, 1);
                dtListado.DataSource = Mostrar;
                OcultarColumnas();
                btnNuevo.Enabled = false;
                btnConsultar.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                btnRestablecer.Enabled = true;
                lbClaveSeguridad.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Rstablcer();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad.MantenimientoUsuarios Mantenimiento = new MantenimientoUsuarios();
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad.MantenimientoUsuarios Mantenimiento = new MantenimientoUsuarios();
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDMAOS LA CLAVE DE SEGURIDAD
                string ClaveSeguridads = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var ClaveSeguridad = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                    ClaveSeguridads, VariablesGlobales.IdUsuario, 1, 1);
                if (ClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad no es valida, o no pertenece al usuario conectado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario mantenimiento = new Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario();

                    mantenimiento.IdUsuario = VariablesGlobales.IdMantenimiento;
                    mantenimiento.CodigoUsuario = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjdataSeguridad.Value.MantenimientoUsuario(mantenimiento, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Rstablcer();
                }

            }
        }
    }
}
