using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Historial
{
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region CERRAR PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Historial.Historial Volver = new Historial();
            Volver.Variables.IdUsuario = VariablesGlobales.IdUsuario;
            Volver.ShowDialog();
        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region SACAR LOS DATOS DE LA FACTURACION
        private void SacarDatosFactura(decimal NumeroConector)
        {
            var SacarDatosFacturas = ObjDataHistorial.Value.HistorialFacturacionCotizacion(
                new Nullable<decimal>(),
                NumeroConector,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                1, 1);
            foreach (var n in SacarDatosFacturas)
            {

                txtTipoFacturacion.Text = n.TipoComprobante;
                txtNombrePaciente.Text = n.NombrePaciente;
                txtTelefono.Text = n.Telefono;
                txtCentroSalud.Text = n.CentroSalud;
                txtSala.Text = n.Sala;
                txtMedico.Text = n.Medico;
                txtTotalDescuento.Text = n.TotalDescuento.ToString();
                txtSubtotal.Text = n.Subtotal.ToString();
                txtTotal.Text = n.Total.ToString();
                txtEstatus.Text = n.Estatus;
                txtTipoIdentificacion.Text = n.TipoIdentificacion;
                txtIdentificacion.Text = n.NumeroIdentificacion;
                txtDireccion.Text = n.Direccion;
                txtsexo.Text = n.Sexo;
                txtEmail.Text = n.Email;
                txtComentario.Text = n.ComentarioPaciente;
                txtCantidadArtiuclos.Text = n.CantidadArticulos.ToString();
                txtImpuesto.Text = n.Impuesto.ToString();
                txtTipoPago.Text = n.TipoPago;
                txtMontoPagar.Text = n.MontoPagado.ToString();
            }
            dataGridView1.DataSource = SacarDatosFacturas;
            OcultarColumnas();
        }
        #endregion
        #region OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            dataGridView1.Columns["NumeroFactura"].Visible = false;
            dataGridView1.Columns["NombrePaciente"].Visible = false;
            dataGridView1.Columns["IdTipoIdentificacion"].Visible = false;
            dataGridView1.Columns["TipoIdentificacion"].Visible = false;
            dataGridView1.Columns["NumeroIdentificacion"].Visible = false;
            dataGridView1.Columns["IdEstatusFacturacion"].Visible = false;
            dataGridView1.Columns["Estatus"].Visible = false;
            dataGridView1.Columns["CodigoFacturacion"].Visible = false;
            dataGridView1.Columns["NumeroConector"].Visible = false;
            dataGridView1.Columns["IdTipoFacturacion"].Visible = false;
            dataGridView1.Columns["TipoComprobante"].Visible = false;
            dataGridView1.Columns["ValidoHasta"].Visible = false;
            dataGridView1.Columns["Comprobante"].Visible = false;
            dataGridView1.Columns["Telefono"].Visible = false;
            dataGridView1.Columns["IdCentroSalud"].Visible = false;
            dataGridView1.Columns["CentroSalud"].Visible = false;
            dataGridView1.Columns["Sala"].Visible = false;
            dataGridView1.Columns["IdMedico"].Visible = false;
            dataGridView1.Columns["Medico"].Visible = false;
            dataGridView1.Columns["Direccion"].Visible = false;
            dataGridView1.Columns["IdSexo"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["ComentarioPaciente"].Visible = false;
            dataGridView1.Columns["FechaFacturacion0"].Visible = false;
            dataGridView1.Columns["FechaFacturacion"].Visible = false;
            dataGridView1.Columns["IdUsuario"].Visible = false;
            dataGridView1.Columns["CreadoPor"].Visible = false;
            dataGridView1.Columns["IdProducto"].Visible = false;
            dataGridView1.Columns["Total"].Visible = false;
            dataGridView1.Columns["TotalDescuento"].Visible = false;
            dataGridView1.Columns["Subtotal"].Visible = false;
            dataGridView1.Columns["Impuesto"].Visible = false;
            dataGridView1.Columns["TotalGeneral"].Visible = false;
            dataGridView1.Columns["IdTipoPago"].Visible = false;
            dataGridView1.Columns["TipoPago"].Visible = false;
            dataGridView1.Columns["MontoPagado"].Visible = false;
            dataGridView1.Columns["IdEstatusCirugia"].Visible = false;
            dataGridView1.Columns["EstatusCirugia"].Visible = false;
            dataGridView1.Columns["Sexo"].Visible = false;
            
        }
        #endregion
        #region DEVOLVER LOS PRODUCTOS AL INVENTARIO AL ANULAR LA FACTURA
        private void DevolverProductosInventario()
        {
            decimal IdProducto = 0;
            string CodigoProducto = "";
            int Cantidad = 0;

            var BuscarProductos = ObjDataFacturacion.Value.BuscarProductosAgregados(VariablesGlobales.NumeroConector, null);
            foreach (var n in BuscarProductos)
            {
                IdProducto = Convert.ToDecimal(n.IdProducto);
                CodigoProducto = n.CodigoProducto;
                Cantidad = Convert.ToInt32(n.Cantidad);

                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Devolver = new Logica.Entidades.EntidadInventario.EPRoducto();

                Devolver.IdProducto = IdProducto;
                Devolver.CodigoProducto = CodigoProducto;
                Devolver.CantidadAlmacen = Cantidad;

                var MAN = ObjDataInventario.Value.MantenimientoProducto(Devolver, "ADD");
            }
        }
        #endregion
        private void AnularFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Anulación de Factura";
            lbTitulo.ForeColor = Color.White;
            SacarInformacionEmpresa(1);
            txtClaveSeguridad.PasswordChar = '•';
            SacarDatosFactura(VariablesGlobales.NumeroConector);
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            if (VariablesGlobales.IdEstatusFacturacion == 1)
            {
                lbTitulo.Text = "Anulación de factura";
                button1.Text = "Anular Factura";
            }
            else
            {
                lbTitulo.Text = "Eliminar Cotización";
                button1.Text = "Eliminar Cotización";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LA CLAVE DE SEGURIDAD
                var ValidarCoalev = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text),
                    null, 1, 1);
                if (ValidarCoalev.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();
                }
                else
                {
                    //ANULAR FACTURA
                    if (VariablesGlobales.IdEstatusFacturacion == 1)
                    {
                        DevolverProductosInventario();
                        //CAMBIAMOS EL ESTATUS DE LA FACTURACION A CANCELADA
                        DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes Changestatus = new Logica.Entidades.EntidadFacturacion.EFacturacionClientes();

                        Changestatus.NumeroConector = VariablesGlobales.NumeroConector;
                        Changestatus.NumeroFactura = VariablesGlobales.Numerofactura;
                        Changestatus.IdUsuario = VariablesGlobales.IdUsuario;

                        var MAN = ObjDataFacturacion.Value.GuararFacturacionCliete(Changestatus, "BILLCANCEL");
                        MessageBox.Show("Anulacion de la factura " + VariablesGlobales.Numerofactura + " fue anulada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CerrarPantalla();
                    }
                    //ELIMIANR COTIZACION
                    else if (VariablesGlobales.IdEstatusFacturacion == 2)
                    {
                        //ELIMINAMOS LA COTIZACION
                        if (MessageBox.Show("¿Quieres eliminar esta cotización?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes Changestatus = new Logica.Entidades.EntidadFacturacion.EFacturacionClientes();

                            Changestatus.NumeroConector = VariablesGlobales.NumeroConector;

                            var MAN = ObjDataFacturacion.Value.GuararFacturacionCliete(Changestatus, "DELETEBILL");
                            MessageBox.Show("Cotización realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CerrarPantalla();
                        }
                    }
                }
            }
        }
    }
}
