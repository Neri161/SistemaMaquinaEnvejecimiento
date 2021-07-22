using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using SistemaMaquinaEnvejecimiento.Herramientas;
using SistemaMaquinaEnvejecimiento.Models;


namespace SistemaMaquinaEnvejecimiento.Controllers
{
    public class UsuarioController : ApiController
    {
        String urlDomain = "http://localhost:54053";
        herramienta herramientas = new herramienta();
        [ActionName("RegistrarUsuario")]
        [HttpPost]
        public Reply registro(Usuario objeto)
        {
            using (DB db = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    var lst = db.Usuario.Where(x => x.Email == objeto.Email);
                    if (lst.Count() < 1)
                    {
                        db.Usuario.Add(objeto);
                        db.SaveChanges();
                        rp.result = 1;
                        rp.message = "Usuario Insertado";
                        return rp;
                    }
                    else
                    {
                        rp.result = 0;
                        rp.message = "El usuario ya existe!";
                    }
                    return rp;
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Error Al insertar Usuario";
                }
                return rp;
            }
        }

        [ActionName("InicioSesion")]
        [HttpPost]
        public Reply login(Usuario objeto)
        {
            using (DB conectar = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    Usuario usuarioObtenido = conectar.Usuario.Where(x => x.Email == objeto.Email).First();
                    if (usuarioObtenido.Email == objeto.Email)
                    {
                        if (usuarioObtenido.Contrasenia == objeto.Contrasenia)
                        {
                            rp.result = 1;
                            rp.data = Guid.NewGuid().ToString();
                            rp.message = "BIENVENIDOO";
                            rp.ID = usuarioObtenido.IdUsuario;
                            usuarioObtenido.Token_ = (String)rp.data;
                            conectar.Entry(usuarioObtenido).State = System.Data.Entity.EntityState.Modified;
                            conectar.SaveChanges();
                            return rp;
                        }
                        else
                        {
                            rp.result = 0;
                            rp.message = "Datos incorrectos";
                            return rp;
                        }
                    }
                    else
                    {
                        rp.result = 0;
                        rp.message = "El usuario no existe!!";
                        return rp;
                    }
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Ha ocurrido un error";
                    return rp;
                }
            }

        }

        [ActionName("Recuperar")]
        [HttpPost]
        public Reply Recuperar(Usuario objeto)
        {
            using (DB conectar = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    Usuario usuarioObtenido = conectar.Usuario.Where(x => x.Email == objeto.Email).First();
                    if (usuarioObtenido.Email == objeto.Email)
                    {
                        String token = herramientas.GetSHA256(Guid.NewGuid().ToString());
                        rp.result = 1;
                        rp.data = token;
                        rp.message = "Correo Enviado, Favor De Revisarlo";
                        usuarioObtenido.Token_recovery = (String)rp.data;
                        conectar.Entry(usuarioObtenido).State = System.Data.Entity.EntityState.Modified;
                        conectar.SaveChanges();
                        SendEmail(usuarioObtenido.Email, token);
                        return rp;
                    }
                    else
                    {
                        rp.result = 0;
                        rp.message = "El usuario no existe!!";
                        return rp;
                    }
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Ha ocurrido un error";
                    return rp;
                }
            }

        }

        [ActionName("CambioContrasenia")]
        [HttpPost]
        public Reply CambioContrasenia(Usuario objeto)
        {
            using (DB conectar = new DB())
            {
                Reply rp = new Reply();
                try
                {
                    Usuario usuarioObtenido = conectar.Usuario.Where(x => x.Token_recovery == objeto.Token_recovery).First();
                    if (usuarioObtenido.Token_recovery == objeto.Token_recovery)
                    {
                        usuarioObtenido.Contrasenia = objeto.Contrasenia;
                        rp.result = 1;
                        rp.message = "Contraseña Cambiada";
                        usuarioObtenido.Token_recovery = "";
                        usuarioObtenido.Date_update = herramientas.convertirEpoch(DateTime.Now);
                        conectar.Entry(usuarioObtenido).State = System.Data.Entity.EntityState.Modified;
                        conectar.SaveChanges();
                        return rp;
                    }
                    else
                    {
                        rp.result = 0;
                        rp.message = "El usuario no existe!!";
                        return rp;
                    }
                }
                catch (Exception ex)
                {
                    rp.result = 0;
                    rp.message = "Ha ocurrido un error";
                    return rp;
                }
            }

        }
        [ActionName("Consulta")]
        [HttpPost]
        public Usuario Consulta(Usuario objeto)
        {
            using (DB conectar = new DB())
            {
                try
                {
                    Usuario usuarioObtenido = conectar.Usuario.Where(x => x.IdUsuario == objeto.IdUsuario).First();
                    if (usuarioObtenido.IdUsuario == objeto.IdUsuario)
                    {
                        return usuarioObtenido;
                    }
                    else {
                        return objeto;
                    }
                }
                catch (Exception ex)
                {
                    return objeto;
                }
            }

        }
        private void SendEmail(string EmailDestino, string token)
        {
            String EmailOrigen = "neriesperon2001@gmail.com";
            String Contraseña = "kdhdnwoanzuascgb";
            string url = urlDomain + "/Vistas/CambioContraseña.aspx?token=" + token;
            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, "Recuperación de contraseña",
                "<p>Correo para recuperación de contraseña</p><br>" +
                "<a href='" + url + "'>Click para recuperar</a>");

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();
        }
    }
}
