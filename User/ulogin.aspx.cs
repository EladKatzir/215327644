using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class User_ulogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblsucc.Visible = false;
        Label11.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        users user = new users();
        admin adn = new admin(txtuser.Text, txtpass.Text);
        user.User_Name = txtuser.Text;
        user.Pass = txtpass.Text;
        if (user.login(user))
        {
            Session["user"] = txtuser.Text;
            DataSet x = user.genderbyuser(user);

            Session["genders"] = x.Tables[0].Rows[0][0].ToString();
        }
        else
        {
            lblsucc.Visible = true;

            if (!user.ifexist(user))
                Response.Redirect("ureg.aspx");
        }
        Response.Write("<script language='javascript'>window.alert('you have logged in! go to home page')</script>");
    }

    protected void txtuser_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtpass_TextChanged(object sender, EventArgs e)
    {

    }

    protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("homepage.aspx");
    }
}