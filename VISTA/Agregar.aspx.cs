using DATOS.daos;
using DATOS.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        PersonaDAO dao = new PersonaDAO();
        Persona persona = new Persona();
        persona.nombre = txtNombre.Text;
        persona.fecha = Calendar1.SelectedDate;
        dao.insert(persona);
        Response.Redirect("ejecutar.aspx");
    }

    protected void btnRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ejecutar.aspx");
    }
}