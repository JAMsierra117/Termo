using System;
using System.Collections.Generic;
using System.Text;

namespace Termo.Generales.API.Impuestos
{
    public class ImpuestoToReturnoDTO
    {
        public int ID_Impuesto { get; set; }
        public string NombreImpuesto { get; set; }        
        public decimal Porcentaje { get; set; }
    }
}
