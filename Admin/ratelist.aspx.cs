using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_ratelist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Admin"] == null)
            Response.Redirect("alogin.aspx");
        userrate x = new userrate();
        DataSet info = new DataSet();
        info = x.getallrate();
        grdrate.DataSource = info;
        grdrate.DataBind();
        DataSet dst = new DataSet();
        dst = x.avgrate();
        txtavg.Text = dst.Tables[0].Rows[0][0].ToString();


    }
}