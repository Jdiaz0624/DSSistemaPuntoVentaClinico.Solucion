using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DSSistemaPuntoVentaClinico.Data.Conexiones.ConexionADO
{
    public static class BDConexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conexion = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DSPuntoVentaClinico"].ConnectionString);
            Conexion.Open();
            return Conexion;
        }

    }
}
