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
    public partial class SubMenuInventario : Form
    {
        public SubMenuInventario()
        {
            InitializeComponent();
        }
        DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        public static string Prueba;

        private void SubMenuInventario_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
            gbOpciones.Text = VariablesGlobales.NombreSistema;
            lbIdUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
            lbTitulo.Text = "Modulo de Inventario";
            lbTitulo.ForeColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFinanciamiento_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.AlmacenConsulta Almacen = new Pantallas.Inventario.AlmacenConsulta();
            Almacen.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Almacen.ShowDialog();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProductoConsulta TipoInventario = new Pantallas.Inventario.TipoProductoConsulta();
            TipoInventario.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            TipoInventario.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new Pantallas.Inventario.ProductoConsulta();
            Producto.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Producto.ShowDialog();
        }

        private void btnTipoProveedor_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoProveedorConsulta Consulta = new Pantallas.Inventario.TipoProveedorConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void btnTipoEmpaque_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.TipoEmpaqueConsulta Consulta = new Pantallas.Inventario.TipoEmpaqueConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProveedorConsulta Consulta = new Pantallas.Inventario.ProveedorConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }
    }
}
