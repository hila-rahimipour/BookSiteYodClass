using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != "admin")
            Response.Redirect("Denied.aspx");
        else
        {
            string fileName = "DB.mdf";//שם הקובץ
            string tableName = "MyTable";//שם הטבלה

            if (Request.Form["submit"] != null)
            {


                //קליטת מידע לעדכון
                string isAdmin = "false";
                string fName = Request.Form["fName"];
                string lName = Request.Form["lName"];
                string fBook = Request.Form["fBook"];
                string fAuthor = Request.Form["fAuthor"];
                string email = Request.Form["email"];
                if (Request.Form["isAdmin"] != null)
                    isAdmin = "true";

                string sql = "UPDATE MyTable SET email = '" + email + "'";
                sql += ", fName='" + fName + "'";
                sql += ", lName='" + lName + "'";
                sql += ", fBook='" + fBook + "'";
                sql += ", fAuthor='" + fAuthor + "'";
                sql += ", isAdmin='" + isAdmin + "'";
                sql += " WHERE email = '" + email + "'";
                MyAdoHelper.DoQuery(fileName, sql);
                Response.Redirect("Control.aspx");
            }
        }
    }
}