using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_alogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Labele.Visible = false;
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        admin adn = new admin(txtuser.Text, txtpass.Text);
        if (adn.login_admin(adn))
        {
            Session["Admin"] = txtuser.Text;
            Response.Redirect("~/Admin/atype.aspx");
        }
        else Labele.Visible = true;
    }
}