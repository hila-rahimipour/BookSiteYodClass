using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SignIn : System.Web.UI.Page
{
    public string regStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null)
        {
            string email = Request.Form["email"];
            string password = Request.Form["password"];
            if (email == "" || email == null || password == "" || password == null)
            {
                regStatus = "שגיאה במילוי המידע";
            }
            else
            {
                string fileName = "DB.mdf";
                string table = "MyTable";
                string selectQuery = "SELECT * FROM " + table + " WHERE email='" + Request.Form["email"] + "' AND password='" + password + "'";
                string query = "SELECT * FROM " + table + " WHERE email='" + Request.Form["email"] + "' AND password='" + password + "' AND isAdmin='True'";
                Session["User"] = null;
                if (MyAdoHelper.IsExist(fileName, query))
                {
                    Session["User"] = "admin";
                    Session["UserEmail"] = email + "";
                    Response.Redirect("Control.aspx");
                }
                else
                {
                    if (MyAdoHelper.IsExist(fileName, selectQuery))
                    {
                        Session["User"] = "user";
                        Session["UserEmail"] = email+""; 
                        Response.Redirect("HomePage.aspx");
                        Session["Active"] = "yes";
                    }
                    else
                    {
                        regStatus = "כתובת דואר אלקטרוני או סיסמה אינם נכונים";
                        Session["User"] = null;
                    }
                }
            }
        }
    }
}