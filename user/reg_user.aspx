<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg_user.aspx.cs" Inherits="reg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <table>
             <tr><td>身份证：&nbsp; 
                 <asp:TextBox ID="identifier" runat="server"></asp:TextBox>
                 </td></tr>
             <tr><td class="auto-style1">姓名：&nbsp;&nbsp; 
                 <asp:TextBox ID="name" runat="server"></asp:TextBox>
                 </td></tr>
             <tr><td>密码：&nbsp;&nbsp; <asp:TextBox ID="password" runat="server"></asp:TextBox>
&nbsp;&nbsp; </td></tr>
             <tr><td id="mobile">手机号码： <asp:TextBox ID="mobile" runat="server"></asp:TextBox>
                 </td></tr>
             <tr><td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp; 
                 <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返 回" />
                 </td></tr>
         </table>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
