using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for admin~
/// </summary>
public class admin
{
    sqlDb sql = new sqlDb();
    //תכונות
    private string adminUser_Name; //שם משתמש
    private string adminPass; //סיסמה

    public admin()
    {
        
    }

    public admin(string aduser, string adpass)
    {
        this.adminUser_Name = aduser;
        this.adminPass = adpass;
    }
    public string AdminUser_Name
    {
        get { return this.adminUser_Name; }
        set { this.adminUser_Name = value; }

    }
    public string AdminPass
    {
        get { return this.adminPass; }
        set { this.adminPass = value; }

    }
    // התחברות מנהל
    public bool login_admin(admin ad)
    {
        DataSet dsAdmin = new DataSet();
        string strAdmin = "SELECT tbAdmin.adminUser, tbAdmin.adminPass FROM tbAdmin WHERE(((tbAdmin.adminUser) ='" + ad.AdminUser_Name + "') AND((tbAdmin.adminPass) ='" + ad.AdminPass + "'));";
        dsAdmin = sql.chkData(strAdmin);
        if (dsAdmin.Tables[0].Rows.Count > 0)
            return true;
        else return false;
    }



}

