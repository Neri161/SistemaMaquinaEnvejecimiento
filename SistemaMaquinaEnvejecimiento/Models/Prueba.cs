using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaMaquinaEnvejecimiento.Models
{
    public class Prueba
    {
        public int ID { get; set; }
        public String Material { get; set; }
        public int FechaInicio { get; set; }
        public int FechaTermino { get; set; }
        public int UsuarioID { get; set; }
        public List<Medicion> Medicion { get; set; }
    }
}