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
    public partial class Mediciones : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
        herramienta herramientas = new herramienta();
        protected void Page_Load(object sender, EventArgs e)
        {
            peticion.PedirComunicacion("Medicion/ConsultaPorMedicion/" + Request.QueryString["id"].ToString(), MetodoHTTP.GET, TipoContenido.JSON);
            String respuesta = peticion.ObtenerJson();
            if (respuesta != null)
            {
                List<MedicionDTO> listaMedicionDTO = JsonConvertidor.Json_ListaObjeto<MedicionDTO>(respuesta).ToList();

                foreach (MedicionDTO medicion in listaMedicionDTO)
                {
                    medicion.FechaString = herramientas.convertirFecha(medicion.Fecha).ToString();
                }

                gvMedicion.DataSource = listaMedicionDTO;
                gvMedicion.DataBind();
            }
        }
    }
}