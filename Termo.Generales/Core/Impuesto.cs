using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Termo.Generales.Core
{
    public class Impuesto : Entity
    {
        [Key]
        public int ID_Impuesto { get; set; }
        public string NombreImpuesto { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal Porcentaje { get; set; }
    }
}
