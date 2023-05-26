using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL
{
    public class Houselist
    {
        public static bool add(YF.Model.Houselist houselist)
        {
            bool result = false;
            string strsql = "insert into t_list (userid,houseid,price,time) values('" + houselist.Userid + "'," + houselist.Houseid + "," + houselist.Price + ",'" + houselist.Time + "')";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }

        public static List<YF.Model.Houselist> list()
        {
            string strsql = "select * from t_list order by id desc";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.Houselist> ListUserid(string userid)
        {
            string strsql = "select * from t_list where userid='" + userid + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.Houselist> Dttolist(DataTable dt)
        {
            List<YF.Model.Houselist> list = new List<YF.Model.Houselist>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Houselist houselist = new YF.Model.Houselist();
                houselist.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                houselist.Userid = dt.Rows[i]["Userid"].ToString();
                houselist.Houseid = int.Parse(dt.Rows[i]["Houseid"].ToString());
                houselist.Price = int.Parse(dt.Rows[i]["Price"].ToString());
                houselist.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                list.Add(houselist);
            }
            return list;
        }
        public static bool del(int id)
        {
            bool result = false;
            string strsql = "delete from t_list where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static YF.Model.Houselist GetHouselist(int id)
        {
            YF.Model.Houselist houselist = new YF.Model.Houselist();
            string strsql = "select * from t_list where id=" + id + "";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dt.Rows.Count != 0)
            {
                houselist.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                houselist.Userid = dt.Rows[0]["Userid"].ToString();
                houselist.Houseid = int.Parse(dt.Rows[0]["Houseid"].ToString());
                houselist.Price = int.Parse(dt.Rows[0]["Price"].ToString());
                houselist.Time = DateTime.Parse(dt.Rows[0]["Time"].ToString());
            }
            return houselist;
        }
    }
}
