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
    public partial class MedicosMantenimiento : Form
    {
        public MedicosMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
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
            txtCorreo.Text = string.Empty;
            CargarCentroalud();
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
        }
        //CARGAR LOS CENTROS DE SALUD
        private void CargarCentroalud()
        {
            var Cargar = ObjdataListas.Value.ListaCentrosalud();
            ddlCentroSalud.DataSource = Cargar;
            ddlCentroSalud.DisplayMember = "Nombre";
            ddlCentroSalud.ValueMember = "IdCentroSalud";
        }
        #region Cerrar Pantalla
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.MedicosConsulta Consulta = new MedicosConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion
        private void MedicosMantenimiento_Load(object sender, EventArgs e)
        {
            SacarDataInformacionEmpresa(1);
            groupBox1.ForeColor = Color.Black;
            ddlCentroSalud.ForeColor = Color.Black;
            txtCorreo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
         //   txtTelefono.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            CargarCentroalud();
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatos = ObjDataEmpresa.Value.BuscaMedicos(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtNombre.Text = n.NombreMedico;
                    txtCorreo.Text = n.Email;
                    ddlCentroSalud.Text = n.CentroSalud;
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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(ddlCentroSalud.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para guardar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EMedico Mantenimiento = new Logica.Entidades.EntidadEmpresa.EMedico();

                Mantenimiento.IdCentroSalud = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoMedico = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.NombreMedico = txtNombre.Text;
                Mantenimiento.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
                Mantenimiento.Email = txtCorreo.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.fechaModifica0 = DateTime.Now;

                var MAN = ObjDataEmpresa.Value.Mantenimientomedicos(Mantenimiento, VariablesGlobales.AccionTomar);

                if (VariablesGlobales.AccionTomar != "INSERT")
                {
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }
                else
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        private void MedicosMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
