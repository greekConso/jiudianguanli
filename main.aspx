<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>
<html>
<head>
<meta charset="utf-8">
<title>田所浩二   1145141919810</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
/* 头部样式 */
.header {
  background-color: #f1f1f1;
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

<div class="header">
  <h1>老师您好！</h1>
  <p>欢迎进入田所浩二的酒店管理系统</p>
</div>

<div class="topnav">
  <a href="/user/login_user.aspx">我是顾客</a>
  <a href="/admin/login_admin.aspx">我是管理员</a>
</div>

  
  <div>
    <h2>主界面</h2>
    <p>这是主页面！登录者可以根据自己的身份选择登录方式</p>
  </div>
  
  <div class="bottom">
  <img src="image/hotel.jpg" alt="图片">
  </div>

  
</body>
</html>