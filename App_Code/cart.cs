using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cart
/// </summary>
public class cart
{
    sqlDb sql = new sqlDb();
    //תכונות 
    string userName;
    string contentId;
    string orderAmount;
    string total;

    //public cart(string user,string bid,string ordamount,string tot)
    //{
    //    this.userName = user;
    //    this.contentId = bid;
    //    this.orderAmount = ordamount;
    //    this.total = tot;
    //}

    public string UserName
    {
        get { return this.userName; }
        set { this.userName = value; }
    }
    public string contentsId
    {
        get { return this.contentId; }
        set { this.contentId = value; }
    }
    public string OrderAmount
    {
        get { return this.orderAmount; }
        set { this.orderAmount = value; }
    }
    public string Total
    {
        get { return this.total; }
        set { this.total = value; }
    }
    // פעולה המכניסה לסל 
    public void addToCart(cart ct)
    {

        DataSet ds = new DataSet();

        //שאילתא הבודקת אם בסל יש כבר את קוד המוצר של המשתמש שמבצע הזמנה
        string chkIfExist = "SELECT tblCart.user_Name, tblCart.contentId, tblCart.orderAmount, tblCart.total FROM tblCart WHERE(((tblCart.user_Name) ='" + ct.UserName + "') AND((tblCart.contentId) =" + ct.contentsId + "));";

        //'" + ct.UserName + "') AND((tblCart.contentId) =" + ct.contentId + "));";
        ds = sql.chkData(chkIfExist);
        if (ds.Tables[0].Rows.Count > 0)//אם המוצר קיים בסל יבוצע עידכון יש .לפני השורה הזו שאילתה שמקבלת נתונים והאיפ הזה בודק אם המוצר קיים
        {

            string stUpdCart = "UPDATE tblCart SET tblCart.orderAmount = "+ct.OrderAmount+", tblCart.total = "+ct.Total+" WHERE(((tblCart.user_Name) ='"+ct.UserName+"') AND((tblCart.contentId) ="+ct.contentsId+"));";
            sql.udi(stUpdCart);
        }
        else
        {
            //המוצר לא קיים בסל לכן תבוצע הכנסה רגילה לטבלה
            string stCart = "INSERT INTO tblCart ( user_Name, contentId, orderAmount, total ) VALUES('"+ct.UserName+"', "+int.Parse(ct.contentsId)+", "+int.Parse(ct.OrderAmount)+", "+int.Parse(ct.Total)+");";

            //INSERT INTO tblCart(user_Name,productId,orderAmount,total) VALUES('" +  + "'," + ct.contentsId + "," + ct.OrderAmount + "," + ct.Total + ");";
            sql.udi(stCart);
        }
    }
    // הצגת סל הקניות ע"פ שם משתמש
    public DataSet MyCart(cart user)
    {
        DataSet DSCart = new DataSet();
        string stCart = "SELECT tblCart.user_Name, tblCart.contentId, tblCart.orderAmount, tblCart.total FROM tblCart WHERE(((tblCart.user_Name) = '" + user.userName + "')); ";

        DSCart = sql.chkData(stCart);
        return DSCart;
    }
    //פעולה המוחקת מהסל לאחר תשלום
    public void delFromCart(cart ct)
    {

        string stDel = "DELETE tblCart.user_Name FROM tblCart WHERE(((tblCart.user_Name) ='" + ct.UserName + "'))";
        ;
        sql.udi(stDel);
    }
}