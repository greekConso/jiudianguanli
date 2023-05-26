<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reg_admin.aspx.cs" Inherits="admin_reg_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><td>姓名：&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                    </td></tr>
                <tr><td>密码：&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="password" runat="server" CssClass="auto-style1"></asp:TextBox>
&nbsp; &nbsp;</td></tr>
                <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click2" Text="注 册" />
                    </td></tr>
                <tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp; &nbsp;</td></tr>
            </table>
        </div>
    </form>
</body>
</html>
