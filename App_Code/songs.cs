using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for songs
/// </summary>
public class songs
{
    sqlDb sql = new sqlDb();
    private string songid;
    private string songname;
    private int songlen;
    private string songgen;
    public string songcredit;
    private int songrate;
    private string songlink;
    private int songprice;
    private string songcover;
    public songs()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public songs(string id, string name, int len, string gen, string cred, int rate, string link, int price, string cover)
    {
        this.songid = id;
        this.songname = name;
        this.songlen = len;
        this.songgen = gen;
        this.songcredit = cred;
        this.songrate = rate;
        this.songlink = link;
        this.songprice = price;
        this.songcover = cover;
    }
    public string sgidy
    {
        get { return this.songid; }
        set { this.songid = value; }
    }
    public string sgnamey
    {
        get { return this.songname; }
        set { this.songname = value; }
    }
    public int sgleny
    {
        get { return this.songlen; }
        set { this.songlen = value; }
    }
    public string sggeny
    {
        get { return this.songgen; }
        set { this.songgen = value; }
    }
    public string sgcredy
    {
        get { return this.songcredit; }
        set { this.songcredit = value; }
    }
    public int sgratey
    {
        get { return this.songrate; }
        set { this.songrate = value; }
    }
    public string sglinky
    {
        get { return this.songlink; }
        set { this.songlink = value; }
    }
    public int sgpricey
    {
        get { return this.songprice; }
        set { this.songprice = value; }
    }
    public string sgcovery
    {
        get { return this.songcover; }
        set { this.songcover = value; }
    }
    public DataSet getgen()
    {
        DataSet dssongDt = new DataSet();
        string stsongDt = "SELECT tblgen.generename, tblgen.genereId FROM tblgen;";

        dssongDt = sql.chkData(stsongDt);
        return dssongDt;
    }
    public DataSet songbygen(songs cool)
    {
        DataSet dssongDt = new DataSet();
        string stsongDt = "SELECT tblsongs.songname, tblgen.generename, tblsongs.songid FROM tblgen INNER JOIN tblsongs ON tblgen.genereId = tblsongs.songgenere WHERE(((tblgen.generename) ='" + cool.sggeny + "'));";

        //'" + cool.sggens + "'));";

        dssongDt = sql.chkData(stsongDt);
        return dssongDt;
    }
    public DataSet songbyname(songs cool)
    {
        DataSet dssongDt = new DataSet();
        string stsongDt = "SELECT tblsongs.songname, tblsongs.songlengthh, tblgen.generename, tblcredit.writername, tblcredit.producername, tblcredit.actorname, tblrate.rate, tblsongs.songlink, tblsongs.songprice, tblsongs.songcover FROM tblrate INNER JOIN (tblcredit INNER JOIN(tblgen INNER JOIN tblsongs ON tblgen.genereId = tblsongs.songgenere) ON tblcredit.creditid = tblsongs.songcredit) ON tblrate.ratingId = tblsongs.songrate WHERE(((tblsongs.songname) ='" + cool.sgnamey + "'));";

        //

        //'" + cool.sggens + "'));";

        dssongDt = sql.chkData(stsongDt);
        return dssongDt;

    }
}