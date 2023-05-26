<%@ Page Language="C#" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="user_checkout" %>

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
    <%  
        string userid = Request.QueryString["userid"];
        string id=Request.QueryString["id"];
        if(id!=null)
        {
            YF.Model.Record record = new YF.Model.Record();
            record = YF.BLL.Record.GetRecord(int.Parse(id));
            List<int> l=new List<int>();
            string houseid = record.Houseid;
            int i,j;
            for(i=0;i<houseid.Length;)
            {
                string h=string.Empty;
                for (j = i; j < houseid.Length && houseid[j] != ' '; j++)
                {
                    if(houseid[j]>='0'&&houseid[j]<='9')h += houseid[j];
                }
                if(h!=string.Empty)l.Add(int.Parse(h));
                i = j + 1;
            }
            for(i=0;i<l.Count;i++)
            {
                YF.Model.House house = new YF.Model.House();
                house = YF.BLL.House.GetHouse(l[i]);
                house.Occupy = "空闲";
                YF.BLL.House.update(house);
            }
            YF.BLL.Record.del(record.Id);
            YF.JsHelper.AlertAndRedirect("退房成功！", "user_main.aspx?userid=" + userid);
        }
                                                      %>
    <a class=a1 href="user_main.aspx?userid=<%=userid%>">返回主菜单</a>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="1" class="auto-style4">
                <tr><td class="auto-style1" width="100">&nbsp;&nbsp;id</td><td class="auto-style1" width="100">用户身份证号</td><td class="auto-style1" width="100">房间id</td><td class="auto-style1" width="100">时间</td><td class="auto-style1">价格</td><td class="auto-style1">操作</td></tr>
            <%  
                string userid = Request.QueryString["userid"];
                List<YF.Model.Record> list=YF.BLL.Record.ListUserid(userid); %>
                <%for (int i = 0; i < list.Count; i++)
                    {%>
                        <tr><td width="100"><%=list[i].Id%></td><td width="100"><%=list[i].Userid%></td><td width="100"><%=list[i].Houseid%></td><td width="100"><%=list[i].Time%></td><td class="auto-style6"><%=list[i].Price%></td><td class="auto-style6"><a href="checkout.aspx?id=<%=list[i].Id %>&userid=<%=userid %>">退房</a></td></tr>
                    <%} %>
            </table>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
</body>
</html>
