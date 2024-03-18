using GPRWeb.Modelos.Usuario;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.AccesoDatos.DateReaders
{
    public class UsuarioReader
    {
        public Usuario GetReader(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Usuario usuario = new Usuario() { 
                    IdUsuario = Convert.ToInt32(reader["IdUsuario"]),
                    Nombre = Convert.ToString(reader["Nombre"]),
                    Pass = Convert.ToString(reader["Pass"]),
                    DescripciónRol = Convert.ToString(reader["DescripcionRol"])
                };
                return usuario;
            }

            return new Usuario();
        }
    }
}
