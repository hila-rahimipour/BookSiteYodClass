<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditUser.aspx.cs" Inherits="EditUser" %>

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
                if (sign == -1 || signSplit != 2 || (signLIndex == 0) || (signLIndex == (len - 1)) || dot == (len - 1) || dot == -1 || (dot - 1 == sign) || (sign - 1 == dot))
                    return false;
                return true;
            }
            function isValidStE(str) {
                var quote = "\"";
                var badChar = "!#$%^&*()+=<>[]{}_אבגדהוזחטיכלמנסעפצקרשתןםךףץ";
                for (var i = 0; i < str.length; i++)
                    for (var j = 0; j < badChar.length; j++)
                        if (str.charAt(i) == badChar.charAt(j))
                            return false;
                if (str.indexOf(quote) != -1)
                    return false;
                return true;
            }
            function check() {
                if (!isEmpty(document.getElementById("fName").value))
                    msg += "הכנס שם פרטי" + "<br/>";
                if (!isValidSt(document.getElementById("fName").value) || isNum(document.getElementById("fName")))
                    msg += "אותיות בלבד בשם פרטי" + "<br/>";
                if (!isEmpty(document.getElementById("lName").value))
                    msg += "הכנס שם משפחה" + "<br/>";
                if (!isValidSt(document.getElementById("lName").value) || isNum(document.getElementById("fName")))
                    msg += "אותיות בלבד בשם משפחה" + "<br/>";
                if (!isEmpty(document.getElementById("email").value))
                    msg += "הכנס כתובת דואר אלקטרוני" + "<br/>";
                if (!email(document.getElementById("email").value) || !isValidStE(document.getElementById("email").value))
                    msg += "כתובת דואר אלקטרוני לא תקינה" + "<br/>";
                if (!isEmpty(document.getElementById("fBook").value))
                    msg += "הכנס ספר אהוב" + "<br/>";
                if (!isValidSt(document.getElementById("fBook").value) || isNum(document.getElementById("fBook")))
                    msg += "אותיות בלבד בספר אהוב" + "<br/>";
                if (!isEmpty(document.getElementById("fAuthor").value))
                    msg += "הכנס סופר אהוב" + "<br/>";
                if (!isValidSt(document.getElementById("fAuthor").value) || isNum(document.getElementById("fAuthor")))
                    msg += "אותיות בלבד בסופר אהוב" + "<br/>";
                if (!isEmpty(document.getElementById("password").value))
                    msg += "הכנס סיסמה" + "<br/>";
                if (document.getElementById("password").value.length <= 8)
                    msg += "סיסמה באורך של 8 תווים לפחות" + "<br/>";
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
            <br />
            <h1>עריכת נתונים</h1>
            <p id="msg"></p>
            <%=editUser %>
        </div>
    </div>
</asp:Content>

