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
    public partial class AsistentesConsulta : Form
    {
        public AsistentesConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataInventario = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA CLAVE DE SEGURIDAD
        private void SacarNombreEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarNombreEMpresa = ObjDataInventario.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarNombreEMpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS ASISTENTES DE CIRUGIA
        private void MostrarListado()
        {
            string _Nombre = string.IsNullOrEmpty(txtNombreConsulta.Text.Trim()) ? null : txtNombreConsulta.Text.Trim();

            var Buscar = ObjDataEmpresa.Value.BuscaAsistenteCirugia(
                new Nullable<decimal>(),
                null,
                _Nombre,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        #endregion
        #region OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdAsistenteCirugia"].Visible = false;
            this.dtListado.Columns["CodigoAsistenteCirugia"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        #endregion
        #region DESHABILITAR ASISTENTE DE CIRUGIA
        private void DeshabilitarAsistenteCirugia()
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia Deshabilitar = new Logica.Entidades.EntidadEmpresa.EAsistenteCirugia();

                Deshabilitar.IdAsistenteCirugia = VariablesGlobales.IdMantenimiento;
                Deshabilitar.CodigoAsistenteCirugia = VariablesGlobales.CodigoMantenimiento;
                Deshabilitar.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Deshabilitar.FechaAdiciona0 = DateTime.Now;
                Deshabilitar.UsuarioModifica = VariablesGlobales.IdUsuario;
                Deshabilitar.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataEmpresa.Value.MantenimeintoAsistenteCirugia(Deshabilitar, "DISABLE");
                MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                RestablecerPantalla();
                
            }
            catch (Exception) {
                MessageBox.Show("Error al deshabilitar el asistente de cirugia", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region RESTABLECER LA PANTALLA
        private void RestablecerPantalla()
        {
            txtNombreConsulta.Text = string.Empty;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarListado();
            btnConsultar.Enabled = true;
            btnNuevo.Enabled = true;
            btnDeshabilitar.Enabled = false;
            btnModificar.Enabled = false;
            btnRestablecer.Enabled = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            lbClave.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
        }
        #endregion
        private void AsistentesConsulta_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;

            txtClaveSeguridad.PasswordChar = '•';
            txtClaveSeguridad.MaxLength = 20;
            SacarNombreEmpresa(1);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Asistente de Cirugia consulta";
            RestablecerPantalla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.AsistentesMantenimiento Mantenimiento = new AsistentesMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.btnAccion.Text = "Guardar";
            Mantenimiento.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar el campo de la clave de seguridad", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    this.Hide();
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.AsistentesMantenimiento Mantenimiento = new AsistentesMantenimiento();
                    Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
                    Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
                    Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
                    Mantenimiento.btnAccion.Text = "Modificar";
                    Mantenimiento.ShowDialog();
                }
            }
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar el campo de la clave de seguridad", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    //DESHABILITAR
                    DeshabilitarAsistenteCirugia();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AsistentesConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdAsistenteCirugia"].Value.ToString());
                this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoAsistenteCirugia"].Value.ToString());

                var Seleccionar = ObjDataEmpresa.Value.BuscaAsistenteCirugia(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                dtListado.DataSource = Seleccionar;
                OcultarColumnas();
                btnConsultar.Enabled = false;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = true;
                btnDeshabilitar.Enabled = true;
                btnRestablecer.Enabled = true;
                txtNumeroPagina.Enabled = false;
                txtNumeroRegistros.Enabled = false;
                lbClave.Visible = true;
                txtClaveSeguridad.Visible = true;
            }
        }
    }
}
