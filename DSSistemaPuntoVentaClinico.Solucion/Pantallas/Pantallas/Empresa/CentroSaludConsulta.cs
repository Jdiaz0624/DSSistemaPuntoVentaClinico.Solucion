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
    public partial class CentroSaludConsulta : Form
    {
        public CentroSaludConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        //SACAMOS LA INFORMACION DE LA EMPRESA
        private void SacarDataInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }

        //RESTABLECER PANTALLA
        private void RestablecerPantalla()
        {

            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnModificar.Enabled = false;
            btnRestablecer.Enabled = false;
            btnDeshabilitar.Enabled = false;
            lbClaveSeguridad.Enabled = false;
            txtClaveSeguridad.Enabled = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            ListadoCentroSalud();
            txtClaveSeguridad.Visible = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
        }

        private void ListadoCentroSalud()
        {
            string _Descripcion = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();

            var Buscar = ObjDataEmpresa.Value.BuscaCentroSalus(
                new Nullable<decimal>(),
                _Codigo, _Descripcion,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = Buscar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
        private void CentroSaludConsulta_Load(object sender, EventArgs e)
        {
            SacarDataInformacionEmpresa(1);
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            ListadoCentroSalud();
            txtClaveSeguridad.Visible = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Centro de Salud";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.CentroSaludMantenimiento Mantenimiento = new CentroSaludMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ListadoCentroSalud();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumeroPagina.Value = 1;
                ListadoCentroSalud();
            }
            else
            {
                ListadoCentroSalud();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                ListadoCentroSalud();
            }
            else
            {
                ListadoCentroSalud();
            }

        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdCentroSalud"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoCentroSalud"].Value.ToString());

                    var Buscar = ObjDataEmpresa.Value.BuscaCentroSalus(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, 1, 1);
                    dtListado.DataSource = Buscar;
                    OcultarColumnas();
                    btnNuevo.Enabled = false;
                    btnConsultar.Enabled = false;
                    txtNumeroPagina.Enabled = false;
                    txtNumeroRegistros.Enabled = false;
                    btnModificar.Enabled = true;
                    btnRestablecer.Enabled = true;
                    btnDeshabilitar.Enabled = true;
                    lbClaveSeguridad.Enabled = true;
                    txtClaveSeguridad.Enabled = true;
                    txtClaveSeguridad.Visible = true;
                    lbClaveSeguridad.Visible = true;
                }
            }
            catch (Exception) { }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.CentroSaludMantenimiento Mantenimiento = new CentroSaludMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.ShowDialog();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo clave de seguridad vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.ECentroSalud Deshabilitar = new Logica.Entidades.EntidadEmpresa.ECentroSalud();

                    Deshabilitar.IdCentroSalud = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoCentroSalud = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjDataEmpresa.Value.MantenimientoCentroSalud(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RestablecerPantalla();
                }
            }
        }

        private void CentroSaludConsulta_FormClosing(object sender, FormClosingEventArgs e)
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
