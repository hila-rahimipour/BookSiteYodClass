using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignUp : System.Web.UI.Page
{
    public string regStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string fName = Request.Form["fName"];
            string lName = Request.Form["lName"];
            string email = Request.Form["email"];
            string fBook = Request.Form["fBook"];
            string fAuthor = Request.Form["fAuthor"];
            string password = Request.Form["password"];
            Session["Active"] = null;
            if ((fName == "") || (lName == "") || (email == "") || (fBook == "") || (fAuthor == "") || (password == ""))
            {
                regStatus = "שגיאה במילוי המידע";
            }
            else
            {
                string fileName = "DB.mdf";
                string table = "MyTable";
                string selectQuery = "SELECT * FROM " + table + " WHERE email='" + Request.Form["email"] + "'";
                if (MyAdoHelper.IsExist(fileName, selectQuery))
                    regStatus = "כתובת הדואר האלקטרוני נמצאת במערכת";
                else
                {
                    string sql = "INSERT INTO MyTable (email, fName, lName, fBook, fAuthor, password, isAdmin)";
                    sql += " VALUES('" + email + "','" + fName + "','" + lName + "','" + fBook + "','" + fAuthor + "','" + password + "','"+"False"+"')";
                    MyAdoHelper.DoQuery(fileName, sql);
                    regStatus = "המידע נקלט בהצלחה";
                    Session["User"] = "user";
                    Session["UserEmail"] = email + "";
                }
            }
        }
    }
}