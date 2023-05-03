using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_userListByGender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
            Response.Redirect("alogin.aspx");
        lbleu.Visible = false;
        
    }


    protected void ddlgender_SelectedIndexChanged1(object sender, EventArgs e)
    {
       
        users userGender = new users();
        DataSet dsgender = new DataSet();
        userGender.Gender = ddlgender.SelectedItem.Text;
        dsgender = userGender.userlistByGender(userGender);
       

        if (dsgender.Tables[0].Rows.Count > 0)
        {
            grdlist.DataSource = userGender.userlistByGender(userGender);
            grdlist.DataBind();
            txtNumC.Text = grdlist.Rows.Count.ToString();
        }
        else
            lbleu.Visible = true;
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("amenu.aspx");
    }
}