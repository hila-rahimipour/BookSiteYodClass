using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Survey : System.Web.UI.Page
{
    public string msg;
    public string survey;
    protected void Page_Load(object sender, EventArgs e)
    { 
        if (Session["User"] == null)
            Response.Redirect("Denied.aspx");
        survey += @"<input type= 'radio' id= 'book1' name= 'book' value = '1' />
       
                       <label> 1 - 3 </label>
                              <br/>
       
                       <input type = 'radio' id = 'book2' name = 'book' value = '2' />
              
                              <label> 3 - 5 </label>
                              <br/>
              
                              <input type ='radio' id='book3' name ='book' value='3' />
                     
                                     <label> 5 - 7 </label>
                                        <br/>
                     
                                     <input type = 'radio' id = 'book4' name = 'book' value = '4' />
                            
                                            <label> 7 - 9 </label>
                              <br/>
                            
                                            <input type = 'radio' id = 'book5' name = 'book' value = '5' />
                                   
                                                   <label> 9 - 11 </label>";
        if (Request.Form["submit"] != null) 
        {
            if (Session["Survey"] == null)
            {
                Application["a" + Request.Form["book"].ToString()] = (int)Application["a" + Request.Form["book"].ToString()] + 1;
                Session["Survey"] = true;
                Response.Redirect("SurveyAnswer.aspx");
            }
        }
        if (Session["Survey"] != null)
        {
            msg = "הצבעת כבר לסקר זה";
            survey = "<button><a href='SurveyAnswer.aspx'>תוצאות הסקר</a></button>";
        }

    }
}