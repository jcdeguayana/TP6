﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ProductosSeleccionados"] != null)
            {
                DataTable ProductosSeleccionados = (DataTable)Session["ProductosSeleccionados"];
                GridView1.DataSource = ProductosSeleccionados;
                GridView1.DataBind();
            }
        }
    }
}