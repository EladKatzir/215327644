using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for shows
/// </summary>
public class shows
{
    sqlDb sql = new sqlDb();
    private string showid;
    private string showname;
    private int showlen;
    private string showgen;
    public string showcredit;
    private int showrate;
    private string showlink;
    private int showprice;
    private string showimg;
    public shows()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public shows(string id, string name, int len, string gen, string cred, int rate, string link, int price,string img)
    {
        this.showid = id;
        this.showname = name;
        this.showlen = len;
        this.showgen = gen;
        this.showcredit = cred;
        this.showrate = rate;
        this.showlink = link;
        this.showprice = price;
        this.showimg = img;
    }
    public string sgids
    {
        get { return this.showid; }
        set { this.showid = value; }
    }
    public string sgnames
    {
        get { return this.showname; }
        set { this.showname = value; }
    }
    public int sglens
    {
        get { return this.showlen; }
        set { this.showlen = value; }
    }
    public string sggens
    {
        get { return this.showgen; }
        set { this.showgen = value; }
    }
    public string sgcreds
    {
        get { return this.showcredit; }
        set { this.showcredit = value; }
    }
    public int sgrates
    {
        get { return this.showrate; }
        set { this.showrate = value; }
    }
    public string sglinks
    {
        get { return this.showlink; }
        set { this.showlink = value; }
    }
    public string sgimg
    {
        get { return this.showimg; }
        set { this.showimg = value; }
    }
    public int sgprices
    {
        get { return this.showprice; }
        set { this.showprice = value; }
    }
    public DataSet showbygen(shows cool)
    {
        DataSet dsshowDt = new DataSet();
        string stshowDt = "SELECT tblshows.showname, tblshows.showlength, tblshows.showcredit, tblshows.showrate, tblshows.showprice, tblshows.showcover FROM tblgen INNER JOIN tblshows ON tblgen.genereId = tblshows.showgenere WHERE(((tblgen.generename) ='" + cool.sggens + "'));";

        //'" + cool.sggens + "'));";

        dsshowDt = sql.chkData(stshowDt);
        return dsshowDt;
    }
    public DataSet getgen()
    {
        DataSet dsshowDt = new DataSet();
        string stshowDt = "SELECT tblgen.generename, tblgen.genereId FROM tblgen;";

        dsshowDt = sql.chkData(stshowDt);
        return dsshowDt;
    }
    public DataSet showbyname(shows cool)
    {
        DataSet dsshowDt = new DataSet();
        string stshowDt = "SELECT tblshows.showname, tblshows.showlength, tblgen.generename, tblcredit.writername, tblcredit.producername, tblcredit.actorname, tblrate.rate, tblshows.showprice, tblshows.showcover FROM tblrate INNER JOIN (tblcredit INNER JOIN(tblgen INNER JOIN tblshows ON tblgen.genereId = tblshows.showgenere) ON tblcredit.creditid = tblshows.showcredit) ON tblrate.ratingId = tblshows.showrate WHERE(((tblshows.showname) ='" + cool.sgnames + "'));";

        //

        //'" + cool.sggens + "'));";

        dsshowDt = sql.chkData(stshowDt);
        return dsshowDt;
    }

}
