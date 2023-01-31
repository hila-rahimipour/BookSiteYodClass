using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RemoveUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = "DB.mdf";//שם הקובץ
        if (Request.QueryString["email"] != null)
        {
            string email = Request.QueryString["email"];
            string sql = "DELETE FROM MyTable WHERE email = '" + email + "'";
            MyAdoHelper.DoQuery(fileName, sql);
        }
        Response.Redirect("Control.aspx");
    }
}