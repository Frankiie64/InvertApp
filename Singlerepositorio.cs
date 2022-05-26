using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public sealed class Singlerepositorio
    {
        public List<OCategoria> listCateg = new List<OCategoria>();

        public List<OProducto> NombreProduct = new List<OProducto>();

        public static Singlerepositorio Instancia { get; } = new Singlerepositorio();
        

        private Singlerepositorio()
        {

        }    
    }    
}

