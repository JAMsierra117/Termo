using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.Core
{
    public class ZonaImpuesto : Entity
    {
        [Key]
        public int ID_ZonaImpuesto { get; set; }
        public string NombreZonaImpuesto { get; set; }
    }
}
