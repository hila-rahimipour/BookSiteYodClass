<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript">
        var msg = "";
        function isEmpty(str) {
            if (str.trim().length == 0)
                return false;
            else
                return true;
        }
        //function isNum(str) {
        //    var badChar = "1234567890";
        //    for (var i = 0; i < str.length; i++)
        //        for (var j = 0; j < badChar.length; j++)
        //            if (str.charAt(i) == badChar.charAt(j))
        //                return false;
        //    return true;
        //}
        function isValidSt(str) {
            var quote = "\"";
            var badChar = "!@#$%^&*()+=<>[]{}_1234567890";
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
            var dot = str.indexOf(".");
            var dotSplit = str.split(".");
            var lastDot = str.lastIndexOf(".");
            var lastSign = str.lastIndexOf("@");
            if (sign == -1 || sign == 0 || signSplit != 2 || sign == (len - 1) || dot == (len - 1) || dot == -1 || dot == 0 || (dot - 1 == sign) || (sign - 1 == dot) || lastDot == str.length - 1 || lastSign == str.length-1)
                return false;
            for (var i = 0; i < dotSplit.length; i++) {
                var txt = dotSplit[i];
                var dotI = txt.indexOf(".");
                if (dotI == 0 || dotI == txt.length - 1)
                    return false;
            }
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
        function isSame(fName, lName) {
            if (fName == lName)
                return false;
            else
                return true;
        }
        function check() {
            if (!isEmpty(document.getElementById("fName").value))
                msg += "הכנס שם פרטי" + "<br/>";
            if (!isValidSt(document.getElementById("fName").value))
                msg += "אותיות בלבד בשם פרטי" + "<br/>";
            if (!isEmpty(document.getElementById("lName").value))
                msg += "הכנס שם משפחה" + "<br/>";
            if (!isValidSt(document.getElementById("lName").value))
                msg += "אותיות בלבד בשם משפחה" + "<br/>";
            if (!isEmpty(document.getElementById("email").value))
                msg += "הכנס כתובת דואר אלקטרוני" + "<br/>";
            if (!email(document.getElementById("email").value) || !isValidStE(document.getElementById("email").value))
                msg += "כתובת דואר אלקטרוני לא תקינה" + "<br/>";
            if (!isEmpty(document.getElementById("fBook").value))
                msg += "הכנס ספר אהוב" + "<br/>";
            if (!isValidSt(document.getElementById("fBook").value))
                msg += "אותיות בלבד בספר אהוב" + "<br/>";
            if (!isEmpty(document.getElementById("fAuthor").value))
                msg += "הכנס סופר אהוב" + "<br/>";
            if (!isValidSt(document.getElementById("fAuthor").value))
                msg += "אותיות בלבד בסופר אהוב" + "<br/>";
            if (!isEmpty(document.getElementById("password").value))
                msg += "הכנס סיסמה" + "<br/>";
            if (document.getElementById("password").value.length <= 8)
                msg += "סיסמה באורך של 8 תווים לפחות" + "<br/>";
            if (!isSame(document.getElementById("fName").value, document.getElementById("lName").value))
                msg += "שם פרטי ומשפחה זהים" + "<br/>";
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
    <style>
        p{
            font-size:18px;
            text-align:right;
            line-height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="flex-container">
        <div>
     <h1>הרשמה</h1>
            <br />
    <form id="myForm" name="myForm" method="post" action=""  onsubmit="return check()">
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
                <p>שם פרטי</p>
            </td>
            <td>
                <input type="text" id="fName" name="fName" />
            </td>
        </tr>
            <tr>
            <td>
                <p>שם משפחה</p>
            </td>
            <td>
                <input type="text" id="lName" name="lName" />
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
                <p>ספר אהוב</p>
            </td>
            <td>
                <input type="text" id="fBook" name="fBook" />
            </td>
        </tr>
            <tr>
            <td>
                <p>סופר אהוב</p>
            </td>
            <td>
                <input type="text" id="fAuthor" name="fAuthor" />
            </td>
        </tr>
            <tr>
            <td>
                <p>סיסמה</p>
            </td>
            <td>
                <input type="password" id="password" name="password" />
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
            <tr>
                <td colspan="2">
            <p id="msg"> </p>
                </td>
            </tr>
        </table>
    </form>
    <br /><br />
    </div>
        </div>
</asp:Content>

