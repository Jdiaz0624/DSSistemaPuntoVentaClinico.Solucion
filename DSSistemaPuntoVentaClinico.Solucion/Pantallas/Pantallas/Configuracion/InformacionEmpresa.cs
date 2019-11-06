using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class InformacionEmpresa : Form
    {
        public InformacionEmpresa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacionEmpresa_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.Black;
            groupBox2.ForeColor = Color.Black;
            btnModificar.ForeColor = Color.Black;
            btnCerrar.ForeColor = Color.Black;
            txtNombreEmpresa.ForeColor = Color.Black;
            txtRNC.ForeColor = Color.Black;
            txtDireccion.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtEmail2.ForeColor = Color.Black;
            txtFacebook.ForeColor = Color.Black;
            txtInstagram.ForeColor = Color.Black;
            txtTelefonos.ForeColor = Color.Black;
            txtFax.ForeColor = Color.Black;
            txtClaveSeguridad.ForeColor = Color.Black;
            txtClaveSeguridad.PasswordChar = '•';
            btnBucaImagen.ForeColor = Color.Red;
            cbCambiarLogo.Checked = false;
            cbCambiarLogo.ForeColor = Color.Red;
            btnBucaImagen.Enabled = false;
        }
          

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformacionEmpresa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCambiarLogo.Checked)
            {
                btnBucaImagen.Enabled = true;
                cbCambiarLogo.ForeColor = Color.Green;
                btnBucaImagen.ForeColor = Color.White;
            }
            else
            {
                btnBucaImagen.Enabled = false;
                cbCambiarLogo.ForeColor = Color.Red;
                btnBucaImagen.ForeColor = Color.Red;
            }
        }
    }
}
