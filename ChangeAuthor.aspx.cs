using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeAuthor : System.Web.UI.Page
{
    public string regStatus;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Response.Redirect("Denied.aspx");
        else
        {
            string FileName = "DB.mdf";
            string TableName = "MyTable";
            string SelectQuery = "";
            string sql = "";
            string email = Request.Form["email"];
            string password = Request.Form["pass"];
            string fAuthor = Request.Form["fAuthor"];
            if (Request.Form["submit"] != null)
            {
                SelectQuery = "SELECT * FROM " + TableName + " WHERE email='" + email + "' AND password='" + password + "'";
                sql = "UPDATE " + TableName + " SET fAuthor='" + fAuthor + "' WHERE email='" + email + "' AND password='" + password + "'";
                if (MyAdoHelper.IsExist(FileName, SelectQuery))
                {
                    MyAdoHelper.DoQuery(FileName, sql);
                    regStatus = "הסופר האהוב הוחלף";
                }
                else
                    regStatus = "משהו השתבש...";
            }
        }
    }
}