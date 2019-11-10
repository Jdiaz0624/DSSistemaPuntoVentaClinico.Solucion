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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjdataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales Variables = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR EL HISTORIAL
        private void MostrarHistorial()
        {
            try {
                //HACEMOS LA CONSULTA CUANDO EL RADIO BUTTON GENERAL ESTA SELECCIONADO
                if (rbGenerar.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        //BUSQUEDA GENERAL SIN AGREGAR RANGO DE FECHA
                        var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                            new Nullable<decimal>(),
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
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = Consultar;

                    }
                    else
                    {
                        //BUSQUEDA GENERAL AGREGANDO RANGO DE FECHA
                        var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                            new Nullable<decimal>(),
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = Consultar;
                    }
                }
                //HACEMOS LA CONSULTA CUANDO EL CHECK DE FACTURA CORTA ESTA SELECCIONADO
                else if (rbFactura.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            //BUSQUEDA GENERAL SIN AGREGAR RANGO DE FECHA
                            var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                Convert.ToDecimal(txtParametro.Text),
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
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Consultar;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            //BUSQUEDA GENERAL AGREGANDO RANGO DE FECHA
                            var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                Convert.ToDecimal(txtParametro.Text),
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Consultar;
                        }
                    }

                }
                //HACEMOS LA CONSULTA CON EL NUMERO DE FACTURA LARGO
                else if (rbNumeroFactura.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                Convert.ToDecimal(txtParametro.Text),
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
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Consultar;

                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                            {
                                MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtParametro.Focus();
                            }
                            {
                                var Consultar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                            new Nullable<decimal>(),
                            Convert.ToDecimal(txtParametro.Text),
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            null,
                            Convert.ToDateTime(txtFechaDesde.Text),
                            Convert.ToDateTime(txtFechaHasta.Text),
                            null,
                            Convert.ToInt32(txtNumeroPagina.Value),
                            Convert.ToInt32(txtNumeroRegistros.Value));
                                dtListado.DataSource = Consultar;
                            }
                         
                        }
                    }
                }
                //HACEMOS LA CONSULTA MEDIANTE EL ESTATUS DE LA FACTURA
                else if (rbEstatus.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(ddlSeleccionar.Text.Trim()))
                        {
                            MessageBox.Show("No hay registros cargados para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var Buscar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Buscar;
                        }
                    }
                    else
                    {
                        var Buscar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToDateTime(txtFechaDesde),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                        dtListado.DataSource = Buscar;
                    }
                }
                //HACEMOS LA CONSULTA MEDIANTE EL TIPO DE FACTURACION
                else if (rbTipoFacturacion.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(ddlSeleccionar.Text.Trim()))
                        {
                            MessageBox.Show("No hay registros cargados para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var Buscar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                null,
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Buscar;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(ddlSeleccionar.Text.Trim()))
                        {
                            MessageBox.Show("No hay registros cargados para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var Buscar = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                               new Nullable<decimal>(),
                               null,
                               null,
                               null,
                               null,
                               Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                               null,
                               null,
                               null,
                               Convert.ToDateTime(txtFechaDesde.Text),
                               Convert.ToDateTime(txtFechaHasta.Text),
                               null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Buscar;
                        }
                    }
                }
                //HACEMOS LA CONSULTA MEDIANTE EL TIPO DE PAGO
                else if (rbTipoPago.Checked)
                {
                    if (cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(ddlSeleccionar.Text.Trim()))
                        {
                            MessageBox.Show("No hay registros cargados para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var TipoPago = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                                null,
                                null,
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = TipoPago;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(ddlSeleccionar.Text.Trim()))
                        {
                            MessageBox.Show("No hay registros cargados para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            var TipoPago = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToDecimal(ddlSeleccionar.SelectedValue),
                                Convert.ToDateTime(txtFechaDesde.Text),
                                Convert.ToDateTime(txtFechaHasta.Text),
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = TipoPago;
                        }
                    }
                }
                //HACEMOS LA CONSULTA MEDIANTE EL NOMBRE DEL PACIENTE
                else if (rbPaciente.Checked)
                {
                    if(cbNoagregarRangofecha.Checked)
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            var Buscarpaciente = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                                new Nullable<decimal>(),
                                null,
                                txtParametro.Text,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                null,
                                Convert.ToInt32(txtNumeroPagina.Value),
                                Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Buscarpaciente;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtParametro.Text.Trim()))
                        {
                            MessageBox.Show("Tienes que ingresar el numero de factura para realizar esta consulta", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtParametro.Focus();
                        }
                        else
                        {
                            var Buscarpaciente = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                               new Nullable<decimal>(),
                               null,
                               txtParametro.Text,
                               null,
                               null,
                               null,
                               null,
                               null,
                               null,
                               Convert.ToDateTime(txtFechaDesde.Text),
                               Convert.ToDateTime(txtFechaHasta.Text),
                               null,
                               Convert.ToInt32(txtNumeroPagina.Value),
                               Convert.ToInt32(txtNumeroRegistros.Value));
                            dtListado.DataSource = Buscarpaciente;
                        }
                    }
                }
                OcultarColumnas();
                btnImprimir.Enabled = false;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al mostrar la consulta, Codigo de Error --> " + ex.Message, Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void OcultarColumnas()
        {
            this.dtListado.Columns["IdTipoIdentificacion"].Visible = false;
            this.dtListado.Columns["IdEstatusFacturacion"].Visible = false;
            this.dtListado.Columns["CodigoFacturacion"].Visible = false;
            this.dtListado.Columns["IdTipoFacturacion"].Visible = false;
            this.dtListado.Columns["ValidoHasta"].Visible = false;
            this.dtListado.Columns["IdCentroSalud"].Visible = false;
            this.dtListado.Columns["IdMedico"].Visible = false;
            this.dtListado.Columns["IdSexo"].Visible = false;
            this.dtListado.Columns["FechaFacturacion0"].Visible = false;
            this.dtListado.Columns["IdUsuario"].Visible = false;
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["IdTipoPago"].Visible = false;
        }
        #endregion

        #region MANTENIMIENTO DE HISTORIAL DE FACTURACION COTIZACION
        private void MANHistorialFacturacionCotizacion(string Accion)
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion Mantenimiento = new Logica.Entidades.EntidadReporte.EReporteHistorialFacturacionCotizacion();

            Mantenimiento.IdUsuario = Variables.IdUsuario;
            Mantenimiento.NumeroFactura = Variables.NumeroFacturaHis;
            Mantenimiento.NombrePaciente = Variables.NombrePacienteHis;
            Mantenimiento.IdTipoIdentificacion = Variables.IdTipoIdentificacionHis;
            Mantenimiento.TipoIdentificacion = Variables.TipoIdentificacionHis;
            Mantenimiento.NumeroIdentificacion = Variables.NumeroIdentificacionHis;
            Mantenimiento.IdEstatusFacturacion = Variables.IdEstatusFacturacionHis;
            Mantenimiento.Estatus = Variables.EstatusHis;
            Mantenimiento.CodigoFacturacion = Variables.CodigoFacturacionHis;
            Mantenimiento.NumeroConector = Variables.NumeroConector;
            Mantenimiento.IdTipoFacturacion = Variables.IdTipoFacturacionHis;
            Mantenimiento.TipoComprobante = Variables.TipoComprobanteHis;
            Mantenimiento.ValidoHasta = Variables.ValidoHastaHis;
            Mantenimiento.Comprobante = Variables.ComprobanteHis;
            Mantenimiento.Telefono = Variables.TelefonoHis;
            Mantenimiento.IdCentroSalud = Variables.IdCentroSaludHis;
            Mantenimiento.CentroSalud = Variables.CentroSaludHis;
            Mantenimiento.Sala = Variables.SalaHis;
            Mantenimiento.IdMedico = Variables.IdMedicoHis;
            Mantenimiento.Medico = Variables.MedicoHis;
            Mantenimiento.Direccion = Variables.DireccionHis;
            Mantenimiento.IdSexo = Variables.IdSexoHis;
            Mantenimiento.Sexo = Variables.SexoHis;
            Mantenimiento.Email = Variables.EmailHis;
            Mantenimiento.ComentarioPaciente = Variables.ComentarioPacienteHis;
            Mantenimiento.FechaFacturacion0 = Variables.FechaFacturacion0His;
            Mantenimiento.FechaFacturacion = Variables.FechaFacturacionHis;
            Mantenimiento.IdUsuarioCrea = Variables.IdUsuarioCreaHis;
            Mantenimiento.Creadopor = Variables.CreadoporHis;
            Mantenimiento.IdProducto = Variables.IdProductoHis;
            Mantenimiento.TipoProducto = Variables.TipoProductoHis;
            Mantenimiento.ProDucto = Variables.ProDuctoHis;
            Mantenimiento.Cantidad = Variables.CantidadHis;
            Mantenimiento.Precio = Variables.PrecioHis;
            Mantenimiento.DescuentoAplicado = Variables.DescuentoAplicadoHis;
            Mantenimiento.Total = Variables.TotalHis;
            Mantenimiento.CantidadArticulos = Variables.CantidadArticulosHis;
            Mantenimiento.TotalDescuento = Variables.TotalDescuentoHis;
            Mantenimiento.Subtotal = Variables.SubtotalHis;
            Mantenimiento.Impuesto = Variables.ImpuestoHis;
            Mantenimiento.TotalGeneral = Variables.TotalGeneralHis;
            Mantenimiento.IdTipoPago = Variables.IdTipoPagoHis;
            Mantenimiento.TipoPago = Variables.TipoPagoHis;
            Mantenimiento.MontoPagado = Variables.MontoPagadoHis;

            var MAN = ObjdataHistorial.Value.MantenimientoHistorialFacturacionCotizacion(Mantenimiento, Accion);
        }
        #endregion

        #region IMPRESION DE FACTURAS
        private void GenerarFacturaVentas(decimal NumeroConector)
        {
            //SACAMOS EL USUARIO Y LA CLAVE DE LA BASE DE DATOS
            var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                Variables.UsuarioBD = n.Usuario;
                Variables.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }
            //SACAMOS LA RUTA DEL REPORTE SELECCIONADO

            var SacarRutaReporte = ObjdataHistorial.Value.SacarRutaReporte(1);
            foreach (var n in SacarRutaReporte)
            {
                Variables.RutaReporte = n.RutaReporte;
            }

            //MOSTRAMOS EL REPORTE
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Factura = new Reporte.Reportes();
            Factura.VariablesGlobales.UsuarioBD = Variables.UsuarioBD;
            Factura.VariablesGlobales.ClaveBD = Variables.ClaveBD;
            Factura.VariablesGlobales.RutaReporte = Variables.RutaReporte;
            Factura.CargarReporteExternoPantalla(NumeroConector);
            Factura.ShowDialog();
        }
        #endregion

        #region RESTABLECER LA PANTALLA
        private void RestablecerPantalla()
        {
            rbGenerar.Checked = true;
            cbNoagregarRangofecha.Checked = false;
            txtNumeroPagina.Value = 1;
            txtNumeroRegistros.Value = 10;
            btnFacturar.Enabled = false;
            MostrarHistorial();
        }
        #endregion

        #region GUARDAR LA FACTURACION COMPROBANTE
        private void AfectarComprobante(decimal IdCOmprobante)
        {
            //SACAMOS LOS DATOS DEL COMPROBANTE
            string Comprobante = "", TipoComprobante = "";
            var SacarComprobante = ObjdataContabilidad.Value.GenerarComprobantesFiscales(IdCOmprobante);
            foreach (var n in SacarComprobante)
            {
                Comprobante = n.Comprobante;
                TipoComprobante = n.TipoComprobante;
            }
            //GUARDAMOS LOS DATOS DE LOS COMPROBANTES
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EGuardarFacturacionComprobante Guardar = new Logica.Entidades.EntidadFacturacion.EGuardarFacturacionComprobante();

            Guardar.IdFacturacion = 0;
            Guardar.CodigoFacturacion = "";
            Guardar.NumeroConector = Variables.NumeroConector;
            Guardar.TipoComprobante = TipoComprobante;
            Guardar.Comprobante = Comprobante;

            var MAN = ObjDataFacturacion.Value.GuardarFacturacionComprobante(Guardar, "INSERT");
        }

        #endregion

        #region SACAR EL NOMBRE DE LA EMPRESA
        private void SacarNombreEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacionEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacionEmpresa)
            {
                Variables.NombreSistema = n.NombreEmpresa;
            }
            

            
        }
        #endregion

        #region AFECTAR LA CAJA
        private void AfectarCaja(decimal Total,decimal IdTipoPago)
        {
            //INSERTAMOS LOS DATOS PARA HACER EL REGISTRO DENTRO DEL HISTORIAL DE LA CAJA

                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EHistorialCaja Historial = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

                Historial.IdistorialCaja = 0;
                Historial.IdCaja = 1;
                Historial.Monto = Total;
                Historial.Concepto = "FACTURACION";
                Historial.Fecha0 = DateTime.Now;
                Historial.IdUsuario = Variables.IdUsuario;
                Historial.NumeroReferencia = Variables.NumeroConector;
                Historial.IdTipoPago = IdTipoPago;

                var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(Historial, "INSERT");

                //ACTUALIZAR EL MONTO EN LACAJA
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ECaja Caja = new Logica.Entidades.EntidadesCaja.ECaja();

                Caja.IdCaja = 1;
                Caja.MontoActual = Total;

                var mam = ObjDataCaja.Value.MantenimientoCaja(Caja, "ADD");
            
        }
        #endregion

        private void Historial_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarHistorial();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            SacarNombreEmpresa(1);
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            groupBox4.ForeColor = Color.Black;
            groupBox5.ForeColor = Color.Black;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Historial de Facturación";
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbPaciente.Checked)
            {
                DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloLetras(e);
            }
            else
            {
                DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
            }
        }

        private void txtNumeroPagina_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroPagina.Value < 1)
            {
                MessageBox.Show("El numero de paginas no puede ser menor a 1", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroPagina.Value = 1;
                MostrarHistorial();
            }
            else
            {
                MostrarHistorial();
            }
        }

        private void txtNumeroRegistros_ValueChanged(object sender, EventArgs e)
        {
            if (txtNumeroRegistros.Value < 1)
            {
                MessageBox.Show("El numero de registros no puede ser menor a 1", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroRegistros.Value = 1;
                MostrarHistorial();
            }
            else
            {
                MostrarHistorial();
            }
        }

        private void rbEstatus_CheckedChanged(object sender, EventArgs e)
        {
            //MOSTRAMOS EL LISTADO DE LOS ESTATUS
            try {
                txtParametro.Text = string.Empty;
                var EstatusFacturacion = ObjDataListas.Value.ListadoEstatusFActuracion();
                ddlSeleccionar.DataSource = EstatusFacturacion;
                ddlSeleccionar.DisplayMember = "Estatus";
                ddlSeleccionar.ValueMember = "IdEstatusFacturacion";

            }
            catch (Exception) { }
        }

        private void rbTipoFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            //MOSTRAMOS EL TIPO DE FACTURACION
            try {
                txtParametro.Text = string.Empty;
                var TipoFacturacion = ObjDataListas.Value.ListadoComprobantes();
                ddlSeleccionar.DataSource = TipoFacturacion;
                ddlSeleccionar.DisplayMember = "Descripcion";
                ddlSeleccionar.ValueMember = "IdComprobante";
            }
            catch (Exception ex) { }
        }

        private void rbTipoPago_CheckedChanged(object sender, EventArgs e)
        {
            try {
                txtParametro.Text = string.Empty;
                var TipoPago = ObjDataListas.Value.ListaTipoPago();
                ddlSeleccionar.DataSource = TipoPago;
                ddlSeleccionar.DisplayMember = "Descripcion";
                ddlSeleccionar.ValueMember = "IdTipoPago";
            }
            catch (Exception) { }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (rbGenerar.Checked)
            {
                if (cbNoagregarRangofecha.Checked)
                {
                    //VERIFICAMOS QUE EL CAMPO NO BUSCAR POR RANGO DE FECHA ESTE CHEQUEADO
                    //ELIMINAMOS TODOS LOS REGISTROS MEDIANTE EL USUARIO LOGEADO
                    MANHistorialFacturacionCotizacion("DELETE");

                    var BuscarRegistros = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                        new Nullable<decimal>(),
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
                        1, 8000);
                    foreach (var n in BuscarRegistros)
                    {
                        Variables.NumeroFacturaHis = Convert.ToDecimal(n.NumeroFactura);
                        Variables.NombrePacienteHis = n.NombrePaciente;
                        Variables.IdTipoIdentificacionHis = Convert.ToDecimal(n.IdTipoIdentificacion);
                        Variables.TipoIdentificacionHis = n.TipoIdentificacion;
                        Variables.NumeroIdentificacionHis = n.NumeroIdentificacion;
                        Variables.IdEstatusFacturacionHis = Convert.ToDecimal(n.IdEstatusFacturacion);
                        Variables.EstatusHis = n.Estatus;
                        Variables.CodigoFacturacionHis = n.CodigoFacturacion;
                        Variables.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                        Variables.IdTipoFacturacionHis = Convert.ToDecimal(n.IdTipoFacturacion);
                        Variables.TipoComprobanteHis = n.TipoComprobante;
                        Variables.ValidoHastaHis = n.ValidoHasta;
                        Variables.ComprobanteHis = n.Comprobante;
                        Variables.TelefonoHis = n.Telefono;
                        Variables.IdCentroSaludHis = Convert.ToDecimal(n.IdCentroSalud);
                        Variables.CentroSaludHis = n.CentroSalud;
                        Variables.SalaHis = n.Sala;
                        Variables.IdMedicoHis = Convert.ToInt32(n.IdMedico);
                        Variables.MedicoHis = n.Medico;
                        Variables.DireccionHis = n.Direccion;
                        Variables.IdSexoHis = Convert.ToDecimal(n.IdSexo);
                        Variables.SexoHis = n.Sexo;
                        Variables.EmailHis = n.Email;
                        Variables.ComentarioPacienteHis = n.ComentarioPaciente;
                        Variables.FechaFacturacion0His = Convert.ToDateTime(n.FechaFacturacion0);
                        Variables.FechaFacturacionHis = n.FechaFacturacion;
                        Variables.IdUsuarioCreaHis = Convert.ToDecimal(n.IdUsuario);
                        Variables.CreadoporHis = n.Creadopor;
                        Variables.IdProductoHis = Convert.ToDecimal(n.IdProducto);
                        Variables.TipoProductoHis = n.TipoProducto;
                        Variables.ProDuctoHis = n.ProDucto;
                        Variables.CantidadHis = Convert.ToDecimal(n.Cantidad);
                        Variables.PrecioHis = Convert.ToDecimal(n.Precio);
                        Variables.DescuentoAplicadoHis = Convert.ToDecimal(n.DescuentoAplicado);
                        Variables.TotalHis = Convert.ToDecimal(n.Total);
                        Variables.CantidadArticulosHis = Convert.ToDecimal(n.CantidadArticulos);
                        Variables.TotalDescuentoHis = Convert.ToDecimal(n.TotalDescuento);
                        Variables.SubtotalHis = Convert.ToDecimal(n.Subtotal);
                        Variables.ImpuestoHis = Convert.ToDecimal(n.Impuesto);
                        Variables.TotalGeneralHis = Convert.ToDecimal(n.TotalGeneral);
                        Variables.IdTipoPagoHis = Convert.ToDecimal(n.IdTipoPago);
                        Variables.TipoPagoHis = n.TipoPago;
                        Variables.MontoPagadoHis = Convert.ToDecimal(n.MontoPagado);

                        //GUARDAMOS LOS DATOS

                        MANHistorialFacturacionCotizacion("INSERT");
                    }
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    //VERIFICAMOS QUE EL CAMPO NO BUSCAR POR RANGO DE FECHA ESTE CHEQUEADO
                    //ELIMINAMOS TODOS LOS REGISTROS MEDIANTE EL USUARIO LOGEADO
                    MANHistorialFacturacionCotizacion("DELETE");

                    var BuscarRegistros = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                        new Nullable<decimal>(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        Convert.ToDateTime(txtFechaDesde.Text),
                        Convert.ToDateTime(txtFechaHasta.Text),
                        1, 8000);
                    foreach (var n in BuscarRegistros)
                    {
                        Variables.NumeroFacturaHis = Convert.ToDecimal(n.NumeroFactura);
                        Variables.NombrePacienteHis = n.NombrePaciente;
                        Variables.IdTipoIdentificacionHis = Convert.ToDecimal(n.IdTipoIdentificacion);
                        Variables.TipoIdentificacionHis = n.TipoIdentificacion;
                        Variables.NumeroIdentificacionHis = n.NumeroIdentificacion;
                        Variables.IdEstatusFacturacionHis = Convert.ToDecimal(n.IdEstatusFacturacion);
                        Variables.EstatusHis = n.Estatus;
                        Variables.CodigoFacturacionHis = n.CodigoFacturacion;
                        Variables.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                        Variables.IdTipoFacturacionHis = Convert.ToDecimal(n.IdTipoFacturacion);
                        Variables.TipoComprobanteHis = n.TipoComprobante;
                        Variables.ValidoHastaHis = n.ValidoHasta;
                        Variables.ComprobanteHis = n.Comprobante;
                        Variables.TelefonoHis = n.Telefono;
                        Variables.IdCentroSaludHis = Convert.ToDecimal(n.IdCentroSalud);
                        Variables.CentroSaludHis = n.CentroSalud;
                        Variables.SalaHis = n.Sala;
                        Variables.IdMedicoHis = Convert.ToInt32(n.IdMedico);
                        Variables.MedicoHis = n.Medico;
                        Variables.DireccionHis = n.Direccion;
                        Variables.IdSexoHis = Convert.ToDecimal(n.IdSexo);
                        Variables.SexoHis = n.Sexo;
                        Variables.EmailHis = n.Email;
                        Variables.ComentarioPacienteHis = n.ComentarioPaciente;
                        Variables.FechaFacturacion0His = Convert.ToDateTime(n.FechaFacturacion0);
                        Variables.FechaFacturacionHis = n.FechaFacturacion;
                        Variables.IdUsuarioCreaHis = Convert.ToDecimal(n.IdUsuario);
                        Variables.CreadoporHis = n.Creadopor;
                        Variables.IdProductoHis = Convert.ToDecimal(n.IdProducto);
                        Variables.TipoProductoHis = n.TipoProducto;
                        Variables.ProDuctoHis = n.ProDucto;
                        Variables.CantidadHis = Convert.ToDecimal(n.Cantidad);
                        Variables.PrecioHis = Convert.ToDecimal(n.Precio);
                        Variables.DescuentoAplicadoHis = Convert.ToDecimal(n.DescuentoAplicado);
                        Variables.TotalHis = Convert.ToDecimal(n.Total);
                        Variables.CantidadArticulosHis = Convert.ToDecimal(n.CantidadArticulos);
                        Variables.TotalDescuentoHis = Convert.ToDecimal(n.TotalDescuento);
                        Variables.SubtotalHis = Convert.ToDecimal(n.Subtotal);
                        Variables.ImpuestoHis = Convert.ToDecimal(n.Impuesto);
                        Variables.TotalGeneralHis = Convert.ToDecimal(n.TotalGeneral);
                        Variables.IdTipoPagoHis = Convert.ToDecimal(n.IdTipoPago);
                        Variables.TipoPagoHis = n.TipoPago;
                        Variables.MontoPagadoHis = Convert.ToDecimal(n.MontoPagado);

                        //GUARDAMOS LOS DATOS

                        MANHistorialFacturacionCotizacion("INSERT");
                    }
                    MessageBox.Show("Registro Guardado");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbGenerar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenerar.Checked)
            {
                txtParametro.Text = string.Empty;
            }
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFactura.Checked)
            {
                txtParametro.Text = string.Empty;
            }
        }

        private void rbNumeroFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNumeroFactura.Checked)
            {
                txtParametro.Text = string.Empty;
            }
        }

        private void rbPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPaciente.Checked)
            {
                txtParametro.Text = string.Empty;
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (MessageBox.Show("¿Quieres selecionar este registro?", Variables.NombrePacienteHis, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Variables.NumeroConector = Convert.ToDecimal(this.dtListado.CurrentRow.Cells["NumeroConector"].Value.ToString());

                    //BUSCAMOS EL REGISTRO MEDIANTE EL NUMERO DE CONECTOR
                    var BuscarProductoSeleccionado = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                        new Nullable<decimal>(),
                        Variables.NumeroConector,
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
                        1, 8000);
                    dtListado.DataSource = BuscarProductoSeleccionado;
                    OcultarColumnas();
                    btnImprimir.Enabled = true;
                    int IdEstatus = 0;
                    foreach (var n in BuscarProductoSeleccionado)
                    {
                        IdEstatus = Convert.ToInt32(n.IdEstatusFacturacion);
                    }
                    if (IdEstatus == 2)
                    {
                        btnFacturar.Enabled = true;
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarFacturaVentas(Variables.NumeroConector);
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Quieres facturar esta cotización?", Variables.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal IdTipoComprobante = 0;
                decimal Total = 0;
                decimal IdTpoPago = 0;
                //SACAMOS EL TIPO DE COMPROBANTE PARA PODER AFECTARLO MEDIANTE EL NUMERO DE FACTURACION
                var SacarTipoFacturacion = ObjdataHistorial.Value.HistorialFacturacionCotizacion(
                    new Nullable<decimal>(),
                    Variables.NumeroConector,
                    null, null, null, null, null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarTipoFacturacion)
                {
                    IdTipoComprobante = Convert.ToDecimal(n.IdTipoFacturacion);
                    Total = Convert.ToDecimal(n.Total);
                    IdTpoPago = Convert.ToDecimal(n.IdTipoPago);
                }
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes Facturar = new Logica.Entidades.EntidadFacturacion.EFacturacionClientes();

                Facturar.NumeroConector = Variables.NumeroConector;

                var MANFacturar = ObjDataFacturacion.Value.GuararFacturacionCliete(Facturar, "CHANGESTATUS");
                AfectarComprobante(IdTipoComprobante);
                
                AfectarCaja(Total, IdTpoPago);
                MessageBox.Show("Registro Facturado exitosamente", Variables.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("¿Quieres generar la factura de este registro?", Variables.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //IMPRIMIMOS LA FACTURA
                    GenerarFacturaVentas(Variables.NumeroConector);
                    RestablecerPantalla();
                }
                RestablecerPantalla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestablecerPantalla();
        }
    }
}
