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
    public partial class CambioContraseña : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblToken.Text = Request.QueryString["token"].ToString();
        }
        protected void btnCambiar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Contrasenia = herramientas.GetSHA256(pass1.Text.ToString()),
                Token_recovery = lblToken.Text.ToString()
            };
            String enviar = JsonConvertidor.Objeto_Json(usuario);
            peticion.PedirComunicacion("Usuario/CambioContrasenia", MetodoHTTP.POST, TipoContenido.JSON);
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
    }
}