﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GPRWeb.UI.Inicio
{
    public partial class Inicio : PaginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rMovies.DataSource = this.CargarMovies();
            rMovies.DataBind();
        }
    }
}