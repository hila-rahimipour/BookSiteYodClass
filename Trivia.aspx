<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trivia.aspx.cs" Inherits="Trivia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        td{
            padding:15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div class="flex-container">
        <div>
            <br />
            <h1>טריוויה על ספרים וסופרים</h1>
            <p><%=grade %></p>
            <form name="myForm" id="myForm" method="post" action="">
                <table>
                    <tr>
                        <td><p style="font-size:20px;"><b>מהו ספרו המוכר ביותר של ריק ריירדן?</b></p></td>
                        <td>
                            <input type="radio" id="a1" name="q1" value="1"/>פרסי ג'קסון
                            <input type="radio" id="a2" name="q1" value="2"/>ארץ האגדות
                            <input type="radio" id="a3" name="q1" value="3"/>משחקי הרעב
                            <input type="radio" id="a4" name="q1" value="4"/>הארי פוטר
                        </td>
                    </tr>
                    <tr>
                        <td><p style="font-size:20px;"><b>כמה ספרים יש בסדרה משחקי הרעב?</b></p></td>
                        <td>
                            <input type="radio" id="a1" name="q2" value="1" />6
                            <input type="radio" id="a2" name="q2" value="2" />7
                            <input type="radio" id="a3" name="q2" value="3" />3
                            <input type="radio" id="a4" name="q2" value="4" />4
                        </td>
                    </tr>
                     <tr>
                        <td><p style="font-size:20px;"><b>מי כתב את הסדרה בני הנפילים?</b></p></td>
                         <td>
                            <input type="radio" id="a1" name="q3" value="1" />קארן מ' מקמנוס
                            <input type="radio" id="a2" name="q3" value="2" />כריס קולפר
                            <input type="radio" id="a3" name="q3" value="3" />ריק ריירדן
                            <input type="radio" id="a4" name="q3" value="4" />קסנדרה קלייר
                        </td>
                    </tr>
                    <tr>
                        <td><p style="font-size:20px;"><b>מי הן הדמויות הראשיות בסדרה ארץ האגדות?</b></p></td>
                        <td>
                            <input type="radio" id="a1" name="q4" value="1" />פרסי ואנבת'
                            <input type="radio" id="a2" name="q4" value="2" />אלכס וקונר ביילי
                            <input type="radio" id="a3" name="q4" value="3" />קטניס ופרים
                            <input type="radio" id="a4" name="q4" value="4" />דנה אלעזר הלוי
                        </td>
                    </tr>
                    <tr>
                        <td><p style="font-size:20px;"><b>מי הסופר שכתב את הספר משחקי הרעב?</b></p></td>
                        <td>
                            <input type="radio" id="a1" name="q5" value="1" />ג'יי קיי רולינג
                            <input type="radio" id="a2" name="q5" value="2" />ברנדון סנדרסון
                            <input type="radio" id="a3" name="q5" value="3" />סוזן קולינס
                            <input type="radio" id="a4" name="q5" value="4" />תמי שם טוב
                        </td>
                    </tr>
                    <tr>
            <td style="text-align:center;">
                <input type="reset" id="reset" name="reset" value="אפס" style="font-size:16px;" />
            </td>
            <td style="text-align:center;">
                <input type="submit" id="submit" name="submit" value="שלח" style="font-size:16px;"/>
            </td>
        </tr>
                </table>
            </form>
        </div>
   </div>
</asp:Content>

