using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
/// <summary>
/// Summary description for userrate
/// </summary>
public class userrate
{
    sqlDb sql = new sqlDb();
    private string user;
    private int rate;
    public userrate()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public userrate(string name,int num)
    {
        this.user = name;
        this.rate = num;
    }
       public string users
    {
        get { return this.user; }
        set { this.user = value; }

    }
    public int rates
    {
        get { return this.rate; }
        set { this.rate = value; }

    }
    public void addrate(userrate com)
    {
        string newcom = "INSERT INTO tbluserrate ( username, rate) Values('" + com.users + "'," + com.rates + ")";
        sql.udi(newcom);

    }
    public DataSet getallrate()
    {
        DataSet dscom = new DataSet();
        string stcom = "SELECT tbluserrate.username, tbluserrate.Rate FROM tbluserrate;";
        dscom = sql.chkData(stcom);
        return dscom;
    }
    public DataSet avgrate()
    {
        DataSet dscom = new DataSet();
        string stcom = "SELECT Avg(tbluserrate.rate) AS Avgמתוךrate FROM tbluserrate;";
        dscom = sql.chkData(stcom);
        return dscom;
    }
}