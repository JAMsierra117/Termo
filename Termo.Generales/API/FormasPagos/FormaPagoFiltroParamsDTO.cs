using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.API.Helpers;

namespace Termo.Generales.API.FormasPagos
{
    public class FormaPagoFiltroParamsDTO : PaginationParams
    {
        public string NombreFormaPago { get; set; } = "";        
    }
}
