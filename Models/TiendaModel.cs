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
    public class DetalleModel{
        public int idDetalle {get; set;}
        public ProductoModel fkProductoDetalle {get; set;}
    }
    public class CarritoModel{
        public int idCarrito{get; set;}
        public DetalleModel fkCarritoDetalle {get; set;}
        //public 
    }
    public class CompraModel {
        public int idCompra {get;set;}
        public DetalleModel fkCompraDetalle {get; set;}

    }
}