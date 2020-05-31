using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion
{
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjdataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LA INFORMACION DE LA EMPRESA
        private void MostrarInformacionEmpresa(decimal IdInformacionEmpresa)
        {
            var Mostrar = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in Mostrar)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region MOSTRAR EL TIPO DE PRODCTO
        private void MostrarTipoProducto()
        {
            var Mostrar = ObjdataListas.Value.ListaTipoProducto();
            ddlTipoProducto.DataSource = Mostrar;
            ddlTipoProducto.DisplayMember = "Descripcion";
            ddlTipoProducto.ValueMember = "IdTipoProducto";
        }
        #endregion
        #region MOSTRAR EL LISTADO MEDINA DIAZ
        private void MostrarListado()
        {
            string _Codigo = string.IsNullOrEmpty(txtCodigo.Text.Trim()) ? null : txtCodigo.Text.Trim();
            string _Descripcion = string.IsNullOrEmpty(txtDescripcion.Text.Trim()) ? null : txtDescripcion.Text.Trim();

            var Buscar = ObjdataInventario.Value.BuscaProducto(
                new Nullable<decimal>(),
                _Codigo,
                null,
                null,
                null,
                null,
                Convert.ToDecimal(ddlTipoProducto.SelectedValue),
                _Descripcion,
                null,
                null,
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtSeleccionarproducto.DataSource = Buscar;
            OcultarColumna();
        }
        private void OcultarColumna()
        {
            this.dtSeleccionarproducto.Columns["IdProducto"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdAlmacen"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdTipoProveedor"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdProveedor"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdTipoEmpaque"].Visible = false;
            this.dtSeleccionarproducto.Columns["Estatus0"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaEntrada0"].Visible = false;
            this.dtSeleccionarproducto.Columns["LlevaDescuento0"].Visible = false;
            this.dtSeleccionarproducto.Columns["UsuarioAdiciona"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaAdiciona0"].Visible = false;
            this.dtSeleccionarproducto.Columns["UsuarioModifica"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaModifica0"].Visible = false;
            this.dtSeleccionarproducto.Columns["IdTipoProducto0"].Visible = false;
            this.dtSeleccionarproducto.Columns["Almacen"].Visible = false;
            this.dtSeleccionarproducto.Columns["TipoEmpaque"].Visible = false;
            this.dtSeleccionarproducto.Columns["PrecioCompra"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaEntrada"].Visible = false;
            this.dtSeleccionarproducto.Columns["CreadoPor"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaAdiciona"].Visible = false;
            this.dtSeleccionarproducto.Columns["ModificadoPor"].Visible = false;
            this.dtSeleccionarproducto.Columns["FechaModifica"].Visible = false;

            this.dtSeleccionarproducto.Columns["TipoProveedor"].Visible = false;
            this.dtSeleccionarproducto.Columns["Proveedor"].Visible = false;
            this.dtSeleccionarproducto.Columns["TipoProducto"].Visible = false;
            this.dtSeleccionarproducto.Columns["LlevaDescuento"].Visible = false;
            this.dtSeleccionarproducto.Columns["PorcientoDescuento"].Visible = false;

            dtSeleccionarproducto.Columns["CantidadAlmacen"].DefaultCellStyle.Format = "N0";
            dtSeleccionarproducto.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
            dtSeleccionarproducto.Columns["SegundoPrecio"].DefaultCellStyle.Format = "N2";
            dtSeleccionarproducto.Columns["TercerPrecio"].DefaultCellStyle.Format = "N2";
        }
        #endregion
        #region GUARDAR LOS PROUCTOS PARA LA FACTURACION
        private void GuardarProductosFacturacion(string Accion)
        {
            decimal PrecioUsar = 0;
            decimal NumeroPago = 0;

            if (rbAgregarPrimerprecio.Checked)
            {
                PrecioUsar = Convert.ToDecimal(txtPrecio.Text);
            }
            else if (rbAgregarSegundoPrecio.Checked)
            {
                PrecioUsar = Convert.ToDecimal(txtSegundoPrecio.Text);
            }
            else if (rbAgregarTercerprecio.Checked)
            {
                PrecioUsar = Convert.ToDecimal(txtTercerprecio.Text);
            }
            if (rbAgregarPrimerprecio.Checked)
            {
                NumeroPago = 1;
            }
            else if (rbAgregarSegundoPrecio.Checked)
            {
                NumeroPago = 2;
            }
            else if (rbAgregarTercerprecio.Checked)
            {
                NumeroPago = 3;
            }
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionProductos Producto = new Logica.Entidades.EntidadFacturacion.EFacturacionProductos();

            Producto.NumeroConector = VariablesGlobales.NumeroConector;
            Producto.IdProducto = VariablesGlobales.IdMantenimiento;
            Producto.Precio = PrecioUsar;
            Producto.Cantidad = Convert.ToDecimal(txtCantidadUsar.Text);
            Producto.DescuentoAplicado = Convert.ToDecimal(txtDescuento.Text);
            Producto.Secuencial = VariablesGlobales.Secuencial;
            Producto.NumeroPago = NumeroPago;

            var MAN = ObjDataFacturacion.Value.GuardarFacturacionProductos(Producto, Accion);
        }
        #endregion
        #region MOSTRAR LOS PRODUCTOS AGREGADOS
        private void MostrarProductosAgregados(decimal NumeroConector)
        {
            var Mostrar = ObjDataFacturacion.Value.BuscarProductosAgregados(NumeroConector);
            dtProductosAgregados.DataSource = Mostrar;
            this.dtProductosAgregados.Columns["NumeroConector"].Visible = false;
            this.dtProductosAgregados.Columns["IdProducto"].Visible = false;
            this.dtProductosAgregados.Columns["CodigoProducto"].Visible = false;
            this.dtProductosAgregados.Columns["PrecioCompra"].Visible = false;
            this.dtProductosAgregados.Columns["Secuencial"].Visible = false;
            this.dtProductosAgregados.Columns["NumeroPago"].Visible = false;
            this.dtProductosAgregados.Columns["LlevaDescuento0"].Visible = false;
            this.dtProductosAgregados.Columns["DescuentoAplicado"].Visible = false;

            dtProductosAgregados.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dtProductosAgregados.Columns["Cantidad"].DefaultCellStyle.Format = "N0";
            dtProductosAgregados.Columns["Total"].DefaultCellStyle.Format = "N2";
        }
        #endregion
        #region VOLVER ATRAS
        private void Volver()
        {
            dtSeleccionarproducto.Enabled = true;
            txtCodigo.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNumeroPagina.Enabled = false;
            txtNumeroRegistros.Enabled = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            MostrarListado();
            txtTipoProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtCantidadDisponible.Text = string.Empty;
            txtCantidadUsar.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtSegundoPrecio.Text = string.Empty;
            txtTercerprecio.Text = string.Empty;
            txtDescuento.Text = string.Empty;
            rbAgregarPrimerprecio.Checked = true;
            btnQuitar.Enabled = false;
            btnAgregar.Enabled = false;
        }
#endregion
        private void AgregarProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
            this.dtSeleccionarproducto.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtSeleccionarproducto.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dtProductosAgregados.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtProductosAgregados.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            gbBuscarproductos.ForeColor = Color.Black;
            gbListadoProductos.ForeColor = Color.Black;
            gbProductosAgregados.ForeColor = Color.Black;
            lbcantidadDisponible.ForeColor = Color.Black;
            lbCantidadUsar.ForeColor = Color.Black;
            lbCantidaRegistros.ForeColor = Color.Black;
            lbDescuento.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            lbPrecio.ForeColor = Color.Black;
            lbProducto.ForeColor = Color.Black;
            lbSegundoPrecio.ForeColor = Color.Black;
            lbTercerPrecio.ForeColor = Color.Black;
            lbTipoProducto.ForeColor = Color.Black;
            btnAgregar.ForeColor = Color.Black;
            txtCantidadDisponible.ForeColor = Color.Black;
            txtCantidadUsar.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtDescripcion.ForeColor = Color.Black;
            txtTercerprecio.ForeColor = Color.Black;
            txtNumeroPagina.ForeColor = Color.Black;
            txtNumeroRegistros.ForeColor = Color.Black;
            txtPrecio.ForeColor = Color.Black;
            txtProducto.ForeColor = Color.Black;
            txtSegundoPrecio.ForeColor = Color.Black;
            txtTipoProducto.ForeColor = Color.Black;
            dtProductosAgregados.ForeColor = Color.Black;
            dtSeleccionarproducto.ForeColor = Color.Black;
            MostrarInformacionEmpresa(1);
            MostrarTipoProducto();
            btnVolver.ForeColor = Color.Black;
            rbAgregarPrimerprecio.ForeColor = Color.Red;
            rbAgregarSegundoPrecio.ForeColor = Color.Red;
            rbAgregarTercerprecio.ForeColor = Color.Red;
            rbAgregarPrimerprecio.Checked = true;
            MostrarProductosAgregados(VariablesGlobales.NumeroConector);
            btnQuitar.ForeColor = Color.Black;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.Facturacion Facturacion = new Facturacion();
            Facturacion.VariablesGlobales.NumeroConector = VariablesGlobales.NumeroConector;
            Facturacion.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Facturacion.VariablesGlobales.SacarDatosEspejo = true;
            Facturacion.VariablesGlobales.BloqueaControles = VariablesGlobales.BloqueaControles;
            Facturacion.VariablesGlobales.IdTipoVentaSeleccionado = VariablesGlobales.IdTipoVentaSeleccionado;
            Facturacion.VariablesGlobales.CodigoPaciente = VariablesGlobales.CodigoPaciente;
            Facturacion.ddlTipoVenta.Text = VariablesGlobales.TipoVenta;
            Facturacion.ddlCantidadDias.Text = VariablesGlobales.CantidadDias.ToString();
            Facturacion.VariablesGlobales.ConvertirCotizacionFactura = VariablesGlobales.ConvertirCotizacionFactura;
            Facturacion.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarListado();
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void lbNumeroRegistros_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de reistros no puede ser menor a 1", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 10;
                MostrarListado();
            }
            else
            {
                MostrarListado();
            }
        }

        private void dtSeleccionarproducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                decimal Cantidad = 0;
                if (MessageBox.Show("¿Quieres seleccionar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtSeleccionarproducto.CurrentRow.Cells["IdProducto"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtSeleccionarproducto.CurrentRow.Cells["CodigoProducto"].Value.ToString());


                    //VERIFICAMOS SI EL PRODUCTO ESTA ACTIVADO
                    var Verificarproducto = ObjdataInventario.Value.BuscaProducto(
                        VariablesGlobales.IdMantenimiento,
                        VariablesGlobales.CodigoMantenimiento,
                        null, null, null, null, null, null, null, null, 1, 1);

                    foreach (var n in Verificarproducto)
                    {
                        VariablesGlobales.EstatusProducto = Convert.ToBoolean(n.Estatus0);
                        if (VariablesGlobales.EstatusProducto == true)
                        {
                            //CONTAMOS LA CANTIDAD DISPONIBLE
                            var Contar = ObjdataInventario.Value.Contarproductos(
                                VariablesGlobales.IdMantenimiento,
                                VariablesGlobales.CodigoMantenimiento);
                            foreach (var n2 in Contar)
                            {
                                lbCantidaRegistros.Text = n2.Cantidad.ToString();
                            }
                            Cantidad = Convert.ToDecimal(lbCantidaRegistros.Text);
                            if (Cantidad < 1)
                            {
                                MessageBox.Show("Este producto esta agotado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                txtTipoProducto.Text = n.TipoProducto;
                                txtProducto.Text = n.Producto;
                                int CantidadDisponible = Convert.ToInt32(n.CantidadAlmacen);
                                decimal Precio = Convert.ToDecimal(n.PrecioVenta);
                                decimal SegundoPrecio = Convert.ToDecimal(n.SegundoPrecio);
                                decimal TercerPrecio = Convert.ToDecimal(n.TercerPrecio);

                                txtCantidadDisponible.Text = CantidadDisponible.ToString("N0");
                                txtPrecio.Text = Precio.ToString("N2");
                                txtSegundoPrecio.Text = SegundoPrecio.ToString("N2");
                                txtTercerprecio.Text = TercerPrecio.ToString("N2");
                                bool LlevaDescuento = Convert.ToBoolean(n.LlevaDescuento0);
                                if (LlevaDescuento == true)
                                {
                                    txtDescuento.Enabled = true;
                                    txtDescuento.Text = "0";
                                }
                                else
                                {
                                    txtDescuento.Enabled = false;
                                    txtDescuento.Text = "0";
                                }
                                dtSeleccionarproducto.DataSource = Verificarproducto;
                                dtSeleccionarproducto.Enabled = false;
                                txtNumeroPagina.Enabled = false;
                                txtNumeroRegistros.Enabled = false;
                                txtCantidadUsar.Text = "1";
                                btnAgregar.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este producto no se puede seleccionar por que esta deshabilitado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {

                }
            }
            catch (Exception) { }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Volver();
            txtCantidadUsar.Enabled = true;
        }

        private void rbAgregarPrimerprecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgregarPrimerprecio.Checked)
            {
                rbAgregarPrimerprecio.ForeColor = Color.White;
            }
            else
            {
                rbAgregarPrimerprecio.ForeColor = Color.Red;
            }
        }

        private void rbAgregarSegundoPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgregarSegundoPrecio.Checked)
            {
                rbAgregarSegundoPrecio.ForeColor = Color.White;
            }
            else
            {
                rbAgregarSegundoPrecio.ForeColor = Color.Red;
            }
        }

        private void rbAgregarTercerprecio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAgregarTercerprecio.Checked)
            {
                rbAgregarTercerprecio.ForeColor = Color.White;
            }
            else
            {
                rbAgregarTercerprecio.ForeColor = Color.Red;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            //DESCONTAMOS EL LA CANTIDAD AL PRODUCTO
            //SACAMOS LA CANTIDAD
            decimal CantidadAlmacen = Convert.ToDecimal(txtCantidadDisponible.Text);
            decimal CantidadVeder = Convert.ToDecimal(txtCantidadUsar.Text);

            if (CantidadVeder > CantidadAlmacen)
            {
                MessageBox.Show("No es posible realizar este paso por que actualmente tienes " + CantidadAlmacen + " en almacen y estan vendiendo " + CantidadVeder + " del producto seleccionado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (VariablesGlobales.ConvertirCotizacionFactura != "CONVERTIR COTIZACION A FACTURA")
                {
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Priducto = new Logica.Entidades.EntidadInventario.EPRoducto();

                    Priducto.IdProducto = VariablesGlobales.IdMantenimiento;
                    Priducto.CodigoProducto = VariablesGlobales.CodigoMantenimiento;
                    Priducto.CantidadAlmacen = Convert.ToInt32(CantidadVeder);

                    var MAN = ObjdataInventario.Value.MantenimientoProducto(Priducto, "LESS");

                }

           

                VariablesGlobales.Secuencial = 0;
                GuardarProductosFacturacion("INSERT");
                MostrarProductosAgregados(VariablesGlobales.NumeroConector);
                Volver();
            }
        

        }

        private void dtProductosAgregados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres seleccionar este producto?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtCantidadUsar.Enabled = false;
                    this.VariablesGlobales.IdMantenimiento = Convert.ToDecimal(this.dtProductosAgregados.CurrentRow.Cells["IdProducto"].Value.ToString());
                    this.VariablesGlobales.CodigoMantenimiento = Convert.ToString(this.dtProductosAgregados.CurrentRow.Cells["CodigoProducto"].Value.ToString());
                    this.VariablesGlobales.Secuencial = Convert.ToDecimal(this.dtProductosAgregados.CurrentRow.Cells["Secuencial"].Value.ToString());
                    //SACAMOS LOS DATOS DEL PRODUCTO
                 //   btnAgregar.Text = "Editar";
                    btnQuitar.Enabled = true;
                    decimal Numeropago = 0;
                    bool LlevaDescuento = false;
                    var SacarDatos = ObjDataFacturacion.Value.BuscarProductosAgregados(
                        VariablesGlobales.NumeroConector,
                        VariablesGlobales.Secuencial);
                    foreach (var n in SacarDatos)
                    {
                        //SACAMOS EL PRODUCTO
                        var Sacarproducto = ObjdataInventario.Value.BuscaProducto(
                            VariablesGlobales.IdMantenimiento,
                            null,
                            null, null, null, null, null, null, null, null, 1, 1);
                        foreach (var n2 in Sacarproducto)
                        {
                            txtTipoProducto.Text = n2.TipoProducto;
                            txtProducto.Text = n2.Producto;
                            txtCantidadDisponible.Text = n2.CantidadAlmacen.ToString();
                            txtPrecio.Text = n2.PrecioVenta.ToString();
                            txtSegundoPrecio.Text = n2.SegundoPrecio.ToString();
                            txtTercerprecio.Text = n2.TercerPrecio.ToString();
                            LlevaDescuento = Convert.ToBoolean(n.LlevaDescuento0);
                            if (LlevaDescuento == true)
                            {
                                txtDescuento.Enabled = true;
                            }
                            else
                            {
                                txtDescuento.Enabled = false;
                            }

                        }
                        txtCantidadUsar.Text = n.Cantidad.ToString();
                        Numeropago = Convert.ToDecimal(n.NumeroPago);
                        if (Numeropago == 1)
                        {
                            rbAgregarPrimerprecio.Checked = true;
                        }
                        else if (Numeropago == 2)
                        {
                            rbAgregarSegundoPrecio.Checked = true;
                        }
                        else if (Numeropago == 3)
                        {
                            rbAgregarTercerprecio.Checked = true;
                        }
                        txtDescuento.Text = n.DescuentoAplicado.ToString();
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres eliminar este producto de la facturación", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Priducto = new Logica.Entidades.EntidadInventario.EPRoducto();

                Priducto.IdProducto = VariablesGlobales.IdMantenimiento;
                Priducto.CodigoProducto = VariablesGlobales.CodigoMantenimiento;
                Priducto.CantidadAlmacen = Convert.ToInt32(txtCantidadUsar.Text);

                var MAN = ObjdataInventario.Value.MantenimientoProducto(Priducto, "ADD");

                GuardarProductosFacturacion("DELETE");
                MostrarProductosAgregados(VariablesGlobales.NumeroConector);
                txtCantidadUsar.Enabled = true;
                Volver();
            }
        }
    }
}
