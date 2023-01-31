<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
            <br />
            <h1>~דף הבית~</h1>    
            <p style="text-align:right;"><b>ברוכים הבאים לאתר שלי! </b></p>
            <p style="text-align:right;">באתר זה אמליץ על ספרי נוער שונים והנה מספר עובדות מעניינות שקשורות לספרים:</p>
            <p style="text-align:right;">1. קריאה של 6 דקות ביום, מפחיתה לחץ בכ-68 אחוזים</p>
            <p style="text-align:right;">2. גובהו של הספר הגדול ביותר בעולם הוא בערך 2 מטרים</p>
            <p style="text-align:right;">3. קיימים מעל ל-129 מיליון ספרים בעולם</p>
            <p style="text-align:right;">4. שוויו של הספר היקר ביותר שנמכר אי פעם עומד על 30.8 מיליון דולר</p>
            <p style="text-align:right;">5. השם הארוך ביותר לספר הוא באורך של 3,700 מילים</p>
    <br />
            </div>
                <div style="padding:20px; margin:20px; border:1px solid black;">
         <%=news %>
                   <%=txt %>
        </div>
        <div>
    <img src="images/home.jpg" width="40%"/>
            </div>
    <br /><br />
        </div>
</asp:Content>

