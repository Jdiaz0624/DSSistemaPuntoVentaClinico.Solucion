using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Contabilidad
{
    public partial class HistorialPagos : Form
    {
        public HistorialPagos()
        {
            InitializeComponent();
        }
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HistorialPagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void HistorialPagos_Load(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Historial de Pagos";
        }

        private void txtRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            DSSistemaPuntoVentaClinico.Logica.Comunes.ValidarControles.SoloNumeros(e);
        }
    }
}
