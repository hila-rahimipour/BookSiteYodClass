<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowAllData.aspx.cs" Inherits="ShowAllData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
            <h1>המשתמשים באתר זה</h1>
            <%=usersList %>
            <br />
        </div>
    </div>
</asp:Content>

