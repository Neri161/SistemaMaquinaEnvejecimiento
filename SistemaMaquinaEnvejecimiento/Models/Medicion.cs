using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Medicion
    {
        [Key]
        public int IdMedicion { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public Boolean EstatusLuz { get; set; }
        public String CicloTrabajo { get; set; }
        public int Fecha { get; set; }
        public int IdPrueba { get; set; }
        public virtual Prueba Prueba { get; set; }
    }
}