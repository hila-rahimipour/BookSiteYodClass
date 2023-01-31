<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="flex-container">
        <div>
            <h1>שינוי סיסמה</h1>
            <br />
    <form id="myForm" name="myForm" method="post" action="">
        <table style="direction:rtl; width:450px; border: 1px solid black; padding:10px;">
            <tr>
                <td colspan="2">
                    <p style="text-align:center;">
                         <%=regStatus %>
                    </p>
                </td>
            </tr>
        <tr>
            <td>
                <p>כתובת דואר אלקטרוני</p>
            </td>
            <td>
                <input type="text" id="email" name="email" />
            </td>
        </tr>
            <tr>
            <td>
                <p>סיסמה</p>
            </td>
            <td>
                <input type="text" id="pass" name="pass" />
            </td>
        </tr>
            <tr>
            <td style="text-align:center;">
                <input type="reset" id="reset" name="reset" value="אפס" style="font-size:16px;" />
            </td>
            <td style="text-align:center;">
                <input type="submit" id="submit" name="submit" value="שלח" style="font-size:16px;" />
            </td>
        </tr>
            
        </table>
    </form>
    <br /><br />
    </div>
        </div>
</asp:Content>

