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
    public partial class ClienteMantenimiento : Form
    {
        public ClienteMantenimiento()
        {
            InitializeComponent();
        }
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();
        #region Cerrar Pantalla
        private void CerrarPantalla()
        {
            this.Dispose();
            DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Empresa.ClienteCFonsulta Consulta = new ClienteCFonsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }
#endregion
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTipoDeIdentificacion.Text == "Cedula")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "000-0000000-0";
                txtIdentificacion.Text = string.Empty;
            }
            else if (txtTipoDeIdentificacion.Text == "RNC")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "";
                txtIdentificacion.Text = string.Empty;
            }
            else if (txtTipoDeIdentificacion.Text == "Pasaporte")
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Mask = "";
                txtIdentificacion.Text = string.Empty;
            }
            else
            {
                txtIdentificacion.Visible = true;
                txtIdentificacion.Visible = false;
                txtIdentificacion.Text = string.Empty;
            }
        }

        private void ClienteMantenimiento_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.Black;
            txtApellido.ForeColor = Color.Black;
            txtComentario.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtIdentificacion.ForeColor = Color.Black;
            txtNombre.ForeColor = Color.Black;
            txtOtroTipoComunicacion.ForeColor = Color.Black;
            txtTelefonos.ForeColor = Color.Black;
            txtTipoCliente.ForeColor = Color.Black;
            txtTipoDeIdentificacion.ForeColor = Color.Black;
            btnAccion.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarPantalla();
        }
    }
}
