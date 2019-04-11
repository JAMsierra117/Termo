using System;
using System.Collections.Generic;
using System.Text;

namespace Termo.Generales.API.Clientes
{
    public class ClienteToReturnDTO
    {
        public int ID_Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
    }
}
