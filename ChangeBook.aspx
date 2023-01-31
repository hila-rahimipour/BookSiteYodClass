<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChangeBook.aspx.cs" Inherits="ChangeBook" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        var msg = "";
        function isEmpty(str) {
            if (str.trim().length == 0)
                return false;
            else
                return true;
        }
        function isNum(str) {
            if (isNaN(str))
                return false;
            else
                return true;
        }
        function isValidSt(str) {
            var quote = "\"";
            var badChar = "!@#$%^&*()+=<>[]{}_";
            for (var i = 0; i < str.length; i++)
                for (var j = 0; j < badChar.length; j++)
                    if (str.charAt(i) == badChar.charAt(j))
                        return false;
            if (str.indexOf(quote) != -1)
                return false;
            return true;
        }
        function email(str) {
            var sign = str.indexOf("@");
            var signSplit = str.split("@").length;
            var len = str.length;
            var signLIndex = str.lastIndexOf("@");
            var dot = str.indexOf(".");
            if (sign == -1 || signSplit != 2 || (signLIndex == 0) || (signLIndex == (len - 1)) || dot == (len - 1) || dot == 0 || (dot - 1 == sign) || (sign - 1 == dot))
                return false;
            return true;
        }
        function isValidStE(str) {
            var quote = "\"";
            var badChar = "!#$%^&*()+=<>[]{}_";
            for (var i = 0; i < str.length; i++)
                for (var j = 0; j < badChar.length; j++)
                    if (str.charAt(i) == badChar.charAt(j))
                        return false;
            if (str.indexOf(quote) != -1)
                return false;
            return true;
        }
        function check() {
            if (!isEmpty(document.getElementById("email").value) || !isValidStE(document.getElementById("email").value))
                msg += "הכנס כתובת דואר אלקטרוני" + "<br/>";
            if (!isEmpty(document.getElementById("fBook").value))
                msg += "הכנס ספר אהוב" + "<br/>";
            if (!isValidSt(document.getElementById("fBook").value) || isNum(document.getElementById("fBook")))
                msg += "אותיות בלבד בספר אהוב" + "<br/>";
            if (!isEmpty(document.getElementById("pass").value))
                msg += "הכנס סיסמה" + "<br/>";
            if (msg.length == 0) {
                return true;
            }
            else {
                document.getElementById("msg").innerHTML = msg;
                msg = "";
                return false;
            }
        }
    </script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="flex-container">
        <div>
            <h1>שינוי סופר אהוב</h1>
            <br />
    <form id="myForm" name="myForm" method="post" action="" onsubmit="return check()">
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
            <td>
                <p>ספר אהוב חדש</p>
            </td>
            <td>
                <input type="text" id="fBook" name="fBook" />
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
             <tr>
            <td style="text-align:center;" colspan="2">
                <p id="msg"></p>
            </td>
        </tr>
        </table>
    </form>
    <br /><br />
    </div>
        </div>
</asp:Content>

