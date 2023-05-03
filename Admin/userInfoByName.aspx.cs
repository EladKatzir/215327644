using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class userListByName : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
            Response.Redirect("adminlogin.aspx");
        lbleu.Visible = false;
        
    }

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("adminmenu.aspx");
    }

    protected void grdlist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ddlun_SelectedIndexChanged(object sender, EventArgs e)
    {

        users userName = new users();
        DataSet dsname = new DataSet();
        userName.User_Name = ddlun.SelectedItem.Text;
        dsname = userName.userInfoByUsrename(userName);


        if (dsname.Tables[0].Rows.Count > 0)
        {
            grdlist.DataSource = userName.userInfoByUsrename(userName);
            grdlist.DataBind();
        }
        else
            lbleu.Visible = true;
    }
}