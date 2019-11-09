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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                lbNombreEmpresa.Text = n.NombreEmpresa;
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region SACAR LA CANTIDAD DE INTENTOS DE LOS USUARIOS
        private void SacarCantidadIntentos(int Cantidad)
        {
            var SacarNumeroIntentos = ObjDataConfiguracion.Value.ConfiguracionGeneralSistema(Cantidad);
            foreach (var n in SacarNumeroIntentos)
            {
                VariablesGlobales.CantidadIntentos = Convert.ToInt32(n.CantidadIntentoLogin);
            }
        }
        #endregion
        #region VALIDAR LOS USUARIOS
        private void ValidarUsuario()
        {
            //VERIFICAMOS LOS CAMPOS VACIOS
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar campos vacios para ingresar al sistema", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VERIFICAMOS SI EL USUARIO INGRESADO ES VALIDO
                string _Usuario = string.IsNullOrEmpty(txtUsuario.Text.Trim()) ? null : txtUsuario.Text.Trim();
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClave.Text);

                var VerificarUsuario = ObjDataSeguridad.Value.BuscaUsuario(
                    new Nullable<decimal>(),
                    null, null, null,
                    _Usuario, _Clave, 1, 1);
                if (VerificarUsuario.Count() < 1)
                {
                    MessageBox.Show("El nombre de usuario o la clave ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Text = string.Empty;
                    txtClave.Text = string.Empty;
                    txtUsuario.Focus();
                }
                else
                {
                    foreach (var n in VerificarUsuario)
                    {
                        VariablesGlobales.IdUsuario = Convert.ToDecimal(n.IdUsuario);
                        VariablesGlobales.EstatusUsuario = Convert.ToBoolean(n.Estatus0);
                    }
                    if (VariablesGlobales.EstatusUsuario == false)
                    {
                        MessageBox.Show("Este usuario se encuentra deshabilitado, cominiquese con un administrador para desbloquear la cuenta", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        this.Hide();
                        DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal Menu = new MenuPrincipal.MenuPrincipal();
                        Menu.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                        Menu.ShowDialog();
                    }
                }
            }
            
        }
#endregion
        private void Login_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.Black;
            txtUsuario.ForeColor = Color.Black;
            txtClave.ForeColor = Color.Black;
            lbHora.ForeColor = Color.White;
            lbFecha.ForeColor = Color.White;
            lbNombreEmpresa.ForeColor = Color.Black;
            txtClave.PasswordChar = '•';
            timer1.Start();
            SacarInformacionEmpresa(1);
            SacarCantidadIntentos(1);
            DSSistemaPuntoVentaClinico.Logica.Comunes.AutoCompletarControles.AutoCompletarUsuarios(txtUsuario);
            txtUsuario.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres salir del sistema?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ValidarUsuario();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
