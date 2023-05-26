<%@ Page Language="C#" AutoEventWireup="true" CodeFile="finance.aspx.cs" Inherits="admin_finance" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <a href="admin_main.aspx">返回主菜单</a>
        <div>
            <table align="center" border="1" class="auto-style4">
                <tr><td class="auto-style1" width="100">&nbsp;&nbsp;id</td><td class="auto-style1" width="100">userid</td><td class="auto-style1" width="100">房号</td><td class="auto-style1" width="100">价格</td><td class="auto-style1" width="100">时间</td><td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 操作</td></tr>
            <%  
                string id = Request.QueryString["id"];

                if(id!=null)
                {
                    string category = Request.QueryString["category"];
                    if (category == "删除")
                    {
                        YF.BLL.Finance.admin_del(int.Parse(id));
                        YF.JsHelper.AlertAndRedirect("删除成功！", "finance.aspx");
                    }
                    else
                    {
                        YF.BLL.Finance.del(int.Parse(id));
                        YF.JsHelper.AlertAndRedirect("彻底删除！", "finance.aspx");
                    }
                }
                List<YF.Model.Finance> list=YF.BLL.Finance.list(); %>
                <%for (int i = 0; i < list.Count; i++)
                    {%>
                        <tr><td width="100"><%=list[i].Id%></td><td width="100"><%=list[i].Userid%></td><td width="100"><%=list[i].Houseid%></td><td width="100"><%=list[i].Price%></td><td width="100"><%=list[i].Time%></td><td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="finance.aspx?id=<%=list[i].Id%>&category=删除">删除</a>|<a href="finance.aspx?id=<%=list[i].Id%>&category=彻底删除">彻底删除</a></td></tr>
                    <%} %>
            </table>
        </div>
    </form>
</body>
</html>
