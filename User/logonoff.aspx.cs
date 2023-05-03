using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_logonoff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label11.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
        if (Session["user"] != null)
        {
            lbl.Text = "you are already connected  " + Session["user"] + "";
            btn1.Text = "press to log off";
            Session["user"] = null;
        }
        else
        {
            lbl.Text = "you arent connected";
            btn1.Text = "press to log in";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ulogin.aspx");
    }
}