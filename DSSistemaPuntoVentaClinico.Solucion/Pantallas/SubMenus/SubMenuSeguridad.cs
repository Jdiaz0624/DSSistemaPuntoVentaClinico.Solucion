using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    public partial class SubMenuSeguridad : Form
    {
        public SubMenuSeguridad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuSeguridad_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.White;
            lbusuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Pantallas.Seguridad.ListadoUsuarios ListadoUsuario = new Pantallas.Seguridad.ListadoUsuarios();
            ListadoUsuario.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            ListadoUsuario.ShowDialog();
        }

        private void btnClaveSeguridad_Click(object sender, EventArgs e)
        {
            Pantallas.Seguridad.ClaveSeguridad ClaveSeguridad = new Pantallas.Seguridad.ClaveSeguridad();
            ClaveSeguridad.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            ClaveSeguridad.ShowDialog();
        }
    }
}
