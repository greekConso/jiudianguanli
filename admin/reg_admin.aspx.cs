using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_reg_admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        YF.Model.Admin admin = new YF.Model.Admin();
        admin.Name = this.name.Text;
        admin.Password = this.password.Text;
        if (YF.BLL.Admin.add(admin))
        {
            YF.JsHelper.AlertAndRedirect("注册成功", "admin_main.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("注册失败", "reg_admin.aspx");
        }
        return;
    }
}