using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Bind_GridView_With_XML();
    }
    private void Bind_GridView_With_XML()
    {
        DataSet ds = new DataSet();

        ds.ReadXml(MapPath("~/xml/XMLFILE1.xml"));

        // BIND THE DataSet WITH GRIDVIEW.

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}