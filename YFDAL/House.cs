using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace YF.DAL
{/// <summary>
/// 数据库访问层
/// </summary>
    public class House
    {
        public static bool add(YF.Model.House house)
        {
            bool result = false;
            string strsql = "insert into t_house (category,occupy,price,img) values('" + house.Category+ "','" + house.Occupy + "'," + house.Price + ",'" + house.Img + "')";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }
        public static bool Search(int id)
        {
            bool result = false;
            string strsql = "select * from t_house where id=" + id + "";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count == 0)
                result = true;
            else result = false;
            return result;
        }

        public static List<YF.Model.House> list()
        {
            string strsql = "select * from t_house order by id asc";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.House> ListOccupy(string occupy)
        {
            string strsql = "select * from t_house where occupy='"+occupy+"'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }
        public static List<YF.Model.House> Dttolist(DataTable dt)
        {
            List<YF.Model.House> list = new List<YF.Model.House>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.House house = new YF.Model.House();
                house.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                house.Price = int.Parse(dt.Rows[i]["Price"].ToString());
                house.Occupy = dt.Rows[i]["Occupy"].ToString();
                house.Category = dt.Rows[i]["Category"].ToString();
                house.Img = dt.Rows[i]["Img"].ToString();
                list.Add(house);
            }
            return list;
        }
        public static bool del(int id)
        {
            bool result = false;
            File.Delete("D:/课设项目/课设项目/myweb/myweb/myweb/image/" + GetHouse(id).Img);
            string strsql = "delete from t_house where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }
        public static bool update(YF.Model.House house)
        {
            bool result = false;
            string strsql="update t_house set category='"+house.Category+"',occupy='"+house.Occupy+"',price="+house.Price+",img='"+house.Img+"' where id="+house.Id+"";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static YF.Model.House GetHouse(int id)
        {
            YF.Model.House house = new YF.Model.House();
            string strsql = "select * from t_house where id=" + id + "";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dt.Rows.Count != 0)
            {
                house.Id = int.Parse(dt.Rows[0]["id"].ToString());
                house.Occupy = dt.Rows[0]["Occupy"].ToString();
                house.Category = dt.Rows[0]["Category"].ToString();
                house.Price = int.Parse(dt.Rows[0]["Price"].ToString());
                house.Img = dt.Rows[0]["Img"].ToString();
            }
            return house;
        }
    }
}
