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
    public partial class OtrasInformaciones : Form
    {
        public OtrasInformaciones()
        {
            InitializeComponent();
        }
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        private void OtrasInformaciones_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.Red;
        }
    }
}
