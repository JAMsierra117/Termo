using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.API.DTOs
{
    public class FormaPagoForCreationDTO
    {
        [Required]
        [Range(1, int.MaxValue)]
        public Nullable<int> CodigoFormaPago { get; set; }
        [Required]
        [StringLength(200)]
        public string NombreFormaPago { get; set; }
    }
}
