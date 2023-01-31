<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SearchByEmail.aspx.cs" Inherits="SearchByEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="flex-container">
        <div>
            <h1>חיפוש לפי כתובת דואר אלקטרוני</h1>
            <br />
            <form id="myForm" name="myForm" method="post" action="">
            <table style="direction:rtl; width:450px; border: 1px solid black;">
        <tr>
            <td>
                <p style="font-size:18px;">כתובת הדואר האלקטרוני לחיפוש</p>
            </td>
            <td>
                <input type="text" id="email" name="email" />
            </td>
        </tr>
            <tr>
            <td style="text-align:center;" colspan="2">
                <input type="submit" id="submit" name="submit" value="שלח" style="font-size:16px;" />
            </td>
        </tr>  
        </table>
    </form>
        </div>
    </div>
    <div class="flex-container">
                <div>
           <br />
            <%=usersList %>
            <br />
        </div>
    </div>
</asp:Content>

