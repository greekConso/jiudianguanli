using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
    /// <summary>
    /// 业务层
    /// </summary>
    public class User
    {
        public static bool add(YF.Model.User user)
        {
            return YF.DAL.User.add(user);
        }
        public static List<YF.Model.User> SearchName(string name)
        {
            return YF.DAL.User.SearchName(name);
        }

        public static List<YF.Model.User> SearchIdentifier(string identifier)
        {
            return YF.DAL.User.SearchIdentifier(identifier);
        }

        public static List<YF.Model.User> SearchFirstName(string name)
        {
            return YF.DAL.User.SearchFirstName(name);
        }

        public static bool login(string username,string password)
        {
            return YF.DAL.User.login(username,password);
        }
        public static List<YF.Model.User> list()
        {
            return YF.DAL.User.list();
        }
        public static bool del(string identifier)
        {
            return YF.DAL.User.del(identifier);
        }
        public static bool update(YF.Model.User user)
        {
            return YF.DAL.User.update(user);
        }
        public static YF.Model.User GetUser(string identifier)
        {
            return YF.DAL.User.GetUser(identifier);
        }

    }
}
