using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_mycart : System.Web.UI.Page
{
    users user = new users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // .בדיקה אם המשתמש מחובר. במידה ולא מעיף ללוג אין ,שולח להתחברות
            if (Session["user"] == null)
                Response.Redirect("ulogin.aspx");
            date.Text = DateTime.Now.ToString();
            Label11.Text = "current page is: " + System.IO.Path.GetFileName(Request.Url.ToString());
            txtDate.Text = DateTime.Now.ToString();

            var a = Session["user"].ToString();
            user.User_Name = a;
            var b = user.userInfoByUsrename(user);
            grduser.DataSource = b;
            grduser.DataBind();
            cart ct = new cart();
            ct.UserName = a;
            grdcart.DataSource = ct.MyCart(ct);
            grdcart.DataBind();

            // סיכום סך הכל לתשלום ומספר הפריטים שקניתי
            string tmpTotal, tmpAmount;
            int sumTotal = 0, sumAmount = 0;
            for (int i = 0; i < grdcart.Rows.Count; i++)
            {
                tmpAmount = grdcart.Rows[i].Cells[2].Text;
                tmpTotal = grdcart.Rows[i].Cells[3].Text;
                sumAmount += int.Parse(tmpAmount);
                sumTotal += int.Parse(tmpTotal);
            }
            txtTotal.Text = sumTotal.ToString();
            txtNum.Text = sumAmount.ToString();
            Session["tot"] = sumTotal.ToString();
            Session["num"] = sumAmount.ToString();
            //  pnlPay.Visible = false;
            //  btnRecipt.Visible = false;
            for (int i = 0; i < grdcart.Rows.Count; i++)
            {
                grdcart.FooterRow.Cells[2].Text = sumTotal.ToString();
                grdcart.FooterRow.Cells[3].Text = sumAmount.ToString();
            }
        }
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
    }

    protected void btnRecipt_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReciptNew.aspx");
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        pnlPay.Visible = true;
        btnpay.Visible = true;
    }

    protected void txtcvv_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtcardNum_TextChanged(object sender, EventArgs e)
    {

    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        string tokef;

        ServiceReference1.Credit lhC = new ServiceReference1.Credit();
        lhC.Id = txtId.Text;
        lhC.CardNum = txtcardNum.Text;
        tokef = DateTime.Parse(txtex.Text).ToString("dd/MM/yyyy");
        lhC.Expr = tokef;
        lhC.Company = ddlCompany.SelectedItem.Text;
        lhC.Cvv = txtcvv.Text;

        ServiceReference1.ServiceSoapClient chkcard = new ServiceReference1.ServiceSoapClient();

        //chk if cardNum is valid
        if (chkcard.chkCard(lhC))
        {
            lblsucc.Visible = true;
            reciept.Visible = true;
        }

        else
        {
            lblsucc.Text = "not valid";
            lblsucc.Visible = true;
        }
        ////========================================= ארכיון הזמנות - סיום הזמנה ============================
        ////=============================== שלב א =============================================
        ////שליפת קוד משתמש
            users user = new users();
            user.User_Name = Session["user"].ToString();
            // string userid = user.user_id(user);
            orders order = new orders(txtDate.Text, Session["user"].ToString());
            order.OrderDate = date.Text;
            order.Username = Session["user"].ToString();
            //הכנסת תאריך הזמנה וקוד לקוח להזמנה -מס ההזמנה מתקבל אוטומטי באופן מיידי
            order.insertOrder(order);
            //מס ההזמנה האחרון להצגה של הלקוח המזמין
            Session["orderId"] = order.getLastorderId(order); //תוקנה שגיאה שנבעה מחוסר של משתנה בטבלה

            //================================שלב ב ============================================
            //הכנסה מסל הקניות לטבלת פראי הזמנה המשמשת כארכיון
            string conId, orderAmount, total;
            orders orderLine = new orders();
            for (int i = 0; i < grdcart.Rows.Count; i++)
            {
                conId = grdcart.Rows[i].Cells[1].Text;
                orderAmount = grdcart.Rows[i].Cells[2].Text;
                total = grdcart.Rows[i].Cells[3].Text;
            Session["tot"] = total;
            Session["am"] = orderAmount;
                orderLine.insertOrderDetails(Session["orderId"].ToString(), conId, orderAmount, total);

            }
            //=============================שלב ג ==================================================
            //מחיקה מהסל לאחר  התשלום וההעברה לארכיון של פרטי הזמנה

            orders user1 = new orders();// מחיקה עפ קוד המשתמש
            user1.Username = Session["user"].ToString();//קוד המשתמש נישלף בשלב א ומשתמש בו כאן
            orderLine.delFromCart(user1);//קריאה לפעולה עם פרמטר קוד משתמש
            cart ct = new cart();
            ct.UserName = Session["user"].ToString();
            ct.delFromCart(ct);
            lblsucc.Visible = true;
            Session["creditCard"] = txtcardNum.Text;
            pnlPay.Visible = true;
            lblsucc.Visible = true;
            reciept.Visible = true;

       
    }

    protected void btnreturn_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void reciept_Click(object sender, EventArgs e)
    {
        Response.Redirect("reciept.aspx");
    }
}