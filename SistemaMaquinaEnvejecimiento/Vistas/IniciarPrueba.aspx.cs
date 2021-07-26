using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using SistemaMaquinaEnvejecimiento.Herramientas;
using SistemaMaquinaEnvejecimiento.Models;

namespace SistemaMaquinaEnvejecimiento.Vistas
{
    public partial class IniciarPrueba : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            Prueba prueba = new Prueba
            {
                Material = txtMaterial.Text.ToString(),
                FechaInicio = herramientas.convertirEpoch(CalendarInicio.SelectedDate),
                FechaTermino = herramientas.convertirEpoch(CalendarFin.SelectedDate) + 86399,
                Privacidad = ddlPrivacidad.SelectedValue,
                IdUsuario = Int32.Parse(Session["ID"].ToString())
            };
            String enviar = JsonConvertidor.Objeto_Json(prueba);
            peticion.PedirComunicacion("Prueba/RegistroPrueba", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(enviar);
            String respuesta = peticion.ObtenerJson();
            Reply consulta = JsonConvertidor.Json_Objeto<Reply>(respuesta);

            if (consulta.result == 0)
            {
                Response.Write("<script>alert('" + consulta.message + "');</script>");
            }
            else
            {
                Response.Write("<script>alert('" + consulta.message + "');</script>");
                //     Response.Redirect("Inicio.aspx");
            }
        }

    }
}