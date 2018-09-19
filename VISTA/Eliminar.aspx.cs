using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DATOS.modelo;
using DATOS.daos;
public partial class Eliminar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        PersonaDAO dao = new PersonaDAO();
        Persona p = new Persona();
        p.id = int.Parse(txtId.Text);
        dao.delete(p);
        
    }

    protected void btnEliminar2_Click(object sender, EventArgs e)
    {
        PersonaDAO dao = new PersonaDAO();
        Persona p = new Persona();
        p.id = int.Parse(DropDownList1.SelectedValue);
        dao.delete(p);
        //Actualizar el combo
        DropDownList1.DataBind();
        ClientScript.RegisterStartupScript
            (this.GetType(), "myalert",
            "alert('" + "" + "Se elimino" + "');", true);
        //        Response.Write(" < SCRIPT LANGUAGE = 'JavaScript' > alert('Hello this is an Alert') </ SCRIPT > ");



    }
}