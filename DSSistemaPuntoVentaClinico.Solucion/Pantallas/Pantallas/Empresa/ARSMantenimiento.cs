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
    public partial class ARSMantenimiento : Form
    {
        public ARSMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region Cerrar Pantalla
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ARSConsulta Consulta = new ARSConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region LIMPIAR CONTROLES
        private void LimpiarControles()
        {
            txtdESCRIPCION.Text = string.Empty;
            txtRepresentante.Text = string.Empty;
            txtRNC.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtdESCRIPCION.Focus();
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
        }
        #endregion

        #region MANTENIMIENTO DE ARS
        private void MANARS()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EArs Mantenimiento = new Logica.Entidades.EntidadEmpresa.EArs();

            Mantenimiento.IdArs = VariablesGlobales.IdMantenimiento;
            Mantenimiento.CodigoARS = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.ARS = txtdESCRIPCION.Text;
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona0 = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica0 = DateTime.Now;
            Mantenimiento.Representante = txtRepresentante.Text;
            Mantenimiento.RNC = txtRNC.Text;
            Mantenimiento.Telefono = txttelefono.Text;
            Mantenimiento.Correo = txtcorreo.Text;
            Mantenimiento.Direccion = txtDireccion.Text;

            var MAN = ObjDataEmpresa.Value.MantenimientoARs(Mantenimiento, VariablesGlobales.AccionTomar);
        }
        #endregion



        private void ARSMantenimiento_Load(object sender, EventArgs e)
        {
            gbDatos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            txtdESCRIPCION.ForeColor = Color.Black;
            SacarInformacionEmpresa(1);
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                //BUSCAMOS LOS DATOS
                var SacarDatos = ObjDataEmpresa.Value.BuscaARS(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtdESCRIPCION.Text = n.ARS;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    txtRepresentante.Text = n.Representante;
                    txtRNC.Text = n.RNC;
                    txttelefono.Text = n.Telefono;
                    txtcorreo.Text = n.Correo;
                    txtDireccion.Text = n.Direccion;

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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();

        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrEmpty(txtdESCRIPCION.Text.Trim()) || string.IsNullOrEmpty(txtRepresentante.Text.Trim()))
                {
                    MessageBox.Show("Has dejado campos vacios que son necesarios para realizar el mantenimiento", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MANARS();
                    if (VariablesGlobales.AccionTomar == "INSERT")
                    {
                        MessageBox.Show("Registro Guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                    }
                   
                }
            }
            catch (Exception) { }
        }

        private void ARSMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
