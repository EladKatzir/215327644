using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class User_contant : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
        txtdate.Text = DateTime.Now.ToString();
        if (Session["user"] != null)
        {
            users user = new users();
            user.User_Name = Session["user"].ToString();
            DataSet tmail = user.mailbyuser(user);
            txtmail.Text = tmail.Tables[0].Rows[0][0].ToString();
            lblwel.Text = "welcome " + Session["user"].ToString() + " whats on your mind today?";
            lblwel.Visible = true;
        }
    }

    protected void btnsend_Click(object sender, EventArgs e)
    {
        if (ddltype.SelectedValue != null)
        {
            comments add = new comments();
            add.CommentType = ddltype.SelectedItem.Text;
            add.Comment1 = txtcomment.Text;
            add.CommentDate = txtdate.Text;
            add.Email = txtmail.Text;
            add.addcomment(add);
            lblsucc.Visible = true;
                }
        else
        {
            Response.Write("<script language='javascript'>window.alert('you didnt select any type')</script>");
        }
            
    }
}