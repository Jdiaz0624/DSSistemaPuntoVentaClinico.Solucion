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
    }
}
