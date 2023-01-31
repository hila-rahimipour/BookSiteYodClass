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

public partial class ShowAllData : System.Web.UI.Page
{
    public string usersList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != "admin")
            Response.Redirect("Denided.aspx");
        else
        {
            string FileName = "DB.mdf";
            string TableName = "MyTable";
            string SelectQuery = "SELECT * FROM " + TableName;
            DataTable dt = MyAdoHelper.ExecuteDataTable(FileName, SelectQuery);
            int users = dt.Rows.Count;
            usersList += "<p> ישנם " + users + " משתמשים באתר זה </p>";
            usersList += MyAdoHelper.PrintDataTableNew(dt);
        }
    }
}