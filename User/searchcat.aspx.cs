using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.OleDb;

public partial class User_searchcat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["user"] == null)
        {
            Response.Write("<script language='javascript'>window.alert('you arent logged in')</script>");
            Response.Redirect("ulogin.aspx");
        }
        if (!IsPostBack)
        {
            Timer1.Enabled = true;
            LoadImages();
            pnlAdd.Visible = true;
            
        }
        Image1.Visible = true;
        Image2.Visible = true;

        
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        LoadImages();
    }

    private void LoadImages()
    {
        var imageFolder = Server.MapPath("~/pics/");
        var imageFiles = Directory.GetFiles(imageFolder);
        var random = new Random();

        string imagePath1;
        string imagePath2;
        do
        {
            imagePath1 = imageFiles[random.Next(imageFiles.Length)];
            imagePath2 = imageFiles[random.Next(imageFiles.Length)];
        } while (imagePath1 == imagePath2);

        Image1.ImageUrl = "~/pics/" + Path.GetFileName(imagePath1);
        Image2.ImageUrl = "~/pics/" + Path.GetFileName(imagePath2);
    }

    protected void searchButton_Click(object sender, EventArgs e)
    {
        Image1.Visible = false;
        Image2.Visible = false;
        pnlAdd.Visible = true;
        if (RadioButtonList1.SelectedValue.ToString() == "1")
        {
            DataSet dsmovie = new DataSet();
            movies movieDT = new movies();
            movieDT.sgnamem = searchTextBox.Text;
            dsmovie = movieDT.moviebyname(movieDT);
            txttype.Text = "movies";
            if (dsmovie.Tables[0].Rows[0][0].ToString()=="")
            {
                lblfail.Visible = true;
            }
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
            Session["name"] = searchTextBox.Text;
            Session["price"] = txtPrice.Text;
        }
        if (RadioButtonList1.SelectedValue.ToString() == "2")
        {
            DataSet dssong = new DataSet();
            songs songDT = new songs();
            songDT.sgnamey = searchTextBox.Text;
            dssong = songDT.songbyname(songDT);
            txttype.Text = "songs";
            if(dssong.Tables[0].Rows[0][0].ToString()=="")
            {
                lblfail.Visible = true;
            }
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

            Session["name"] = searchTextBox.Text;
            Session["price"] = txtPrice.Text;
        }
        if (RadioButtonList1.SelectedValue.ToString() == "3")
        {
            DataSet dsshow = new DataSet();
            shows showDT = new shows();
            // DataSet dscontent = new DataSet();
            //contents contentDT = new contents();
            showDT.sgnames = searchTextBox.Text;
            dsshow = showDT.showbyname(showDT);
            txttype.Text = "shows";
            if(dsshow.Tables[0].Rows[0][0].ToString()=="")
            {
                lblfail.Visible = true;
            }
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
            Session["name"] = searchTextBox.Text;
            Session["price"] = txtPrice.Text;
        }
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

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["type"] =RadioButtonList1.SelectedItem.Text;
        searchTextBox.Enabled = true;

    }
}
