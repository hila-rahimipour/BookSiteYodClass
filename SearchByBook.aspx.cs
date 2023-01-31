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

public partial class SearchByBook : System.Web.UI.Page
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
            string selectQuery = "";
            if (Request.Form["submit"] != null)
            {
                selectQuery = "SELECT * FROM " + TableName + " WHERE fBook='" + Request.Form["fBook"] + "'";
            }
            if (selectQuery != "")
            {
                DataTable dt = MyAdoHelper.ExecuteDataTable(FileName, selectQuery);
                usersList = MyAdoHelper.PrintDataTableNew(dt).ToString();
            }
        }    
    }
}