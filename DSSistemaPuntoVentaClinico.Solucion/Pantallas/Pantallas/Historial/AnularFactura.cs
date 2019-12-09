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
                    //GUARDAMOS LOS DATOS PARA REALIZAR LA NOTA DE CREDITO

                    try {
                        var GuardarDatos = ObjDataHistorial.Value.HistorialFacturacionCotizacion(
                                 new Nullable<decimal>(),
                                 VariablesGlobales.NumeroConector,
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
                        foreach (var n in GuardarDatos)
                        {
                            //GUARDAMOS LOS DATOS DE LOS CLIENTES
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes DatoCliente = new Logica.Entidades.EntidadFacturacion.EFacturacionClientes();
                            DatoCliente.NumeroFactura = 0;
                            DatoCliente.IdEstatusFacturacion = 3;
                            DatoCliente.CodigoFacturacion = "";
                            DatoCliente.NumeroConector = n.NumeroConector;
                            DatoCliente.IdTipoFacturacion = 4;
                            DatoCliente.NombrePaciente = n.NombrePaciente;
                            DatoCliente.Telefono = n.Telefono;
                            DatoCliente.IdCentroSalud = n.IdCentroSalud;
                            DatoCliente.Sala = n.Sala;
                            DatoCliente.IdMedico = n.IdMedico;
                            DatoCliente.IdTipoIdentificacion = n.IdTipoIdentificacion;
                            DatoCliente.NumeroIdentificacion = n.NumeroIdentificacion;
                            DatoCliente.Direccion = n.Direccion;
                            DatoCliente.IdSexo = n.IdSexo;
                            DatoCliente.Email = n.Email;
                            DatoCliente.ComentarioPaciente = n.ComentarioPaciente;
                            DatoCliente.FechaFacturacion = n.FechaFacturacion0;
                            DatoCliente.IdUsuario = VariablesGlobales.IdUsuario;

                            var MAN = ObjDataFacturacion.Value.GuararFacturacionCliete(DatoCliente, "INSERT");

                            //GUARDAMOS LOS DATOS DE LOS PRODUCTOS PARA HACER LA NOTA DE CREDITO
                            var BuscarProductosAgregados = ObjDataFacturacion.Value.BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                            foreach (var n2 in BuscarProductosAgregados)
                            {
                                //GUARDAMOS LOS PRODUCTOS
                                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionProductos Guararproducto = new Logica.Entidades.EntidadFacturacion.EFacturacionProductos();

                                Guararproducto.NumeroConector = VariablesGlobales.NumeroConector;
                                Guararproducto.IdProducto = n2.IdProducto;
                                Guararproducto.Precio = n2.Precio;
                                Guararproducto.Cantidad = n2.Cantidad;
                                Guararproducto.DescuentoAplicado = n2.DescuentoAplicado;
                                Guararproducto.Total = n2.Total;
                                Guararproducto.Secuencial = n2.Secuencial;
                                Guararproducto.NumeroPago = n2.NumeroPago;

                                var MANProducto = ObjDataFacturacion.Value.GuardarFacturacionProductos(Guararproducto, "INSERT");
                            }

                            //GUARDAMOS LOS DATOS DE LOS CALCULOS
                            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionCalculos GuardarCalculos = new Logica.Entidades.EntidadFacturacion.EFacturacionCalculos();

                            GuardarCalculos.NumeroConector = n.NumeroConector;
                            GuardarCalculos.CantidadArticulos = n.CantidadArticulos;
                            GuardarCalculos.TotalDescuento = (n.TotalDescuento * -1);
                            GuardarCalculos.Subtotal = (n.Subtotal * -1);
                            GuardarCalculos.Impuesto = (n.Impuesto * -1);
                            GuardarCalculos.Total = (n.Total * -1);
                            GuardarCalculos.IdTipoPago = n.IdTipoPago;
                            GuardarCalculos.MontoPagado = (n.MontoPagado * -1);
                            GuardarCalculos.IdEstatusCirugia = n.IdEstatusCirugia;

                            var MANCalculos = ObjDataFacturacion.Value.GuardarFacturacionCalculos(GuardarCalculos, "INSERT");
                        }
                        //GUARDAMOS LOS DATOS DEL CLIENTE
                        

                       


                    }
                    catch (Exception ex) { }
                }
            }
        }
    }
}
