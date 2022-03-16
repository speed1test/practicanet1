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
}