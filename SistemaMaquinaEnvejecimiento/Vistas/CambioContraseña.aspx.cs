using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using SistemaMaquinaEnvejecimiento.Models;

namespace SistemaMaquinaEnvejecimiento.Vistas
{
    public partial class CambioContraseña : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:54053/");
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}