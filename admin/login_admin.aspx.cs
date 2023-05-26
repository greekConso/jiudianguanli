using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_login_admin :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("reg_admin.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string name = this.name.Text;
        string password = this.password.Text;
        if (YF.BLL.Admin.login(name, password))
        {
            YF.JsHelper.AlertAndRedirect("登录成功！", "admin_main.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("姓名或密码不正确！", "login_admin.aspx");
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("../main.aspx");
    }
}