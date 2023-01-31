<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CountDataBook.aspx.cs" Inherits="CountDataBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
            <h1>ספירת משתמשים לפי ספרים אהובים</h1>
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

