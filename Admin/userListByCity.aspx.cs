using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userListByCity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Admin"] == null)
            Response.Redirect("alogin.aspx");
        lbleu.Visible = false;
        

    }

    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {

        users userCity = new users(); // יוצר אובייקט מסוג יוסרס 
        userCity.CityName = ddlcity.SelectedItem.Text; //ddlהשם של העיר שווה לשם שנבחר ב
        
        if (userCity.userlistByCity(userCity).Tables[0].Rows.Count > 0)//אם לשאילתה יש תוצאה
        {
            
            grdlist.DataSource = userCity.userlistByCity(userCity);//המקור של כל מה שבגריד טייבל הוא תוצאת השאליתה עבור יוסר סיטי
            grdlist.DataBind(); //הצג
            txtNumC.Text = grdlist.Rows.Count.ToString(); //ספור כמה שורות כאשר כל שורה מייצגת יוסר ככה שמקבלים כמה יוסרס
           
        }
        else
            lbleu.Visible = true;

    }


    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("amenu.aspx");
    }
}