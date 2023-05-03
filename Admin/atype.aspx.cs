using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_atype : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
        {
            Response.Redirect("~/Admin/alogin.aspx");
        }
    }

    protected void btnuser_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/auser.aspx");
    }

    protected void btnpro_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/apro.aspx");
    }

    protected void btnrev_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/arev.aspx");
    }
}