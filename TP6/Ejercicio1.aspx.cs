using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6.Clases;

namespace TP6
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack==false)
            {
                CargarGridView();
            }
        }

        public void CargarGridView()
        {
            GestionProductos gp = new GestionProductos();
            grdProductos.DataSource = gp.ObtenerTodosLosProductos();
            grdProductos.DataBind();

        }

        //protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        //{
        //    String s_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProducto")).Text;
        //    String s_Nombre = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblNombre")).Text;
        //    String s_Cantidad = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblCantidad")).Text;
        //    String s_Precio = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblPrecio")).Text;

        //    lblMensaje.Text = "Usted selecciono: " + s_IdProducto + " " + s_Nombre + " " + s_Cantidad + " " + s_Precio;
        //}
     

        protected void grdProductos_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            //Busco en el itemtemplate el IDLIBRO

            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_IdProducto")).Text;

            Productos pr = new Productos();
            pr.idProducto = Convert.ToInt32(s_IdProducto);

            GestionProductos gpr = new GestionProductos();
            gpr.EliminarProducto(pr);

            CargarGridView();
        }

        protected void grdProductos_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            CargarGridView();
        }

        protected void grdProductos_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void grdProductos_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            //Buscar los datos del edititemplate
            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_IdProducto")).Text;
            String s_Nombre = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txtNombre")).Text;
            String s_Cantidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txtCantidad")).Text;
            String s_Precio = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txtPrecio")).Text;

            Productos pr = new Productos();
            pr.idProducto = Convert.ToInt32(s_IdProducto);
            pr.nombreProducto = s_Nombre;
            pr.cantidad = s_Cantidad;
            pr.precio = Convert.ToDecimal(s_Precio);

            GestionProductos glibros = new GestionProductos();
            glibros.ActualizarProducto(pr);

            grdProductos.EditIndex = -1;
            CargarGridView();
        }

        protected void grdProductos_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }
}