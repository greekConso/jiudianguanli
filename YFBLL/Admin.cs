using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
    public class Admin
    {
        public static bool add(YF.Model.Admin admin)
        {
            return YF.DAL.Admin.add(admin);
        }
        public static bool Search(string name)
        {
            return YF.DAL.Admin.Search(name);
        }
        public static bool login(string name, string password)
        {
            return YF.DAL.Admin.login(name, password);
        }
    }
}
