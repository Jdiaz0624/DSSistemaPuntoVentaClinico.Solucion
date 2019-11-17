using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class SecuencialComprobantes : Form
    {
        public SecuencialComprobantes()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacaInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR LOS COMPROBANTES FISCALES
        private void MostrarComprobantesFiscales()
        {
            var Mostrar = ObjdataContabilidad.Value.ListadoComprobantes(
                new Nullable<decimal>());
            dtComprobantes.DataSource = Mostrar;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            this.dtComprobantes.Columns["IdComprobante"].Visible = false;
            this.dtComprobantes.Columns["Estatus0"].Visible = false;
            this.dtComprobantes.Columns["PorDefecto0"].Visible = false;
        }
        #endregion
        #region MANTENIMIENTO DE COMPROBANTES FISCALES
        private void MANCOmprobantes()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales Mantenimiento = new Logica.Entidades.EntidadesContabilidad.EMantenimientoComprobantesFiscales();

            Mantenimiento.IdComprobante = VariablesGlobales.IdMantenimiento;
            Mantenimiento.Comprobante = txtDescripcion.Text;
            Mantenimiento.Serie = txtSerie.Text;
            Mantenimiento.TipoComprobante = txtTipoComprobante.Text;
            Mantenimiento.Secuencial = Convert.ToInt64(txtSecuencial.Text);
            Mantenimiento.SecuenciaInicial = Convert.ToInt64(txtSecuenciaInicial.Text);
            Mantenimiento.SecuenciaFinal = Convert.ToInt64(txtSecuenciaFinal.Text);
            Mantenimiento.Limite = Convert.ToInt64(txtLimite.Text);
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.ValidoHasta = txtValidoHasta.Text;
            Mantenimiento.PorDefecto0 = cbPorDefecto.Checked;
            Mantenimiento.Posiciones = Convert.ToInt64(txtPociciones.Text);

            var MAn = ObjdataContabilidad.Value.MantenimientoComprobantesFiscales(Mantenimiento, "UPDATE");
        }
        #endregion
        #region RESTABELCER LA PANTALLA
        private void Restablecerpantalla()
        {
            txtDescripcion.Text = string.Empty;
            txtSerie.Text = string.Empty;
            txtTipoComprobante.Text = string.Empty;
            txtSecuencial.Text = string.Empty;
            txtSecuenciaInicial.Text = string.Empty;
            txtSecuenciaFinal.Text = string.Empty;
            txtLimite.Text = string.Empty;
            txtValidoHasta.Text = string.Empty;
            txtPociciones.Text = string.Empty;
            cbEstatus.Checked = false;
            cbPorDefecto.Checked = false;
            gnConfiguracion.Enabled = false;
            txtClaveSeguridad.Text = string.Empty;
            MostrarComprobantesFiscales();
        }
        #endregion
        #region GUARDAR
        private void Guardar()
        {
            //VERIFICAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtSerie.Text.Trim()) || string.IsNullOrEmpty(txtTipoComprobante.Text.Trim()) || string.IsNullOrEmpty(txtSecuencial.Text.Trim()) || string.IsNullOrEmpty(txtSecuenciaInicial.Text.Trim()) || string.IsNullOrEmpty(txtSecuenciaFinal.Text.Trim()) || string.IsNullOrEmpty(txtLimite.Text.Trim()) || string.IsNullOrEmpty(txtValidoHasta.Text.Trim()) || string.IsNullOrEmpty(txtPociciones.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {//VERIFICAMOS LA CLAVE DE SEGURIDAD
                    if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                    {
                        MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            //REALIZAMOS EL MANTENIMIENTO
                            MANCOmprobantes();
                            MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Restablecerpantalla();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al realizar el cambio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void SecuencialComprobantes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void SecuencialComprobantes_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Secuencia de Comprobantes";
            lbTitulo.ForeColor = Color.White;
            SacaInformacionEmpresa(1);
            this.dtComprobantes.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtComprobantes.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            MostrarComprobantesFiscales();
            gnConfiguracion.Enabled = false;
            txtClaveSeguridad.PasswordChar = '•';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSecuencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void dtComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtComprobantes.CurrentRow.Cells["IdComprobante"].Value.ToString());

                    var SacarDatos = ObjdataContabilidad.Value.ListadoComprobantes(VariablesGlobales.IdMantenimiento);
                    dtComprobantes.DataSource = SacarDatos;
                    foreach (var n in SacarDatos)
                    {
                        txtDescripcion.Text = n.Comprobante;
                        txtSerie.Text = n.Serie;
                        txtTipoComprobante.Text = n.TipoComprobante;
                        txtSecuencial.Text = n.Secuencial.ToString();
                        txtSecuenciaInicial.Text = n.SecuenciaInicial.ToString();
                        txtSecuenciaFinal.Text = n.SecuenciaFinal.ToString();
                        txtLimite.Text = n.Limite.ToString();
                        txtValidoHasta.Text = n.ValidoHasta;
                        txtPociciones.Text = n.Posiciones.ToString();
                        cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                        cbPorDefecto.Checked = (n.PorDefecto0.HasValue ? n.PorDefecto0.Value : false);
                    }
                    gnConfiguracion.Enabled = true;
                }
            }
            catch (Exception) { }
        }

        private void btnRestabelcer_Click(object sender, EventArgs e)
        {
            Restablecerpantalla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void txtClaveSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Guardar();
            }
        }
    }
}
