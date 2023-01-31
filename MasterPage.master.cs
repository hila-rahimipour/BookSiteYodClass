using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string regStatus;
    public string Count="כניסות לאתר: ";
    public string User;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null || Session["User"] == "")
        {
            regStatus = "<li><a href='SignUp.aspx'><b>הרשמה</b></a></li>" +
               "<li><a href='SignIn.aspx'><b>כניסה</b></a></li>";
        }
        if (Session["User"] == "user")
        {
            regStatus= "<li><a href='DarkestMinds.aspx'><b>|מוחות אפלים|</b></a></li> " +
                 "<li><a href='OneOfUsIsLying.aspx'><b>| אחד מאיתנו משקר|</b></a></li>" +
                 "<li><a href= 'IllBeThere.aspx'><b>| אני אהיה שם|</b></a></li>" +
                 "<li><a href= 'TaleOfMagic.aspx'><b>| סיפור של קסם|</b></a></li>" +
                "<li><a href='ChangeAuthor.aspx'><b>|שינוי סופר אהוב|</b></a></li>" +
                "<li><a href='ChangeBook.aspx'><b>|שינוי ספר אהוב|</b></a></li>" +
                "<li><a href='ChangePass.aspx'><b>|שינוי סיסמה|</b></a></li>" +
                "<li><a href='Delete.aspx'><b>|מחיקת משתמש|</b></a></li>"+ 
                "<li><a href='Survey.aspx'><b>|סקר השבוע|</b></a></li>"+
                "<li><a href='Trivia.aspx'><b>|טריוויה|</b></a></li>" +
                "<li><a href='EditUser.aspx'><b>|עריכת נתונים|</b></a></li>" +
                "<li><a href='LogOut.aspx'><b><u>|התנתקות|</u></b></a></li>";
        }
        if (Session["User"] == "admin")
        {
            regStatus = "<li><a href='DarkestMinds.aspx'><b>|מוחות אפלים|</b></a></li> " +
                 "<li><a href='OneOfUsIsLying.aspx'><b>| אחד מאיתנו משקר|</b></a></li>" +
                 "<li><a href= 'IllBeThere.aspx'><b>| אני אהיה שם|</b></a></li>" +
                 "<li><a href= 'TaleOfMagic.aspx'><b>| סיפור של קסם|</b></a></li>" +
                 "<li><a href='ChangeAuthor.aspx'><b>|שינוי סופר אהוב|</b></a></li>" +
                 "<li><a href='ChangeBook.aspx'><b>|שינוי ספר אהוב|</b></a></li>" +
                 "<li><a href='ChangePass.aspx'><b>|שינוי סיסמה|</b></a></li>" +
                 "<li><a href='Delete.aspx'><b>|מחיקת משתמש|</b></a></li>" +
                 "<li><a href='Survey.aspx'><b>|סקר השבוע|</b></a></li>" +
                 "<li><a href='Trivia.aspx'><b>|טריוויה|</b></a></li>" +
                 "<li><a href='EditUser.aspx'><b>|עריכת נתונים|</b></a></li>" +
                 "<li><a href='LogOut.aspx'><b><u>|התנתקות|</u></b></a></li>" +
                 "</ul><ul><li><a href='Control.aspx'><b>|פאנל ניהול|</b></a></li>" +
                 "<li><a href='CountDataAuthor.aspx'><b>|ספירת משתמשים לפי סופר אהוב|</b></a></li>" +
                 "<li><a href='CountDataBook.aspx'><b>|ספירת משתמשים לפי ספר אהוב|</b></a></li>"+
                 "<li><a href='SearchByAuthor.aspx'><b>|חיפוש לפי סופר|</b></a></li>"+
                 "<li><a href='SearchByBook.aspx'><b>|חיפוש לפי ספר|</b></a></li>"+
                 "<li><a href='SearchByEmail.aspx'><b>|חיפוש לפי אימייל|</b></a></li>"+
                 "<li><a href='SearchByEmail2.aspx'><b>|חיפוש לפי קידומת|</b></a></li>" +
                 "<li><a href='ShowAllData.aspx'><b>|הצגת כל המשתמשים|</b></a></li>"; 
        }
        if (Session["user"]!=null && Session["user"] != "")
            User = "את/ה מחובר/ת לאתר";
        else
            User = "את/ה לא מחובר/ת לאתר";
        if (Session["firstLog"] == null)
        {
            Application.Lock();
            if (Application["myCount"] == null)
            {
                Application["myCount"] = 0;
            }
            Application["myCount"] = (int)Application["myCount"] + 1;
            Application.UnLock();
            Session["firstLog"] = "no";
        }
        Count += Application["myCount"].ToString();
    }
}
