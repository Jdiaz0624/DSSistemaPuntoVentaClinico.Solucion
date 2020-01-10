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
    public partial class AsistentesMantenimiento : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataInventario = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataInventario.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MANTENIMIENTO DE ASISTENTE DE CIRUGIA
        private void MANAsistenteCirugia()
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EAsistenteCirugia Mantenimiento = new Logica.Entidades.EntidadEmpresa.EAsistenteCirugia();

                Mantenimiento.IdAsistenteCirugia = VariablesGlobales.IdMantenimiento;
                Mantenimiento.CodigoAsistenteCirugia = VariablesGlobales.CodigoMantenimiento;
                Mantenimiento.Nombre = txtNombre.Text;
                Mantenimiento.TipoIdentificacion = ddlTipoIdentificacion.Text;
                Mantenimiento.NumeroIdentificacion = txtNumeroIdentificacion.Text;
                Mantenimiento.Telefono = txtTelefono.Text;
                Mantenimiento.Direccion = txtDireccion.Text;
                Mantenimiento.Estatus0 = cbEstatus.Checked;
                Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataEmpresa.Value.MantenimeintoAsistenteCirugia(Mantenimiento, VariablesGlobales.AccionTomar);
                if (VariablesGlobales.AccionTomar == "INSERT")
                {
                    MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        RestablecerPantalla();
                    }
                    else
                    {
                        CerrarPantalla();
                    }
                }
                else
                {
                    MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CerrarPantalla();
                }

            }
            catch (Exception) {
                MessageBox.Show("Error al realizar el mantenimiento", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.AsistentesConsulta consulta = new AsistentesConsulta();
            consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            consulta.ShowDialog();
        }
        #endregion
        #region RESTABLECER PANTALLA
        private void RestablecerPantalla()
        {
            txtNombre.Text = string.Empty;
            txtNumeroIdentificacion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }
        #endregion
        public AsistentesMantenimiento()
        {
            InitializeComponent();
        }

        private void AsistentesMantenimiento_Load(object sender, EventArgs e)
        {
            SacarNombreEmpresa(1);
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                var SacarDatosAsistenteCirugia = ObjDataEmpresa.Value.BuscaAsistenteCirugia(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, 1, 1);
                foreach (var n in SacarDatosAsistenteCirugia)
                {
                    txtNombre.Text = n.Nombre;
                    ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtNumeroIdentificacion.Text = n.NumeroIdentificacion;
                    txtTelefono.Text = n.Telefono;
                    txtDireccion.Text = n.Direccion;
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
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

        private void AsistentesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
            if (string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtNumeroIdentificacion.Text.Trim()))
            {
                if (VariablesGlobales.AccionTomar == "INSERT")
                {
                    MessageBox.Show("Has dejado campos vacios que son necesarios para guardar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Has dejado campos vacios que son necesarios para modificar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MANAsistenteCirugia();
            }
        }
    }
}
