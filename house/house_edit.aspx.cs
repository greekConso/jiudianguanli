using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class house_house_edit :  System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string id = Request.QueryString["id"];

            YF.Model.House house = YF.BLL.House.GetHouse(int.Parse(id));

            this.id.Text = house.Id.ToString();
            this.price.Text = house.Price.ToString();
            this.occupy.Text = house.Occupy.ToString();
            this.category.Text = house.Category;
            this.old_img.Value = house.Img.ToString();
        }

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        YF.Model.House house  = new YF.Model.House();
        house.Id = int.Parse(this.id.Text);
        house.Price = int.Parse(this.price.Text);
        house.Occupy = this.occupy.Text;
        house.Category = this.category.Text;
        File.Delete("D:/课设项目/课设项目/myweb/myweb/myweb/image/" + old_img.Value.ToString());
        if(new_img.HasFile)
        {
            string filename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + Path.GetExtension(new_img.FileName);
            string filepath = "D:/课设项目/课设项目/myweb/myweb/myweb/image/" + filename;
            new_img.SaveAs(filepath);
            house.Img = filename;
        }
        if (YF.BLL.House.update(house))
        {
            YF.JsHelper.AlertAndRedirect("更新成功", "state.aspx");
        }
        else
        {
            YF.JsHelper.AlertAndRedirect("更新失败", "house_edit.aspx");
        }
        return;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        YF.JsHelper.Redirect("../admin/admin_main.aspx");
    }
}