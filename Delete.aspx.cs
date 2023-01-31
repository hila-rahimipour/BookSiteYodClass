using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Delete : System.Web.UI.Page
{
    public string regStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Response.Redirect("Denied.aspx");
        else
        {
            if (Request.Form["submit"] != null)
            {
                string email = Request.Form["email"];
                string password = Request.Form["pass"];
                string tableName = "MyTable";
                string fileName = "DB.mdf";
                if (email == "" || password == "")
                {
                    regStatus = "שגיאה בקבלת המידע";
                }
                else
                {
                    string select = "SELECT * FROM " + tableName + " WHERE email='" + email + "' AND password='" + password + "'";
                    if (MyAdoHelper.IsExist(fileName, select))
                    {
                        string sql = "DELETE FROM " + tableName + " WHERE email='" + email + "' AND password='" + password + "'";
                        MyAdoHelper.DoQuery(fileName, sql);
                        regStatus = "המשתמש שלך נמחק בהצלחה";
                    }
                    else
                        regStatus = "המשתמש שהזנת לא קיים";
                }
            }
        }
    }
}