using GPRWeb.Modelos.Movie;
using GPRWeb.Modelos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace GPRWeb
{
    public class PaginaBase : Page
    {
        Controlador.Control control;

        public PaginaBase()
        {
            this.control = new Controlador.Control();
        }
        protected bool Consultar(string nombre, string pass)
        {
            Usuario usuario = control.Usuario_SEL(nombre, pass);
            if (usuario.IdUsuario != 0)
            {
                Session["usuario"] = usuario;
                Response.Redirect("UI/Inicio/Inicio.aspx");
            }
            return false;
        }

        protected List<Movie> CargarMovies()
        {
            return control.GetTrending();
        }
    }
}