<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login_admin.aspx.cs" Inherits="admin_login_admin" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
"http://www.w3.org/TR/html4/loose.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1762px;
            height: 300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <img border="0" src="/image/login_admin.jpg" alt="login_admin" class="auto-style1" ></img>
            <table align="center">
                <tr><td>管理员姓名：
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
&nbsp;&nbsp; </td></tr>
                <tr><td>密码：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server"></asp:TextBox>
&nbsp;</td></tr>
                <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="登 录" />
&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="注 册" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返 回 起 始 页" />
                    </td></tr>
            </table>
         <img border="0" src="/image/login_admin.jpg" alt="login_admin" class="auto-style1" ></img>
    </form>
</body>
</html>
