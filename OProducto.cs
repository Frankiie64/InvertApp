using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class OProducto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Categoria { get; set; }

        public int Cantidad { get; set; }

        public OProducto(string name,int precio,string categoria)
        {
            Nombre = name;
            Precio = precio;
            Categoria = categoria;
        }

        public OProducto()
        { }

        public OProducto(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

    }
}
