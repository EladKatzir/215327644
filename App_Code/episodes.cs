using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for episodes
/// </summary>
public class episodes
{
    sqlDb sql = new sqlDb();
    //תכונות
    private int episodeId;
    private int episodenum;
    private int seasonnum;
    private string showfrom;
    private string link;//קוד לקוח
    public episodes(int numbere, string name)
    {
        this.episodenum = numbere;
        this.showfrom = name;
    }
    public episodes(int enumber, int snumber, string show, string links)
    {

    }
    public episodes()
    {
       
    }

    public int gsepisodeId
    {
        get { return this.episodeId; }
        set { this.episodeId = value; }
    }
    public int gsseasonnum
    {
        get { return this.seasonnum; }
        set { this.seasonnum = value; }
    }
    public int gsepisodenum
    {
        get { return this.episodenum; }
        set { this.episodenum = value; }

    }
    public string gsshowfrom
    {
        get { return this.showfrom; }
        set { this.showfrom = value; }
    }
    public string gslink
    {
        get { return this.link; }
        set { this.link = value; }
    }

    // הכנסת תאריך וקוד הלקוח לטבלת הזמנות
    public void insertepisode(episodes e)
    {

        string stAddepisode = "insert into tblepisodes(episodenum,link)values('" + e.episodenum + "','" + e.link + "')";
        sql.udi(stAddepisode);

    }

    public DataSet episodelist(episodes d)
    {
        sqlDb sql = new sqlDb();
        DataSet dslistuser = new DataSet();
        string stListuser = "SELECT tblepisodes.episodenumber FROM tblshows INNER JOIN tblepisodes ON tblshows.showid = tblepisodes.showfrom WHERE(((tblepisodes.seasonnumber) ='" + d.gsseasonnum + "') AND((tblshows.showname) ='" + d.gsshowfrom + "'));";
        dslistuser = sql.chkData(stListuser);
        return dslistuser;

    }
}