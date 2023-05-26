<%@ Page Language="C#" AutoEventWireup="true" CodeFile="user_main.aspx.cs" Inherits="user_user_main" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>客户订房</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>

/* 头部样式 */
.header {
  background-color:gold;
  padding: 20px;
  text-align: center;
}

/* 导航条 */
.topnav {
  background-color: #333;
  overflow:hidden;
}

/* 导航链接 */
.topnav a {
  float: left;
  display: block;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

/* 链接 - 修改颜色 */
.topnav a:hover {
  background-color: #ddd;
  color: black;
}



.bottom{
    align-self:center;
    width:100%;
    height:auto;
}


</style>
</head>
<body>
    <%   string userid = Request.QueryString["userid"];
        %>
<div class="header">
  <h1>你好，尊敬的顾客！</h1>
  <p>欢迎进入田所浩二的酒店管理系统</p>
</div>

<div class="topnav">
  <a href="book.aspx?userid=<%=userid%>">我要订房</a>
  <a href="list.aspx?userid=<%=userid%>">我要入住</a>
  <a href="checkout.aspx?userid=<%=userid%>">我要退房</a>
  <a href="history.aspx?userid=<%=userid%>">历史账单</a>
  <a href="../main.aspx">退出登录</a>
</div>

  
  <div class="column middle">
    <h2>这是用户主界面</h2>
    <p>用户通过点击上方导航条完成系列操作！</p>
  </div>
  
  <div class="bottom">
  <img src="../image/hotel.jpg" class="bottom">
  </div>

  
</body>
</html>