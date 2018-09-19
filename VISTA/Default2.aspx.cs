using DATOS.daos;
using DATOS.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
       
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        PersonaDAO dao = new PersonaDAO();
        Persona p = new Persona();
        
        p.id = int.Parse(e.Values[0].ToString());
        dao.delete(p);
    }
}