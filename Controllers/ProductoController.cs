using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Practica1.Models;
using System.Text.RegularExpressions;
using Practica1.Controllers;
namespace Practica1.Controllers;

public class Producto : Controller{
    [Route("/Product")]
    public IActionResult VerProductos()
    {

        return View("/Views/Product/Index.cshtml");
    }
}