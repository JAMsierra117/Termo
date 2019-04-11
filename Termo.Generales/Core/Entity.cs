using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Termo.Generales.Core
{
    public class Entity
    {
        [Column(Order = 501)]
        public string Activo { get; set; }
        [Column(Order = 501)]
        public Nullable<int> ID_UsuarioAlta { get; set; }
        [Column(Order = 502)]
        public Nullable<DateTime>  Alta { get; set; }
        [Column(Order = 503)]
        public Nullable<int> ID_UsuarioActualizacion { get; set; }
        [Column(Order = 504)]
        public Nullable<DateTime> Actualizacion { get; set; }
    }
}
