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
    public partial class PruebasPublicas : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ID"] == null)
                Response.Redirect("Login.aspx");

            peticion.PedirComunicacion("Prueba/Consulta", MetodoHTTP.GET, TipoContenido.JSON);
            String respuesta = peticion.ObtenerJson();
            if (respuesta!=null)
            {
                List<PruebaDTO> listaPruebaDTO = JsonConvertidor.Json_ListaObjeto<PruebaDTO>(respuesta).ToList();

                foreach (PruebaDTO prueba in listaPruebaDTO)
                {
                    prueba.FechaInicioString = herramientas.convertirFecha(prueba.FechaInicio).ToString();
                    prueba.FechaTerminoString = herramientas.convertirFecha(prueba.FechaTermino).ToString();
                    prueba.Nombre = prueba.ApellidoPaterno + " " + prueba.ApellidoMaterno + " " + prueba.Nombre;
                }

                gvPrueba.DataSource = listaPruebaDTO;
                gvPrueba.DataBind();
            }
        }

        protected void gvPrueba_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "mediciones")
            {
                int crow = Convert.ToInt32(e.CommandArgument.ToString());
                string id = gvPrueba.Rows[crow].Cells[0].Text;
                Response.Redirect("Mediciones.aspx?id="+id);
            }
        }
    }
}