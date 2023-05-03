using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class User_reciept : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["creditCard"] == null)
        {
            Response.Redirect("mycart.aspx");
        }
        if (!IsPostBack)
        {
            DataSet dsrecipt = new DataSet();
            orders x = new orders();
            x.OrderId = Session["orderId"].ToString();
            dsrecipt = x.getorderbyid(x);

            //string strecipt = "SELECT tblcontent.contectId, tblcontent.contentname, tblcontent.contentprice, tblSubOrders.Total, tblSubOrders.orderAmount FROM tblOrders INNER JOIN (tblcontent INNER JOIN tblSubOrders ON tblcontent.contectId = tblSubOrders.contentId) ON tblOrders.OrderId = tblSubOrders.orderId WHERE(((tblOrders.OrderId) ='"+ Session["orderId"] + "'));";
            //dsrecipt = sqlrecipt.chkData(strecipt);
            grdrec.DataSource = dsrecipt.Tables[0];
            grdrec.DataBind();

            credit.Text = Session["creditCard"].ToString();
            orderid.Text = Session["orderId"].ToString();
            amount.Text = Session["am"].ToString();
            price.Text = Session["tot"].ToString();
            txtDate.Text = DateTime.Now.ToString();

        }
    }

    protected void imgeye_Click(object sender, ImageClickEventArgs e)
    {
        
        if(!credit.Text.Contains("*"))
        {
            imgeye.ImageUrl = "~/images/eyec.png";
            credit.Text = "***********";

        }
        else
        {
            credit.Text = Session["creditCard"].ToString();
            imgeye.ImageUrl = "~/images/eyeo.png";
           
        }
    }

    protected void print_Click(object sender, EventArgs e)
    {
        Response.Write("<script language='javascript'>window.print()</script>");
    }
}