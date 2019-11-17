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
    public partial class SubMenuContabilidad : Form
    {
        public SubMenuContabilidad()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SubMenuContabilidad_Load(object sender, EventArgs e)
        {
            gbOpciones.ForeColor = Color.Black;
        }

        private void btnControlApertura_Click(object sender, EventArgs e)
        {

        }
    }
}
