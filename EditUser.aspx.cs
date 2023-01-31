using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

public partial class EditUser : System.Web.UI.Page
{
    public string editUser = "";
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null || Session["User"] == "")
        {
            Response.Redirect("Denied.aspx");
        }
        string fileName = "DB.mdf";
        string userEmail = (string)Session["UserEmail"];
        if (Request.Form["submit"] != null)
        {
            string fName = Request.Form["fName"];
            string lName = Request.Form["lName"];
            string fBook = Request.Form["fBook"];
            string fAuthor = Request.Form["fAuthor"];
                string sql = "UPDATE MyTable SET fName = '" + fName + "'";
                sql += ", lName='" + lName + "'";
                sql += ", fBook='" + fBook + "'";
                sql += ", fAuthor='" + fAuthor + "'";
                sql += " WHERE email = '" + userEmail + "'";
                MyAdoHelper.DoQuery(fileName, sql);
                msg = "עדכון בוצע בהצלחה";
        }

        else
        {

            string selectQuery = "SELECT * FROM MyTable WHERE email = '" + userEmail + "'";
            DataTable table = MyAdoHelper.ExecuteDataTable(fileName, selectQuery);
            int length = table.Rows.Count;

            if (length > 0)
            {
                editUser += "<form name='myForm' id='myForm' method='post' action='' onsubmit='return check()'>";
                editUser += "<table>";
                editUser += "<p style='font-size:18px'>" + userEmail + "</p>";
                editUser += "<tr><td>שם פרטי:</td><td><input type='text' name='fName' id='fName' value='" + (string)table.Rows[0]["fName"] + "' /></td></tr>";
                editUser += "<tr><td>שם משפחה:</td><td><input type='text' name='lName' id='lName' value='" + (string)table.Rows[0]["lName"] + "' /></td></tr>";
                editUser += "<tr><td>ספר אהוב:</td><td><input type='text' name='fBook' id='fBook' value='" + (string)table.Rows[0]["fBook"] + "' /></td></tr>";
                editUser += "<tr><td>סופר אהוב:</td><td><input type='text' name='fAuthor' id='fAuthor' value='" + (string)table.Rows[0]["fAuthor"] + "' /></td></tr>";
                editUser += "</table>";
                editUser += "<input type='submit' name='submit' value='עדכן' />";
                editUser += "</form>";
            }
        }
    }
}