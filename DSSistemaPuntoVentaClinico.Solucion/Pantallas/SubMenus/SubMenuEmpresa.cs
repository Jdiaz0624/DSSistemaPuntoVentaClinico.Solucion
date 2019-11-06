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
    public partial class SubMenuEmpresa : Form
    {
        public SubMenuEmpresa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuEmpresa_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
            lbIdUsuario.Text = DSSistemaPuntoVentaClinico.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuario.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ClienteCFonsulta Consulta = new Pantallas.Empresa.ClienteCFonsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void brnMedicos_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.MedicosConsulta Consulta = new Pantallas.Empresa.MedicosConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void btnARS_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ARSConsulta Consulta = new Pantallas.Empresa.ARSConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void btnCentroSalud_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.CentroSaludConsulta Consulta = new Pantallas.Empresa.CentroSaludConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.SalasConsulta Consulta = new Pantallas.Empresa.SalasConsulta();
            Consulta.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbIdUsuario.Text);
            Consulta.ShowDialog();
        }
    }
}
