using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addnewcontent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnadd_Click(object sender, EventArgs e)
    {
        contents x = new contents();
        x.contentsName = txtname.Text; ;
        x.contentsPrice = txtprice.Text;
        x.contentsType = ddltype.SelectedItem.Value;
        x.addto(x);
        lblsucc.Visible = true;
    }

    protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
    }
}