using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public String Contrasenia { get; set; }
        public String Token_ { get; set; }
        public String Token_recovery { get; set; }
        public DateTime Date_created { get; set; }
        public DateTime Date_update { get; set; }
        public List<Prueba> Prueba { get; set; }
    }
}