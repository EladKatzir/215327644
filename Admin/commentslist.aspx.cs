using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_commentslist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ddltype_SelectedIndexChanged(object sender, EventArgs e)
    {
        comments x = new comments();
        DataSet info = new DataSet();
        x.CommentType = ddltype.SelectedItem.Text;
        info = x.getcommentsbytopic(x);
        grdcm.DataSource = info;
        grdcm.DataBind();
        grdcm.Visible = true;
    }

    protected void btnall_Click(object sender, EventArgs e)
    {
        comments x = new comments();
        DataSet info = new DataSet();
        info = x.getallcomment();
        grdcm.DataSource = info;
        grdcm.DataBind();
    }

    protected void grdcm_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        comments x = new comments();
        DataSet info = new DataSet();
        x.del(x);
        grdcm.DataBind();
    }
}