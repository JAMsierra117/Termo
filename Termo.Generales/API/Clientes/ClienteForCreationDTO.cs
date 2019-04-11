using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Termo.Generales.API.Clientes
{
    public class ClienteForCreationDTO
    {
        [Required]
        public string NombreCliente { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }        
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
    }
}
