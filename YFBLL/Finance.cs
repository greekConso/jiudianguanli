using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.BLL
{
    public class Finance
    {
        public static bool add(YF.Model.Finance finance)
        {
            return YF.DAL.Finance.add(finance);
        }
        public static bool Search(int id)
        {
            return YF.DAL.Finance.Search(id);
        }
        public static List<YF.Model.Finance> list()
        {
            return YF.DAL.Finance.list();
        }

        public static List<YF.Model.Finance> ListUserid(string userid)
        {
            return YF.DAL.Finance.ListUserid(userid);
        }
        public static List<YF.Model.Finance> Dttolist(DataTable dt)
        {
            return YF.DAL.Finance.Dttolist(dt);
        }
        public static bool user_del(int id)
        {
            return YF.DAL.Finance.user_del(id);
        }

        public static bool admin_del(int id)
        {
            return YF.DAL.Finance.admin_del(id);
        }

        public static bool del(int id)
        {
            return YF.DAL.Finance.del(id);
        }
        public static YF.Model.Finance GetFinance(int id)
        {
            return YF.DAL.Finance.GetFinance(id);
        }
    }
}

