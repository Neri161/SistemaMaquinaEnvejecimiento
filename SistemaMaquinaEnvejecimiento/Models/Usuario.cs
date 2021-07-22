using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public String Contrasenia { get; set; }
        public String Token_ { get; set; }
        public String Token_recovery { get; set; }
        public int Date_created { get; set; }
        public int? Date_update { get; set; }
    }
}