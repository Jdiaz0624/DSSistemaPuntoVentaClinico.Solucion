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
    public partial class ProductoMantenimiento : Form
    {
        public ProductoMantenimiento()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarDatosEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarDatos = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarDatos)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region CARGAR LAS LISTAS
        private void CargarAlmacenes()
        {
            var Cargar = ObjdataListas.Value.ListaAlnmacenes();
            txtAlmacen.DataSource = Cargar;
            txtAlmacen.DisplayMember = "Nombre";
            txtAlmacen.ValueMember = "IdAlmacen";
        }
        private void CargarTipoPriveedor()
        {
            var Cargar = ObjdataListas.Value.ListaTipoProveedor();
            txtTipoProveedor.DataSource = Cargar;
            txtTipoProveedor.DisplayMember = "Descripcion";
            txtTipoProveedor.ValueMember = "IdTipoProveedor";
        }
        private void CargarProveedores()
        {
            try {
                var IdTipoSuplido = txtTipoProveedor.SelectedValue.ToString();
                var Cargar = ObjdataListas.Value.ListaProveedores(Convert.ToDecimal(txtTipoProveedor.SelectedValue));
                txtProveedor.ValueMember = "IdProveedor";
                txtProveedor.DisplayMember = "Nombre";
                txtProveedor.DataSource = Cargar;
            }
            catch (Exception) { }

        }
        private void CargarTipoProducto()
        {
            var Cargar = ObjdataListas.Value.ListaTipoProducto();
            txtTipoProducto.ValueMember = "IdTipoProducto";
            txtTipoProducto.DisplayMember = "Descripcion";
            txtTipoProducto.DataSource = Cargar;
        }
        private void CargarTipoEmpaque()
        {
            var Cargar = ObjdataListas.Value.ListaTipoEmpaque();
            txtTipoEmpaque.DataSource = Cargar;
            txtTipoEmpaque.DisplayMember = "Descripcion";
            txtTipoEmpaque.ValueMember = "IdTipoEmpaque";
        }
        #endregion
        #region REGION MANTENIMIENTO DE PRODUCTO
        private void MANProductos()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Mantenimiento = new Logica.Entidades.EntidadInventario.EPRoducto();

            Mantenimiento.IdProducto = VariablesGlobales.IdMantenimiento;
            Mantenimiento.CodigoProducto = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.IdAlmacen = Convert.ToDecimal(txtAlmacen.SelectedValue);
            Mantenimiento.IdTipoProveedor = Convert.ToDecimal(txtTipoProveedor.SelectedValue);
            Mantenimiento.IdProveedor = Convert.ToDecimal(txtProveedor.SelectedValue);
            Mantenimiento.IdTipoEmpaque = Convert.ToDecimal(txtTipoEmpaque.SelectedValue);
            Mantenimiento.IdTipoProducto0 = Convert.ToDecimal(txtTipoProducto.SelectedValue);
            Mantenimiento.Producto = txtDescripcion.Text;
            Mantenimiento.Estatus0 = cbEstatus.Checked;
            Mantenimiento.CantidadAlmacen = Convert.ToInt32(txtCantidadAlmacen.Text);
            Mantenimiento.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            Mantenimiento.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            Mantenimiento.SegundoPrecio = Convert.ToDecimal(txtSegundoPrecio.Text);
            Mantenimiento.TercerPrecio = Convert.ToDecimal(txttercerPrecio.Text);
            Mantenimiento.FechaEntrada0 = DateTime.Now;
            Mantenimiento.LlevaDescuento0 = cbLlevaDescuento.Checked;
            Mantenimiento.PorcientoDescuento = Convert.ToInt32(txtPorcientoDescuento.Text);
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona0 = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica0 = DateTime.Now;

            var MAN = ObjdataInventario.Value.MantenimientoProducto(Mantenimiento, VariablesGlobales.AccionTomar);
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Consulta = new ProductoConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion
        #region LIMPIAR LOS CONTROLES
        private void LimparControles()
        {
            CargarAlmacenes();
            CargarTipoPriveedor();
            CargarTipoEmpaque();
            txtDescripcion.Text = string.Empty;
            txtCodigoBarras.Text = string.Empty;
            txtCantidadAlmacen.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtSegundoPrecio.Text = string.Empty;
            txttercerPrecio.Text = string.Empty;
            txtPorcientoDescuento.Text = string.Empty;
            cbEstatus.Checked = true;
            cbLlevaDescuento.Checked = true;
            cbEstatus.Visible = false;
        }
#endregion
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ProductoMantenimiento_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.White;
            txtCantidadAlmacen.ForeColor = Color.Black;
            txtCodigoBarras.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtPorcientoDescuento.ForeColor = Color.Black;
            txtPrecioCompra.ForeColor = Color.Black;
            txtPrecioVenta.ForeColor = Color.Black;
            cbEstatus.ForeColor = Color.Red;
            cbLlevaDescuento.ForeColor = Color.Red;
            btnAccion.ForeColor = Color.White;
            btnCerrar.ForeColor = Color.White;
            SacarDatosEmpresa(1);
            CargarAlmacenes();
            CargarTipoPriveedor();
            CargarProveedores();
            CargarTipoEmpaque();
            CargarTipoProducto();
            cbEstatus.Checked = true;
            cbEstatus.Visible = false;
            txtAlmacen.ForeColor = Color.White;
            txtTipoProveedor.ForeColor = Color.White;
            txtProveedor.ForeColor = Color.White;
            txtTipoEmpaque.ForeColor = Color.White;
            txtTipoProducto.ForeColor = Color.White;
            if (VariablesGlobales.AccionTomar!= "INSERT")
            {
                var SacarDatos = ObjdataInventario.Value.BuscaProducto(
                    VariablesGlobales.IdMantenimiento,
                    VariablesGlobales.CodigoMantenimiento,
                    null, null, null, null, null, null, null, null,1, 1);
                foreach (var n in SacarDatos)
                {
                    txtAlmacen.Text = n.Almacen;
                    txtTipoProveedor.Text = n.TipoProveedor;
                    txtTipoProducto.Text = n.TipoProducto;
                    txtProveedor.Text = n.Proveedor;
                    txtTipoEmpaque.Text = n.TipoEmpaque;
                    txtDescripcion.Text = n.Producto;
                    txtCodigoBarras.Text = "";
                    txtCantidadAlmacen.Text = n.CantidadAlmacen.ToString();
                    txtPrecioCompra.Text = n.PrecioCompra.ToString();
                    txtPrecioVenta.Text = n.PrecioVenta.ToString();
                    txtPorcientoDescuento.Text = n.PorcientoDescuento.ToString();
                    txtSegundoPrecio.Text = n.SegundoPrecio.ToString();
                    txttercerPrecio.Text = n.TercerPrecio.ToString();
                    cbEstatus.Checked = (n.Estatus0.HasValue ? n.Estatus0.Value : false);
                    cbLlevaDescuento.Checked = (n.LlevaDescuento0.HasValue ? n.LlevaDescuento0.Value : false);

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

        private void cbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstatus.Checked)
            {
                cbEstatus.ForeColor = Color.White;
            }
            else
            {
                cbEstatus.ForeColor = Color.Red;
            }
        }

        private void cbLlevaDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLlevaDescuento.Checked)
            {
                cbLlevaDescuento.ForeColor = Color.White;
            }
            else
            {
                cbLlevaDescuento.ForeColor = Color.Red;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void txtTipoProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void txtProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            try { txtDescripcion.Text = txtProveedor.SelectedValue.ToString(); }
            catch (Exception)
            {
                txtDescripcion.Text = "0";
            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            try
            {//VERIFICAMOS LOS CAMPOS QUE NO PUEDEN ESTAR VACIOS
                if (string.IsNullOrEmpty(txtAlmacen.Text.Trim()) || string.IsNullOrEmpty(txtTipoProveedor.Text.Trim()) || string.IsNullOrEmpty(txtProveedor.Text.Trim()) || string.IsNullOrEmpty(txtTipoEmpaque.Text.Trim()) || string.IsNullOrEmpty(txtDescripcion.Text.Trim()) || string.IsNullOrEmpty(txtCantidadAlmacen.Text.Trim()) || string.IsNullOrEmpty(txtPrecioCompra.Text.Trim()) || string.IsNullOrEmpty(txtPrecioVenta.Text.Trim()) || string.IsNullOrEmpty(txtSegundoPrecio.Text.Trim()) || string.IsNullOrEmpty(txttercerPrecio.Text.Trim()))
                {
                    MessageBox.Show("Has dejado campos vacios que son necesario para realizar esta operación", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MANProductos();
                    if (VariablesGlobales.AccionTomar != "INSERT")
                    {
                        MessageBox.Show("Registro modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("Registro guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("¿Quieres guardar otro registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            LimparControles();
                        }
                        else
                        {
                            CerrarPantalla();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al realizar la operación, favor de verificar si la informacion suministrada sea la requerida por parte del sistema", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCantidadAlmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void ProductoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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
