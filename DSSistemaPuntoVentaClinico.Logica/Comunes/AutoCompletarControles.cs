using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DSSistemaPuntoVentaClinico.Logica.Comunes
{
    public class AutoCompletarControles
    {
        public static void AutoCompletarUsuarios(TextBox Usuarios)
        {   //AUTOCOMPLETAR USUARIOS
            SqlCommand comando = new SqlCommand("select Usuario from Seguridad.Usuario where Estatus = 1 and Usuario != 'juan.diaz'", DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion());
            SqlDataReader readr = comando.ExecuteReader();
            while (readr.Read() == true)
            {
                Usuarios.AutoCompleteCustomSource.Add(readr["Usuario"].ToString());
            }
            readr.Close();
        }

        public static void AutoCompletarProductos(TextBox Filtro)
        {
            try {
                SqlCommand comando = new SqlCommand("select Descripcion from Inventario.Producto  where Estatus = 1", DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO.BDConexion.ObtenerConexion());
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read() == true)
                {
                    Filtro.AutoCompleteCustomSource.Add(reader["Descripcion"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error al Autocompletar el producto codigo de eror " + ex.Message, "EROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
