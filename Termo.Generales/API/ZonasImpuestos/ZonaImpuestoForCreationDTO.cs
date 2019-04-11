using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.API.ZonasImpuestos
{
    public class ZonaImpuestoForCreationDTO
    {
        [Required]
        public string NombreZonaImpuesto { get; set; }
    }
}
