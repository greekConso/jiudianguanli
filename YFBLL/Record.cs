using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.BLL
{
    public class Record
    {
        public static bool add(YF.Model.Record record)
        {
            return YF.DAL.Record.add(record);
        }

        public static List<YF.Model.Record> list()
        {
            return YF.DAL.Record.list();
        }

        public static List<YF.Model.Record> ListUserid(string userid)
        {
            return YF.DAL.Record.ListUserid(userid);
        }


        public static List<YF.Model.Record> Dttolist(DataTable dt)
        {
            return YF.DAL.Record.Dttolist(dt);
        }

        public static bool del(int id)
        {
            return YF.DAL.Record.del(id);
        }

        public static YF.Model.Record GetRecord(int id)
        {
            return YF.DAL.Record.GetRecord(id);
        }


    }
}
