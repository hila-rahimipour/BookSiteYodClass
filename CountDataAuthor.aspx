<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CountDataAuthor.aspx.cs" Inherits="CountDataAuthor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="flex-container">
        <div>
            <h1>ספירת משתמשים לפי סופרים אהובים</h1>
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

