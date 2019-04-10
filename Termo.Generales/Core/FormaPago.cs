using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.Core
{
    public class FormaPago
    {
        [Key]
        public int ID_FormaPago { get; set; }
        public int CodigoFormaPago { get; set; }
        [StringLength(200)]
        public string NombreFormaPago { get; set; }

    }
}
