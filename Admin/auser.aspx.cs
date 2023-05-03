using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_amenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "welcome " + Session["Admin"].ToString();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/homepage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("changeprice.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("offer.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("moviebytype.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("showbytype.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("songbytype.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("userListByGender.aspx");
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("userListByCity.aspx");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        Response.Redirect("userlist.aspx");
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        Response.Redirect("addnewcontent.aspx");
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        Response.Redirect("ratelist.aspx");
    }
}