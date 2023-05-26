<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add_house.aspx.cs" Inherits="house_add_house" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
"http://www.w3.org/TR/html4/loose.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="../admin/admin_main.aspx">返回主菜单</a>
        <table align="center">
            <tr><td>&nbsp;房间类型：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="category" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td></tr>
            <tr><td>&nbsp;占用状态： &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="occupy" runat="server">
                    <asp:ListItem>占用</asp:ListItem>
                    <asp:ListItem>空闲</asp:ListItem>
                    <asp:ListItem>已预订</asp:ListItem>
                </asp:DropDownList>
                </td></tr>
            <tr><td>&nbsp;价格：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="price" runat="server"></asp:TextBox>
&nbsp;&nbsp;<br />
&nbsp; 图片：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                <asp:FileUpload ID="img" runat="server" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提 交" />
                </td></tr>
        </table>
    </form>
</body>
</html>
