using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangePass : System.Web.UI.Page
{
    public string regStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Response.Redirect("Denied.aspx");
        else
        {
            string FileName = "MyDB.mdf";
            string TableName = "MyTable";
            string SelectQuery = "";
            string sql = "";
            string email = Request.Form["email"];
            string password = Request.Form["passO"];
            string NewPassword = Request.Form["passN"];
            if (Request.Form["submit"] != null)
            {
                SelectQuery = "SELECT * FROM " + TableName + " WHERE email='" + email + "' AND password='" + password + "'";
                sql = "UPDATE " + TableName + " SET password='" + NewPassword + "' WHERE email='" + email + "' AND password='" + password + "'";
                if (MyAdoHelper.IsExist(FileName, SelectQuery))
                {
                    MyAdoHelper.DoQuery(FileName, sql);
                    regStatus = "הסיסמה עודכנה בהצלחה";
                }
                else
                    regStatus = "משהו השתבש...";
            }
        }
    }
}