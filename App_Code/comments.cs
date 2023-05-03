using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for comments
/// </summary>
public class comments
{
    sqlDb sql = new sqlDb();
    private string email;
    private string commentDate;
    private string commentType;
    private string comment1;

    public comments(string mail, string coDate, string coType, string comt)
    {
        this.email = mail;
        this.commentDate = coDate;
        this.commentType = coType;
        this.comment1 = comt;
    }
    public comments()
    {

    }
    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }
    public string CommentDate
    {
        get { return this.commentDate; }
        set { this.commentDate = value; }

    }
    public string CommentType
    {
        get { return this.commentType; }
        set { this.commentType = value; }

    }

    public string Comment1
    {
        get { return this.comment1; }
        set { this.comment1 = value; }

    }
    public void addcomment(comments com)
    {
        string newcom = "INSERT INTO tblComment ( Email, commentDate, commentType,comment1 ) Values('" + com.Email + "','" + com.CommentDate + "','" + com.CommentType + "','" + com.Comment1 + "')";
        //insert into tblComment(mail,time,topic,comment) values()


        sql.udi(newcom);

    }
    //everything down from here need to be adapted to current website.
    //הצגת כל התגובות
    public DataSet getallcomment()
    {
        DataSet dscom = new DataSet();
        string stcom = "SELECT tblComment.Email, tblComment.commentType, tblComment.commentDate, tblComment.comment1 FROM tblComment;";
        dscom = sql.chkData(stcom);
        return dscom;
    }
    // הצגת תגובות עפ סוג התגובה
    public DataSet getcommentsbytopic(comments comtopic)
    {
        DataSet dscom = new DataSet();
        string strcom = "SELECT tblComment.Email, tblComment.commentDate, tblComment.comment1 FROM tblComment WHERE(((tblComment.commentType) ='" + comtopic.CommentType + "'));";
        dscom = sql.chkData(strcom);
        return dscom;
    }
    //מחיקת תגובה
    public void del(comments con)
    {
        string deletecom = "DELETE tblComment.comment FROM tblComment WHERE(((tblComment.comment) ='" + con.Comment1 + "'));";
        sql.udi(deletecom);

    }


}