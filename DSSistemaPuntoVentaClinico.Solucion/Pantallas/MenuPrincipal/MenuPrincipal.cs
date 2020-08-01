using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {

        
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        public static decimal IdUsuario;
        #region FUNCION PARA LLAMAR LOS FORMULARIOS
        private void AbrirPantallasEnPanel(object Pantalla)
        {
            if (pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form Formulario = Pantalla as Form;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(Formulario);
            this.pContenedor.Tag = Formulario;
            VariablesGlobales.NombreSistema = lbUsuarioConectado.Text;

            Formulario.Show();
        }
        #endregion
        #region ASIGNAR Y QUITAR LAS LETRAS A LOS BOTONES
        private void AsignarLetrasBotones()
        {
            btnFacturacion.Text = "Facturación";
            btnCaja.Text = "Caja";
            btnContabilidad.Text = "Contabilidad";
            btnEmpresa.Text = "Empresa";
            btnGestionCobros.Text = "Gestion de Cobros";
            btnNomina.Text = "Nomina";
            btnHistorial.Text = "Historial";
            btnReportes.Text = "Reportes";
            btnSeguridad.Text = "Seguridad";
            btnConfiguracion.Text = "Configuración";
        }
        private void QUitarLetrasBotones()
        {
            btnFacturacion.Text = "";
            btnCaja.Text = "";
            btnContabilidad.Text = "";
            btnEmpresa.Text = "";
            btnGestionCobros.Text = "";
            btnNomina.Text = "";
            btnHistorial.Text = "";
            btnReportes.Text = "";
            btnSeguridad.Text = "";
            btnConfiguracion.Text = "";
        }
        #endregion
        #region METODOS PARA PODER MOVER EL MENU PRINCIPAL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        #region SACAR LOS DATOS DEL USUARIO
        private void SacarDatosUsuarios(decimal IdUsuario)
        {
            var SacarDatosUsuario = ObjDataSeguridad.Value.BuscaUsuario(IdUsuario,
                null, null, null, null, null, 1, 1);
            foreach (var n in SacarDatosUsuario)
            {
                lbUsuarioConectado.Text = n.Persona;
                lbPerfilUsuarioConectado.Text = n.Perfil + " - " + VariablesGlobales.NombreSistema;
                lbiDUSUARIO.Text = n.IdUsuario.ToString();
            }
        }
        #endregion
        #region SACAR LOS DATOS DE LA EMPRESA
        private void SacarDatosEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarDatosEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarDatosEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
#endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres salir del sistema?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCambiarTamano_Click(object sender, EventArgs e)
        {
            if (pMenuIzquierda.Width == 230)
            {
                pMenuIzquierda.Width = 100;
                pbImagenCompleta.Visible = false;
                pbImagenInicales.Visible = true;
                //QUITAR LAS LETRAS DE LOS BOTONES
                QUitarLetrasBotones();
                lbHora.Visible = false;
                lbFechaSistema.Visible = false;
                btnCerrarSesion.Visible = false;
                btnCerrarSesion2.Visible = true;
            }
            else
            {
                pMenuIzquierda.Width = 230;
                pbImagenCompleta.Visible = true;
                pbImagenInicales.Visible = false;
                //ASIGNAR LAS LETRAS A LOS BOTONES
                AsignarLetrasBotones();
                lbHora.Visible = true;
                lbFechaSistema.Visible = true;
                btnCerrarSesion.Visible = true;
                btnCerrarSesion2.Visible = false;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            pMenuIzquierda.Width = 230;
            AsignarLetrasBotones();
            lbUsuarioConectado.ForeColor = Color.White;
            lbPerfilUsuarioConectado.ForeColor = Color.White;
            timer1.Start();
            lbHora.ForeColor = Color.White;
            lbFechaSistema.ForeColor = Color.White;
            SacarDatosEmpresa(1);
            SacarDatosUsuarios(VariablesGlobales.IdUsuario);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFechaSistema.Text = DateTime.Now.ToShortDateString();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres cerrar sesión?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad.Login Login = new Pantallas.Seguridad.Login();
                Login.ShowDialog();
            }
        }

        private void btnCerrarSesion2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres cerrar sesión?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Seguridad.Login Login = new Pantallas.Seguridad.Login();
                Login.ShowDialog();
            }
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuFacturacion());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuInventario());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuCaja());
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuContabilidad());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuEmpresa());
        }

        private void btnGestionCobros_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuGestionCobros());
        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuNomina());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuHistorial());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuReporte());
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuSeguridad());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus.SubMenuConfiguracion());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            IdUsuario = Convert.ToDecimal(lbiDUSUARIO.Text);
            AbrirPantallasEnPanel(new DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugiaConsulta());


            //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugiaConsulta Programacion = new Pantallas.Facturacion.ProgramacionCirugiaConsulta();
            //Programacion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            //Programacion.ShowDialog();

        }

        private void pSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
