using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    public partial class ProgramacionCirugiaConsulta : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFActuracion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LA INFORMACION DE LA EMPRESA
        private void MostrarInformacionEmpresa(int idInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(idInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTAD DE LAS CIRUGIAS
        private void MostrarHistorialCirugias()
        {
            var MostrarListado = ObjDataFActuracion.Value.BuscaProgramacionCirugia(
                new Nullable<decimal>(),
                Convert.ToDateTime(txtFechaDesde.Text),
                Convert.ToDateTime(txtFechaHasta.Text),
                null, null, null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = MostrarListado;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdProgramacionCirugia"].Visible = false;
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["IdMedico"].Visible = false;
            this.dtListado.Columns["IdAuxiliarCirugia"].Visible = false;
            this.dtListado.Columns["IdHoraCirugia"].Visible = false;
            this.dtListado.Columns["IdEstatusCirugia"].Visible = false;
            this.dtListado.Columns["UsuarioAdiciona"].Visible = false;
            this.dtListado.Columns["FechaAdiciona0"].Visible = false;
            this.dtListado.Columns["IdTipoFacturacion"].Visible = false;
            this.dtListado.Columns["UsuarioModifica"].Visible = false;
            this.dtListado.Columns["ModificadoPor"].Visible = false;
            this.dtListado.Columns["FechaModifica0"].Visible = false;
            this.dtListado.Columns["FechaModifica"].Visible = false;
            this.dtListado.Columns["IdCentroSaludAnterior"].Visible = false;
            this.dtListado.Columns["IdMedicoAnterior"].Visible = false;
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdSexo"].Visible = false;
            this.dtListado.Columns["Email"].Visible = false;
            this.dtListado.Columns["ComentarioPaciente"].Visible = false;
            this.dtListado.Columns["FechaFacturacion0"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["FechaCirugia0"].Visible = false;
        }
        #endregion
        #region RESTABLECER LA PANTALLA
        private void RestablecerPantalla()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarHistorialCirugias();
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtClaveSeguridad.Text = string.Empty;
            btnGastosCirugia.Enabled = false;
        }
        #endregion

        public ProgramacionCirugiaConsulta()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugias Mantenimiento = new ProgramacionCirugias();
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.NumeroFacturaMantenimiento = VariablesGlobales.NumeroFacturaMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }

        private void ProgramacionCirugiaConsulta_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            MostrarInformacionEmpresa(1);
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Programación de cirugias";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbBuscarTodo.Checked)
            {
                var MostrarListado = ObjDataFActuracion.Value.BuscaProgramacionCirugia(
             new Nullable<decimal>(),
             null,
             null,
             null, null, null, null,
             Convert.ToInt32(txtNumeroPagina.Value),
             Convert.ToInt32(txtNumeroRegistros.Value));
                dtListado.DataSource = MostrarListado;
                OcultarColumnas();
            }
            else
            {
                MostrarHistorialCirugias();
            }
           
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarHistorialCirugias();
            }
            else
            {
                MostrarHistorialCirugias();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarHistorialCirugias();
            }
            else
            {
                MostrarHistorialCirugias();
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.NumeroFacturaMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NoFactura"].Value.ToString());
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["IdProgramacionCirugia"].Value.ToString());
                    btnNuevo.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnDeshabilitar.Enabled = true;
                    lbClaveSeguridad.Visible = true;
                    txtClaveSeguridad.Visible = true;
                    btnRestablecer.Enabled = true;
                    txtNumeroPagina.Enabled = false;
                    txtNumeroRegistros.Enabled = false;
                    btnGastosCirugia.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS LA CLAVE DE SEGURIDAD
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("La clave de seguridad no puede estar vacia, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS SI LA CLAVE DE SEGURIDAD ES VALIDA
                string Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    Clave, null, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    this.Hide();
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugias Modificar = new ProgramacionCirugias();
                    Modificar.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
                    Modificar.VariablesGlobales.NumeroFacturaMantenimiento = VariablesGlobales.NumeroFacturaMantenimiento;
                    Modificar.VariablesGlobales.AccionTomar = "UPDATE";
                    Modificar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                    Modificar.ShowDialog();
                }
            }
            
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar la clave de seguridad", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS LA CLAVE DE SEGURIDAD
                string Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    Clave, null, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    if (MessageBox.Show("¿Quieres eliminar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //ELIMINAMOS EL REGISTRO
                        DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia Borrar = new Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia();

                        Borrar.IdProgramacionCirugia = VariablesGlobales.IdMantenimiento;

                        var MAN = ObjDataFActuracion.Value.MantenimientoProgramacionCirugia(Borrar, "DELETE");
                        MessageBox.Show("Registro eliminado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RestablecerPantalla();
                    }
                    else
                    {

                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }

        private void ProgramacionCirugiaConsulta_FormClosing(object sender, FormClosingEventArgs e)
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
