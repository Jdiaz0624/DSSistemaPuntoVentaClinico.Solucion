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
    public partial class ProgramacionCirugias : Form
    {
        public ProgramacionCirugias()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaFacturacion> ObjDataFacturacion = new Lazy<Logica.Logica.LogicaFacturacion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaListas> ObjDataListas = new Lazy<Logica.Logica.LogicaListas>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaHistorial> ObjDataHistorial = new Lazy<Logica.Logica.LogicaHistorial>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LOS DATOS DE LA EMPRESA
        private void SacarDatosInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjDataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
            }
        }
        #endregion

        #region CARGAR LOS CENTROS DE SALUD
        private void CargarCentroSalud()
        {
            var CentroSalid = ObjDataListas.Value.ListaCentrosalud();
            ddlCentroSalud.DataSource = CentroSalid;
            ddlCentroSalud.DisplayMember = "Nombre";
            ddlCentroSalud.ValueMember = "IdCentroSalud";
        }
        #endregion

        #region CARGAR LOS MEDICOS
        private void CargarMedicos()
        {
            try {
                var Medicos = ObjDataListas.Value.ListaMedicos(
                    Convert.ToDecimal(ddlCentroSalud.SelectedValue));
                ddlMedico.DataSource = Medicos;
                ddlMedico.DisplayMember = "NombreMedico";
                ddlMedico.ValueMember = "IdMedico";

            }
            catch (Exception) { }
        }
        #endregion

        #region CARGAR EL ESTATUS DE CIRUGIA
        private void CargarEstatusCirugia()
        {
            var Estatus = ObjDataListas.Value.BuscaEstatusCirugia();
            ddlEstatusCirugia.DataSource = Estatus;
            ddlEstatusCirugia.DisplayMember = "Descripcion";
            ddlEstatusCirugia.ValueMember = "IdEstatusCirugia";
        }
        #endregion

        #region SACAMOS LOS DATOS DE LA PROGRAMACION PARA REALIZAR LA PROGRAMACION
        private void SacarDatosprogramacionCirugia(decimal Parametro)
        {
            //REALIZAMOS LA CONSULTA
            if (rbBuscarPorNumeroFactura.Checked)
            {
                var Buscar = ObjDataHistorial.Value.HistorialFacturacionCotizacion(
                    Parametro,
                    null,
                    null,
                    1,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    1, 1);
                if (Buscar.Count() < 1)
                {
                    MessageBox.Show("No existen datos relacionados con el numero de factura ingresado, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //MOSTRAMOS LOS OCNTROLES OCULTOS
                    lbEstatus.Visible = true;
                    ddlEstatusCirugia.Visible = true;
                    gbProductosAgregados.Visible = true;
                    gbDatosPaciente.Visible = true;
                    btnCompletarRegistro.Visible = true;
                    lbEstatus.Visible = true;
                    ddlEstatusCirugia.Visible = true;
                    //SACAMOS LOS DATOS 
                    foreach (var n in Buscar)
                    {
                        txtTipoFacturacion.Text = n.TipoComprobante;
                        txtNombrePaciente.Text = n.NombrePaciente;
                        txtTelefono.Text = n.Telefono;
                        txtSala.Text = n.Sala;
                        txtTipoIdentificacion.Text = n.TipoIdentificacion;
                        txtNoIdentificacion.Text = n.NumeroIdentificacion;
                        txtSexo.Text = n.Sexo;
                        txtEmail.Text = n.Email;
                        txtDireccion.Text = n.Direccion;
                        lbNumeroFactura.Text = n.NumeroFactura.ToString();
                        ddlEstatusCirugia.Text = n.EstatusCirugia;
                        ddlCentroSalud.Text = n.CentroSalud;
                        ddlMedico.Text = n.Medico;
                        lbNumeroReferencia.Text = n.NumeroConector.ToString();
                    }
                    //MOSTRAMOS LOS PRODUCTOS AGREGADOS
                    var ProductosAgregados = ObjDataFacturacion.Value.BuscarProductosAgregados(
                        Convert.ToDecimal(lbNumeroReferencia.Text), null);
                    dtListado.DataSource = ProductosAgregados; 
                    OcultarColumnas();
                }
            }
            else if (rbBuscarPorNumeroReferencia.Checked)
            {

            }
        }
        #endregion

        #region METODO PARA EL MOTON DE CONSULTAR
        private void Consultar()
        {
            //VERIFICAMOS LOS CAMPOS VACIOS
            if (rbBuscarPorNumeroFactura.Checked)
            {
                if (string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()))
                {
                    MessageBox.Show("El campo numero de factura no puede estar vacio para realizar la busqueda", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SacarDatosprogramacionCirugia(Convert.ToDecimal(txtNumeroFactura.Text));
                }
            }
            else if (rbBuscarPorNumeroReferencia.Checked)
            {
                if (string.IsNullOrEmpty(txtNumeroFactura.Text.Trim()))
                {
                    MessageBox.Show("El campo numero de referencia no puede estar vacio para realizar la busqueda", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SacarDatosprogramacionCirugia(Convert.ToDecimal(txtReferencia.Text));
                }
            }

            else
            {
                MessageBox.Show("Error al tratar de ralizar la consulta, favor de seleccionar una opcion", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region OCULTAR COLUMNAS
        private void OcultarColumnas()
        {
            this.dtListado.Columns["NumeroConector"].Visible = false;
            this.dtListado.Columns["IdProducto"].Visible = false;
            this.dtListado.Columns["PrecioCompra"].Visible = false;
            this.dtListado.Columns["LlevaDescuento0"].Visible = false;
            this.dtListado.Columns["_LlevaDescuento"].Visible = false;
            this.dtListado.Columns["PorcientoDescuento"].Visible = false;
            this.dtListado.Columns["DescuentoAplicado"].Visible = false;
            this.dtListado.Columns["Total"].Visible = false;
            this.dtListado.Columns["Secuencial"].Visible = false;
            this.dtListado.Columns["NumeroPago"].Visible = false;
        }
        #endregion

        #region IMPRESION DE FACTURAS
        private void GenerarFacturaVentas(decimal NumeroConector)
        {
            //SACAMOS EL USUARIO Y LA CLAVE DE LA BASE DE DATOS
            var SacarCredenciales = ObjdataSeguridad.Value.SacarLogonBD(1);
            foreach (var n in SacarCredenciales)
            {
                VariablesGlobales.UsuarioBD = n.Usuario;
                VariablesGlobales.ClaveBD = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(n.Clave);
            }
            //SACAMOS LA RUTA DEL REPORTE SELECCIONADO

            var SacarRutaReporte = ObjDataHistorial.Value.SacarRutaReporte(1);
            foreach (var n in SacarRutaReporte)
            {
                VariablesGlobales.RutaReporte = n.RutaReporte;
            }

            //MOSTRAMOS EL REPORTE
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Reporte.Reportes Factura = new Reporte.Reportes();
            Factura.VariablesGlobales.UsuarioBD = VariablesGlobales.UsuarioBD;
            Factura.VariablesGlobales.ClaveBD = VariablesGlobales.ClaveBD;
            Factura.VariablesGlobales.RutaReporte = VariablesGlobales.RutaReporte;
            Factura.CargarReporteExternoPantalla(NumeroConector);
            Factura.ShowDialog();
        }
        #endregion

        #region MANTENIMIENTO DE PROGRAMACION DE CIRUGIAS
        private void MAMProgramacionCirugias()
        {
            DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia Mantenimiento = new Logica.Entidades.EntidadFacturacion.EMantenimientoProgramacionCirugia();

            Mantenimiento.IdProgramacionCirugia = VariablesGlobales.IdMantenimiento;
            Mantenimiento.FechaCirugia = Convert.ToDateTime(txtFechaCirugia.Text);
            Mantenimiento.IdCentroSalud = Convert.ToDecimal(ddlCentroSalud.SelectedValue);
            Mantenimiento.IdMedico = Convert.ToDecimal(ddlMedico.SelectedValue);
            Mantenimiento.IdAuxiliarCirugia = Convert.ToDecimal(ddlAsistenteCirugia.SelectedValue);
            Mantenimiento.IdHoraCirugia = Convert.ToDecimal(ddlHoraCirugia.SelectedValue);
            Mantenimiento.IdEstatusCirugia = Convert.ToDecimal(ddlEstatusCirugia.SelectedValue);
            Mantenimiento.NoFactura = Convert.ToDecimal(lbNumeroFactura.Text);
            Mantenimiento.NoReferencia = Convert.ToDecimal(lbNumeroReferencia.Text);
            Mantenimiento.UsuarioAdiciona = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaAdiciona = DateTime.Now;
            Mantenimiento.UsuarioModifica = VariablesGlobales.IdUsuario;
            Mantenimiento.FechaModifica = DateTime.Now;
            Mantenimiento.Comentario = txtComentario.Text;

            var MAN = ObjDataFacturacion.Value.MantenimientoProgramacionCirugia(Mantenimiento, VariablesGlobales.AccionTomar);
            if (VariablesGlobales.AccionTomar != "INSERT")
            {

                MessageBox.Show("Registro Modificado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
            else
            {
                MessageBox.Show("Registro Guardado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarPantalla();
            }
        }
        #endregion

        #region CERRAR LA PANTALLA
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugiaConsulta Consulta = new ProgramacionCirugiaConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
        #endregion

        #region CARGAR LAS LISTAS DESPLEGABLES
        private void CargarHoras()
        {
            var Horas = ObjDataListas.Value.BuscaHoras(
                new Nullable<decimal>(),
                null);
            ddlHoraCirugia.DataSource = Horas;
            ddlHoraCirugia.ValueMember = "IdHora";
            ddlHoraCirugia.DisplayMember = "Hora";
            
        }
        private void CargarAsistenteCirugia()
        {
            var AsistenteCirugia = ObjDataListas.Value.BuscaAsistenteCirugia();
            ddlAsistenteCirugia.DataSource = AsistenteCirugia;
            ddlAsistenteCirugia.ValueMember = "IdAsistenteCirugia";
            ddlAsistenteCirugia.DisplayMember = "Nombre";
        }
        #endregion
        private void ProgramacionCirugias_Load(object sender, EventArgs e)
        {
            this.dtListado.RowsDefaultCellStyle.BackColor = Color.LightSalmon;
            this.dtListado.AlternatingRowsDefaultCellStyle.BackColor = Color.CornflowerBlue;
            rbBuscarPorNumeroFactura.Checked = true;
            SacarDatosInformacionEmpresa(1);
            gbDatosPaciente.ForeColor = Color.Black;
            gbProductosAgregados.ForeColor = Color.Black;
            gbProgramacionCirugia.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtNoIdentificacion.ForeColor = Color.Black;
            txtNombrePaciente.ForeColor = Color.Black;
            txtSala.ForeColor = Color.Black;
            txtSexo.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            txtTipoFacturacion.ForeColor = Color.Black;
            txtTipoIdentificacion.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
            CargarCentroSalud();
            CargarMedicos();
            CargarEstatusCirugia();
            CargarHoras();
            CargarAsistenteCirugia();
            if (VariablesGlobales.AccionTomar != "INSERT")
            {
                SacarDatosprogramacionCirugia(VariablesGlobales.NumeroFacturaMantenimiento);

                var SacarDatos = ObjDataFacturacion.Value.BuscaProgramacionCirugia(
                    VariablesGlobales.IdMantenimiento,
                    null, null, null, null, null, null, 1, 1);
                foreach (var n in SacarDatos)
                {
                    txtFechaCirugia.Text = n.FechaCirugia0.ToString();
                    ddlCentroSalud.Text = n.CentroSalud;
                    ddlMedico.Text = n.NombreMedico;
                    ddlHoraCirugia.Text = n.Hora;
                    ddlAsistenteCirugia.Text = n.AuxiliarCirugia;
                    txtComentario.Text = n.Comentario;
                    ddlEstatusCirugia.Text = n.Estatus;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTipoFacturacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }

        private void ProgramacionCirugias_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void ddlCentroSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMedicos();
        }

        private void rbBuscarPorNumeroFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarPorNumeroFactura.Checked)
            {
                rbBuscarPorNumeroFactura.ForeColor = Color.White;
                txtNumeroFactura.Text = string.Empty;
                txtReferencia.Text = string.Empty;
                txtNumeroFactura.Enabled = true;
                txtReferencia.Enabled = false;
                txtNumeroFactura.Focus();
            }
            else
            {
                rbBuscarPorNumeroFactura.ForeColor = Color.Red;
                txtNumeroFactura.Text = string.Empty;
                txtReferencia.Text = string.Empty;
                txtNumeroFactura.Enabled = false;
                txtReferencia.Enabled = false;
            }
        }

        private void rbBuscarPorNumeroReferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuscarPorNumeroReferencia.Checked)
            {
                rbBuscarPorNumeroReferencia.ForeColor = Color.White;
                txtNumeroFactura.Text = string.Empty;
                txtReferencia.Text = string.Empty;
                txtNumeroFactura.Enabled = false;
                txtReferencia.Enabled = true;
                txtReferencia.Focus();
            }
            else
            {
                rbBuscarPorNumeroReferencia.ForeColor = Color.Red;
                txtNumeroFactura.Text = string.Empty;
                txtReferencia.Text = string.Empty;
                txtNumeroFactura.Enabled = false;
                txtReferencia.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Consultar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarFacturaVentas(Convert.ToDecimal(lbNumeroReferencia.Text));
        }

        private void btnCompletarRegistro_Click(object sender, EventArgs e)
        {
            MAMProgramacionCirugias();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.OtrasInformaciones Otras = new OtrasInformaciones();
            Otras.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Otras.ShowDialog();
        }

        private void gbProgramacionCirugia_Enter(object sender, EventArgs e)
        {

        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
