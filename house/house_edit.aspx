<%@ Page Language="C#" AutoEventWireup="true" CodeFile="house_edit.aspx.cs" Inherits="house_house_edit" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN""http://www.w3.org/TR/html4/loose.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .H_1
        {
            color:red;
        }
        .auto-style1 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="800" align="center">
                <tr>
                    <td class="auto-style1">id：&nbsp;
                        <asp:TextBox ID="id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">类型：<asp:TextBox ID="category" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>价格：&nbsp;&nbsp; <asp:TextBox ID="price" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">占用：&nbsp;&nbsp;
                        <asp:DropDownList ID="occupy" runat="server">
                            <asp:ListItem Value="占用">占用</asp:ListItem>
                            <asp:ListItem Value="空闲">空闲</asp:ListItem>
                            <asp:ListItem>已预订</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        图片：<asp:FileUpload ID="new_img" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="保 存" style="height: 27px" Width="50px" />
                        &nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返 回" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:HiddenField ID="old_img" runat="server" />
    </form>
</body>
</html>
