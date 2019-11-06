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
    public partial class CentroSaludMantenimiento : Form
    {
        public CentroSaludMantenimiento()
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
        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txttelefonos.Text = string.Empty;
            cbEstatus.Visible = false;
            cbEstatus.Checked = true;
        }
        #region Cerrar Pantalla
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.CentroSaludConsulta Consulta = new CentroSaludConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion
        private void CentroSaludMantenimiento_Load(object sender, EventArgs e)
        {
            gbDatos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            txttelefonos.ForeColor = Color.Black;
            cbEstatus.ForeColor = Color.Red;
            SacarDataInformacionEmpresa(1);
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataEmpresa.Value.BuscaCentroSalus(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtNombre.Text = n.Nombre;
                    txtDireccion.Text = n.Direccion;
                    txttelefonos.Text = n.Telefonos;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void CentroSaludMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                MessageBox.Show("El nombre del centro no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.ECentroSalud Mantenimiento = new Logica.Entidades.EntidadEmpresa.ECentroSalud();

                Mantenimiento.IdCentroSalud = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoCentroSalud = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.Nombre = txtNombre.Text;
                Mantenimiento.Direccion = txtDireccion.Text;
                Mantenimiento.Telefonos = txttelefonos.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataEmpresa.Value.MantenimientoCentroSalud(Mantenimiento, VariablesGlobales.AccionTomar);
                if (VariablesGlobales.AccionTomar != "INSERT")
                {
                    MessageBox.Show("Registro actualizado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpiarControles();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
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
    }
}
