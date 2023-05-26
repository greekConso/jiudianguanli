using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using YF;

public partial class reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        YF.Model.User user = new YF.Model.User();
        user.Identifier = this.identifier.Text;
        int i;
        if(user.Identifier.Length!=18)
        {
            YF.JsHelper.AlertAndRedirect("非法的身份证号长度！！", "reg_user.aspx");
            return;
        }
        for(i=0;i<user.Identifier.Length-1;i++)
        {
            if(user.Identifier[i]<'0'||user.Identifier[i]>'9')
            {
                YF.JsHelper.AlertAndRedirect("含有非法字符！", "reg_user.aspx");
                return;
            }
        }
        if (user.Identifier[i]!='X'&& user.Identifier[i] != 'x' && (user.Identifier[i] < '0' || user.Identifier[i] > '9'))
        {
            YF.JsHelper.AlertAndRedirect("含有非法字符！", "reg_user.aspx");
            return;
        }
        user.Password = this.password.Text;
        user.Name = this.name.Text;
        user.Mobile = this.mobile.Text;
        user.Occupy = 2;
        if (YF.BLL.User.SearchIdentifier(this.identifier.Text).Count!=0)
        {
            YF.JsHelper.AlertAndRedirect("重复的身份证！", "reg_user.aspx");
        }
        else
        {
            if (YF.BLL.User.add(user))
            {
                YF.JsHelper.AlertAndRedirect("注册成功", "user_main.aspx");
            }
            else
            {
                YF.JsHelper.AlertAndRedirect("注册失败", "reg_user.aspx");
            }
        }
        return;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("../main.aspx");
    }
}