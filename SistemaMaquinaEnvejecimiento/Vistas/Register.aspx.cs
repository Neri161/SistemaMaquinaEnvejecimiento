using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using SistemaMaquinaEnvejecimiento.Models;
using SistemaMaquinaEnvejecimiento.Herramientas;

namespace SistemaMaquinaEnvejecimiento.Vistas
{
    public partial class Register : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] != null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nombre = nombre.Text.ToString(),
                ApellidoPaterno = paterno.Text.ToString(),
                ApellidoMaterno = materno.Text.ToString(),
                Email = email.Text.ToString(),
                Contrasenia = herramientas.GetSHA256(pass1.Text.ToString()),
                Date_created =herramientas.convertirEpoch(DateTime.Now)
            };
            String enviar = JsonConvertidor.Objeto_Json(usuario);
            peticion.PedirComunicacion("Usuario/RegistrarUsuario", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(enviar);
            String respuesta = peticion.ObtenerJson();
            Reply consulta = JsonConvertidor.Json_Objeto<Reply>(respuesta);
            if (consulta.result == 0)
            {
                Response.Write("<script>alert('" + consulta.message + "');</script>");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}