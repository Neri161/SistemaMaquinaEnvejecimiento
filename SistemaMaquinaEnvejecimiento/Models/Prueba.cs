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
    public class PruebaDTO
    {
        [Key]
        public int ID { get; set; }
        public String Material { get; set; }
        public int FechaInicio { get; set; }
        public int FechaTermino { get; set; }
        public String FechaInicioString { get; set; }
        public String FechaTerminoString { get; set; }
        public String Privacidad { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Nombre { get; set; }
    }
}