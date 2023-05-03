using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Admin_catalog : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Write("<script language='javascript'>window.alert('you arent logged in')</script>");
            Response.Redirect("ulogin.aspx");
        }
        cblgenere.Enabled = true;
    }

    protected void rbltype_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbltype.SelectedItem.Text == "movies")
        {
            movies a = new movies();
            DataSet dsT = new DataSet();
            dsT = a.getgen();
            string tmp = "";
            cblgenere.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            cblgenere.Items.Add("choose genere");
            for (int i = 11; i < dsT.Tables[0].Rows.Count; i++)
            {
                tmp = dsT.Tables[0].Rows[i][0].ToString();
                cblgenere.Items.Add(tmp);
            }
        }
        if (rbltype.SelectedItem.Text == "shows")
        {
            shows a = new shows();
            DataSet dsT = new DataSet();
            dsT = a.getgen();
            string tmp = "";
            cblgenere.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            cblgenere.Items.Add("choose genere");
            for (int i = 10; i < dsT.Tables[0].Rows.Count; i++)
            {
                tmp = dsT.Tables[0].Rows[i][0].ToString();
                cblgenere.Items.Add(tmp);
            }
        }
        if (rbltype.SelectedItem.Text == "songs")
        {
            songs a = new songs();
            DataSet dsT = new DataSet();
            dsT = a.getgen();
            string tmp = "";
            cblgenere.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            cblgenere.Items.Add("choose genere");
            cblgenere.Items.FindByValue("choose genere").Selected = true;
            for (int i = 1; i < 10; i++)
            {
                tmp = dsT.Tables[0].Rows[i][0].ToString();
                cblgenere.Items.Add(tmp);
            }
        }
        Session["type"] = rbltype.SelectedItem.Text;


    }

    protected void cblgenere_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbltype.SelectedItem.Text == "movies")
        {
            movies a = new movies();
            a.sggenm = cblgenere.SelectedItem.Text;
            DataSet dsT = new DataSet();
            dsT = a.moviebygen(a);
            string tmp = "";
            ddlmovie.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            ddlmovie.Items.Add("choose movie");
            for (int i = 0; i < dsT.Tables[0].Rows.Count; i++)
            {
                tmp = dsT.Tables[0].Rows[i][0].ToString();
                ddlmovie.Items.Add(tmp);
            }
            ddlmovie.Visible = true;
            cblgenere.Enabled = false;

        }
        if (rbltype.SelectedItem.Text == "shows" &&cblgenere.SelectedItem.Text!="")
        {

            shows sa = new shows();
            sa.sggens = cblgenere.SelectedItem.Text;
            DataSet dsTs = new DataSet();
            dsTs = sa.showbygen(sa);
            string tmps = "";
            ddlshow.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            ddlshow.Items.Add("choose show");
            for (int i = 0; i < dsTs.Tables[0].Rows.Count; i++)
            {
                tmps = dsTs.Tables[0].Rows[i][0].ToString();
                ddlshow.Items.Add(tmps);
            }
            ddlshow.Visible = true;

        }
        if (rbltype.SelectedItem.Text == "songs")
        {
            songs soa = new songs();
            soa.sggeny = cblgenere.SelectedItem.Text;
            DataSet dsTso = new DataSet();
            dsTso = soa.songbygen(soa);
            string tmpso = "";
            ddlsong.Items.Clear(); //cbl since i want to later have a show or movie to have two or more genres
            ddlsong.Items.Add("choose show");
            for (int i = 0; i < dsTso.Tables[0].Rows.Count; i++)
            {
                tmpso = dsTso.Tables[0].Rows[i][0].ToString();
                ddlsong.Items.Add(tmpso);
            }
            ddlsong.Visible = true;

        }
    }

    protected void ddlsong_SelectedIndexChanged(object sender, EventArgs e)
    {
        cblgenere.Enabled = false;
        pnlAdd.Visible = true;
        DataSet dssong = new DataSet();
        songs songDT = new songs();
        songDT.sgnamey = ddlsong.SelectedItem.Text;
        dssong = songDT.songbyname(songDT);
        txttype.Text = "songs";
        txtname.Text = dssong.Tables[0].Rows[0][0].ToString();
        txtgen.Text = dssong.Tables[0].Rows[0][3].ToString();
        txtPrice.Text = dssong.Tables[0].Rows[0][8].ToString();
        txtlen.Text = dssong.Tables[0].Rows[0][1].ToString();
        txtcred.Text = dssong.Tables[0].Rows[0][3].ToString() + dssong.Tables[0].Rows[0][4].ToString() + dssong.Tables[0].Rows[0][5].ToString();
        //DataSet dscontent = new DataSet();
        //contents contentDT = new contents();
        //contentDT.contentsName = txtname.Text;
        //contentDT.contentsType = txttype.Text;

        //dscontent = contentDT.idbytypeandname(contentDT);
        //txtid.Text = dscontent.Tables[0].Rows[0][0].ToString();
        if (int.Parse(dssong.Tables[0].Rows[0][6].ToString()) == 1)
        {
            str1.Visible = true;
        }
        if (int.Parse(dssong.Tables[0].Rows[0][6].ToString()) == 2)
        {
            str1.Visible = true;
            str2.Visible = true;
        }
        if (int.Parse(dssong.Tables[0].Rows[0][6].ToString()) == 3)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
        }
        if (int.Parse(dssong.Tables[0].Rows[0][6].ToString()) == 4)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
        }
        if (int.Parse(dssong.Tables[0].Rows[0][6].ToString()) == 5)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
            str5.Visible = false;
        }
        imgcover.ImageUrl = dssong.Tables[0].Rows[0][9].ToString();

        Session["name"] = ddlsong.SelectedItem.Text;
        Session["price"] = txtPrice.Text;
    }

    protected void ddlmovie_SelectedIndexChanged(object sender, EventArgs e)
    {
        cblgenere.Enabled = false;
        pnlAdd.Visible = true;
        DataSet dsmovie = new DataSet();
        movies movieDT = new movies();
        movieDT.sgnamem = ddlmovie.SelectedItem.Text;
        dsmovie = movieDT.moviebyname(movieDT);
        txttype.Text = "movies";
        txtname.Text = dsmovie.Tables[0].Rows[0][0].ToString();
        txtgen.Text = dsmovie.Tables[0].Rows[0][2].ToString();
        txtPrice.Text = dsmovie.Tables[0].Rows[0][8].ToString();
        txtlen.Text = dsmovie.Tables[0].Rows[0][1].ToString();
        //DataSet dscontent = new DataSet();
        //contents contentDT = new contents();
        //contentDT.contentsName = txtname.Text;
        //contentDT.contentsType = txttype.Text;

        //dscontent = contentDT.idbytypeandname(contentDT);
        //txtid.Text = dscontent.Tables[0].Rows[0][0].ToString();
        txtcred.Text = dsmovie.Tables[0].Rows[0][4].ToString() + dsmovie.Tables[0].Rows[0][5].ToString() + dsmovie.Tables[0].Rows[0][6].ToString();
        if (int.Parse(dsmovie.Tables[0].Rows[0][3].ToString()) == 1)
        {
            str1.Visible = true;
        }
        if (int.Parse(dsmovie.Tables[0].Rows[0][3].ToString()) == 2)
        {
            str1.Visible = true;
            str2.Visible = true;
        }
        if (int.Parse(dsmovie.Tables[0].Rows[0][3].ToString()) == 3)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
        }
        if (int.Parse(dsmovie.Tables[0].Rows[0][3].ToString()) == 4)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
        }
        if (int.Parse(dsmovie.Tables[0].Rows[0][3].ToString()) == 5)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
            str5.Visible = true;
        }
        imgcover.ImageUrl = dsmovie.Tables[0].Rows[0][9].ToString();
        Session["name"] = ddlmovie.SelectedItem.Text;
        Session["price"] = txtPrice.Text;
    }

    protected void ddlshow_SelectedIndexChanged(object sender, EventArgs e)
    {
        cblgenere.Enabled = false;
        pnlAdd.Visible = true;
        DataSet dsshow = new DataSet();
        shows showDT = new shows();
        // DataSet dscontent = new DataSet();
        //contents contentDT = new contents();
        showDT.sgnames = ddlshow.SelectedItem.Text;
        dsshow = showDT.showbyname(showDT);
        txttype.Text = "shows";
        txtname.Text = dsshow.Tables[0].Rows[0][0].ToString();
        txtgen.Text = dsshow.Tables[0].Rows[0][2].ToString();
        txtPrice.Text = dsshow.Tables[0].Rows[0][7].ToString();
        txtlen.Text = dsshow.Tables[0].Rows[0][1].ToString();
        txtcred.Text = dsshow.Tables[0].Rows[0][3].ToString() + dsshow.Tables[0].Rows[0][4].ToString() + dsshow.Tables[0].Rows[0][5].ToString();

        //contentDT.contentsName = txtname.Text;
        //contentDT.contentsType = txttype.Text;

        //dscontent = contentDT.idbytypeandname(contentDT);
        //txtid.Text = dscontent.Tables[0].Rows[0][0].ToString();
        if (int.Parse(dsshow.Tables[0].Rows[0][6].ToString()) == 1)
        {
            str1.Visible = true;
        }
        if (int.Parse(dsshow.Tables[0].Rows[0][6].ToString()) == 2)
        {
            str1.Visible = true;
            str2.Visible = true;
        }
        if (int.Parse(dsshow.Tables[0].Rows[0][6].ToString()) == 3)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
        }
        if (int.Parse(dsshow.Tables[0].Rows[0][6].ToString()) == 4)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
        }
        if (int.Parse(dsshow.Tables[0].Rows[0][6].ToString()) == 5)
        {
            str1.Visible = true;
            str2.Visible = true;
            str3.Visible = true;
            str4.Visible = true;
            str5.Visible = false;
        }
        imgcover.ImageUrl = dsshow.Tables[0].Rows[0][8].ToString();
        Session["name"] = ddlshow.SelectedItem.Text;
        Session["price"] = txtPrice.Text;
    }

    protected void btnslc_Click(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            Response.Write("<script language='javascript'>window.alert('you are already signed in')</script>");
            Response.Redirect("ulogin.aspx");
        }
        Response.Redirect("addtobasket.aspx");
    }

    protected void btnCart_Click(object sender, EventArgs e)
    {
        //cart addto = new cart();
        //addto.UserName = Session["user"].ToString();
        //addto.contentsId = txtid.Text;
        //addto.Total = txtPay.Text;
        //addto.addToCart(addto);
        //lblsucc.Visible = true;
    }
}