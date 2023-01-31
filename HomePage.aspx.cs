using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

public partial class HomePage : System.Web.UI.Page
{
    public string news = "";
    public string txt = "";
    void InsertReport(string user, string date, string content)
    {
        XmlElement reportElement, userElement, dateElement, contentElement;
        XmlDocument doc = new XmlDocument();
        string XMLfile = Server.MapPath("news.xml");
        doc.Load(XMLfile);
        userElement = doc.CreateElement("user");
        dateElement = doc.CreateElement("date");
        contentElement = doc.CreateElement("content");
        reportElement = doc.CreateElement("report");
        userElement.InnerText = user;
        dateElement.InnerText = date;
        contentElement.InnerText = content;
        reportElement.AppendChild(userElement);
        reportElement.AppendChild(dateElement);
        reportElement.AppendChild(contentElement);
        doc.DocumentElement.InsertBefore(reportElement, doc.DocumentElement.FirstChild);

        FileStream fsxml = new FileStream(XMLfile, FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);

        doc.Save(fsxml);
        fsxml.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form["submit"] != null && Session["User"] != null)
        {
            DateTime dt = DateTime.Now;
            string currentDate = dt.Day + "/" + dt.Month + "/" + dt.Year;
            InsertReport(Session["UserEmail"].ToString(), currentDate, Request.Form["content"]);
        }
        string XMLfile = Server.MapPath("news.xml");
        XmlDocument doc = new XmlDocument();
        doc.Load(XMLfile);
        XmlNodeList user = doc.GetElementsByTagName("user");
        XmlNodeList date = doc.GetElementsByTagName("date");
        XmlNodeList content = doc.GetElementsByTagName("content");
        news = "<h2><u>הודעות</u></h2>";
        int reports = content.Count;
        for (int i = 0; i < reports; i++)
        {
            news += "<p style='font-size:16px; line-height:20px;'><b>" + user[i].InnerText + " " + date[i].InnerText + "</b></p>";
            news += "<p style='font-size:16px; line-height:20px;'>" + content[i].InnerText + " </p>";
            news += "<p style='line-height:20px;'>----------------------</p>";
        }
        if (Session["User"] != null)
        {
            txt += @"<form name = 'myForm' id = 'myForm' method = 'post' action = ''>
        
                            <textarea id = 'content' name = 'content' style = 'direction:rtl;' rows='5' cols='25'></textarea>
             
                                 <br/>
             
                                 <input type='submit' name = 'submit' id = 'submit' value = 'שלח'/></form>";
        }
    }
}