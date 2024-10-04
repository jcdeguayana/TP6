using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace TP6.Clases
{
    public class Productos
    {
        private int IdProducto;
        private string NombreProducto;
        private string Cantidad;
        private decimal Precio;

        public Productos()
        {

        }

        public Productos(int IdProducto,string NombreProducto, string Cantidad, decimal Precio)
        {
            this.IdProducto = IdProducto;
            this.NombreProducto = NombreProducto;
            this.Cantidad = Cantidad;
            this.Precio = Precio;

        }

        public int idProducto
        {
            get { return IdProducto; }
            set { IdProducto = value; }
        }

       
        public string nombreProducto
        {
            get { return NombreProducto; }
            set { NombreProducto = value; }
        }

        
        public string cantidad
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        
        public decimal precio
        {
            get { return Precio; }
            set { Precio = value; }
        }

    }
}