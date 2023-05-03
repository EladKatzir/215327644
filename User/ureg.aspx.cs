using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class User_ureg : System.Web.UI.Page
{
    public bool check()
    {
        bool f = true;
        // בדיקה אם לא היכנסנו נתונים
        if (txtmail.Text == "")
        {
            Response.Write("<script language='javascript'>window.alert('יש להכניס מיי')</script>");
            //txtfname.Text = "יש להכניס שם פרטי";
            txtmail.Focus();
            f = false;

        }
        if (txtlname.Text == "")
        {
            Response.Write("<script language='javascript'>window.alert('יש להכניס שם משפחה')</script>");
            txtlname.Focus();
            f = false;

        }
        //בדיקה אם יש ספרות בשם פרטי
        else
        {
            for (int i = 0; i < txtmail.Text.Length; i++)
                if (txtmail.Text[i] >= '0' && txtmail.Text[i] <= '9')
                {
                    Response.Write("<script language='javascript'>window.alert('יש להכניס אותיות בלבד')</script>");
                    // txtfname.Text = "יש להכניס אותיות בלבד";
                    txtmail.Focus();
                    f = false;
                    i = txtmail.Text.Length;
                }
        }

        return f;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblne.Visible = false;
        lblpe.Visible = false;
        lblunerror.Visible = false;
        bsign.Visible = true;
        bs.Visible = false;
        lblperfect.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string stPhon = ddl3d.SelectedItem.Text + txtphone.Text;
        // int x = System.Convert.ToInt32(ddlc.SelectedItem.Value);

        users User = new users(txtfname.Text, txtlname.Text, txtAddress.Text, ddlc.SelectedItem.Value, ddlg.SelectedItem.Value, stPhon, txtmail.Text, txtuser.Text, txtpass.Text);
        // users user = new users();
        User.User_Name = txtuser.Text;
        if (User.ifexist(User))
        {
            lblunerror.Visible = true;
            bsign.Visible = true;
        }

        else
        {  //מחרוזת השאילתא
            if (check())
            {
                User.newuser();
                lblperfect.Visible = true;
                bs.Visible = true;

            }
        }
        DataSet x = User.genderbyuser(User);

        Session["genders"] = x.Tables[0].Rows[0][0].ToString();
        lblgender.Text = Session["genders"].ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string stPhon = ddl3d.SelectedItem.Text + txtphone.Text;
        // int x = System.Convert.ToInt32(ddlc.SelectedItem.Value);

        users User = new users(txtfname.Text, txtlname.Text, txtAddress.Text, ddlc.SelectedItem.Value, ddlg.SelectedItem.Value, stPhon, txtmail.Text, txtuser.Text, txtpass.Text);
        // users user = new users();
        User.User_Name = txtuser.Text;
        if (User.ifexist(User))
        {
            lblunerror.Visible = true;
            bsign.Visible = true;
        }

        else
        {  //מחרוזת השאילתא
            if (check())
            {
                User.newuser();
                lblperfect.Visible = true;
                bs.Visible = true;
                Response.Redirect("ulogin.aspx");

            }
        }
    }
    protected void bs_Click(object sender, EventArgs e)
    {
        Session["user"] = txtfname.Text;
        Response.Redirect("homepage.aspx");
    }

}
