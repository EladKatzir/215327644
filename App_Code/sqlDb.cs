using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for sqlDb
/// </summary>
public class sqlDb
{
    // פעולה המבצעת שליפת נתונים מבסיס הנתונים 
    public DataSet chkData(string sqlstr)
    {
        // connect  ההתחברות לבסיס הנתונים מהמחלקה    
        string connString = myConnect.GetConnectionString();
        OleDbConnection conn = new OleDbConnection(connString);
        OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    // פעולה המבצעת עדכון,מחיקה והכנסה על בסיס הנתונים
    public void udi(string sqlstr)
    {

        string connString = myConnect.GetConnectionString();
        OleDbConnection conn = new OleDbConnection(connString);
        OleDbCommand build = new OleDbCommand(sqlstr, conn);
        conn.Open();
        build.ExecuteNonQuery();
        conn.Close();
    }

}