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

public partial class Control : System.Web.UI.Page
{
    public string supportList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != "admin")
            Response.Redirect("Denied.aspx");
        else
        {
            string fileName = "DB.mdf";//שם הקובץ
            string tableName = "MyTable";//שם הטבלה
            string selectQuery = "SELECT * FROM " + tableName; // שאילתת בחירה

            DataTable table = MyAdoHelper.ExecuteDataTable(fileName, selectQuery);

            int length = table.Rows.Count; // מספר הרשומות בטבלה
            if (length > 0)
            {
                supportList += "<table>";
                supportList += "<tr>";
                supportList += "<th>כתובת דואר אלקטרוני</th>";
                supportList += "<th>שם פרטי</th>";
                supportList += "<th>שם משפחה</th>";
                supportList += "<th>ספר אהוב</th>";
                supportList += "<th>סיסמה</th>";
                supportList += "<th>מנהל?</th>";
                supportList += "</tr>";
                for (int i = 0; i < length; i++)
                { // הדפסת כל הרשומות בטבלה
                    supportList += "<tr>";
                    supportList += "<form method='post' action='AdminEdit.aspx'>";
                    supportList += "<input type='hidden' name='email' value='" + table.Rows[i]["email"] + "' />";
                    supportList += "<td>" + table.Rows[i]["email"] + "</td>";
                    supportList += "<td><input type='text' name='fName' value='" + table.Rows[i]["fName"] + "' /></td>";
                    supportList += "<td><input type='text' name='lName' value='" + table.Rows[i]["lName"] + "' /></td>";
                    supportList += "<td><input type='text' name='fBook' value='" + table.Rows[i]["fBook"] + "' /></td>";
                    supportList += "<td><input type='text' name='fAuthor' value='" + table.Rows[i]["fAuthor"] + "' /></td>";
                    if ((bool)table.Rows[i]["isAdmin"] == true)
                        supportList += "<td> <input type='checkbox' name='isAdmin' value='true' checked='checked' /></td>";
                    else
                        supportList += "<td> <input type='checkbox' name='isAdmin' value='false' /></td>";
                    supportList += "<td><input type='submit' name='submit' value='עדכן' /></td>";
                    supportList += "<td><input type='button' onclick='window.location.href=\"RemoveUser.aspx?email=" + table.Rows[i]["email"] + "\"' value='מחק' /></td>";
                    supportList += "</form>";
                    supportList += "</tr>";
                }
                supportList += "</table></br></br>";
            }

        }
    }
}