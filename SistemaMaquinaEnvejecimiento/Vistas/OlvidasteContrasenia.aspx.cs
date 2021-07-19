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
    public partial class OlvidasteContrasenia : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Email = email.Text.ToString()
            };
            String enviar = JsonConvertidor.Objeto_Json(usuario);
            peticion.PedirComunicacion("Usuario/Recuperar", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(enviar);
            String respuesta = peticion.ObtenerJson();
            Reply consulta = JsonConvertidor.Json_Objeto<Reply>(respuesta);
            Response.Write("<script>alert('" + consulta.message + "');</script>");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}