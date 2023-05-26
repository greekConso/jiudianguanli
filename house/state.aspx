<%@ Page Language="C#" AutoEventWireup="true" CodeFile="state.aspx.cs" Inherits="house_state" %>

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
        .auto-style5 {
            height: 26px;
            width: 170px;
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
    <a class=a1 href="../admin/admin_main.aspx">返回主菜单</a>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="1" class="auto-style4">
                <tr><td class="auto-style1" width="100">&nbsp;&nbsp;id</td><td class="auto-style1" width="100">类型</td><td class="auto-style1" width="100">占用状态</td><td class="auto-style1" width="100">价格</td><td class="auto-style1">图片</td><td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 操作</td></tr>
            <%  

                string id = Request.QueryString["id"];

                if(id!=null)
                {
                    YF.BLL.House.del(int.Parse(id));
                    YF.JsHelper.AlertAndRedirect("删除成功！", "state.aspx");

                }
                List<YF.Model.House> list=YF.BLL.House.list(); %>
                <%for (int i = 0; i < list.Count; i++)
                    {%>
                        <tr><td width="100"><%=list[i].Id%></td><td width="100"><%=list[i].Category%></td><td width="100"><%=list[i].Occupy%></td><td width="100"><%=list[i].Price%></td><td width="100"><img src="../image/<%=list[i].Img%>" alt="img" width="100px" height="100px"></td><td class="auto-style6">&nbsp; <a href="state.aspx?id=<%=list[i].Id%>">删除</a>|<a href="house_edit.aspx?id=<%=list[i].Id%>">修改</a></td></tr>
                    <%} %>
            </table>
        </div>
    </form>
</body>
</html>
