using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string identifier = this.identifier.Text;
        string password = this.password.Text;
        if(YF.BLL.User.login(identifier,password))
        {
            string href= "user_main.aspx?userid="+identifier;
            YF.JsHelper.AlertAndRedirect("登录成功！",href);
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("身份证或密码不正确！", "login_user.aspx");
        }
    }

    protected void user_reg_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("reg_user.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("../main.aspx");
    }
}