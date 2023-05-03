using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for orders
/// </summary>
public class orders
{
    sqlDb sql = new sqlDb();
    //תכונות
    private string orderId;
    private string orderDate; //תאריך הזמנה
    private string username; //קוד לקוח
    public orders(string ordate, string user)
    {
        this.orderDate = ordate;
        this.username = user;
    }
    public orders()
    {

    }

    public string OrderId
    {
        get { return this.orderId; }
        set { this.orderId = value; }

    }
    public string OrderDate
    {
        get { return this.orderDate; }
        set { this.orderDate = value; }

    }
    public string Username
    {
        get { return this.username; }
        set { this.username = value; }
    }

    // הכנסת תאריך וקוד הלקוח לטבלת הזמנות
    public void insertOrder(orders ord)
    {

        string stAddOrder = "insert into tblOrders(orderDate,user_Name)values('" + ord.OrderDate + "','" + ord.Username + "')";
        sql.udi(stAddOrder);

    }
    //יש לשלוף מטבלת הזמנות את מספר ההזמנה הנוכחי והאחרון של מזמין ההזמנה
    public string getLastorderId(orders user)
    {

        string stOrderId = "SELECT Last(tblOrders.orderId) AS LastOforderId FROM tblOrders GROUP BY tblOrders.user_Name HAVING(((tblOrders.user_Name) ='" + user.Username + "'));        ";
        DataSet dsorderId = new DataSet();
        dsorderId = sql.chkData(stOrderId);
        string lastordid = dsorderId.Tables[0].Rows[0][0].ToString();
        return lastordid;
    }
    //הכנסת פרטי הספרים לטבלת פרטי הזמנות
    public void insertOrderDetails(string orderid, string bookid, string quantitiy, string tot)
    {
        string stinsert = "insert into tblSubOrders(orderId,contentId,orderAmount,Total)values('" + orderid + "','" + bookid + "','" + quantitiy + "','" + tot + "')";
        sql.udi(stinsert);

    }
    // מחיקה מהסל את הספרים של המשתמש לאחר ששולם עליהם
    public void delFromCart(orders user)
    {

        string stDel = "DELETE tblShoppingcart.user_Name FROM tblShoppingcart WHERE(((tblShoppingcart.user_Name) ='" + user.Username + "'));        ";
        sql.udi(stDel);

    }

    // הצגת ההזמנה לקבלה למשתמש

    //public DataSet getOrderByOrderId(orders orderid)

    //{
    //    DataSet dsorder = new DataSet();
    //    string storder = "SELECT tblSuborders.bookId, tblBooks.bookName, tblBooks.bookprice, tblBooksType.bookTypename, tblSuborders.oederAmount, tblSuborders.total FROM tblBooksType INNER JOIN(tblBooks INNER JOIN(tblOrders INNER JOIN tblSuborders ON tblOrders.orderId = tblSuborders.orderId) ON tblBooks.bookId = tblSuborders.bookId) ON tblBooksType.bookTypeid = tblBooks.bookType WHERE(((tblOrders.orderId) = " + orderid.OrderId + ")); ";

    //    '" + orderid.OrderId + "')); ";
    //    dsorder = sql.chkData(storder);
    //    return dsorder;

    //}


    public DataSet getorderbyid(orders ne)
    {
        DataSet i = new DataSet();
        string s = "SELECT tblcontent.contectId, tblcontent.contentname, tblcontent.contentprice, tblSubOrders.Total, tblSubOrders.orderAmount FROM tblOrders INNER JOIN (tblcontent INNER JOIN tblSubOrders ON tblcontent.contectId = tblSubOrders.contentId) ON tblOrders.OrderId = tblSubOrders.orderId WHERE(((tblOrders.OrderId) =" + ne.OrderId+ "));";
        i = sql.chkData(s);
        return i;
    }
}