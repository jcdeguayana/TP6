using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP6.Clases;

namespace TP6
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                CargarGridView();
            }
        }

        public void CargarGridView()
        {
            GestionProductos gp = new GestionProductos();
            grdProductos.DataSource = gp.ObtenerTodosLosProductosYProveedor();
            grdProductos.DataBind();

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProducto")).Text;
            String s_Nombre = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblNombre")).Text;
            String s_IdProveedor = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblProveedor")).Text;
            String s_Precio = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lblPrecio")).Text;

            lblMensaje.Text = "Productos agregados: " + s_Nombre ;

            DataTable ProductosSeleccionados;
            if (Session["ProductosSeleccionados"] == null)
            {
                // Si no existe, crear uno nuevo con las columnas correspondientes
                ProductosSeleccionados = new DataTable();
                ProductosSeleccionados.Columns.Add("IdProducto", typeof(string));
                ProductosSeleccionados.Columns.Add("NombreProducto", typeof(string));
                ProductosSeleccionados.Columns.Add("IdProveedor", typeof(string));
                ProductosSeleccionados.Columns.Add("PrecioUnidad", typeof(string));
            }
            else
            {
                // Si existe, obtenerlo de la sesión
                ProductosSeleccionados = (DataTable)Session["ProductosSeleccionados"];
            }

            // Agregar la fila seleccionada al DataTable
            DataRow row = ProductosSeleccionados.NewRow();
            row["IdProducto"] = s_IdProducto;
            row["NombreProducto"] = s_Nombre;
            row["IdProveedor"] = s_IdProveedor;
            row["PrecioUnidad"] = s_Precio;
            ProductosSeleccionados.Rows.Add(row);

            // Guardar el DataTable en la sesión
            Session["ProductosSeleccionados"] = ProductosSeleccionados;
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarGridView();
        }
    }
}