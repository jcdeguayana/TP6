using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace TP6.Clases
{
    public class GestionProductos
    {
        public GestionProductos()
        {
        }
        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "Select IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad from Productos");
        }

        public DataTable ObtenerTodosLosProductosYProveedor()
        {
            return ObtenerTabla("Productos", "Select IdProducto,NombreProducto,IdProveedor,PrecioUnidad from Productos");
        }

        private void ArmarParametrosProductoEliminar(ref SqlCommand Comando, Productos productos)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = productos.idProducto;
        }

        private void ArmarParametrosProductos(ref SqlCommand Comando, Productos productos)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = productos.idProducto;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            SqlParametros.Value = productos.nombreProducto;
            SqlParametros = Comando.Parameters.Add("@Cantidad", SqlDbType.NVarChar, 20);
            SqlParametros.Value = productos.cantidad;
            SqlParametros = Comando.Parameters.Add("@Precio", SqlDbType.Money);
            SqlParametros.Value = productos.precio;
        }

        public bool ActualizarProducto(Productos productos)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductos(ref Comando, productos);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }


        public bool EliminarProducto(Productos productos)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductoEliminar(ref Comando, productos);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

    }
}