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
    public partial class ProductoConsulta : Form
    {
        public ProductoConsulta()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
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

        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS
        private void Listadoproductos()
        {
            string _Codigo = string.IsNullOrEmpty(txtCodigoProducto.Text.Trim()) ? null : txtCodigoProducto.Text.Trim();
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();

            var Listado = ObjdataInventario.Value.BuscaProducto(
                new Nullable<decimal>(),
                _Codigo,
                null, null, null, null,null,
                _Descripcion,
                null, null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtProductos.DataSource = Listado;
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
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

            //this.dtProductos.Columns["TipoProveedor"].Visible = false;
            //this.dtProductos.Columns["TipoProveedor"].Visible = false;
            //this.dtProductos.Columns["TipoProveedor"].Visible = false;
            //this.dtProductos.Columns["TipoProveedor"].Visible = false;
            //this.dtProductos.Columns["TipoProveedor"].Visible = false;

            //FORMATEAR PRODUCTOS
            dtProductos.Columns["CantidadAlmacen"].DefaultCellStyle.Format = "N0";
            dtProductos.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["SegundoPrecio"].DefaultCellStyle.Format = "N2";
            dtProductos.Columns["TercerPrecio"].DefaultCellStyle.Format = "N2";

        }
        #endregion

        #region RESTABLECER PANTALLA
        private void Restablecer()
        {
            btnNuevo.Enabled = true;
            btnConsultar.Enabled = true;
            btnModificar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnRestablecer.Enabled = false;
            lbClaveSeguridad.Visible = false;
            txtClaveSeguridad.Visible = false;
            txtNumeroPagina.Enabled = true;
            txtNumeroRegistros.Enabled = true;
            txtCodigoProducto.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            Listadoproductos();
        }
        #endregion

        #region MANTENIMIENTO
        private void Eliminar()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte EliminarRegistros = new Logica.Entidades.EntidadReporte.EmantenimientoReporte();

            EliminarRegistros.IdUsuarioImprime = VariablesGlobales.IdUsuario;

            var MAN = ObjDataHistorial.Value.MantenimientoReporteProducto(EliminarRegistros, "DELETE");
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("EL numero de registros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 1;
                Listadoproductos();
            }
            else
            {
                Listadoproductos();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoMantenimiento Mantenimiento = new ProductoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = 0;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = "";
            Mantenimiento.VariablesGlobales.AccionTomar = "INSERT";
            Mantenimiento.ShowDialog();
        }

        private void ProductoConsulta_Load(object sender, EventArgs e)
        {
            this.dtProductos.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            gbProductoConsulta.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            gbListadoProductos.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigoProducto.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            dtProductos.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
            SacarDatosEmpresa(1);
            Listadoproductos();
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Mantenimiento de Productos";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Listadoproductos();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                Listadoproductos();
            }
            else
            {
                Listadoproductos();
            }
        }

        private void dtProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtProductos.CurrentRow.Cells["IdProducto"].Value.ToString());
                    VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtProductos.CurrentRow.Cells["CodigoProducto"].Value.ToString());
                    btnAgregar.Enabled = true;
                    var Buscar = ObjdataInventario.Value.BuscaProducto(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, null, null, null, null, null, null, null, 1, 1);
                    dtProductos.DataSource = Buscar;
                    OcultarColumnas();
                    btnNuevo.Enabled = false;
                    btnConsultar.Enabled = false;
                    btnModificar.Enabled = true;
                    btnDeshabilitar.Enabled = true;
                    btnRestablecer.Enabled = true;
                    lbClaveSeguridad.Visible = true;
                    txtClaveSeguridad.Visible = true;
                    txtNumeroPagina.Enabled = false;
                    txtNumeroRegistros.Enabled = false;
                }
            }
            catch (Exception) { }
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("No puedes dejar el campo clave de seguridad vacio para deshabilitar este registro", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var ValidarClave = ObjdataSeguridad.Value.BuscaClaveSeguridad(
                    _Clave,
                    VariablesGlobales.IdUsuario, 1, 1);
                if (ValidarClave.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Deshabilitar = new Logica.Entidades.EntidadInventario.EPRoducto();

                    Deshabilitar.IdProducto = VariablesGlobales.IdMantenimiento;
                    Deshabilitar.CodigoProducto = VariablesGlobales.CodigoMantenimiento;

                    var MAN = ObjdataInventario.Value.MantenimientoProducto(Deshabilitar, "DISABLE");
                    MessageBox.Show("Registro deshabilitado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restablecer();
                    txtClaveSeguridad.Text = string.Empty;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductoMantenimiento Mantenimiento = new ProductoMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.VariablesGlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            Mantenimiento.VariablesGlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            Mantenimiento.VariablesGlobales.AccionTomar = "UPDATE";
            Mantenimiento.ShowDialog();
        }

        private void ProductoConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.AgregarQuitarProductos AgregarQuitar = new AgregarQuitarProductos();
            AgregarQuitar.VariablesBlobales.IdUsuario = VariablesGlobales.IdUsuario;
            AgregarQuitar.VariablesBlobales.IdMantenimiento = VariablesGlobales.IdMantenimiento;
            AgregarQuitar.VariablesBlobales.CodigoMantenimiento = VariablesGlobales.CodigoMantenimiento;
            AgregarQuitar.ShowDialog();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try {
                Eliminar();
                string _Codigo = string.IsNullOrEmpty(txtCodigoProducto.Text.Trim()) ? null : txtCodigoProducto.Text.Trim();
                string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();

                var Listado = ObjdataInventario.Value.BuscaProducto(
                    new Nullable<decimal>(),
                    _Codigo,
                    null, null, null, null, null,
                    _Descripcion,
                    null, null,
                    1,
                    999999999);
                foreach (var n in Listado)
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EmantenimientoReporte Guardar = new Logica.Entidades.EntidadReporte.EmantenimientoReporte();

                    Guardar.IdUsuarioImprime = VariablesGlobales.IdUsuario;
                    Guardar.IdProducto = Convert.ToDecimal(n.IdProducto);
                    Guardar.CodigoProducto = n.CodigoProducto;
                    Guardar.Almacen = n.Almacen;
                    Guardar.TipoProveedor = n.TipoProveedor;
                    Guardar.Proveedor = n.Proveedor;
                    Guardar.TipoEmpaque = n.TipoEmpaque;
                    Guardar.TipoProducto = n.TipoProducto;
                    Guardar.Producto = n.Producto;
                    Guardar.Estatus = n.Estatus;
                    Guardar.CantidadAlmacen = Convert.ToInt32(n.CantidadAlmacen);
                    Guardar.PrecioCompra = Convert.ToDecimal(n.PrecioCompra);
                    Guardar.PrecioVenta = Convert.ToDecimal(n.PrecioVenta);
                    Guardar.SegundoPrecio = Convert.ToDecimal(n.SegundoPrecio);
                    Guardar.TercerPrecio = Convert.ToDecimal(n.TercerPrecio);
                    Guardar.FechaEntrada = n.FechaEntrada;
                    Guardar.LlevaDescuento = n.LlevaDescuento;
                    Guardar.PorcientoDescuento = Convert.ToInt32(n.PorcientoDescuento);
                    Guardar.CreadoPor = n.CreadoPor;
                    Guardar.FechaAdiciona = n.FechaAdiciona;
                    Guardar.ModificadoPor = n.ModificadoPor;
                    Guardar.FechaModifica = n.FechaModifica;

                    var MAN = ObjDataHistorial.Value.MantenimientoReporteProducto(Guardar, "INSERT");

                }

                //COMENZAMOS EL PROCESO PARA MOSTRAR EL REPORTE
                //SACAMOS LA RUTA DEL REPORTE
                var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(5);
                foreach (var n in SacarRutaReporte)
                {
                    VariablesGlobales.RutaReporte = n.RutaReporte;
                }

                //SACAMOS LAS CREDENCIALES DE LA BASE DE DATOS
                var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
                foreach (var n in SacarCredenciales)
                {
                    VariablesGlobales.UsuarioBD = n.Usuario;
                    VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
                }

                ////CARGAMOS EL REPORTE
                //DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes cargar = new Reporte.Reportes();

                //cargar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                //cargar.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
                //cargar.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
                //cargar.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
                //cargar.GenerarReporteProductos(VariablesGlobales.IdUsuario);
                //cargar.ShowDialog();
            }
            catch (Exception) {
                MessageBox.Show("Error al realiar este proceso", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Inventario.ProductosCantidadMinima Cantidad = new ProductosCantidadMinima();
            Cantidad.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Cantidad.ShowDialog();
        }
    }
}
