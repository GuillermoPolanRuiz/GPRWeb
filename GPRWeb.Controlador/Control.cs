﻿using GPRWeb.AccesoDatos;
using GPRWeb.Modelos.Movie;
using GPRWeb.Modelos.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRWeb.Controlador
{
    public class Control
    {
        private DatabaseWeb database;
        private TMDB tmdb;
        public Control()
        {
            database = new DatabaseWeb();
            tmdb = new TMDB();
        }

        public Usuario Usuario_SEL(string nombre, string pass)
        {
            Usuario usuario = database.Usuario_SEL(nombre);
            if (!String.IsNullOrEmpty(usuario.Pass) && usuario.Pass == Security.SecurityControl.Encrypt(pass))
            {
                return usuario;
            }
            return new Usuario();
        }

        public List<Movie> GetTrending()
        {
            return tmdb.GetTrending().Result;
        }
    }
}
