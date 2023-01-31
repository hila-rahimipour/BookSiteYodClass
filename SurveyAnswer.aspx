<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SurveyAnswer.aspx.cs" Inherits="SurveyAnswer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
           <table>
               <tr>
                   <td><h1>תוצאות הסקר</h1></td>
               </tr>
               <tr>
                   <td>
                       <p style="font-size:18px;"><b>1-3</b></p>
                       <div style="background-color:green; height:10px; border-radius:5px; width:<%=a1 %>%;"><%=a1 %>%</div></td>
               </tr>
               <tr>
                   <td>
                       <p style="font-size:18px;"><b>3-5</b></p>
                       <div style="background-color:blue; height:10px; border-radius:5px; width:<%=a2 %>%;"><%=a2 %>%</div></td>
               </tr>
               <tr>
                   <td>
                       <p style="font-size:18px;"><b>5-7</b></p>
                       <div style="background-color:yellow; height:10px; border-radius:5px; width:<%=a3 %>%;"><%=a3 %>%</div></td>
               </tr>
               <tr>
                   <td>
                       <p style="font-size:18px;"><b>7-9</b></p>
                       <div style="background-color:red; height:10px; border-radius:5px; width:<%=a4 %>%;"><%=a4 %>%</div></td>
               </tr>
               <tr>
                   <td>
                       <p style="font-size:18px;"><b>9-11</b></p>
                       <div style="background-color:purple; height:10px; border-radius:5px; width:<%=a5 %>%;"><%=a5 %>%</div></td>
               </tr>
           </table>
            <br />
        </div>
    </div>
</asp:Content>

