using System;
using System.Collections.Generic;
using System.Text;
using Termo.Generales.API.Helpers;

namespace Termo.Generales.API.Clientes
{
    public class ClienteFiltroParamsDTO :  PaginationParams
    {
        public string NombreCliente { get; set; } = "";
    }
}
