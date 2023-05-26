using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL
{
    public class Finance
    {
        public static bool add(YF.Model.Finance finance)
        {
            bool result = false;
            string strsql = "insert into t_finance (time,userid,houseid,price,user_delete,admin_delete) values('" + finance.Time + "','" + finance.Userid + "','" + finance.Houseid + "'," + finance.Price+ "," + finance.User_delete + "," + finance.Admin_delete + ")";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }
        
          public static bool Search(int id)
        {
            bool result = false;
            string strsql = "select * from t_finance where id=" + id + "";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count == 0)
                result = true;
            else result = false;
            return result;
        }

        public static List<YF.Model.Finance> list()
        {
            int val = 0;
            string strsql = "select * from t_finance where admin_delete=" + val + "";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.Finance> ListUserid(string userid)
        {
            int val = 0;
            string strsql = "select * from t_finance where userid='"+userid+"' and user_delete="+ val +"";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }
        public static List<YF.Model.Finance> Dttolist(DataTable dt)
        {
            List<YF.Model.Finance> list = new List<YF.Model.Finance>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Finance finance = new YF.Model.Finance();
                finance.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                finance.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                finance.Houseid = dt.Rows[i]["Houseid"].ToString();
                finance.Userid= dt.Rows[i]["Userid"].ToString();
                finance.Price = int.Parse(dt.Rows[i]["Price"].ToString());
                list.Add(finance);
            }
            return list;
        }
        public static bool user_del(int id)
        {
            bool result = false;
            int val = 1;
            string strsql = "update t_finance set user_delete=" + val + "where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static bool admin_del(int id)
        {
            bool result = false;
            int val = 1;
            string strsql = "update t_finance set admin_delete=" + val + "where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static bool del(int id)
        {
            bool result = false;
            string strsql = "delete from t_finance where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static YF.Model.Finance GetFinance(int id)
        {
            YF.Model.Finance finance = new YF.Model.Finance();
            string strsql = "select * from t_finance where id=" + id + "";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dt.Rows.Count != 0)
            {
                finance.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                finance.Houseid = dt.Rows[0]["Houseid"].ToString();
                finance.Userid = dt.Rows[0]["Userid"].ToString();
                finance.Price = int.Parse(dt.Rows[0]["Price"].ToString());
                finance.Time = DateTime.Parse(dt.Rows[0]["Time"].ToString());
            }
            return finance;
        }
    }
}
