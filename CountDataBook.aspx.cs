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

public partial class CountDataBook : System.Web.UI.Page
{
    public string usersList;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] != "admin")
            Response.Redirect("Denied.aspx");
        else
        {
            string FileName = "DB.mdf";
            string TableName = "MyTable";
            string SelectQuery = "SELECT fBook, COUNT(*) AS 'myCount' FROM " + TableName + " GROUP BY fBook";
            DataTable dt = MyAdoHelper.ExecuteDataTable(FileName, SelectQuery);
            usersList = MyAdoHelper.PrintDataTableNew(dt);
        }
    }
}