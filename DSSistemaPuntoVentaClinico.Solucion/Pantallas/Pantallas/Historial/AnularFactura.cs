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
                txtNombrePaciente.Text = n.NombrePaciente;
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }
    }
}
