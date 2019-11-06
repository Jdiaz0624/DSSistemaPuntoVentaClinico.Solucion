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
    public partial class SubMenuConfiguracion : Form
    {
        public SubMenuConfiguracion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuConfiguracion_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
        }

        private void btnInformacionEmpresa_Click(object sender, EventArgs e)
        {
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion.InformacionEmpresa InformacionEmpresa = new Pantallas.Configuracion.InformacionEmpresa();
            InformacionEmpresa.ShowDialog();
        }
    }
}
