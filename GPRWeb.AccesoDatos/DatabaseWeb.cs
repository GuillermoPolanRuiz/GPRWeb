using GPRWeb.AccesoDatos.DateReaders;
using GPRWeb.Modelos.Usuario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.AccesoDatos
{
    public class DatabaseWeb
    {
        private static SqlConnection conexion;
        public DatabaseWeb()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = ConfigurationManager.AppSettings["CadenaConexion"];
        }

        public Usuario Usuario_SEL(string nombre)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand("Usuario_SEL", conexion))
                {
                    SqlParameter parametro = new SqlParameter("@Nombre", nombre);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add(parametro);
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    Usuario usuario = new UsuarioReader().GetReader(reader);
                    conexion.Close();

                    return usuario;
                }
            }
            catch (Exception ex)
            {
                conexion.Close();
                throw;
            }
        }
    }
}
