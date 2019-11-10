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
    public partial class MantenimientoTipoPago : Form
    {
        public MantenimientoTipoPago()
        {
            InitializeComponent();
        }
        public Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var Sacar = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in Sacar)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL LISTADO DE TIPO DE PAGOS
        private void MostrarListado()
        {
            string _TipoPago = string.IsNullOrEmpty(txtTipoPago.Text.Trim()) ? null : txtTipoPago.Text.Trim();

            var Buscar = ObjDataFacturacion.Value.ListadoTipoPago(
                new Nullable<decimal>(),
                null,
                _TipoPago,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dataGridView1.DataSource = Buscar;
            OcutarColumnas();
        }
        private void OcutarColumnas()
        {
            this.dataGridView1.Columns["IdTipoPago"].Visible = false;
            this.dataGridView1.Columns["Estatus0"].Visible = false;
            this.dataGridView1.Columns["BloqueaMontoPagar0"].Visible = false;
            this.dataGridView1.Columns["UsuarioAdiciona"].Visible = false;
            this.dataGridView1.Columns["FechaAdiciona0"].Visible = false;
            this.dataGridView1.Columns["UsuarioModifica"].Visible = false;
            this.dataGridView1.Columns["FechaModifica0"].Visible = false;
        }
        #endregion
        #region GUARDAR LOS DATOS DE LA FACTURACION

        #endregion
        #region GUARDAR LOS DATOS DE LA COTIZACION

#endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MantenimientoTipoPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void MantenimientoTipoPago_Load(object sender, EventArgs e)
        {
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            txtTipoPago.ForeColor = Color.Black;
            SacarInformacionEmpresa(1);
            txtClaveSeguridad.PasswordChar = '•';
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            txtTipoPago.ForeColor = Color.Black;
            MostrarListado();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Tipo de Pago";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("EL numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoPago.Text.Trim()))
            {
                MessageBox.Show("El campo tipo de pago no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.ETipoPago Mantenimiento = new Logica.Entidades.EntidadFacturacion.ETipoPago();

                Mantenimiento.IdTipoPago = 0;
                Mantenimiento.CodigoTipoPago = "";
                Mantenimiento.TipoPago = txtTipoPago.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;
                Mantenimiento.BloqueaMontoPagar0 = cbBloquear.Checked;

                var MAN = ObjDataFacturacion.Value.MantenimientoTipoPago(Mantenimiento, "INSERT");

                MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipoPago.Text = string.Empty;
                cbBloquear.Checked = false;
                cbEstatus.Checked = true;
                cbEstatus.Visible = false;
                txtNumeroPagina.Value = 1;
                txtNumeroRegistros.Value = 10;
                MostrarListado();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoPago.Text.Trim()))
            {
                MessageBox.Show("El campo de tipo de pago no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                    var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(_Clave, VariablesGlobales.IdUsuario,1,1);
                    if (Validar.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Focus();
                    }
                    else
                    {
                        DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.ETipoPago Mantenimiento = new Logica.Entidades.EntidadFacturacion.ETipoPago();

                        Mantenimiento.IdTipoPago = VariablesGlobales.IdMantenimiento;
                        Mantenimiento.CodigoTipoPago = VariablesGlobales.CodigoMantenimiento;
                        Mantenimiento.TipoPago = txtTipoPago.Text;
                        Mantenimiento.Estatus0 = cbEstatus.Checked;
                        Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                        Mantenimiento.FechaAdiciona0 = DateTime.Now;
                        Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                        Mantenimiento.FechaModifica0 = DateTime.Now;
                        Mantenimiento.BloqueaMontoPagar0 = cbBloquear.Checked;

                        var MAN = ObjDataFacturacion.Value.MantenimientoTipoPago(Mantenimiento, "UPDATE");

                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoPago.Text = string.Empty;
                        cbBloquear.Checked = false;
                        cbEstatus.Checked = true;
                        cbEstatus.Visible = false;
                        txtNumeroPagina.Value = 1;
                        txtNumeroRegistros.Value = 10;
                        MostrarListado();
                        btnNuevo.Enabled = true;
                        btnConsultar.Enabled = true;
                        btnRestablecer.Enabled = false;
                        btnModificar.Enabled = false;
                        btnDeshabilitar.Enabled = false;
                        txtNumeroPagina.Enabled = true;
                        txtNumeroRegistros.Enabled = true;
                        lbClaveSeguridad.Visible = false;
                        txtClaveSeguridad.Text = string.Empty;
                        txtClaveSeguridad.Visible = false;
                    }
                }
            }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtTipoPago.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
            cbBloquear.Checked = false;
            cbEstatus.Checked = true;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnRestablecer.Enabled = false;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            MostrarListado();
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

                var Validar = ObjdataSeguridad.Value.BuscaClaveSeguridad(_Clave, VariablesGlobales.IdUsuario,1,1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.ETipoPago Mantenimiento = new Logica.Entidades.EntidadFacturacion.ETipoPago();

                    Mantenimiento.IdTipoPago = VariablesGlobales.IdMantenimiento;
                    Mantenimiento.CodigoTipoPago = VariablesGlobales.CodigoMantenimiento;
                    Mantenimiento.TipoPago = txtTipoPago.Text;
                    Mantenimiento.Estatus0 = cbEstatus.Checked;
                    Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                    Mantenimiento.FechaAdiciona0 = DateTime.Now;
                    Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                    Mantenimiento.FechaModifica0 = DateTime.Now;
                    Mantenimiento.BloqueaMontoPagar0 = cbBloquear.Checked;

                    var MAN = ObjDataFacturacion.Value.MantenimientoTipoPago(Mantenimiento, "DISABLE");

                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipoPago.Text = string.Empty;
                    cbBloquear.Checked = false;
                    cbEstatus.Checked = true;
                    cbEstatus.Visible = false;
                    txtNumeroPagina.Value = 1;
                    txtNumeroRegistros.Value = 10;
                    MostrarListado();
                    btnNuevo.Enabled = true;
                    btnConsultar.Enabled = true;
                    btnRestablecer.Enabled = false;
                    btnModificar.Enabled = false;
                    btnDeshabilitar.Enabled = false;
                    txtNumeroPagina.Enabled = true;
                    txtNumeroRegistros.Enabled = true;
                    lbClaveSeguridad.Visible = false;
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Visible = false;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres deshabilitar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdTipoPago"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CodigoTipoPago"].Value.ToString());

                    var SacarDatos = ObjDataFacturacion.Value.ListadoTipoPago(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, 1, 1);
                    foreach (var n in SacarDatos)
                    {
                        txtTipoPago.Text = n.TipoPago;
                        cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                        cbBloquear.Checked = (n.BloqueaMontoPagar0.HasValue ? n.BloqueaMontoPagar0.Value : false);
                    }
                    if (cbEstatus.Checked == true)
                    {
                        cbEstatus.Visible = false;
                    }
                    else
                    {
                        cbEstatus.Visible = true;
                    }
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
    }
}
