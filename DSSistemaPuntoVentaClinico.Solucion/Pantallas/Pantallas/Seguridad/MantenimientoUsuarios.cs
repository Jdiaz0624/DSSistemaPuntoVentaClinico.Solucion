using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad
{
    public partial class MantenimientoUsuarios : Form
    {
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa(int IdInformacionEmpresa)
        {
            var SacarNombreEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarNombreEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region LIMPIAR PANTALLA
        private void LimpiarPantalla()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
            txtPersona.Text = string.Empty;
            txtClaveSeguridad.Text = string.Empty;
        }
        #endregion
        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuario(decimal IdUsuario, string CodigoUsuario)
        {
            var SacarDatosUsuario = ObjDataSeguridad.Value.BuscaUsuario(
                VariablesGlobales.IdMantenimiento,
                VariablesGlobales.CodigoMantenimiento,
                null, null, null, null, 1, 1);
            foreach (var n in SacarDatosUsuario)
            {
                txtUsuario.Text = n.Usuario;
                txtClave.Text = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                txtConfirmar.Text = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                txtPersona.Text = n.Persona;
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
        #endregion
        #region MANTENIMIENTO DE USUARIOS
        private void MANUsuarios()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario mantenimiento = new Logica.Entidades.EntidadSeguridad.EMantenimientoUsuario();

            mantenimiento.IdUsuario = VariablesGlobales.IdMantenimiento;
            mantenimiento.CodigoUsuario = VariablesGlobales.CodigoMantenimiento;
            mantenimiento.IdPerfil = 1;
            mantenimiento.Usuario = txtUsuario.Text;
            mantenimiento.Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);
            mantenimiento.Persona = txtPersona.Text;
            mantenimiento.Estatus = cbEstatus.Checked;
            mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            mantenimiento.FechaAdiciona = DateTime.Now;
            mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            mantenimiento.FechaModifica = DateTime.Now;

            var MAN = ObjDataSeguridad.Value.MantenimientoUsuario(mantenimiento, VariablesGlobales.AccionTomar);
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad.ListadoUsuarios Listado = new ListadoUsuarios();
            Listado.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Listado.ShowDialog();
        }
#endregion
        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            SacarNombreEmpresa(1);
            groupBox1.ForeColor = Color.White;
            txtUsuario.ForeColor = Color.Black;
            txtClave.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtConfirmar.ForeColor = Color.Black;
            txtPersona.ForeColor = Color.Black;
            txtClave.PasswordChar = '•';
            txtConfirmar.PasswordChar = '•';
            txtClaveSeguridad.PasswordChar = '•';
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                SacarDatosUsuario(VariablesGlobales.IdMantenimiento, VariablesGlobales.CodigoMantenimiento);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void MantenimientoUsuarios_FormClosing(object sender, FormClosingEventArgs e)
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
            //HACEMOS ALS VALIDACIONES CORRESPONDIENTES
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()) || string.IsNullOrEmpty(txtConfirmar.Text.Trim()) || string.IsNullOrEmpty(txtPersona.Text.Trim()))
            {
                MessageBox.Show("Has dejado campos vacios que son necesarios para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string Clave = txtClave.Text;
                string Confirmar = txtConfirmar.Text;
                if (Clave != Confirmar)
                {
                    MessageBox.Show("Las claves ingresadas no concuerdan, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.Text = string.Empty;
                    txtConfirmar.Text = string.Empty;
                }
                else
                {
                    if (VariablesGlobales.AccionTomar != "INSERT")
                    {
                        if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                        {
                            MessageBox.Show("Favor ingresar la clave de seguridad", VariablesGlobales.NombrePacienteHis, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //VALIDAMOS LA CLAVE DE SEGURIDAD
                            string Claves = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);

                            var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                                Claves, VariablesGlobales.IdUsuario, 1, 1);
                            if (ValidarClave.Count() < 1)
                            {
                                MessageBox.Show("El campo clave de seguridad no puede estar vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                MANUsuarios();
                                MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CerrarPantalla();
                            }
                        }
                    }
                    else
                    {
                        //VERIFICAMOS QUE EL NOMBRE DE USUARIO YA NO EXISTA
                        var VerificarUsuario = ObjDataSeguridad.Value.BuscaUsuario(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            txtUsuario.Text,
                            null, 1, 1);
                        if (VerificarUsuario.Count() < 1)
                        {
                            MANUsuarios();
                            MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("¿Quieres agregar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                LimpiarPantalla();
                            }
                            else
                            {
                                CerrarPantalla();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario ingresado ya esta registrado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
