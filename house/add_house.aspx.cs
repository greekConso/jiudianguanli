using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class house_add_house : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        YF.Model.House house = new YF.Model.House();
        house.Category = category.Text;
        house.Occupy = occupy.Text;
        house.Price = int.Parse(price.Text);
        if(img.HasFile)
        {
            string filename = DateTime.Now.Year.ToString()+ DateTime.Now.Month.ToString()+ DateTime.Now.Day.ToString()+ DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString()+ DateTime.Now.Millisecond.ToString()+Path.GetExtension(img.FileName);
            string filepath = "D:/课设项目/课设项目/myweb/myweb/myweb/image/"+filename;
            img.SaveAs(filepath);
            house.Img = filename;
        }
        if(YF.BLL.House.add(house))
        {
            YF.JsHelper.AlertAndRedirect("添加成功！", "../admin/admin_main.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("添加失败！", "add_house.aspx");
        }
        return;
    }
}