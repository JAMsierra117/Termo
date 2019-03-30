using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.Core
{
    public class Producto
    {
        [Key]
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Linea { get; set; }



        public Linea Linea { get; set; }
    }
}
