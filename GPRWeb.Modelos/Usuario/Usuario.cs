using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.Modelos.Usuario
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public string DescripciónRol { get; set; }
    }
}
