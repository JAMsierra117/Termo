using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Termo.Generales.Core
{
    public class Cliente : Entity
    {
        [Key]        
        public int ID_Cliente { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
    }
}
