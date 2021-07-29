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
        DB bd = new DB();

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
                    db.SaveChanges();
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

        [ActionName("Consulta")]
        [HttpGet]
        public IQueryable<PruebaDTO> Consulta()
        {
            var consulta = from prueba in bd.Prueba
                           where prueba.Privacidad == "Publico"
                           select new PruebaDTO
                           {
                               ID = prueba.IdPrueba,
                               ApellidoPaterno = prueba.Usuario.ApellidoPaterno,
                               ApellidoMaterno = prueba.Usuario.ApellidoMaterno,
                               Nombre = prueba.Usuario.Nombre,
                               FechaInicio = prueba.FechaInicio,
                               FechaTermino = prueba.FechaTermino,
                               Material = prueba.Material,
                               Privacidad = prueba.Privacidad
                           };

            return consulta;

        }

        [ActionName("ConsultaPorUsuario")]
        [HttpGet]
        public IQueryable<PruebaDTO> ConsultaPorUsuario(int id)
        {
            var consulta = from prueba in bd.Prueba
                           where prueba.IdUsuario == id
                           select new PruebaDTO
                           {
                               ID = prueba.IdPrueba,
                               ApellidoPaterno = prueba.Usuario.ApellidoPaterno,
                               ApellidoMaterno = prueba.Usuario.ApellidoMaterno,
                               Nombre = prueba.Usuario.Nombre,
                               FechaInicio = prueba.FechaInicio,
                               FechaTermino = prueba.FechaTermino,
                               Material = prueba.Material,
                               Privacidad = prueba.Privacidad
                           };

            return consulta;

        }

        [ActionName("ConsultaPrueba")]
        [HttpGet]
        public Prueba ConsultaPrueba()
        {
            Prueba consulta = bd.Prueba.OrderByDescending(x => x.IdPrueba).First();
            return consulta;
        }
    }
}
