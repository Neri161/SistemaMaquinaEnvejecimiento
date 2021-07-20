using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaMaquinaEnvejecimiento.Vistas.MasterPage
{
    public partial class SideBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInicioPrueba_Click(object sender, EventArgs e)
        {
            Response.Redirect("IniciarPrueba.aspx");
        }

        protected void btnHistorialPruebas_Click(object sender, EventArgs e)
        {

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}