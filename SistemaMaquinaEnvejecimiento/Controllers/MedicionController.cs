using SistemaMaquinaEnvejecimiento.Herramientas;
using SistemaMaquinaEnvejecimiento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaMaquinaEnvejecimiento.Controllers
{
    public class MedicionController : ApiController
    {

        String urlDomain = "http://localhost:54053";
        herramienta herramientas = new herramienta();
        [ActionName("RegistrarMedicion")]
        [HttpPost]
        public Reply registro(Medicion objeto)
        {
            using (DB db = new DB())
            {
                Medicion medicion = new Medicion();
                Reply rp = new Reply();
                try
                {
                    medicion.Temperatura = objeto.Temperatura;
                    medicion.Humedad = objeto.Humedad;
                    medicion.EstatusLuz = objeto.EstatusLuz;
                    medicion.CicloTrabajo = objeto.CicloTrabajo;
                    medicion.Fecha = herramientas.convertirEpoch(DateTime.Now);
                    medicion.IdPrueba = objeto.IdPrueba;
                    db.Medicion.Add(medicion);
                    db.SaveChanges();                  
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Error";
                }
                return rp;
            }
        }


    }
}
