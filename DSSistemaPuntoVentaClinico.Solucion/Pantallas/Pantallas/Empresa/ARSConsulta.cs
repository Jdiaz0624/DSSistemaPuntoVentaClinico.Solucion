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
    public partial class ARSConsulta : Form
    {
        public ARSConsulta()
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
        private void RestablecerPantalla()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
            ListadoARS();
        }
        #region MOSTRAR EL LISTADO DE ARS
        private void ListadoARS()
        {
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();
            string _Descripcion = string.IsNullOrEmpty(txtNombre.Text.Trim()) ? null : txtNombre.Text.Trim();

            var Buscar = ObjDataEmpresa.Value.BuscaARS(
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
            this.dtListado.Columns["IdARS"].Visible = false;
            this.dtListado.Columns["Estatus0"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
        }
#endregion
        private void ARSConsulta_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            SacarDataInformacionEmpresa(1);
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
            ListadoARS();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de ARS";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ARSMantenimiento Mantenimiento = new ARSMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ListadoARS();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                ListadoARS();
            }
            else
            {
                ListadoARS();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                ListadoARS();
            }
            else
            {
                ListadoARS();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdARS"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtListado.CurrentRow.Cells["CodigoARS"].Value.ToString());

                    var Buscar = ObjDataEmpresa.Value.BuscaARS(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, 1, 1);
                    dtListado.DataSource = Buscar;
                    OcultarColumnas();

                    btnNuevo.Enabled = false;
                    btnConsultar.Enabled = false;
                    txtNumeroPagina.Enabled = false;
                    txtNumeroRegistros.Enabled = false;
                    btnRestablecer.Enabled = true;
                    btnModificar.Enabled = true;
                    btnDeshabilitar.Enabled = true;
                    lbClaveSeguridad.Visible = true;
                    txtClaveSeguridad.Visible = true;
                }
            }
            catch (Exception) { }
        }

        private void ARSConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void gbListado_Enter(object sender, EventArgs e)
        {

        }
    }
}
