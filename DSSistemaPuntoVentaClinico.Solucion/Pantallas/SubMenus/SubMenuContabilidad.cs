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
    public partial class SubMenuContabilidad : Form
    {
        public SubMenuContabilidad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuContabilidad_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
            lbTitulo.Text = "Modulo de Contabiliad";
            lbTitulo.ForeColor = Color.White;
            lbUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnControlApertura_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad.CuntasPorCobrar cxc = new Pantallas.Contabilidad.CuntasPorCobrar();
            cxc.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            cxc.ShowDialog();
        }

        private void btnHistorialPagos_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad.HistorialPagos Historial = new Pantallas.Contabilidad.HistorialPagos();
            Historial.VariablesGlobales.IdUsuario = Convert.ToInt32(lbUsuario.Text);
            Historial.ShowDialog();
        }

        private void btnComisionMedico_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad.ComisionMedico Comision = new Pantallas.Contabilidad.ComisionMedico();
            Comision.VariablesGlobales.IdUsuario = Convert.ToInt32(lbUsuario.Text);
            Comision.ShowDialog();
        }
    }
}
