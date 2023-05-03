using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Admin_offer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["Admin"] == null)
        //    Response.Redirect("alogin.aspx");
        lblsucc.Visible = false;
        btnsucc.Visible = false;
        DataSet dss = new DataSet();
        contents tmp = new contents();
        dss = tmp.list(tmp);
        grdMerch.DataSource = dss;
        grdMerch.DataBind();
        //avg
        txtAvg.Text = tmp.Average();
        //Amout
        txtAmount.Text = grdMerch.Rows.Count.ToString();
    }

    protected void btnInc_Click(object sender, EventArgs e)
    {
        contents mtsply = new contents();
        mtsply.GeneralIncreasment(int.Parse(txtPrec.Text));
        lblsucc.Visible = true;
        btnsucc.Visible = true;
    }

    protected void btnDec_Click(object sender, EventArgs e)
    {
        contents mtsply = new contents();
        mtsply.GeneralDecreasment(int.Parse(txtPrec.Text));
        lblsucc.Visible = true;
        btnsucc.Visible = true;
    }

    protected void btnsucc_Click(object sender, EventArgs e)
    {
        Response.Redirect("offer.aspx");
    }

    protected void up_Click(object sender, EventArgs e)
    { 
        //check if exist
        ServiceReference1.coupon c = new ServiceReference1.coupon();
        c.MainCoupon = name.Text;
        c.DiscCoupon = pre.Text;
        ServiceReference1.ServiceSoapClient upd = new ServiceReference1.ServiceSoapClient();
        upd.updCoupon(c);
        grdco.DataBind();
        lbldone.Text = "נעשה, לחץ שוב על הצג קופונים";
        lbldone.Visible = true;

    }

    protected void add_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.coupon c = new ServiceReference1.coupon();
        ServiceReference1.ServiceSoapClient showc = new ServiceReference1.ServiceSoapClient();
        grdco.DataSource=showc.GetAllcoupon();
        grdco.DataBind();
        grdco.Visible = true;
        pnlcoup.Visible = true;
    }

    protected void add_Click1(object sender, EventArgs e)
    {
        ServiceReference1.coupon c = new ServiceReference1.coupon();
        c.MainCoupon = name.Text;
        c.DiscCoupon = pre.Text;
        ServiceReference1.ServiceSoapClient addcoup = new ServiceReference1.ServiceSoapClient();
        addcoup.InsertNewCoupon(c);
        grdco.DataBind();
        lbldone.Text = "נעשה, לחץ שוב על הצג קופונים";
        lbldone.Visible = true;
    }
}