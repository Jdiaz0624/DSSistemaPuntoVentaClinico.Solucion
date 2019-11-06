using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.SubMenus
{
    public partial class SubMenuFacturacion : Form
    {
        public SubMenuFacturacion()
        {
            InitializeComponent();
        }
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja>();
        private void SubMenuFacturacion_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SubMenuFacturacion_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
            lbUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            bool EstatusCaja = false;

            var SacarEstatusCaja = ObjDataCaja.Value.BuscaCaja(1, null);
            foreach (var n in SacarEstatusCaja)
            {
                EstatusCaja = Convert.ToBoolean(n.Estatus0);
                if (EstatusCaja == true)
                {
                    DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.Facturacion Facturacion = new Pantallas.Facturacion.Facturacion();
                    Facturacion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
                    Facturacion.VariablesGlobales.GenerarConector = true;
                    Facturacion.VariablesGlobales.SacarDatosEspejo = false;
                    Facturacion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se puede acceder a esta pantalla por que la caja principal esta actualmente cerrada", "Facturació", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.MantenimientoTipoPago TipoPagoConsulta = new Pantallas.Facturacion.MantenimientoTipoPago();
            TipoPagoConsulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            TipoPagoConsulta.ShowDialog();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Historial.Historial Registros = new Pantallas.Historial.Historial();
            Registros.Variables.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            Registros.ShowDialog();
        }

        private void btnFinanciamiento_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Facturacion.ProgramacionCirugiaConsulta Programacion = new Pantallas.Facturacion.ProgramacionCirugiaConsulta();
            Programacion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            Programacion.ShowDialog();
        }
    }
}
