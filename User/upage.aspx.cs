using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class User_upage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
        Label11.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
        if (Session["genders"]==null || Session["user"]==null)
        {
            Response.Redirect("ulogin.aspx");
        }
        users user = new users();
        user.User_Name = Session["user"].ToString();
        DataSet x = user.photobyuser(user);
        Session["photo"] = x.Tables[0].Rows[0][0].ToString();
        if (Session["genders"].ToString()=="זכר"&& Session["photo"]==null)
        {
            imgavatar.ImageUrl = "../images/maleav.png";
        }
        if (Session["genders"].ToString() == "נקבה" && Session["photo"] == null)
        {
           imgavatar.ImageUrl = "../images/femav.png";
        }
        if(Session["photo"]!=null)
        {
            imgavatar.ImageUrl = Session["photo"].ToString();
        }
    }

    protected void imgavatar_Click(object sender, ImageClickEventArgs e)
    {
        
        FileUpload1.Visible = true;
        btnrefresh.Visible = true;

    }

    protected void btnrefresh_Click(object sender, EventArgs e)
    {
        users user = new users();
        user.User_Name = Session["user"].ToString();
        string filePath = HttpContext.Current.Server.MapPath("~/images/" + FileUpload1.FileName);
        FileUpload1.SaveAs(filePath);
        string fileUpInto = "~/images/" + FileUpload1.FileName;
        user.changephoto(user, fileUpInto);
        Response.Redirect("upage.aspx");
    }
}