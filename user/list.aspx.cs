using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string userid = Request.QueryString["userid"];
        List<YF.Model.Houselist> list = YF.BLL.Houselist.ListUserid(userid);
        int i,price;
        string houseid="";
        YF.Model.Record record = new YF.Model.Record();
        YF.Model.Finance finance = new YF.Model.Finance();
        for (i=0,price=0;i<list.Count;i++)
        {
            YF.Model.House house = YF.BLL.House.GetHouse(list[i].Houseid);
            house.Occupy = "占用";
            YF.BLL.House.update(house);
            houseid +=house.Id.ToString();
            houseid +=' ';
            price += list[i].Price;
            YF.BLL.Houselist.del(list[i].Id);
        }
        record.Time = DateTime.Now;
        record.Userid = userid;
        record.Price = price;
        record.Houseid = houseid;
        finance.Time = DateTime.Now;
        finance.Userid = userid;
        finance.Price = price;
        finance.Houseid = houseid;
        finance.Admin_delete = 0;
        finance.User_delete = 0;
        YF.BLL.Record.add(record);
        YF.BLL.Finance.add(finance);
        YF.JsHelper.AlertAndRedirect("提交成功！", "user_main.aspx?userid=" + userid);
        return;
    }
}