using System.Collections.Concurrent;
using System;
using System.ComponentModel.DataAnnotations;
namespace Practica1.Models
{
    public class ProductoModel{
        public int idProducto {get; set;}
        public string tituloProducto{get; set;}
        public double precioProducto{get;set;}
    }
    public class CateogoriaModel{
        public int idCategoria{get;set;}
        public string tituloCategoria{get;set;}
        public string descripcionCategoria{get;set;}

    }
}