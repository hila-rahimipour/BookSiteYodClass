using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SurveyAnswer : System.Web.UI.Page
{
    public int sum, a1, a2, a3, a4, a5;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Survey"] == null)
            Response.Redirect("Survey.aspx");
        if (Session["Survey"] != null)
        {
            string book = Request.Form["book"];
            if (Application["book"] == null)
            {
                Application["book"] = 0;
            }
            Application.Lock();
            Application["book"] = (int)Application["book"] + 1;
            Application.UnLock();
            Session["Survey"] = true;
            
        }
        sum = (int)Application["a1"] + (int)Application["a2"] + (int)Application["a3"] + (int)Application["a4"]+ (int)Application["a5"];
        if (sum != 0)
        {
            a1 = (int)Application["a1"] * 100 / sum;
            a2 = (int)Application["a2"] * 100 / sum;
            a3 = (int)Application["a3"] * 100 / sum;
            a4 = (int)Application["a4"] * 100 / sum;
            a5 = (int)Application["a5"] * 100 / sum;
        }
    }
}