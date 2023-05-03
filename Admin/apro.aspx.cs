using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_apro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/changeprice.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/offer.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/moviebytype.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/showbytype.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/songbytype.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("/Admin/addnewcontent.aspx");
    }
}