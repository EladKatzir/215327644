using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("contant.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>window.alert('isnt implanted yet')</script>");
        //tbaddedaboutmepage
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ulogin.aspx");
    }

    protected void btnsignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/user/ureg.aspx");
    }

    protected void btsignupp_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>window.alert('isnt implanted yet')</script>");
        //tbaddedsignuppremium
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>window.alert('isnt implanted yet')</script>");
        //tbacontantus
    }
}
