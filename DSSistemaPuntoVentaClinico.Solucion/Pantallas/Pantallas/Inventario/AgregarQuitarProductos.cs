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
    public partial class AgregarQuitarProductos : Form
    {
        public AgregarQuitarProductos()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesBlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DEL PRODUCTO SELECCIONADO
        private void SacarDatosProductoSeleccionado(decimal IdProducto, string CodigoMantenimiento)
        {
            try {
                var SacarDatos = ObjDataInventario.Value.BuscaProducto(
                    VariablesBlobales.IdMantenimiento,
                    VariablesBlobales.CodigoMantenimiento,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    1, 1);
                foreach (var n in SacarDatos)
                {
                    lbAlmacen.Text = n.Almacen;
                    lbProveedor.Text = n.Proveedor;
                    lbTipoEmpaque.Text = n.TipoEmpaque;
                    lbTipoProducto.Text = n.TipoProducto;
                    lbDescripcion.Text = n.Producto;
                    int CantidadAlmacen = Convert.ToInt32(n.CantidadAlmacen);
                    lbCantidadAlmacen.Text = CantidadAlmacen.ToString("N2");
                    decimal PrecioCompra = Convert.ToDecimal(n.PrecioCompra);
                    lbPrecioCompra.Text = PrecioCompra.ToString("N2");
                    decimal PrecioVenta = Convert.ToDecimal(n.PrecioVenta);
                    lbPrecioVenta.Text = PrecioVenta.ToString("N2");
                    decimal SegundoPrecio = Convert.ToDecimal(n.SegundoPrecio);
                    lbSegundoPrecio.Text = SegundoPrecio.ToString("N2");
                    decimal TercerPrecio = Convert.ToDecimal(n.TercerPrecio);
                    lbTercerPrecio.Text = TercerPrecio.ToString("N2");
                    lbPorcientoDescuento.Text = n.PorcientoDescuento.ToString();
                    txtCantidad.Focus();
                }
            }
            catch (Exception) {
                MessageBox.Show("Error al sacar los datos de la consulta", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                CerrarPantalla();
            }
        }
        #endregion
        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoConsulta Producto = new ProductoConsulta();
            Producto.VariablesGlobales.IdUsuario = VariablesBlobales.IdUsuario;
            Producto.ShowDialog();
        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesBlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region AGREGAR O SACAR PRODUCTOS DEL INVENTARIO
        private void MANProducto(string Accion)
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Mantenimiento = new Logica.Entidades.EntidadInventario.EPRoducto();

                Mantenimiento.IdProducto = VariablesBlobales.IdMantenimiento;
                Mantenimiento.CodigoProducto = VariablesBlobales.CodigoMantenimiento;
                Mantenimiento.CantidadAlmacen = Convert.ToInt32(txtCantidad.Text);
                Mantenimiento.UsuarioAdiciona = VariablesBlobales.IdUsuario;
                Mantenimiento.FechaAdiciona0 = DateTime.Now;
                Mantenimiento.UsuarioModifica = VariablesBlobales.IdUsuario;
                Mantenimiento.FechaModifica0 = DateTime.Now;

                var MAN = ObjDataInventario.Value.MantenimientoProducto(Mantenimiento, Accion);

                if (rbIngresarProducto.Checked)
                {
                    MessageBox.Show("Registro agregado exitosamente", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbSacarProducto.Checked)
                {
                    MessageBox.Show("Producto sacado exitosamente", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) {

            }
        }
        #endregion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void AgregarQuitarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AgregarQuitarProductos_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Agregar o Sacar Productos";
            txtClaveSeguridad.PasswordChar = '•';
            txtClaveSeguridad.MaxLength = 20;
            rbIngresarProducto.Checked = true;
            SacarDatosProductoSeleccionado(VariablesBlobales.IdMantenimiento, VariablesBlobales.CodigoMantenimiento);
            SacarInformacionEmpresa(1);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SacarDatosProductoSeleccionado(VariablesBlobales.IdMantenimiento, VariablesBlobales.CodigoMantenimiento);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS LA CLAVE DE SEGURIDAD
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("Favor de ingresar la clave de seguridad", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS QUE LA CLAVE DE SEGURIDAD INGRESADA ES VALIDA
                var ValidarClaveSeguridad = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarClaveSeguridad.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valdia, favor de verificar", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCantidad.Text.Trim()))
                    {
                        MessageBox.Show("Favor de ingresar la cantidad", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCantidad.Focus();
                    }
                    else
                    {
                        try
                        {
                            if (rbIngresarProducto.Checked)
                            {
                                MANProducto("ADD");
                                SacarDatosProductoSeleccionado(VariablesBlobales.IdMantenimiento, VariablesBlobales.CodigoMantenimiento);
                                txtCantidad.Text = string.Empty;
                                txtClaveSeguridad.Text = string.Empty;
                                rbIngresarProducto.Checked = true;
                            }
                            else if (rbSacarProducto.Checked)
                            {
                                decimal CantidadAlmcen, CantidadIngresada;
                                CantidadAlmcen = Convert.ToDecimal(lbCantidadAlmacen.Text);
                                CantidadIngresada = Convert.ToDecimal(txtCantidad.Text);
                                if (CantidadIngresada > CantidadAlmcen)
                                {
                                    MessageBox.Show("No es posible realizar esta operación por que la cantidad a sacar supera la cantidad en el almacen, favor de verificar", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    MANProducto("LESS");
                                    SacarDatosProductoSeleccionado(VariablesBlobales.IdMantenimiento, VariablesBlobales.CodigoMantenimiento);
                                    txtCantidad.Text = string.Empty;
                                    txtClaveSeguridad.Text = string.Empty;
                                    rbIngresarProducto.Checked = true;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Favor de seleccionar una Opción", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al realizar esta operació", VariablesBlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
