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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaInventario> ObjDataInventario = new Lazy<Logica.Logica.LogicaInventario>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjdataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaContabilidad> ObjdataContabilidad = new Lazy<Logica.Logica.LogicaContabilidad>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(decimal IdInformacionEMpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEMpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion
        #region CARGAR LOS COMPROBANTES FISCALES
        private void CargarComprobantes()
        {
            var Comprobantes = ObjdataListas.Value.ListadoComprobantes();
            ddlTipoFacturacion.DataSource = Comprobantes;
            ddlTipoFacturacion.DisplayMember = "Descripcion";
            ddlTipoFacturacion.ValueMember = "IdComprobante";
        }
        #endregion
        #region CARAGAR LOS TIPOS DE IDENTIFICACION
        private void CargarTipoIdentificacion()
        {
            var Cargar = ObjdataListas.Value.ListaTipoIdentificacion();
            ddlTipoIdentificacion.DataSource = Cargar;
            ddlTipoIdentificacion.DisplayMember = "Descripcion";
            ddlTipoIdentificacion.ValueMember = "IdTipoIdentificacion";
        }
        #endregion
        #region CARGAR LOS SEXOS
        private void CargarSexos()
        {
            var Cargar = ObjdataListas.Value.ListaSexos();
            ddlSexo.DataSource = Cargar;
            ddlSexo.DisplayMember = "Descripcion";
            ddlSexo.ValueMember = "IdSexo";
        }
        #endregion
        #region CARGAR LOS CENTROS DE SALUD
        private void CargarCentrosSalud()
        {
            var Cargar = ObjdataListas.Value.ListaCentrosalud();
            ddlCentroSalud.DataSource = Cargar;
            ddlCentroSalud.DisplayMember = "Nombre";
            ddlCentroSalud.ValueMember = "IdCentroSalud";
        }
        #endregion
        #region CARGAR LOS MEDICOS
        private void CargarMedicos()
        {
            try
            {
                var Cargar = ObjdataListas.Value.ListaMedicos(
                 Convert.ToDecimal(ddlCentroSalud.SelectedValue));
                ddlMedico.DataSource = Cargar;
                ddlMedico.DisplayMember = "NombreMedico";
                ddlMedico.ValueMember = "IdMedico";
            }
            catch (Exception)
            {
              
            }
        }
        #endregion
        #region CARGAR LOS TIPOS DE PAGO
        private void CargarTipoPago()
        {
            var Cargar = ObjdataListas.Value.ListaTipoPago();
            ddltIPago.DataSource = Cargar;
            ddltIPago.DisplayMember = "Descripcion";
            ddltIPago.ValueMember = "IdTipoPago";
            VerificarBloqueo();
        }
        #endregion
        #region GENERAR CONECTOR
        private void GenerarConector()
        {
            Random Generar1 = new Random();
            string Valor1 = Generar1.Next(0, 9999).ToString();
            string Valor2 = Generar1.Next(0, 9999).ToString();
            string Valor3 = Generar1.Next(0, 9999).ToString();

            string Valor4 = Valor1 + Valor2 + Valor3 + VariablesGlobales.IdUsuario.ToString();
            lbConector.Text = Valor4;
            VariablesGlobales.NumeroConector = Convert.ToDecimal(Valor4);
            VariablesGlobales.GenerarConector = false;
        }
        #endregion
        #region GUARDAR LOS DATOS DE LA FACTURACION
        //GUARDAR LOS DATOS DEL CLIENTE
        private void GuardarFacturacionCliente()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionClientes Guardar = new Logica.Entidades.EntidadFacturacion.EFacturacionClientes();

            Guardar.NumeroFactura = VariablesGlobales.NumeroFacturacion;
            Guardar.IdEstatusFacturacion = VariablesGlobales.IdEstatusFacturacion;
            Guardar.CodigoFacturacion = VariablesGlobales.CodigoMantenimiento;
            Guardar.NumeroConector = VariablesGlobales.NumeroConector;
            Guardar.IdTipoFacturacion = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            Guardar.NombrePaciente = txtNombrePaciente.Text;
            Guardar.Telefono = txtTelefono.Text;
            Guardar.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
            Guardar.Sala = txtSala.Text;
            Guardar.IdMedico = Convert.ToDecimal(ddlMedico.SelectedValue);
            Guardar.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            Guardar.NumeroIdentificacion = txtIdentificacion.Text;
            Guardar.Direccion = txtDireccion.Text;
            Guardar.IdSexo = Convert.ToDecimal(ddlSexo.SelectedValue);
            Guardar.Email = txtEmail.Text;
            Guardar.ComentarioPaciente = txtComentario.Text;
            Guardar.FechaFacturacion = DateTime.Now;
            Guardar.IdUsuario = VariablesGlobales.IdUsuario;

            var MAN = ObjDataFacturacion.Value.GuararFacturacionCliete(Guardar,VariablesGlobales.AccionTomar);
        }
        #endregion
        #region MOSTRAR EL LISTADO DE LOS PRODUCTOS AGREGADOS3
        public void MostrarListadoProductosAgregados(decimal NumeroConector)
        {
            var Mostrar = ObjDataFacturacion.Value.BuscarProductosAgregados(NumeroConector);
            dataGridView1.DataSource = Mostrar;
            this.dataGridView1.Columns["NumeroConector"].Visible = false;
            this.dataGridView1.Columns["IdProducto"].Visible = false;
            this.dataGridView1.Columns["CodigoProducto"].Visible = false;
            this.dataGridView1.Columns["PrecioCompra"].Visible = false;
        }
        #endregion
        #region GUARDAR LOS DATOS DE LA FACTURACION ESPEJO
        private void GuardarDatosFActuracionEspejo(string Accion)
        {
        

            if (rbFacturar.Checked == true)
            {
                VariablesGlobales.TipoProceso = true;
            }
            else if (rbCotizar.Checked == true)
            {
                VariablesGlobales.TipoProceso = false;
            }
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EDatosFacturacionEspejo FacturacionEspejo = new Logica.Entidades.EntidadFacturacion.EDatosFacturacionEspejo();

            FacturacionEspejo.NumeroConector = VariablesGlobales.NumeroConector;
            FacturacionEspejo.IdUsuario = VariablesGlobales.IdUsuario;
            FacturacionEspejo.IdTipoFacturacion = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            FacturacionEspejo.NombrePaciente = txtNombrePaciente.Text;
            FacturacionEspejo.Telefono = txtTelefono.Text;
            FacturacionEspejo.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
            FacturacionEspejo.Sala = txtSala.Text;
            FacturacionEspejo.IdMedico = Convert.ToDecimal(ddlMedico.SelectedValue);
            FacturacionEspejo.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            FacturacionEspejo.NumeroIdentificacion = txtIdentificacion.Text;
            FacturacionEspejo.Direccion = txtDireccion.Text;
            FacturacionEspejo.IdSexo = Convert.ToDecimal(ddlSexo.SelectedValue);
            FacturacionEspejo.Email = txtEmail.Text;
            FacturacionEspejo.Comentario = txtComentario.Text;
            FacturacionEspejo.GuardarCliente = false;
            FacturacionEspejo.TipoProceso = VariablesGlobales.TipoProceso;
            FacturacionEspejo.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
            FacturacionEspejo.IdEstatusirugia = Convert.ToDecimal(ddlEstatusCirugia.SelectedValue);

            var MAn = ObjDataFacturacion.Value.MantenimientoDatosFacturacionEspejo(FacturacionEspejo, Accion);
        }
        #endregion
        #region SACAR LOS DATOS DE LOS CALCULOS
        private void SacarDatosCalculos(decimal NumeroConector)
        {
            var SacarCalculos = ObjDataFacturacion.Value.SacarCalculosFacturacion(NumeroConector);
            foreach (var n in SacarCalculos)
            {
                txtCantidadArtiuclos.Text = n.CantidadArticulos.ToString();
                txtTotalDescuento.Text = n.ToTalDescuento.ToString();
                txtSubtotal.Text = n.SubTotal.ToString();
                txtImpuesto.Text = n.Impuesto.ToString();
                txtPorcientoImpuesto.Text = n.PorcientoAplicado.ToString();
                txtTotal.Text = n.Total.ToString();

            }
        }
        #endregion
        #region BUSCAR CLIENTES
        private void BuscarClientes()
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()))
            {
                MessageBox.Show("El campo codigo de cliente no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _CodigoCliente = string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) ? null : txtCodigoCliente.Text.Trim();

                var Validar = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    _CodigoCliente,
                    null, null, null, null, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("El codigo de cliente ingresado no es valido favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (var n in Validar)
                    {
                        ddlTipoFacturacion.Text = n.Comprobante;
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        ddlCentroSalud.Text = n.CentroSalud;
                        txtSala.Text = n.Sala;
                        ddlMedico.Text = n.Medico;
                        ddlTipoIdentificacion.Text = n.TipoIdentificaion;
                        txtIdentificacion.Text = n.NumeroIdentificacion;
                        txtDireccion.Text = n.Direccion;
                        ddlSexo.Text = n.Sexo;
                        txtEmail.Text = n.Email;
                        txtComentario.Text = n.Comentario;
                    }
                }
            }
        }
        #endregion
        #region GUARDAR LOS DATOS DE LA FACTURACION CALCULOS
        private void GuardarDatosFacturaconCalculos()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionCalculos Guardar = new Logica.Entidades.EntidadFacturacion.EFacturacionCalculos();

            Guardar.NumeroConector = VariablesGlobales.NumeroConector;
            Guardar.CantidadArticulos = Convert.ToDecimal(txtCantidadArtiuclos.Text);
            Guardar.TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
            Guardar.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            Guardar.Impuesto = Convert.ToDecimal(txtImpuesto.Text);
            Guardar.Total = Convert.ToDecimal(txtTotal.Text);
            Guardar.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);
            Guardar.MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);
            Guardar.IdEstatusCirugia = Convert.ToDecimal(ddlEstatusCirugia.SelectedValue);

            var MAN = ObjDataFacturacion.Value.GuardarFacturacionCalculos(Guardar, "INSERT");
        }
        #endregion
        #region GUARDAR LOS DATOS DEL CLIENTE
        private void GuardarDatosCliente()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadEmpresa.EPacientes Guardar = new Logica.Entidades.EntidadEmpresa.EPacientes();

            Guardar.IdPaciente = 0;
            Guardar.CodigoPaciente = "";
            Guardar.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            Guardar.Nombre = txtNombrePaciente.Text;
            Guardar.Telefono = txtTelefono.Text;
            Guardar.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
            Guardar.Sala = txtSala.Text;
            Guardar.IdMedico = Convert.ToDecimal(ddlMedico.SelectedValue);
            Guardar.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            Guardar.TipoIdentificaion = txtIdentificacion.Text;
            Guardar.Direccion = txtDireccion.Text;
            Guardar.IdSexo = Convert.ToDecimal(ddlSexo.SelectedValue);
            Guardar.Email = txtEmail.Text;
            Guardar.Comentario = txtComentario.Text;
            Guardar.Estatus0 = true;
            Guardar.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Guardar.FechaAdiciona0 = DateTime.Now;
            Guardar.UsuarioModifica = VariablesGlobales.IdUsuario;
            Guardar.FechaModifica0 = DateTime.Now;

            var MAN = ObjDataEmpresa.Value.MantenimientoPacientes(Guardar, "INSERT");
        }
        #endregion
        #region VERIFICAR BLOQUEO
        private void VerificarBloqueo()
        {
            try
            {
                bool Bloqueo = false;
                var VerificarBloqueo = ObjDataFacturacion.Value.ListadoTipoPago(Convert.ToDecimal(ddltIPago.SelectedValue), null, null, 1, 1);
                foreach (var n in VerificarBloqueo)
                {
                    Bloqueo = Convert.ToBoolean(n.BloqueaMontoPagar0);
                    if (Bloqueo == true)
                    {
                        txtMontoPagar.Enabled = false;
                        txtMontoPagar.Text = "0";
                        txtCambio.Visible = false;
                        txtCambio.Text = string.Empty;
                    }
                    else
                    {
                        txtMontoPagar.Enabled = true;
                        txtMontoPagar.Text = string.Empty;
                        txtCambio.Visible = true;
                        txtCambio.Text = string.Empty;
                        txtMontoPagar.Text = "0";
                    }
                }
            }
            catch (Exception) { }
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
            Guardar.NumeroConector = VariablesGlobales.NumeroConector;
            Guardar.TipoComprobante = TipoComprobante;
            Guardar.Comprobante = Comprobante;

            var MAN = ObjDataFacturacion.Value.GuardarFacturacionComprobante(Guardar, "INSERT");
        }

        #endregion
        #region PASAR A LA PANTALLA DE AGREGAR PRODUCTOS
        private void PasarPantallaAgregarProductos()
        {
            GuardarDatosFActuracionEspejo("INSERT");
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.AgregarProductos Agregar = new AgregarProductos();
            Agregar.VariablesGlobales.NumeroConector = VariablesGlobales.NumeroConector;
            Agregar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Agregar.ShowDialog();
        }
        #endregion
        #region CARGAR LOS ESTATUS DE CIRUGIAS
        private void CargarEstatusCirugia()
        {
            var Estatus = ObjdataListas.Value.BuscaEstatusCirugia();
            ddlEstatusCirugia.DataSource = Estatus;
            ddlEstatusCirugia.DisplayMember = "Descripcion";
            ddlEstatusCirugia.ValueMember = "IdEstatusCirugia";
        }
#endregion
        #region IMPRIMIR FACTURA
        private void ImprimirFactura(decimal NumeroConector)
        {
            //SACAMOS EL USUARIO Y LA CLAVE DE LA BASE DE DATOS
            var SacarUsuarioBD = ObjDataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarUsuarioBD)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }

            //SACAMOS LA RUTA DEL REPORTE
            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(1);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //INVOCAMOS EL LA FACTURA
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Factura = new Reporte.Reportes();
            Factura.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            Factura.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            Factura.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            Factura.CargarReporteExternoPantalla(NumeroConector);
            Factura.ShowDialog();

        }
        #endregion
        #region AFECTAR LA CAJA
        private void AfectarCaja()
        {
            //INSERTAMOS LOS DATOS PARA HACER EL REGISTRO DENTRO DEL HISTORIAL DE LA CAJA
            if (rbFacturar.Checked)
            {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.EHistorialCaja Historial = new Logica.Entidades.EntidadesCaja.EHistorialCaja();

                Historial.IdistorialCaja = 0;
                Historial.IdCaja = 1;
                Historial.Monto = Convert.ToDecimal(txtTotal.Text);
                Historial.Concepto = "FACTURACION";
                Historial.Fecha0 = DateTime.Now;
                Historial.IdUsuario = VariablesGlobales.IdUsuario;
                Historial.NumeroReferencia = VariablesGlobales.NumeroConector;
                Historial.IdTipoPago = Convert.ToDecimal(ddltIPago.SelectedValue);

                var MAN = ObjDataCaja.Value.MantenimientoHistorialCaja(Historial, "INSERT");

                //ACTUALIZAR EL MONTO EN LACAJA
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesCaja.ECaja Caja = new Logica.Entidades.EntidadesCaja.ECaja();

                Caja.IdCaja = 1;
                Caja.MontoActual = Convert.ToDecimal(txtTotal.Text);

                var mam = ObjDataCaja.Value.MantenimientoCaja(Caja, "ADD");
            }
        }
#endregion
        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarEstatusCirugia();
            VariablesGlobales.ModoCotizacion = false;
            // VariablesGlobales.GenerarConector = true;
            groupBox2.ForeColor = Color.White;
            groupBox3.ForeColor = Color.White;
            groupBox4.ForeColor = Color.White;
            rbCotizar.ForeColor = Color.Red;
            rbFacturar.ForeColor = Color.Red;
            gbGeneral.ForeColor = Color.White;
            
            ddlCentroSalud.ForeColor = Color.Black;
            ddlMedico.ForeColor = Color.Black;
            ddlSexo.ForeColor = Color.Black;
            ddlTipoFacturacion.ForeColor = Color.Black;
            ddlTipoIdentificacion.ForeColor = Color.Black;
            txtCodigoCliente.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            dataGridView1.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtNoCotizacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtSala.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            rbFacturar.Checked = true;
            button1.ForeColor = Color.White;
            SacarInformacionEmpresa(1);
            CargarComprobantes();
            CargarTipoIdentificacion();
            CargarSexos();
            CargarCentrosSalud();
            CargarMedicos();
            CargarTipoPago();
            if (VariablesGlobales.GenerarConector == true)
            {
                GenerarConector();
            }
            if (VariablesGlobales.SacarDatosEspejo == true)
            {
                //bool GuardarCliente = false;
                bool Procesar = false;
                var sacarDatosEspejo = ObjDataFacturacion.Value.BuscaDatosFacturacionEspejo(
                    VariablesGlobales.NumeroConector,
                    VariablesGlobales.IdUsuario);
                foreach (var n in sacarDatosEspejo)
                {
                    ddlTipoFacturacion.Text = n.TipoFacturacion;
                    txtNombrePaciente.Text = n.NombrePaciente;
                    txtTelefono.Text = n.Telefono;
                    ddlCentroSalud.Text = n.CentroSalud;
                    txtSala.Text = n.Sala;
                    ddlMedico.Text = n.Medico;
                    ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                    txtIdentificacion.Text = n.NumeroIdentificacion;
                    txtDireccion.Text = n.Direccion;
                    ddlSexo.Text = n.Sexo;
                    txtEmail.Text = n.Email;
                    txtComentario.Text = n.Comentario;
                    VariablesGlobales.GuardarCliente = Convert.ToBoolean(n.GuardarCliente);
                    Procesar = Convert.ToBoolean(n.TipoProceso);
                    ddltIPago.Text = n.TipoPago;
                    ddlEstatusCirugia.Text = n.EstatusCirugia;

                    if (Procesar == true)
                    {
                        rbFacturar.Checked = true;
                    }
                    else
                    {
                        rbCotizar.Checked = true;
                    }
                    
                }
                GuardarDatosFActuracionEspejo("DELETE");
                // GenerarConector();
                MostrarListadoProductosAgregados(VariablesGlobales.NumeroConector);
                SacarDatosCalculos(VariablesGlobales.NumeroConector);
                

            }
            rbQuitarDescuento.Checked = true;
            lbConector.Text = VariablesGlobales.NumeroConector.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbGuardaCliente_CheckedChanged(object sender, EventArgs e)
        {
       
        }

        private void rbNoGuardarCliente_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbFacturar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFacturar.Checked)
            {
                rbFacturar.ForeColor = Color.White;
                VariablesGlobales.IdEstatusFacturacion = 1;
            }
            else
            {
                rbFacturar.ForeColor = Color.Red;
                VariablesGlobales.IdEstatusFacturacion = 0;
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCotizar.Checked)
            {
                rbCotizar.ForeColor = Color.White;
                VariablesGlobales.IdEstatusFacturacion = 2;
            }
            else
            {
                rbCotizar.ForeColor = Color.Red;
                VariablesGlobales.IdEstatusFacturacion = 0;
            }
        }

        private void ddlTipoIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoIdentificacion.Text == "Cedula")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "000-0000000-0";
            }
            else if (ddlTipoIdentificacion.Text == "Pasaporte")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "";
            }
            else if (ddlTipoIdentificacion.Text == "RNC")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "";
            }
            else if (ddlTipoIdentificacion.Text == "Otro")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "";
            }
            else
            {
                txtIdentificacion.Visible = false;
            }
        }

        private void Facturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void gbGeneral_Enter(object sender, EventArgs e)
        {

        }

        private void ddlCentroSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void btnAgregarAlmacen_Click(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.ModoCotizacion == true)
            {
                bool Bloqueo = false;
                var VerificarBloqueo = ObjDataFacturacion.Value.ListadoTipoPago(
                    Convert.ToDecimal(ddltIPago.SelectedValue), null, null, 1, 1);
                foreach (var n in VerificarBloqueo)
                {
                    Bloqueo = Convert.ToBoolean(n.BloqueaMontoPagar0);
                }
                if (Bloqueo == true)
                {
                    VariablesGlobales.AccionTomar = "CHANGESTATUS";
                    GuardarFacturacionCliente();
                    AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                    AfectarCaja();
                    MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImprimirFactura(VariablesGlobales.NumeroConector);
                    this.Dispose();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                    {
                        MessageBox.Show("El monto a pagar no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        decimal Totalagar = Convert.ToDecimal(txtTotal.Text);
                        decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                        if (Totalagar > MontoPagar)
                        {
                            MessageBox.Show("No se puede completar la operación por que el total a pagar es superior al monto a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            VariablesGlobales.AccionTomar = "CHANGESTATUS";
                            GuardarFacturacionCliente();
                            AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                            AfectarCaja();
                            MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ImprimirFactura(VariablesGlobales.NumeroConector);
                            this.Dispose();
                        }
                    }
                }
            }
            else
            {
                //VERIFICAMOS LOS CAMPOS QUE ESTEN VACIOS DEL LADO DEL CLIENTE
                if (string.IsNullOrEmpty(ddlTipoFacturacion.Text.Trim()) || string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()) || string.IsNullOrEmpty(ddlCentroSalud.Text.Trim()) || string.IsNullOrEmpty(txtSala.Text.Trim()) || string.IsNullOrEmpty(ddlMedico.Text.Trim()) || string.IsNullOrEmpty(ddlTipoIdentificacion.Text.Trim()) || string.IsNullOrEmpty(txtIdentificacion.Text.Trim()) || string.IsNullOrEmpty(ddlSexo.Text.Trim()))
                {
                    MessageBox.Show("Has dejado campos vacios del en los datos del paciente los cuales son necesarios para continuar con este proceso", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //VERIFICAMOS SI EL PACIENTE YA TIENE PRODUCTOS AGREGADOS PARA SEGUIR CON LA FACTURACION
                    var VerificarFacturacion = ObjDataFacturacion.Value.BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                    if (VerificarFacturacion.Count() < 1)
                    {
                        MessageBox.Show("No has agregado ningun producto, no es posible completar este proceso sin un producto agreado para facturar, favor proceder a agregar productos al paciente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (MessageBox.Show("¿Quieres pasar a la pantalla correspondiente para agregar productos?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PasarPantallaAgregarProductos();
                        }

                    }
                    else
                    {
                        bool Bloqueo = false;
                        //VALIDAMOS EL TIPO DE PAGO
                        var VerificarTipoPago = ObjDataFacturacion.Value.ListadoTipoPago(
                            Convert.ToDecimal(ddltIPago.SelectedValue),
                            null, null, 1, 1);
                        foreach (var n in VerificarTipoPago)
                        {
                            Bloqueo = Convert.ToBoolean(n.BloqueaMontoPagar0);
                        }
                        if (Bloqueo == true)
                        {
                            //GUARDAMOS LOS DATOS
                            VariablesGlobales.AccionTomar = "INSERT";
                            GuardarFacturacionCliente();
                            GuardarDatosFacturaconCalculos();
                            if (rbFacturar.Checked)
                            {
                                AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                            }
                            MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (MessageBox.Show("¿Quieres guardar los datos del cliente?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                GuardarDatosCliente();
                            }
                            if (rbCotizar.Checked)
                            {
                                MessageBox.Show("Numero de cotizacion --> " + lbConector.Text);
                            }
                            ImprimirFactura(VariablesGlobales.NumeroConector);
                            this.Dispose();
                        }
                        else
                        {
                            //VERIFICAMOS SI EL CAMPO MONTO ESTA VACIO
                            if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                            {
                                MessageBox.Show("El campo monto no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                //VERIFICAMOS SI EL MONTO PAGADO NO SEA MENOR AL TOTAL A PAGAR
                                decimal TotalPagar = Convert.ToDecimal(txtTotal.Text);
                                decimal MontoPagar = Convert.ToDecimal(txtMontoPagar.Text);
                                if (TotalPagar > MontoPagar)
                                {
                                    MessageBox.Show("No se puede continuar con el proceso por que el total a pagar es mayor al monto ingresado", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    VariablesGlobales.AccionTomar = "INSERT";
                                    GuardarFacturacionCliente();
                                    GuardarDatosFacturaconCalculos();
                                    if (rbFacturar.Checked)
                                    {
                                        AfectarCaja();
                                        AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                                    }
                                    MessageBox.Show("Proceso completado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (MessageBox.Show("¿Quieres guardar los datos del cliente?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        GuardarDatosCliente();
                                    }
                                    if (rbCotizar.Checked)
                                    {
                                        MessageBox.Show("Numero de cotizacion --> " + lbConector.Text);
                                    }
                                    ImprimirFactura(VariablesGlobales.NumeroConector);
                                    this.Dispose();
                                }
                            }
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PasarPantallaAgregarProductos();
        }

        private void txtCodigoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarClientes();
            }
        }

        private void txtTotalDescuento_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //APLICAMOS EL DESCUENTO MANUALMENTE
            if (rbAgregarDescuento.Checked)
            {

                //DECLARAMOS LAS VARIABLES
                decimal Total, TotalDescuento, Operacion;
                TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
                Total = Convert.ToDecimal(txtTotal.Text);
                Operacion = Total + TotalDescuento;
                txtTotal.Text = string.Empty;
                txtTotal.Text = Operacion.ToString();

                //SACAMOS EL IMPUESTO
                decimal PorcientoImpuesto = Convert.ToDecimal(txtPorcientoImpuesto.Text);
                decimal Operacion2 = Operacion / PorcientoImpuesto;
                decimal Operacion3 = Operacion - Operacion2;
                txtSubtotal.Text = string.Empty;
                txtImpuesto.Text = string.Empty;
                txtSubtotal.Text = Math.Round(Operacion2, 2).ToString();
                txtImpuesto.Text = Math.Round(Operacion3, 2).ToString();

                txtImpuesto.Enabled = false;
                rbAgregarDescuento.Enabled = false;
                rbQuitarDescuento.Checked = true;


            }
            else if (rbQuitarDescuento.Checked)
            {
                if (string.IsNullOrEmpty(txtTotalDescuento.Text.Trim()))
                {
                    MessageBox.Show("Ingrese la cantidad que quieres descontar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    decimal TotalDescontar, TotalPagar;
                    TotalDescontar = Convert.ToDecimal(txtTotalDescuento.Text);
                    TotalPagar = Convert.ToDecimal(txtTotal.Text);
                    if (TotalDescontar > TotalPagar)
                    {
                        MessageBox.Show("El monto a descontar no puede ser mayor al total a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //DECLARAMOS LAS VARIABLES
                        decimal Total, TotalDescuento, Operacion;
                        TotalDescuento = Convert.ToDecimal(txtTotalDescuento.Text);
                        Total = Convert.ToDecimal(txtTotal.Text);
                        Operacion = Total - TotalDescuento;
                        txtTotal.Text = string.Empty;
                        txtTotal.Text = Operacion.ToString();

                        //SACAMOS EL IMPUESTO
                        decimal PorcientoImpuesto = Convert.ToDecimal(txtPorcientoImpuesto.Text);
                        decimal Operacion2 = Operacion / PorcientoImpuesto;
                        decimal Operacion3 = Operacion - Operacion2;
                        txtSubtotal.Text = string.Empty;
                        txtImpuesto.Text = string.Empty;
                        txtSubtotal.Text = Math.Round(Operacion2, 2).ToString();
                        txtImpuesto.Text = Math.Round(Operacion3, 2).ToString();

                        txtImpuesto.Enabled = true;
                        rbAgregarDescuento.Enabled = true;
                        rbAgregarDescuento.Checked = true;
                     
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ddltIPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarBloqueo();
        }

        private void txtMontoPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumerosDecimales(e);
        }

        private void txtMontoPagar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool Bloqueo = false;
                var SacarBloqueo = ObjDataFacturacion.Value.ListadoTipoPago(Convert.ToDecimal(ddltIPago.SelectedValue), null, null, 1, 1);
                foreach (var n in SacarBloqueo)
                {
                    if (Bloqueo == true)
                    {

                    }
                    else
                    {
                        decimal Total, MontoPagado, Cambio;
                        Total = Convert.ToDecimal(txtTotal.Text);
                        MontoPagado = Convert.ToDecimal(txtMontoPagar.Text);
                        Cambio = MontoPagado - Total;
                        txtCambio.Text = Cambio.ToString();
                    }
                }
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //VERIFICAMOS SI EL CAMPO COTIZACION ESTA VACIO
            if (string.IsNullOrEmpty(txtNoCotizacion.Text.Trim()))
            {
                MessageBox.Show("El campo cotizacion no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //VALIDAMOS LOS DATOS
                var Validar = ObjDataHistorial.Value.HistorialFacturacionCotizacion(
                    new Nullable<decimal>(),
                    Convert.ToDecimal(txtNoCotizacion.Text.Trim()),
                    null, 2, null, null, null, null, null, null, null, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("No se encontraron registros con el numero de cotizacion ingresado, favor de verificar el numero e intentarlo nuevamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                   
                    //SACAMOS LOS DATOS
                    foreach (var n in Validar)
                    {
                        ddlTipoFacturacion.Text = n.TipoComprobante;
                        txtNombrePaciente.Text = n.NombrePaciente;
                        txtTelefono.Text = n.Telefono;
                        ddlCentroSalud.Text = n.CentroSalud;
                        txtSala.Text = n.Sala;
                        ddlMedico.Text = n.Medico;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.NumeroIdentificacion;
                        txtDireccion.Text = n.Direccion;
                        ddlSexo.Text = n.Sexo;
                        txtEmail.Text = n.Email;
                        txtComentario.Text = n.ComentarioPaciente;
                        VariablesGlobales.NumeroConector = Convert.ToDecimal(n.NumeroConector);
                    }
                    VariablesGlobales.ModoCotizacion = true;
                    btnAgregarAlmacen.Visible = false;
                    groupBox3.Visible = false;
                    rbQuitarDescuento.Visible = false;
                    rbAgregarDescuento.Visible = false;
                    btnColocarDescuento.Visible = false;
                    button2.Visible = false;
                    rbFacturar.Checked = true;
                    MostrarListadoProductosAgregados(VariablesGlobales.NumeroConector);
                    SacarDatosCalculos(VariablesGlobales.NumeroConector);
                   
                }
            }
        }
    }
}
