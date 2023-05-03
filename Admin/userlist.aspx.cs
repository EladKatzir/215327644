using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_userlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
            Response.Redirect("alogin.aspx");
        users us = new users();
        grdlist.DataSource = us.userlist();
        grdlist.DataBind();
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("amenu.aspx");
    }
}