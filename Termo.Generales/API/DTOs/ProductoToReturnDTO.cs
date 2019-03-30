using System;
using System.Collections.Generic;
using System.Text;

namespace Termo.Generales.API.DTOs
{
    public class ProductoToReturnDTO
    {
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Linea { get; set; }
        public string Linea { get; set; }
    }
}
