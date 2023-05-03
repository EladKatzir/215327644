using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for users
/// </summary>
public class users
{
    sqlDb sql = new sqlDb();

    //תכונות
    private string fName;  // שם פרטי
    private string lName;//שם משפחה
    private string addres;//כתובת
    private string cityName; //עיר
    private string gender; //מגדר
    private string phoneNumber; //טלפון
    private string mail; //דואר אלקטרוני
    private string user_Name; //שם משתמש
    private string pass; //סיסמה
    private bool prim;
    private DateTime birthday;
    private int balance;
    private string profilepic;

    public users()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public users(string fN, string lN, string aD, string cN, string gE, string pN, string mA, string uN, string pA)
    {
        this.fName = fN;
        this.lName = lN;
        this.addres = aD;
        this.cityName = cN;
        this.gender = gE;
        this.phoneNumber = pN;
        this.mail = mA;
        this.user_Name = uN;
        this.pass = pA;


    }
    public users(string fN, string lN, string aD, string cN, string gE, string pN, string mA, string uN, string pA, bool p, DateTime x, int bal, string pic)
    {
        this.fName = fN;
        this.lName = lN;
        this.addres = aD;
        this.cityName = cN;
        this.gender = gE;
        this.phoneNumber = pN;
        this.mail = mA;
        this.user_Name = uN;
        this.pass = pA;
        this.prim = p;
        this.birthday = x;
        this.balance = bal;
        this.profilepic = pic;

    }
    public string FName
    {
        get { return this.fName; }
        set { this.fName = value; }
    }
    public string LName
    {
        get { return this.lName; }
        set { this.lName = value; }
    }
    public string Addres
    {
        get { return this.addres; }
        set { this.addres = value; }
    }
    public string CityName
    {
        get { return this.cityName; }
        set { this.cityName = value; }

    }
    public string Gender
    {
        get { return this.gender; }
        set { this.gender = value; }

    }
    public string PhoneNumber
    {
        get { return this.phoneNumber; }
        set { this.phoneNumber = value; }

    }
    public string Mail
    {
        get { return this.mail; }
        set { this.mail = value; }

    }
    public string User_Name
    {
        get { return this.user_Name; }
        set { this.user_Name = value; }

    }
    public string Pass
    {
        get { return this.pass; }
        set { this.pass = value; }
    }
    public int bal
    {
        get { return this.balance; }
        set { this.balance = value; }

    }
    public bool primum
    {
        get { return this.prim; }
        set { this.prim = value; }

    }
    public DateTime birth
    {
        get { return this.birthday; }
        set { this.birthday = value; }

    }
    public string pfp
    {
        get { return this.profilepic; }
        set { this.profilepic = value; }

    }

    public bool login(users us)
    {
        DataSet dsUser = new DataSet();
        string stuser = "SELECT tblUsers.User_Name, tblUsers.User_Password FROM tblUsers WHERE(((tblUsers.User_Name) = '" + us.user_Name + "')AND((tblUsers.User_Password) = '" + us.Pass + "')); ";
        dsUser = sql.chkData(stuser);
        if (dsUser.Tables[0].Rows.Count > 0)
        {
            return true;
        }
        else return false;
    }
    // בדיקה אם קיים שם משתמש

    public bool ifexist(users user)
    {
        bool chk = false;
        DataSet dsUser = new DataSet();
        string stuser = "SELECT tblUsers.User_Name FROM tblUsers WHERE(((tblUsers.User_Name) ='" + user.User_Name + "'));";
        dsUser = sql.chkData(stuser);
        if (dsUser.Tables[0].Rows.Count > 0)
            chk = true;
        return chk;
    }
    //הוספת לקוח חדש
    public void newuser()
    {

        {  //מחרוזת השאילתא
            string add = "insert into tblUsers(fName,lName,adress,city,Gender,Phone_Number,mail,User_Name,User_Password) values ('" + FName + "','" + LName + "','" + Addres + "','" + CityName + "','" + Gender + "','" + PhoneNumber + "','" + Mail + "','" + User_Name + "','" + Pass + "')";
            // הפעלת השאילתא
            sql.udi(add);
        }
    } //*need to change quaries, not matching with current website!!!*
    //רשימת משתמשים
    public DataSet userlist()
    {
        sqlDb sql = new sqlDb();
        DataSet dslistuser = new DataSet();
        string stListuser = "SELECT tblUsers.fName, tblUsers.lName, tblUsers.adress, tblUsersGender.Gender, tblUsersCities.CityName, tblUsers.Phone_Number, tblUsers.mail, tblUsers.User_Name, tblUsers.User_Password, tblUsers.premium, tblUsers.balance, tblUsers.birthday FROM tblUsersCities INNER JOIN (tblUsersGender INNER JOIN tblUsers ON tblUsersGender.GenderID = tblUsers.Gender) ON tblUsersCities.CityID = tblUsers.city;";
        dslistuser = sql.chkData(stListuser);
        return dslistuser;
    }

    // רשימת משתמשים עפ עיר
    public DataSet userlistByCity(users cty)
    {

        DataSet dslistcy = new DataSet();
        string stlistcy = "SELECT tblUsers.fName, tblUsers.lName, tblUsers.adress, tblUsersGender.Gender, tblUsersCities.CityName, tblUsers.Phone_Number, tblUsers.mail, tblUsers.User_Name, tblUsers.User_Password, tblUsers.premium, tblUsers.balance, tblUsers.birthday FROM tblUsersCities INNER JOIN (tblUsersGender INNER JOIN tblUsers ON tblUsersGender.GenderID = tblUsers.Gender) ON tblUsersCities.CityID = tblUsers.city WHERE(((tblUsersCities.CityName) ='" + cty.CityName + "'));";

        //'" + cty.CityName + "'));";
        dslistcy = sql.chkData(stlistcy);
        return dslistcy;
    }
    public DataSet userInfoByUsrename(users user)
    {
        sqlDb sqlListuser = new sqlDb();
        DataSet dsuser = new DataSet();
        string stuser = "SELECT tblUsers.fName, tblUsers.lName, tblUsers.adress, tblUsersGender.Gender, tblUsersCities.CityName, tblUsers.Phone_Number, tblUsers.mail, tblUsers.User_Name, tblUsers.User_Password, tblUsers.premium, tblUsers.balance, tblUsers.birthday, tblUsers.profile FROM tblUsersGender INNER JOIN (tblUsersCities INNER JOIN tblUsers ON tblUsersCities.CityID = tblUsers.city) ON tblUsersGender.GenderID = tblUsers.Gender WHERE(((tblUsers.User_Name) ='" + user.user_Name + "')); ";

        //
        dsuser = sql.chkData(stuser);
        return dsuser;
    }
    //פרטי משתמש עפ יוזר
    // רשימת משתמשים עפ מגדר
    public DataSet userlistByGender(users gender)
    {

        DataSet dslistgen = new DataSet();
        string stlistgen = "SELECT tblUsers.fName, tblUsers.lName, tblUsers.adress, tblUsersGender.Gender, tblUsersCities.CityName, tblUsers.Phone_Number, tblUsers.mail, tblUsers.User_Name, tblUsers.User_Password, tblUsers.premium, tblUsers.balance, tblUsers.birthday FROM tblUsersCities INNER JOIN (tblUsersGender INNER JOIN tblUsers ON tblUsersGender.GenderID = tblUsers.Gender) ON tblUsersCities.CityID = tblUsers.city WHERE(((tblUsersGender.Gender) ='" + gender.Gender + "')); ";
        dslistgen = sql.chkData(stlistgen);
        return dslistgen;
    }
    public DataSet genderbyuser(users gender)
    {

        DataSet dslistgen = new DataSet();
        string stlistgen = "SELECT tblUsersGender.Gender FROM tblUsersGender INNER JOIN tblUsers ON tblUsersGender.GenderID = tblUsers.Gender WHERE(((tblUsers.User_Name) ='" + gender.User_Name + "'));";

        dslistgen = sql.chkData(stlistgen);
        return dslistgen;
    }
    public DataSet photobyuser(users photo)
    {

        DataSet dslistgen = new DataSet();
        string stlistgen = "SELECT tblUsers.profile FROM tblUsers WHERE(((tblUsers.User_Name) = '" + photo.User_Name + "')); ";


        dslistgen = sql.chkData(stlistgen);
        return dslistgen;
    }
    public void changephoto(users a, string pic)
    {
        string stry = "UPDATE tblUsers SET tblUsers.profile = '"+pic+"' WHERE(((tblUsers.User_Name) ='"+a.User_Name+"'));";
        sql.udi(stry);
    }
    public DataSet mailbyuser(users mail)
    {

        DataSet dslistgen = new DataSet();
        string stlistgen = "SELECT tblUsers.mail FROM tblUsers WHERE(((tblUsers.User_Name) = '" + mail.User_Name + "')); ";


        dslistgen = sql.chkData(stlistgen);
        return dslistgen;
    }


}
