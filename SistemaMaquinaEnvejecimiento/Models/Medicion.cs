using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Medicion
    {
        public int ID { get; set; }
        public float Temperatura { get; set; }
        public float Humedad { get; set; }
        public Boolean EstatusLuz { get; set; }
        public String CicloTrabajo { get; set; }
        public DateTime Fecha { get; set; }
        public int PruebaID { get; set; }
    }
}