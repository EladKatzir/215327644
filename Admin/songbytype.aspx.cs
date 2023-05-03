using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_songbytype : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lble.Visible = false;

    }


    protected void ddlgen_SelectedIndexChanged1(object sender, EventArgs e)
    {
        songs sa = new songs();
        sa.sggeny = ddlgen.SelectedItem.Text;
        DataSet dsTs = new DataSet();
        dsTs = sa.songbygen(sa);
        string tmps = "";
        grdan.DataSource = dsTs;
        grdan.DataBind();
        if (dsTs.Tables[0].Rows.Count > 0)
        {
            grdan.DataSource = dsTs;
            grdan.DataBind();
            grdan.Visible = true;
        }
        else
        {
            lble.Visible = true;
        }
    }

    protected void btns_Click(object sender, EventArgs e)
    {
        songs a = new songs();
        DataSet dsT = new DataSet();
        dsT = a.getgen();
        string tmp = "";
        ddlgen.Items.Clear(); //cbl since i want to later have a song or song to have two or more genres
        ddlgen.Items.Add("choose genere");
        for (int i = 1; i < 10; i++)
        {
            tmp = dsT.Tables[0].Rows[i][0].ToString();
            ddlgen.Items.Add(tmp);
        }
    }
}