using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class User_homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
        Label1.Text = "welcome guest!";
        if (IsPostBack)
        {
            Session["user"] = null;
        }
        else
        {
            
            if (Session["user"] != null)
                Label1.Text = "welcome " + Session["user"].ToString();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ulogin.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("../User/ureg.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Admin/alogin.aspx");

    }

}