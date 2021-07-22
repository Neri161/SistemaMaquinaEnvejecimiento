using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Prueba
    {
        [Key]
        public int IdPrueba { get; set; }
        public String Material { get; set; }
        public int FechaInicio { get; set; }
        public int FechaTermino { get; set; }
        public String Privacidad { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}