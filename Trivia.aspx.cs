using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Trivia : System.Web.UI.Page
{
    public string grade="";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["User"] == null)
            Response.Redirect("Denied.aspx");
        else
        if (Request.Form["submit"] != null)
        {
            int count = 0;
            string answer1 = Request.Form["q1"];
            if (answer1 == "1")
                count += 20;
            string answer2 = Request.Form["q2"];
            if (answer2 == "3")
                count += 20;
            string answer3 = Request.Form["q3"];
            if (answer3 == "4")
                count += 20;
            string answer4 = Request.Form["q4"];
            if (answer4 == "2")
                count += 20;
            string answer5 = Request.Form["q5"];
            if (answer5 == "3")
                count += 20;
            grade += "הציון שלך הוא: ";
            grade += count.ToString();
        }
    }
}