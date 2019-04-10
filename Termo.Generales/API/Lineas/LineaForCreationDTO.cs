using System;
using System.Collections.Generic;
using System.Text;

namespace Termo.Generales.API.DTOs
{
    public class LineaForCreationDTO
    {
        public string CodigoLinea { get; set; }
        public string NombreLinea { get; set; }
        public int ID_Padre { get; set; }
        public bool EsHijo { get; set; }
    }
}
