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
    public partial class SubMenuCaja : Form
    {
        public SubMenuCaja()
        {
            InitializeComponent();
        }

        private void SubMenuCaja_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;

            lbusuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gbOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja.MonedaListado Listado = new Pantallas.Caja.MonedaListado();
            Listado.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            Listado.ShowDialog();
        }

        private void btnEntradaEfectivo_Click(object sender, EventArgs e)
        {

        }

        private void btnAbirCerrarCaja_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja.Caja MANCaja = new Pantallas.Caja.Caja();
            MANCaja.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            MANCaja.ShowDialog();
        }

        private void btnCuadreCaja_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Caja.CuadreCaja cuadre = new Pantallas.Caja.CuadreCaja();
            cuadre.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbusuario.Text);
            cuadre.ShowDialog();
        }
    }
}
