using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL
{
    public class Record
    {
        public static bool add(YF.Model.Record record)
        {
            bool result = false;
            string strsql = "insert into t_record (userid,houseid,price,time) values('" + record.Userid + "','" + record.Houseid + "'," + record.Price + ",'" + record.Time + "')";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }
       
        public static List<YF.Model.Record> list()
        {
            string strsql = "select * from t_record order by id desc";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.Record> ListUserid(string userid)
        {
            string strsql = "select * from t_record where userid='"+userid+"'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }

        public static List<YF.Model.Record> Dttolist(DataTable dt)
        {
            List<YF.Model.Record> list = new List<YF.Model.Record>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                YF.Model.Record record = new YF.Model.Record();
                record.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                record.Userid = dt.Rows[i]["Userid"].ToString();
                record.Houseid = dt.Rows[i]["Houseid"].ToString();
                record.Price = int.Parse(dt.Rows[i]["Price"].ToString());
                record.Time = DateTime.Parse(dt.Rows[i]["Time"].ToString());
                list.Add(record);
            }
            return list;
        }
        public static bool del(int id)
        {
            bool result = false;
            string strsql = "delete from t_record where id=" + id + "";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }

        public static YF.Model.Record GetRecord(int id)
        {
            YF.Model.Record record = new YF.Model.Record();
            string strsql = "select * from t_record where id=" + id + "";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dt.Rows.Count != 0)
            {
                record.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                record.Userid = dt.Rows[0]["Userid"].ToString();
                record.Houseid = dt.Rows[0]["Houseid"].ToString();
                record.Price = int.Parse(dt.Rows[0]["Price"].ToString());
                record.Time = DateTime.Parse(dt.Rows[0]["Time"].ToString());
            }
            return record;
        }

        bool update(int id,List<int> new_house)
        {
            int price = 0;
            int p = 0;
            string house_id="";
            int i;
            for (i = 0; i < new_house.Count; i++)
            {
                house_id += new_house[i].ToString();
                house_id += ' ';
                string price_sql = "select * from t_house where id=" + new_house[i] + "";
                DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(price_sql).Tables[0];
                price += int.Parse(dt.Rows[0]["price"].ToString());
            }

            string strsql = "update t_record set houseid='" + house_id + "',price=" + price + "";
            i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            return i != 0;
        }

    }
}
