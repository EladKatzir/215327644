using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for movies
/// </summary>
public class movies
{
    sqlDb sql = new sqlDb();
    private string movieid;
    private string moviename;
    private int movielen;
    private string moviegen;
    public string moviecredit;
    private int movierate;
    private string movielink;
    private int movieprice;
    private string moviecover;
    public movies()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public movies(string id,string name,int len,string gen,string cred,int rate,string link,int price)
    {
        this.movieid = id;
        this.moviename = name;
        this.movielen = len;
        this.moviegen = gen;
        this.moviecredit = cred;
        this.movierate = rate;
        this.movielink = link;
        this.movieprice = price;
    }
    public string sgidm
    {
        get { return this.movieid; }
        set { this.movieid = value; }
    }
    public string sgnamem
    {
        get { return this.moviename; }
        set { this.moviename = value; }
    }
    public int sglenm
    {
        get { return this.movielen; }
        set { this.movielen = value; }
    }
    public string sggenm
    { 
        get { return this.moviegen; }
        set { this.moviegen = value; }
    }
    public string sgcredm
    {
        get { return this.moviecredit; }
        set { this.moviecredit = value; }
    }
    public int sgratem
    {
        get { return this.movierate; }
        set { this.movierate = value; }
    }
    public string sglinkm
    {
        get { return this.movielink; }
        set { this.movielink = value; }
    }
    public string sgcoverm
    {
        get { return this.moviecover; }
        set { this.moviecover = value; }
    }
    public int sgpricen
    {
        get { return this.movieprice; }
        set { this.movieprice = value; }
    }
    public DataSet linkbyname(movies cool)
    {
        DataSet dsmovieDt = new DataSet();
        string stmovieDt = "SELECT tblmovies.movieid, tblmovies.moviename, tblmovies.movielink FROM tblmovies WHERE(((tblmovies.moviename) ='"+cool.sgnamem+"'));";

        dsmovieDt = sql.chkData(stmovieDt);
        return dsmovieDt;
    }
    public DataSet getgen()
    {
        DataSet dsmovieDt = new DataSet();
        string stmovieDt = "SELECT tblgen.generename, tblgen.genereId FROM tblgen;";

        dsmovieDt = sql.chkData(stmovieDt);
        return dsmovieDt;
    }
    public DataSet moviebygen(movies cool)
    {
        DataSet dsmovieDt = new DataSet();
        string stmovieDt = "SELECT tblmovies.moviename, tblmovies.movielength, tblgen.generename, tblmovies.moviecredit, tblmovies.movierate, tblmovies.movielink, tblmovies.movieprice, tblmovies.moviecover FROM tblgen INNER JOIN tblmovies ON tblgen.genereId = tblmovies.moviegenere WHERE(((tblgen.generename) ='"+cool.sggenm+"'));";

        //'" + cool.sggens + "'));";

        dsmovieDt = sql.chkData(stmovieDt);
        return dsmovieDt;
    }
    public DataSet moviebyname(movies cool)
    {
        DataSet dsmovieDt = new DataSet();
        string stmovieDt = "SELECT tblmovies.moviename, tblmovies.movielength, tblmovies.moviegenere, tblrate.rate, tblcredit.writername, tblcredit.producername, tblcredit.actorname, tblmovies.movielink, tblmovies.movieprice, tblmovies.moviecover FROM tblrate INNER JOIN (tblcredit INNER JOIN tblmovies ON tblcredit.[creditid] = tblmovies.[moviecredit]) ON tblrate.[ratingId] = tblmovies.[movierate] WHERE(((tblmovies.moviename)='"+cool.sgnamem+"'));";

        //

        //'" + cool.sggens + "'));";

        dsmovieDt = sql.chkData(stmovieDt);
        return dsmovieDt;
    }
    public void newmovie(movies e)
    {

        string stAddepisode = "INSERT INTO tblmovies ( moviename, movielength, moviegenere,moviecredit,movierate,movielink,movieprice,moviecover ) VALUES('" + e.sgnamem + "', " + e.sglenm + ", '" + e.sggenm + "', '" + e.sgcredm + "',"+e.sgratem+",'"+e.sglinkm+"',"+e.sgpricen+",'"+e.sgcoverm+"');";
        sql.udi(stAddepisode);

    }
}