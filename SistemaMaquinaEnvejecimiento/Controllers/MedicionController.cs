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
                Reply rp = new Reply();
                try
                {

                    for (int i = 0; i < 10; i++)
                    {
                        db.Medicion.Add(objeto);
                        db.SaveChanges();
                    }
                    rp.result = 1;
                    rp.message = "Registrado";
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
