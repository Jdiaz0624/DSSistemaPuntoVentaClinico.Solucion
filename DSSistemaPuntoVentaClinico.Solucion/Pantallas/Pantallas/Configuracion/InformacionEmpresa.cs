using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class InformacionEmpresa : Form
    {
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaConfiguracion> ObjdataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion>();
        Lazy<DSSistemaPuntoVentaClinico.Logica.Logica.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad>();
        public DSSistemaPuntoVentaClinico.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region SACAR LA NFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa(int IdInformacionEmpresa)
        {
            var SacarInformacion = ObjdataConfiguracion.Value.BuscaInformacionEmpresa(IdInformacionEmpresa);
            foreach (var n in SacarInformacion)
            {
                txtNombreEmpresa.Text = n.NombreEmpresa;
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
                VariablesGlobales.CodigoMantenimiento = n.CodigoInformacionEmpresa;
                txtRNC.Text = n.RNC;
                txtTelefonos.Text = n.Telefonos;
                txtInstagram.Text = n.Instagran;
                txtFax.Text = n.Fac;
                txtFacebook.Text = n.Facebook;
                txtEmail2.Text = n.Email2;
                txtEmail.Text = n.Email;
                txtDireccion.Text = n.Direccion;
                
            }
        }
        #endregion
        #region GUARDAR IMAGEN EN LA BASE DE DATOS
        private void GuardarImagen()
        {

            //GUARDAMOS LA IMAGEN EN LA BASE DE DATOS
            SqlCommand comando = new SqlCommand();
            comando.Connection = DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();
            comando.CommandText = "EXEC Configuracion.SP_GUARDAR_LOGO_EMPRESA @IdLogoEmpresa,@Descripcion,@LogoEmpresa";

            comando.Parameters.Add("@IdLogoEmpresa", SqlDbType.Decimal);
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            comando.Parameters.Add("@LogoEmpresa", SqlDbType.Image);

            comando.Parameters["@IdLogoEmpresa"].Value = 1;
            comando.Parameters["@Descripcion"].Value = "Logo";
            MemoryStream ms = new MemoryStream();
            pbLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@LogoEmpresa"].Value = ms.GetBuffer();

            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion().Close();
        }
        #endregion
        #region ACTUALIZAR LOS DATO DE LA INFORMACION DE LA EMPRESA
        private void ActualizarDatos()
        {
            try {
                DSSistemaPuntoVentaClinico.Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa Actualizar = new Logica.Entidades.EntidadesConfiguracion.EMantenimientoInformacionEmpresa();

                Actualizar.IdInformacionEmpresa = 1;
                Actualizar.CodigoInformacionEmpresa = VariablesGlobales.CodigoMantenimiento;
                Actualizar.NombreEmpresa = txtNombreEmpresa.Text;
                Actualizar.RNC = txtRNC.Text;
                Actualizar.Direccion = txtDireccion.Text;
                Actualizar.Email = txtEmail.Text;
                Actualizar.Email2 = txtEmail2.Text;
                Actualizar.Facebook = txtFacebook.Text;
                Actualizar.Instagran = txtInstagram.Text;
                Actualizar.Telefonos = txtTelefonos.Text;
                Actualizar.Fac = txtFax.Text;


                var MAn = ObjdataConfiguracion.Value.MantenimientoInformacionEmpresa(Actualizar, "UPDATE");
                if (cbCambiarLogo.Checked)
                {
                    GuardarImagen();
                }
                SacarInformacionEmpresa(1);
                MessageBox.Show("Registro actualizado con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) {
                MessageBox.Show("Error al actualizar los datos", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
        #endregion
        #region MOSTRAR LA IMAGEN GUARDADA EN LA BASE DE DATOS
        private void MostrarImagen(PictureBox logo, TextBox Texto)
        {
            SqlCommand comando = new SqlCommand("select LogoEmpresa from Configuracion.LogoEmpresa where IdLogoEmpresa = 1", DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion());
            SqlDataAdapter adaptar = new SqlDataAdapter(comando);
            DataSet ds = new DataSet("LogoEmpresa");
            adaptar.Fill(ds, "LogoEmpresa");
            byte[] DATOS = new byte[0];
            DataRow dr = ds.Tables["LogoEmpresa"].Rows[0];
            DATOS=(byte[])dr["LogoEmpresa"];
            MemoryStream ms = new MemoryStream(DATOS);
            logo.Image = System.Drawing.Bitmap.FromStream(ms);
            

        }
        #endregion
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
            SacarInformacionEmpresa(1);
            //CARGAMOS LA IMAGEN DE BASE DE DATOS
            MostrarImagen(pbLogo, txtNombreEmpresa);
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

        private void btnBucaImagen_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog Imagen = new OpenFileDialog();
                Imagen.InitialDirectory = "C://";
                Imagen.Filter = "All files(*.*)|*.*";
                Imagen.FilterIndex = 2;
                Imagen.RestoreDirectory = true;
                if (Imagen.ShowDialog() == DialogResult.OK)
                {
                    this.VariablesGlobales.RutaImagen = Imagen.FileName;
                    pbLogo.ImageLocation = VariablesGlobales.RutaImagen;
                }

            }
            catch (Exception) {
                MessageBox.Show("Error al tratar de abrir la imagen, favor de comunicarse con el administrador del sistema para solucionar este error", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
            {
                MessageBox.Show("El campo clave de seguridad no puede estar vacio para modificar este registro, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClaveSeguridad.Focus();
            }
            else
            {
                //VERIFICAMOS QUE LA CLAVE DE SEGURIDAD INGRESADA S VALIDA
                string Clave = DSSistemaPuntoVentaClinico.Logica.Comunes.SeguridadEncriptacion.Encriptar(txtClaveSeguridad.Text);

                var Validar = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                    Clave,
                    null, 1, 1);
                if (Validar.Count() < 1)
                {
                    MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar e intentarlo nuevamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClaveSeguridad.Text = string.Empty;
                    txtClaveSeguridad.Focus();

                }
                else
                {
                    ActualizarDatos();
                }
            }
        }
    }
}
