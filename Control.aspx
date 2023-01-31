<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Control.aspx.cs" Inherits="Control" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
            <br />
            <h1>פאנל ניהול</h1>
                <%=supportList %>
        </div>
    </div>
</asp:Content>

