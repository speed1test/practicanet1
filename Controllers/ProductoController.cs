using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using System.Text.RegularExpressions;
using Practica1.Controllers;
using Practica1.Repository;
namespace Practica1.Controllers;

public class Producto : Controller{
    [Route("/Product")]
    public IActionResult VerProductos()
    {
        List<ProductoModel> producto = new List<ProductoModel>();
        producto = Repository.Producto.obtenerProductos();
        ViewBag.producto = producto;
        Console.WriteLine(producto);
        return View("/Views/Product/Index.cshtml");
    }
}