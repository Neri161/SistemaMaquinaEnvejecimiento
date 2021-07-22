using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using SistemaMaquinaEnvejecimiento.Models;
using SistemaMaquinaEnvejecimiento.Herramientas;

namespace SistemaMaquinaEnvejecimiento.Vistas.MasterPage
{
    public partial class SideBar : System.Web.UI.MasterPage
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["ID"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Usuario usuario = new Usuario
                {
                    IdUsuario = Int32.Parse(Session["ID"].ToString())
                };
                String enviar = JsonConvertidor.Objeto_Json(usuario);
                peticion.PedirComunicacion("Usuario/Consulta", MetodoHTTP.POST, TipoContenido.JSON);
                peticion.enviarDatos(enviar);
                String respuesta = peticion.ObtenerJson();
                Usuario consulta = JsonConvertidor.Json_Objeto<Usuario>(respuesta);
                lblCorreo.Text = consulta.Email;
            }
        }

        protected void btnInicioPrueba_Click(object sender, EventArgs e)
        {
            Response.Redirect("IniciarPrueba.aspx");
        }

        protected void btnHistorialPruebas_Click(object sender, EventArgs e)
        {
            Response.Redirect("HistorialPruebas.aspx");
        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
        protected void lbCerrar_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }

        protected void btnPruebasPublicas_Click(object sender, EventArgs e)
        {
            Response.Redirect("PruebasPublicas.aspx");
        }
    }
}