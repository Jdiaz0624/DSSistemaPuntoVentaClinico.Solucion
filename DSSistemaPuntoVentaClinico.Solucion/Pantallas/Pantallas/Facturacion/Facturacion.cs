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

        private void OpcionTipoVenta()
        {
            try
            {
                if (Convert.ToInt32(ddlTipoVenta.SelectedValue) == 2)
                {
                    lbCantidadDias.Visible = true;
                    ddlCantidadDias.Visible = true;
                    CargarDias();
                    //SACAMOS EL TIPO DE PAGO
                    var SacarTipoPago = ObjDataFacturacion.Value.ListadoTipoPago(6, null, null, 1, 1);
                    foreach (var n in SacarTipoPago)
                    {
                        ddltIPago.Text = n.TipoPago;
                    }
                    ddltIPago.Enabled = false;
                    rbFacturar.Enabled = false;
                    rbCotizar.Enabled = false;
                    rbFacturar.Checked = true;
                    VariablesGlobales.IdTipoVentaSeleccionado = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
                }
                else
                {
                    lbCantidadDias.Visible = false;
                    ddlCantidadDias.Visible = false;
                    CargarTipoPago();
                    ddltIPago.Enabled = true;
                    rbFacturar.Enabled = true;
                    rbCotizar.Enabled = true;
                    rbFacturar.Checked = true;
                    VariablesGlobales.IdTipoVentaSeleccionado = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
                }
            }
            catch (Exception) { }
        }

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
            Guardar.Paciente = txtPacientePaciente.Text;
            Guardar.CedulaPaciente = txtCedulaCedula.Text;

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

            int TipoRNCSeleccionado = 0;
            if (rbBuscarPaciente.Checked == true)
            {
                TipoRNCSeleccionado = 1;
            }
            else if (rbBuscarCliente.Checked == true)
            {
                TipoRNCSeleccionado = 2;
            }

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
            FacturacionEspejo.IdTipoVenta = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
            FacturacionEspejo.IdCantidadDias = Convert.ToDecimal(ddlCantidadDias.SelectedValue);
            FacturacionEspejo.CodigoPaciente = VariablesGlobales.CodigoPaciente;
            FacturacionEspejo.MontoCredito = Convert.ToDecimal(txtMontoCredito.Text);
            FacturacionEspejo.Paciente = txtPacientePaciente.Text;
            FacturacionEspejo.CedulaPaciente = txtCedulaCedula.Text;
            FacturacionEspejo.TipoBusquedaRNC = TipoRNCSeleccionado;

            var MAn = ObjDataFacturacion.Value.MantenimientoDatosFacturacionEspejo(FacturacionEspejo, Accion);
        }
        #endregion
        #region SACAR LOS DATOS DE LOS CALCULOS
        private void SacarDatosCalculos(decimal NumeroConector)
        {
            var SacarCalculos = ObjDataFacturacion.Value.SacarCalculosFacturacion(NumeroConector);
            foreach (var n in SacarCalculos)
            {
                int CantidadArticulos = Convert.ToInt32(n.CantidadArticulos);
                txtCantidadArtiuclos.Text = CantidadArticulos.ToString("N2");

                decimal ToTalDescuento = Convert.ToDecimal(n.ToTalDescuento);
                txtTotalDescuento.Text = ToTalDescuento.ToString("N2");


                decimal SubTotal = Convert.ToDecimal(n.SubTotal);
                txtSubtotal.Text = SubTotal.ToString("N2");

                decimal Impuesto = Convert.ToDecimal(n.Impuesto);
                txtImpuesto.Text = Impuesto.ToString("N2");

                txtPorcientoImpuesto.Text = n.PorcientoAplicado.ToString();

                decimal TotalFinal = Convert.ToDecimal(n.Total);
                txtTotal.Text = TotalFinal.ToString("N2");

            }
        }
        #endregion
        #region BUSCAR PACIENTES
        private void BuscarClientes()
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()))
            {
                MessageBox.Show("El campo codigo de cliente no puede estar vacio", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _RNC = string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) ? null : txtCodigoCliente.Text.Trim();

                var Validar = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    _RNC,
                    1,
                    1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("El rnc de cliente ingresado no es valido favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        btnAgregarAlmacen.Enabled = false;
                        btnRegresar.Enabled = true;
                        VariablesGlobales.CodigoPaciente = Convert.ToDecimal(n.IdPaciente);
                        BloquearControles();
                        decimal Monto = Convert.ToDecimal(n.MontoCredito);
                        txtMontoCredito.Text = Monto.ToString("N2");
                    }
                }
            }
        }
        #endregion
        #region BUSCAR CLIENTES
        private void BuscarDatosClientes()
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()))
            {
                MessageBox.Show("El campo RNC no puede estar vacio favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string _RNC = string.IsNullOrEmpty(txtCodigoCliente.Text.Trim()) ? null : txtCodigoCliente.Text.Trim();
                //VALIDAMOS SI EL RNC INGRESADO ES VALIDO
                var ValidarRNC = ObjDataEmpresa.Value.BuscaClientes(
                    new Nullable<decimal>(),
                    null,
                    _RNC,
                    1, 1);
                if (ValidarRNC.Count() < 1)
                {
                    MessageBox.Show("El RNC ingresado no esta registrado en el sistema", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    foreach (var n in ValidarRNC)
                    {
                        ddlTipoFacturacion.Text = n.TipoComprobante;
                        txtNombrePaciente.Text = n.Nombre;
                        txtTelefono.Text = n.Telefono;
                        ddlTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtIdentificacion.Text = n.RNC;
                        txtDireccion.Text = n.Direccion;
                        txtEmail.Text = n.Email;
                        txtComentario.Text = n.Comentario;
                        btnAgregarAlmacen.Enabled = false;
                        btnRegresar.Enabled = true;
                        VariablesGlobales.CodigoPaciente = Convert.ToDecimal(n.IdCliente);
                        BloquearControles();
                        decimal Monto = Convert.ToDecimal(n.MontoCredito);
                        txtMontoCredito.Text = Monto.ToString("N2");
                    }
                }
            }
        }
        #endregion
        #region GUARDAR LOS DATOS DE LA FACTURACION CALCULOS
        private void GuardarDatosFacturaconCalculos()
        {
            decimal CantidadDias = 0,Balance = 0;
            if (Convert.ToDecimal(ddlTipoVenta.SelectedValue) == 1)
            {
                CantidadDias = 1;
                Balance = 0;
            }
            else
            {
                CantidadDias = Convert.ToDecimal(ddlCantidadDias.SelectedValue);
                Balance = Convert.ToDecimal(txtTotal.Text);
            }
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
            Guardar.TipoVenta = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
            Guardar.IdCantidadDias = Convert.ToInt32(CantidadDias);
            Guardar.CodigoPaciente = Convert.ToDecimal(VariablesGlobales.CodigoPaciente);
            Guardar.Balance = Balance;
            Guardar.CirugiaProgramada = false;

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
            try {

                GuardarDatosFActuracionEspejo("INSERT");
                this.Hide();
                DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.AgregarProductos Agregar = new AgregarProductos();
                Agregar.VariablesGlobales.NumeroConector = VariablesGlobales.NumeroConector;
                Agregar.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
                Agregar.VariablesGlobales.BloqueaControles = VariablesGlobales.BloqueaControles;
                Agregar.VariablesGlobales.IdTipoVentaSeleccionado = VariablesGlobales.IdTipoVentaSeleccionado;
                Agregar.VariablesGlobales.CodigoPaciente = VariablesGlobales.CodigoPaciente;
               // Agregar.VariablesGlobales.CantidadDias = Convert.ToInt32(ddlCantidadDias.Text);
                Agregar.VariablesGlobales.TipoVenta = ddlTipoVenta.Text;
                Agregar.ShowDialog();
            }
            catch (Exception) { }
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
                if (Convert.ToInt32(ddlTipoVenta.SelectedValue) == 1)
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
        }
        #endregion
        #region TERMINAR PROCESO
        private void TerminarProceso()
        {
            //GUARDAMOS LOS DATOS
            VariablesGlobales.AccionTomar = "INSERT";
            GuardarFacturacionCliente();
            GuardarDatosFacturaconCalculos();
            AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
            AfectarCaja();
            MessageBox.Show("Operación realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImprimirFactura(VariablesGlobales.NumeroConector);
            this.Dispose();
        }
        #endregion
        #region DEVOLVER PRODUCTOS
        private void DevolverProductos()
        {
            try {
                decimal IdProducto = 0;
                int Cantidad = 0;
                string Codigoproducto = "";
                var Devolver = ObjDataFacturacion.Value.BuscarProductosAgregados(
                    VariablesGlobales.NumeroConector, null);
                foreach (var n in Devolver)
                {
                    IdProducto = Convert.ToDecimal(n.IdProducto);
                    Cantidad = Convert.ToInt32(n.Cantidad);
                    Codigoproducto = n.CodigoProducto;

                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Devolverproducto = new Logica.Entidades.EntidadInventario.EPRoducto();

                    Devolverproducto.IdProducto = IdProducto;
                    Devolverproducto.CodigoProducto = Codigoproducto;
                    Devolverproducto.CantidadAlmacen = Cantidad;
                    Devolverproducto.UsuarioAdiciona = VariablesGlobales.IdUsuario;
                    Devolverproducto.FechaAdiciona0 = DateTime.Now;
                    Devolverproducto.UsuarioModifica = VariablesGlobales.IdUsuario;
                    Devolverproducto.FechaModifica0 = DateTime.Now;

                    var MAN = ObjDataInventario.Value.MantenimientoProducto(Devolverproducto, "ADD");

                }
            }
            catch (Exception) {
                MessageBox.Show("Error al devolver los productos al inventario", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region CARGAR LOS TIPOS DE VENTA
        private void CargarTipoVenta()
        {
            var TipoVenta= ObjdataListas.Value.BuscaListaTipoVenta();
            ddlTipoVenta.DataSource = TipoVenta;
            ddlTipoVenta.DisplayMember = "TipoVenta";
            ddlTipoVenta.ValueMember = "IdTipoVenta";
        }
        #endregion
        #region CARGAR LOS DIAS
        private void CargarDias()
        {
            var CargarDias = ObjdataListas.Value.BuscaCantidadDias();
            ddlCantidadDias.DataSource = CargarDias;
            ddlCantidadDias.DisplayMember = "CantidadDias";
            ddlCantidadDias.ValueMember = "IdCantidadDias";
        }
        #endregion
        #region BLOQUEAR Y DESBLOQUEAR CONTROLES
        private void BloquearControles()
        {
            txtCodigoCliente.Enabled = false;
            ddlTipoFacturacion.Enabled = false;
            txtNombrePaciente.Enabled = false;
            txtTelefono.Enabled = false;
          //  ddlCentroSalud.Enabled = false;
          //  txtSala.Enabled = false;
         //   ddlMedico.Enabled = false;
            txtNoCotizacion.Enabled = false;
            ddlTipoIdentificacion.Enabled = false;
            txtIdentificacion.Enabled = false;
            txtDireccion.Enabled = false;
            ddlSexo.Enabled = false;
            txtEmail.Enabled = false;
            txtComentario.Enabled = false;
            btnAgregarAlmacen.Enabled = false;
            btnRegresar.Enabled = true;
            VariablesGlobales.BloqueaControles = true;
        }
        private void DesbloquearControles()
        {
            txtCodigoCliente.Enabled = true;
            ddlTipoFacturacion.Enabled = true;
            txtNombrePaciente.Enabled = true;
            txtTelefono.Enabled = true;
          //  ddlCentroSalud.Enabled = true;
          //  txtSala.Enabled = true;
          //  ddlMedico.Enabled = true;
            txtNoCotizacion.Enabled = true;
            ddlTipoIdentificacion.Enabled = true;
            txtIdentificacion.Enabled = true;
            txtDireccion.Enabled = true;
            ddlSexo.Enabled = true;
            txtEmail.Enabled = true;
            txtComentario.Enabled = true;
            btnAgregarAlmacen.Enabled = true;
            btnRegresar.Enabled = true;

            txtCodigoCliente.Text = string.Empty;
            CargarComprobantes();
            txtNombrePaciente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            CargarCentrosSalud();
            txtSala.Text = string.Empty;
            CargarMedicos();
            txtNoCotizacion.Text = string.Empty;
            CargarTipoIdentificacion();
            txtIdentificacion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            CargarSexos();
            txtEmail.Text = string.Empty;
            txtComentario.Text = string.Empty;

            VariablesGlobales.CodigoPaciente = 787164;
            VariablesGlobales.BloqueaControles = false;
            SacarMontoCreditoGenerico(1);
        }
        #endregion
        #region SACAR LOS DATOS DE LOS TIPOS DE VENTA Y LA CANTIDAD DE DIAS
        public void SacarCantidadDiasTipoVentas()
        {
           
        }
        #endregion
        #region GUARDAR LAS CUENTAS POR COBRAR
        private void GuardarCuentasPorCobrar() {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar CXC = new Logica.Entidades.EntidadesContabilidad.EGuardarCuentasPorPagar();

                CXC.IdCuentaPorPagar = 0;
                CXC.IdPaciente = VariablesGlobales.CodigoPaciente;
                CXC.NumeroConector = VariablesGlobales.NumeroConector;
                CXC.BalanceInicial = Convert.ToDecimal(txtTotal.Text);
                CXC.BalanceActual = Convert.ToDecimal(txtTotal.Text);
                CXC.CantidadPagos = 0;


                var MAN = ObjdataContabilidad.Value.GuardarCuentasPorPagar(CXC, "INSERT");
            }
            catch (Exception) {
                MessageBox.Show("Error al guardar las cuentas por cobrar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region SACAR EL MONTO DEL CREDITO GENERICO
        private void SacarMontoCreditoGenerico(decimal IdMontoCreditoGenerico)
        {
            var SacarMontoCredito = ObjDataEmpresa.Value.GenerarMontoCreditoGenerico(IdMontoCreditoGenerico);
            foreach (var n in SacarMontoCredito)
            {
                decimal Monto = Convert.ToDecimal(n.MontoCredito);
                txtMontoCredito.Text = Monto.ToString("N2");
            }
        }
        #endregion
        #region FILTROS PARA CENTRO DE SALUD
        private void FiltroCentroSalud()
        {
            if (string.IsNullOrEmpty(txtFiltroCentroSalud.Text.Trim()))
            {
                CargarCentrosSalud();
            }
            else
            {
                var Buscar = ObjDataEmpresa.Value.BuscaCentroSalus(
                    Convert.ToDecimal(txtFiltroCentroSalud.Text),
                    null, null, 1, 1);
                if (Buscar.Count() < 1)
                {
                    MessageBox.Show("El codigo ingresado no es valido", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFiltroCentroSalud.Text = string.Empty;
                    txtFiltroCentroSalud.Focus();
                }
                else
                {
                    ddlCentroSalud.DataSource = Buscar;
                    ddlCentroSalud.DisplayMember = "Nombre";
                    ddlCentroSalud.ValueMember = "IdCentroSalud";
                }
            }
        }
        #endregion
        private void Facturacion_Load(object sender, EventArgs e)
        {
            rbBuscarPaciente.Checked = true;
            SacarMontoCreditoGenerico(1);
            CargarTipoVenta();
            if (VariablesGlobales.BloqueaControles == true)
            {
                BloquearControles();
            }
            else
            {
                DesbloquearControles();
            }
            VariablesGlobales.CodigoPaciente = 787164;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            CargarTipoVenta();
            OpcionTipoVenta();
            CargarEstatusCirugia();
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Facturación de Productos";
            VariablesGlobales.ModoCotizacion = false;
            groupBox2.ForeColor = Color.Black;
            groupBox3.ForeColor = Color.Black;
            groupBox4.ForeColor = Color.Black;
            gbGeneral.ForeColor = Color.Black;
            
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
            button1.ForeColor = Color.Black;
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
                int TipoRNCSeleccionado = 0;
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
                    ddlTipoVenta.Text = n.TipoVenta;
                    ddlCantidadDias.Text = n.CantidadDias.ToString();
                    VariablesGlobales.CodigoPaciente = Convert.ToDecimal(n.CodigoPaciente);
                    decimal Monto = Convert.ToDecimal(n.MontoCredito);
                    txtMontoCredito.Text = Monto.ToString("N2");
                    txtPacientePaciente.Text = n.Paciente;
                    txtCedulaCedula.Text = n.CedulaPaciente;
                    TipoRNCSeleccionado = Convert.ToInt32(n.TipoBusquedaRNC);

                    if (TipoRNCSeleccionado == 1)
                    {
                        rbBuscarPaciente.Checked = true;
                        rbBuscarCliente.Checked = false;
                    }
                    else if (TipoRNCSeleccionado == 2)
                    {
                        rbBuscarPaciente.Checked = false;
                        rbBuscarCliente.Checked = true;
                    }

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
            //INICIALMOS EL PROCESO PARA DEVOLVER TODOS LOS PRODUCTOS AL INVENTARIO NUEVAMENTE
            //RECORREMOS LA TABLA DE FACTURACION PRODUCTOS SEGUN EL NUMERO DE CONECTOR SELECCIONADO

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
             //   rbFacturar.ForeColor = Color.SpringGreen;
                VariablesGlobales.IdEstatusFacturacion = 1;
            }
            else
            {
              //  rbFacturar.ForeColor = Color.Red;
                VariablesGlobales.IdEstatusFacturacion = 0;
            }
        }

        private void rbCotizar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCotizar.Checked)
            {
               // rbCotizar.ForeColor = Color.SpringGreen;
                VariablesGlobales.IdEstatusFacturacion = 2;
            }
            else
            {
               // rbCotizar.ForeColor = Color.Red;
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
            if (rbBuscarPaciente.Checked == true)
            {
                BuscarClientes();
            }
            else if (rbBuscarCliente.Checked == true)
            {
                BuscarDatosClientes();
            }
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            try {
                if (Convert.ToInt32(ddlTipoVenta.SelectedValue) == 1)
                {
                    if (Convert.ToInt32(ddltIPago.SelectedValue) == 6)
                    {
                        MessageBox.Show("No es posible proceder con la facturación por que estas seleccionando un tipo de pago a credito cuando estas realizando un tipo de venta a contado, favor de verificar el tipo de venta o cambiar el tipo de pago", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //CONTADO
                        //VALIDAMOS SI HAY PRODUCTOS AGRAGADOS PARA FACTURAR
                        var ValidarProductosAgregados = ObjDataFacturacion.Value.BuscarProductosAgregados(
                            VariablesGlobales.NumeroConector,
                            null);
                        if (ValidarProductosAgregados.Count() < 1)
                        {
                            if (rbFacturar.Checked)
                            {
                                MessageBox.Show("No has agregado productos para facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (rbCotizar.Checked)
                            {
                                MessageBox.Show("No has agregado productos para cotizar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            if (MessageBox.Show("¿Quieres agregar productos?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                PasarPantallaAgregarProductos();
                            }
                        }
                        else
                        {
                            //PROCESAMOS EN BASE A FACTURAR
                            if (rbFacturar.Checked)
                            {
                                //VERIFICAMOS QUE LOS CAMPOS NECESARIOS ESTEN CHEQUEADOS
                                if (string.IsNullOrEmpty(ddlTipoFacturacion.Text.Trim()) || string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()) || string.IsNullOrEmpty(ddlCentroSalud.Text.Trim()) || string.IsNullOrEmpty(ddlMedico.Text.Trim()) || string.IsNullOrEmpty(ddlTipoIdentificacion.Text.Trim()))
                                {
                                    MessageBox.Show("Has dejado campos vacios en la parte del cliente que son necesarios para completar este proceso", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    //VERIFICAMOS SI EL CAMPO MONTO ESTA VACIO
                                    if (string.IsNullOrEmpty(txtMontoPagar.Text.Trim()))
                                    {
                                        MessageBox.Show("El campo monto no puede estar vacio favor de revisar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        decimal TipoPago = 0;
                                        //VERIFICAMOS EL TIPO DE PAGO
                                        var ValidarTipopago = ObjDataFacturacion.Value.ListadoTipoPago(
                                            Convert.ToDecimal(ddltIPago.SelectedValue),
                                            null, null, 1, 1);
                                        foreach (var n in ValidarTipopago)
                                        {
                                            TipoPago = Convert.ToDecimal(n.IdTipoPago);
                                        }
                                        if (TipoPago == 1)
                                        {
                                            //VALIDAMOS EL MONTO
                                            decimal Monto = Convert.ToDecimal(txtMontoPagar.Text);
                                            decimal Total = Convert.ToDecimal(txtTotal.Text);

                                            if (Monto < Total)
                                            {
                                                MessageBox.Show("El monto ingresado es menor al total a pagar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                            else
                                            {
                                                //GUARDAMOS LOS DATOS
                                                TerminarProceso();
                                            }
                                        }
                                        else
                                        {
                                            //GUARDAMOS LOS DATOS
                                            TerminarProceso();

                                        }
                                    }
                                }

                            }
                            else if (rbCotizar.Checked)
                            {
                                if (string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()))
                                {
                                    txtNombrePaciente.Text = "CLIENTE FACTURACION";
                                }
                                DevolverProductos();
                                //GUARDAMOS LOS DATOS
                                VariablesGlobales.AccionTomar = "INSERT";
                                GuardarFacturacionCliente();
                                GuardarDatosFacturaconCalculos();
                                //  AfectarComprobante(Convert.ToDecimal(ddlTipoFacturacion.SelectedValue));
                                // AfectarCaja();
                                MessageBox.Show("Cotización realizada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ImprimirFactura(VariablesGlobales.NumeroConector);
                                this.Dispose();
                            }

                            //PROCESAMOS EN BASE A COTIZAR
                        }
                    }
                }
                //VENTA A CREDITO
                else if (Convert.ToInt32(ddlTipoVenta.SelectedValue) == 2)
                {
                    try {
                        //GENERAR UN NUMERO DE RNC ALEATORIO PARA EN CASO DE QUE ESTE VACIO EL 
                        if (string.IsNullOrEmpty(txtIdentificacion.Text.Trim()))
                        {
                            ddlTipoIdentificacion.Text = "RNC";
                            Random GenerarRNC = new Random();
                           int RNCGenerado = GenerarRNC.Next(0, 999999999);
                            txtIdentificacion.Text = RNCGenerado.ToString();
                        }
                        //VALIDAMOS LOS CAMPOS OBLIGATORIOS
                        if (string.IsNullOrEmpty(ddlTipoFacturacion.Text.Trim()) || string.IsNullOrEmpty(txtNombrePaciente.Text.Trim()) || string.IsNullOrEmpty(ddlCentroSalud.Text.Trim()) || string.IsNullOrEmpty(ddlMedico.Text.Trim()) || string.IsNullOrEmpty(ddlTipoIdentificacion.Text.Trim()) || string.IsNullOrEmpty(ddlSexo.Text.Trim()))
                        {
                            MessageBox.Show("Has dejado campos vacios que son necesarios para realizar este proceso", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //VALIDAMOS SI HAY PRODUCTOS AGREGADOS
                            var ValidarProductos = ObjDataFacturacion.Value.BuscarProductosAgregados(VariablesGlobales.NumeroConector);
                            if (ValidarProductos.Count() < 1)
                            {
                                MessageBox.Show("No hay productos agregados para facturar, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                if (MessageBox.Show("¿Quieres agregar productos?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    PasarPantallaAgregarProductos();
                                }
                            }
                            else
                            {
                                decimal CreditoDisponible = Convert.ToDecimal(txtMontoCredito.Text);
                                decimal TotalPagar = Convert.ToDecimal(txtTotal.Text);
                                if (TotalPagar > CreditoDisponible)
                                {
                                    MessageBox.Show("No es posible realizar este venta por que este cliente solo tiene " + CreditoDisponible.ToString("N2") + " cuando el total a pagar es de " + TotalPagar.ToString("N2") + " Por lo tanto supera el valor",VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    if (VariablesGlobales.CodigoPaciente == 787164)
                                    {
                                        MessageBox.Show("Este paciente no se le puede hacer una venta a credito, por que no esta registrada en el sistema", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        //GUARDAMOS LOS REGISTROS CORRESPONDIENTES
                                        GuardarCuentasPorCobrar();
                                        TerminarProceso();
                                    }
                              
                                }

                            }
                        }
                    }
                    catch (Exception) {
                        MessageBox.Show("Error al realizar la facturación a credito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Error al facturar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception) { }

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
            if (MessageBox.Show("¿Quieres devolver este producto al inventario?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try {
                    decimal IdProducto = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["IdProducto"].Value.ToString());
                    string CodigoProducto = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CodigoProducto"].Value.ToString());
                    int Cantidad = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["Cantidad"].Value.ToString());
                    decimal Secuencial = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells["Secuencial"].Value.ToString());
                    //DEVOLVEMOS LOS PRODUCTOS AL INVENTARIO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadInventario.EPRoducto Devolver = new Logica.Entidades.EntidadInventario.EPRoducto();

                    Devolver.IdProducto = IdProducto;
                    Devolver.CodigoProducto = CodigoProducto;
                    Devolver.CantidadAlmacen = Cantidad;

                    var MAN = ObjDataInventario.Value.MantenimientoProducto(Devolver, "ADD");


                    //ELIMINAMOS EL PRODUCTO
                    DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EFacturacionProductos Producto = new Logica.Entidades.EntidadFacturacion.EFacturacionProductos();

                    Producto.NumeroConector = VariablesGlobales.NumeroConector;
                    Producto.Secuencial = Secuencial;

                    var MAN2 = ObjDataFacturacion.Value.GuardarFacturacionProductos(Producto, "DELETE");

                    //ACTUALIZAMOS LOS DATOS EN EL GRID Y EN LOS CALCULOS
                    MostrarListadoProductosAgregados(VariablesGlobales.NumeroConector);
                    SacarDatosCalculos(VariablesGlobales.NumeroConector);
                }
                catch (Exception) {
                    MessageBox.Show("Error al devolver el este registro al inventario", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void ddlTipoVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  ddlCantidadDias.Visible = true;
            CargarDias();
            OpcionTipoVenta();
          //  ddlCantidadDias.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
        }

        private void ddlCantidadDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
        
            }
            catch (Exception) { }
        }

        private void rbBuscarPaciente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarPaciente.Checked)
            {
                lbNombrePaciente.Text = "Nombre de Paciente*";
                lbNombrePacientePaciente.Visible = false;
                txtPacientePaciente.Visible = false;
                lbCedulaCedula.Visible = false;
                txtCedulaCedula.Visible = false;
            }
            else
            {
                lbNombrePaciente.Text = "Nombre de Cliente*";
                lbNombrePacientePaciente.Visible = true;
                txtPacientePaciente.Visible = true;
                lbCedulaCedula.Visible = true;
                txtCedulaCedula.Visible = true;

            }
        }

        private void rbBuscarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarCliente.Checked)
            {
                lbNombrePaciente.Text = "Nombre de Cliente*";
                lbNombrePacientePaciente.Visible = true;
                txtPacientePaciente.Visible = true;
                lbCedulaCedula.Visible = true;
                txtCedulaCedula.Visible = true;
            }
            else
            {
                lbNombrePaciente.Text = "Nombre de Paciente*";
                lbNombrePacientePaciente.Visible = false;
                txtPacientePaciente.Visible = false;
                lbCedulaCedula.Visible = false;
                txtCedulaCedula.Visible = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FiltroCentroSalud();
        }

        private void txtFiltroCentroSalud_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltroCentroSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FiltroCentroSalud();
            }
        }
    }
}
