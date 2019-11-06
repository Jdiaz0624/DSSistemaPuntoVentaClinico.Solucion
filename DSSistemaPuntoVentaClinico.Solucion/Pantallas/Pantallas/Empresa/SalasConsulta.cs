using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class SalasConsulta : Form
    {
        public SalasConsulta()
        {
            InitializeComponent();
        }
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void SalasConsulta_Load(object sender, EventArgs e)
        {
            gbBuscar.ForeColor = Color.Black;
            gbListado.ForeColor = Color.Black;
            gbOpciones.ForeColor = Color.Black;
            lbNumeroPagina.ForeColor = Color.Black;
            lbNumeroRegistros.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtCodigo.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            dtListado.ForeColor = Color.Black;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.SalasMantenimiento Mantenimiento = new SalasMantenimiento();
            Mantenimiento.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Mantenimiento.ShowDialog();
        }
    }
}
