using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_userrate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Write("<script language='javascript'>window.alert('you arent logged in')</script>");
            Response.Redirect("ulogin.aspx");
        }
    }

    protected void btnrate_Click(object sender, EventArgs e)
    {
        if (rblrate.SelectedValue != null)
        {
            userrate add = new userrate();
            add.rates = int.Parse(rblrate.SelectedItem.Text);
            add.users = Session["user"].ToString();
            add.addrate(add);
            lblsucc.Visible = true;
        }
        else
        {
            Response.Write("<script language='javascript'>window.alert('you didnt select any type')</script>");
        }
    }
}