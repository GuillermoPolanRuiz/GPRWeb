using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GPRWeb.Controlador;

namespace GPRWeb
{
    public partial class _Default : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Controlador.Control control = new Controlador.Control();
            //control.Usuario_SEL("admin");
        }


        protected void Consultar_Click(object sender, EventArgs e)
        {
            this.Consultar(tbUser.Value, tbPass.Value);
        }
    }
}