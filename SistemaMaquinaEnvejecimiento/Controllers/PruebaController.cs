using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SistemaMaquinaEnvejecimiento.Models;

namespace SistemaMaquinaEnvejecimiento.Controllers
{
    public class PruebaController : ApiController
    {
        [ActionName("RegistroPrueba")]
        [HttpPost]
        public Reply RegistroPrueba(Prueba objeto)
        {
            using (DB db = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    db.Prueba.Add(objeto);
                    db.SaveChangesAsync();
                    rp.result = 1;
                    rp.message = "Prueba Registrada";
                    return rp;
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Error Al Registrar Prueba";
                }
                return rp;
            }
        }
    }
}
