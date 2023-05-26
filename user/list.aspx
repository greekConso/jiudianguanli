<%@ Page Language="C#" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="user_list" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN""http://www.w3.org/TR/html4/loose.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style4 {
            width: 1152px;
        }
        .auto-style6 {
            width: 170px;
        }
        .a1
        {
            color:crimson;
            width:100px;
        }
    </style>
</head>
<body>
    <%string userid = Request.QueryString["userid"]; %>
    <a class=a1 href="user_main.aspx?userid=<%=userid%>">返回主菜单</a>
    <form id="form1" runat="server">
        <div align="center">
            <table  border="1" class="auto-style4">
                <tr><td class="auto-style1" width="100">用户身份证号</td><td class="auto-style1" width="100">房间id</td><td class="auto-style1" width="100">时间</td><td class="auto-style1">价格</td><td class="auto-style1">操作</td></tr>
            <%  
                string userid = Request.QueryString["userid"];
                string id=Request.QueryString["id"];
                if(id!=null)
                {
                    YF.Model.Houselist houselist=YF.BLL.Houselist.GetHouselist(int.Parse(id));
                    YF.Model.House house = YF.BLL.House.GetHouse(houselist.Houseid);
                    house.Occupy = "空闲";
                    YF.BLL.House.update(house);
                    YF.BLL.Houselist.del(int.Parse(id));
                    YF.JsHelper.AlertAndRedirect("删除成功！", "list.aspx?userid=" + userid);
                }
                List<YF.Model.Houselist> list=YF.BLL.Houselist.ListUserid(userid); %>
                <%for (int i = 0; i < list.Count; i++)
                    {%>
                        <tr><td width="100"><%=list[i].Userid%></td><td width="100"><%=list[i].Houseid%></td><td width="100"><%=list[i].Time%></td><td class="auto-style6"><%=list[i].Price%></td><td class="auto-style6"><a href="list.aspx?userid=<%=list[i].Userid %>&id=<%=list[i].Id %>">删除订单</a></td></tr>
                    <%} %>
            </table>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提 交"/>
        </div>
    </form>
</body>
</html>
