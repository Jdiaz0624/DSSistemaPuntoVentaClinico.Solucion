using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DSSistemaPuntoVentaClinico.Solucion.Pantallas.Pantallas.Prueba
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.InitialDirectory = "C://";
            imagen.Filter = "All files(*.*)|*.*";
            imagen.FilterIndex = 2;
            imagen.RestoreDirectory = true;
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                try {
                    this.textBox1.Text = imagen.FileName;
                    pictureBox1.ImageLocation = textBox1.Text;
                }
                catch (Exception) { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            comando.Parameters["@LogoEmpresa"].Value = ms.GetBuffer();

            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion();
            comando.ExecuteNonQuery();
            DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion().Close();
            MessageBox.Show("Imagen Guardada");
        }
    }
}
