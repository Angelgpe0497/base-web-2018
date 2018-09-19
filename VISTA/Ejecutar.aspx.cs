using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATOS.daos;
public partial class Ejecutar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnEjecutar_Click(object sender, EventArgs e)
    {
        PersonaDAO p = new PersonaDAO();
        p.getAll();
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        Response.Redirect("agregar.aspx");
    }
}