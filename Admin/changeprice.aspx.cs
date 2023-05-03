using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_changeprice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void rblTy_SelectedIndexChanged(object sender, EventArgs e)
    {
        contents x = new contents();
        x.contentsType = rbl.SelectedItem.Text;
        DataSet gd = new DataSet();
        gd = x.contentbytype(x);
        grdMerch.DataSource = gd;
        grdMerch.DataBind();

    }

    protected void grdMerch_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int RowNumber = Convert.ToInt32(e.CommandArgument);
        pnlChange.Visible = true;
        txtName.Text = grdMerch.Rows[RowNumber].Cells[3].Text;
    }

    protected void btnDec_Click(object sender, EventArgs e)
    {
        contents mtsply = new contents();
        mtsply.contentsName = txtName.Text;
        mtsply.contentsPrice = mtsply.pricebyname(mtsply).Tables[0].Rows[0][0].ToString();
        mtsply.ReductionSpecific(mtsply, int.Parse(txtPrec.Text));
        pnlChange.Visible = true;
        lblsucc.Visible = true;
        btnRefresh.Visible = true;
    }

    protected void btnInc_Click(object sender, EventArgs e)
    {
        contents mtsply = new contents();
        mtsply.contentsName = txtName.Text;
        mtsply.contentsPrice = mtsply.pricebyname(mtsply).Tables[0].Rows[0][0].ToString();
        mtsply.IncreasmentSpecific(mtsply, int.Parse(txtPrec.Text));
        pnlChange.Visible = true;
        lblsucc.Visible = true;
        btnRefresh.Visible = true;
    }

    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        Response.Redirect("Changeprice.aspx");
    }

    protected void grdMerch_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}