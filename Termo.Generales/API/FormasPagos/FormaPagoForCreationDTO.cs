using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.API.DTOs
{
    public class FormaPagoForCreationDTO
    {
        [Required]
        public int CodigoFormaPago { get; set; }
        [StringLength(200)]
        public string NombreFormaPago { get; set; }
    }
}
