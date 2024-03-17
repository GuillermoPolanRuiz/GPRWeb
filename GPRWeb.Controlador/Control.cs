using GPRWeb.AccesoDatos;
using GPRWeb.Modelos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.AccesoDatos
{
    public class Control
    {
        private DatabaseWeb database;
        public Control()
        {
            database = new DatabaseWeb();
        }

        public Usuario Usuario_SEL(string nombre)
        {
            return database.Usuario_SEL(nombre);
        }
    }
}
