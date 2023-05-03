using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class addtobasket : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtPay.Text = Session["price"].ToString();
        DataSet dscontent = new DataSet();
        contents contentDT = new contents();
        contentDT.contentsName = Session["name"].ToString();
        contentDT.contentsType = Session["type"].ToString();

        dscontent = contentDT.idbytypeandname(contentDT);
        txtid.Text = dscontent.Tables[0].Rows[0][0].ToString();
    }

    protected void btnCart_Click(object sender, EventArgs e)
    {
        cart addto = new cart();
        addto.UserName = Session["user"].ToString();
        addto.contentsId = txtid.Text;
        addto.Total = txtPay.Text;
        addto.OrderAmount = "1"; //will always be 1 since you can only order a show one time
        addto.addToCart(addto);
        lblsucc.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      
        ServiceReference1.coupon c = new ServiceReference1.coupon();
        c.MainCoupon = txtcoup.Text;
        ServiceReference1.ServiceSoapClient co = new ServiceReference1.ServiceSoapClient();
        co.chkCoupon(c);
        if (co.chkCoupon(c))
        {
            int x = (int.Parse(txtPay.Text)*int.Parse(txtper.Text)) / 100;
            int y = int.Parse(txtPay.Text) - x;
            txtPay.Text = y.ToString();
            Response.Redirect("~/User/addtobasket.aspx");
        }
    }
}