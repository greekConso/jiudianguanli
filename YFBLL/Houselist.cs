using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.BLL
{
    public class Houselist
    {
        public static bool add(YF.Model.Houselist houselist)
        {
            return YF.DAL.Houselist.add(houselist);
        }

        public static List<YF.Model.Houselist> list()
        {
            return YF.DAL.Houselist.list();
        }

        public static List<YF.Model.Houselist> ListUserid(string userid)
        {
            return YF.DAL.Houselist.ListUserid(userid);
        }

        public static List<YF.Model.Houselist> Dttolist(DataTable dt)
        {
            return YF.DAL.Houselist.Dttolist(dt);
        }

        public static bool del(int id)
        {
            return YF.DAL.Houselist.del(id);
        }

        public static YF.Model.Houselist GetHouselist(int id)
        {
            return YF.DAL.Houselist.GetHouselist(id);
        }
    }
}
