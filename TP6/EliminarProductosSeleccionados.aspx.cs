using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6
{
    public partial class EliminarProductosSeleccionados : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Limpiar la variable de sesión
            Session["ProductosSeleccionados"] = null;

            // Vaciar el GridView que muestra los productos seleccionados
            GridView1.DataSource = null;
            GridView1.DataBind();
        }
    }
}