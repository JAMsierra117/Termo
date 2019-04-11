using System;
using System.Collections.Generic;
using System.Text;

namespace Termo.Generales.API.Impuestos
{
    public class ImpuestoForCreationDTO
    {
        public string NombreImpuesto { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
