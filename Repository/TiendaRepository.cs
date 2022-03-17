using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Practica1.Models;
using Practica1.Controllers;
using Practica1.Utils;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace Practica1.Repository {
  public class Producto {
    public static List < ProductoModel > obtenerProductos() {
      List < ProductoModel > productos = new List < ProductoModel > ();
      try {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = Global.getConnectionString();
        List < SqlParameter > listaParametro = new List < SqlParameter > {

        };
        List < SqlParameter > listaParametroSalida = new List < SqlParameter > {

        };
        DataTable objetoSalida = ejecucionSP.ExecuteSPWithDataReturn("", listaParametro, con);
        if (objetoSalida.Rows.Count > 0) {
          for (int i = 0; i < objetoSalida.Rows.Count; i++) {
            ProductoModel objeto = new ProductoModel();
            objeto.idProducto = Convert.ToInt32(objetoSalida.Rows[i]["IDPRODUCTO"]);
            objeto.tituloProducto = objetoSalida.Rows[i]["TITULOPRODUCTO"].ToString();
            objeto.precioProducto = Convert.ToDouble(objetoSalida.Rows[i]["PRECIOPRODUCTO"]);
            objeto.fechaIngresoProducto = Convert.ToDateTime(objetoSalida.Rows[i]["INGRESOPRODUCTO"].ToString());
            productos.Add(objeto);

          }
        }

      } catch {

      }
      return productos;
    }
  }

}