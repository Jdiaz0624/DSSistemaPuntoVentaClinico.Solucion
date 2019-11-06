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
    public partial class SalasMantenimiento : Form
    {
        public SalasMantenimiento()
        {
            InitializeComponent();
        }
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region Cerrar Pantalla
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.SalasConsulta Consulta = new SalasConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion
        private void SalasMantenimiento_Load(object sender, EventArgs e)
        {
            gbDatos.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            txtSala.ForeColor = Color.Black;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }
    }
}
