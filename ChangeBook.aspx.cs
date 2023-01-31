using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ChangeBook : System.Web.UI.Page
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
            string password = Request.Form["pass"];
            string fBook = Request.Form["fBook"];
            if (Request.Form["submit"] != null)
            {
                SelectQuery = "SELECT * FROM " + TableName + " WHERE email='" + email + "' AND password='" + password + "'";
                sql = "UPDATE " + TableName + " SET fBook='" + fBook + "' WHERE email='" + email + "' AND password='" + password + "'";
                if (MyAdoHelper.IsExist(FileName, SelectQuery))
                {
                    MyAdoHelper.DoQuery(FileName, sql);
                    regStatus = "הספר האהוב הוחלף";
                }
                else
                    regStatus = "משהו השתבש...";
            }
        } 
    }
}