using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.API.DTOs
{
    public class FormaPagoToReturnDTO
    {
        [Key]
        public int ID_FormaPago { get; set; }
        public int CodigoFormaPago { get; set; }
        [StringLength(200)]
        public string NombreFormaPago { get; set; }
    }
}
