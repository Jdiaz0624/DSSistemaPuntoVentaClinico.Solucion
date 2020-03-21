using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario
{
    public partial class ProductosCantidadMinima : Form
    {
        public ProductosCantidadMinima()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacionEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacionEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        #region BUSCAR LISTADO DE PRODUCTOS
        private void BuscaListadoProductos()
        {
            string _CodigoProducto = string.IsNullOrEmpty(txtCodigoProducto.Text.Trim()) ? null : txtCodigoProducto.Text.Trim();
            string _NombreProducto = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();

            var Buscar = ObjDataInventario.Value.BuscaProductoCantidadMinima(
                new Nullable<decimal>(),
                _CodigoProducto,
                null,
                null,
                null,
                null,
                null,
                _NombreProducto,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            foreach (var n in Buscar)
            {
                int CantidadRegistros = Convert.ToInt32(n.CantidadRegistros);
                lbCantidad.Text = CantidadRegistros.ToString("N0");
            }
            dtProductos.DataSource = Buscar;
            if (Buscar.Count() < 1)
            {
                lbCantidad.Text = "0";
            }
            OcultarColumna();
        }
        #endregion

        #region OCULTAR COLUMNA
        private void OcultarColumna() {
            //OCULTAR PRODUCTOS
            this.dtProductos.Columns["IdProducto"].Visible = false;
            this.dtProductos.Columns["IdAlmacen"].Visible = false;
            this.dtProductos.Columns["IdTipoProveedor"].Visible = false;
            this.dtProductos.Columns["IdProveedor"].Visible = false;
            this.dtProductos.Columns["IdTipoEmpaque"].Visible = false;
            this.dtProductos.Columns["Estatus0"].Visible = false;
            this.dtProductos.Columns["FechaEntrada0"].Visible = false;
            this.dtProductos.Columns["LlevaDescuento0"].Visible = false;
            this.dtProductos.Columns["UsuarioAdiciona"].Visible = false;
            this.dtProductos.Columns["FechaAdiciona0"].Visible = false;
            this.dtProductos.Columns["UsuarioModifica"].Visible = false;
            this.dtProductos.Columns["FechaModifica0"].Visible = false;
            this.dtProductos.Columns["IdTipoProducto0"].Visible = false;
            this.dtProductos.Columns["TipoProveedor"].Visible = false;

            this.dtProductos.Columns["Almacen"].Visible = false;
            this.dtProductos.Columns["Proveedor"].Visible = false;
            this.dtProductos.Columns["TipoEmpaque"].Visible = false;
            this.dtProductos.Columns["TipoProducto"].Visible = false;
            this.dtProductos.Columns["Estatus"].Visible = false;
            this.dtProductos.Columns["FechaEntrada"].Visible = false;
            this.dtProductos.Columns["LlevaDescuento"].Visible = false;
            this.dtProductos.Columns["PorcientoDescuento"].Visible = false;
            this.dtProductos.Columns["CreadoPor"].Visible = false;
            this.dtProductos.Columns["FechaAdiciona"].Visible = false;
            this.dtProductos.Columns["ModificadoPor"].Visible = false;
            this.dtProductos.Columns["FechaModifica"].Visible = false;
            this.dtProductos.Columns["CantidadRegistros"].Visible = false;


            //FORMATEAR PRODUCTOS
            dtProductos.Columns["CantidadAlmacen"].DefaultCellStyle.Format = "N0";
            dtProductos.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["SegundoPrecio"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["TercerPrecio"].DefaultCellStyle.Format = "N2";
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void ProductosCantidadMinima_Load(object sender, EventArgs e)
        {
            this.dtProductos.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Productos en Cantidad Minima";
            SacarInformacionEmpresa(1);
            BuscaListadoProductos();
        }

        private void ProductosCantidadMinima_FormClosing(object sender, FormClosingEventArgs e)
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
            BuscaListadoProductos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de pagina no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                BuscaListadoProductos();
            }
            else
            {
                BuscaListadoProductos();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 100;
                BuscaListadoProductos();
            }
            else
            {
                BuscaListadoProductos();
            }
        }
    }
}
