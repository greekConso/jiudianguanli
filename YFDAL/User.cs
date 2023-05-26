using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace YF.DAL
{
    /// <summary>
    /// 数据库访问层
    /// </summary>
    public class User
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>  
        public static string encode(string s)
        {
            //加密方式：数字：加7模10；大写字母转小写，小写字母转大写
            string ans="";
            char c;
            int digit,i;
            for(i=0;i<s.Length;i++)
            {
                if(s[i]>='0'&&s[i]<='9')
                {
                    digit = s[i] - '0';
                    digit += 7;
                    digit %= 10;
                    ans+=digit.ToString();
                }
                else if(s[i]>='A'&&s[i]<='Z')
                {
                    c = (char)(s[i] + 32);
                    ans += c.ToString();
                }
                else if (s[i] >= 'a' && s[i] <= 'z')
                {
                    c = (char)(s[i] - 32);
                    ans += c.ToString();
                }
            }
            return ans;
        }

        public static string decode(string s)
        {
            //解密方式：数字：减7，小于0则加10；大写字母转小写，小写字母转大写
            string ans = "";
            char c;
            int digit,i;
            for (i=0;i<s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    digit = s[i] - '0';
                    digit -= 7;
                    if(digit<0)digit += 10;
                    ans += digit.ToString();
                }
                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    c = (char)(s[i] + 32);
                    ans += c.ToString();
                }
                else if (s[i] >= 'a' && s[i] <= 'z')
                {
                    c = (char)(s[i] - 32);
                    ans += c.ToString();
                }
            }
            return ans;
        }
        public static bool add(YF.Model.User user)
        {
            bool result = false;
            user.Password = encode(user.Password);
            string strsql = "insert into t_user (identifier,name,password,occupy,mobile) values('"+user.Identifier+ "','" + user.Name + "','" + user.Password+ "'," + user.Occupy + ",'" + user.Mobile + "')";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }
        public static List<YF.Model.User> SearchName(string name)
        {
            string strsql = "select * from t_user where name='" + name + "'";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dt);
        }

        public static List<YF.Model.User> SearchFirstName(string fname)
        {
            fname += "%";
            string strsql = "select * from t_user where name like'" + fname + "'";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dt);
        }

        public static List<YF.Model.User> SearchIdentifier(string identifier)
        {
            string strsql = "select * from t_user where identifier='" + identifier+ "'";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dt);
        }


        public static bool login(string identifier,string password)
        {
            bool result=false;
            string enc_pwd = encode(password);
            string strsql = "select * from t_user where identifier='" + identifier + "' and password='" + enc_pwd + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count != 0)
                result = true;
            else result = false;
            return result;
        }
        public static List<YF.Model.User> list()
        {
            string strsql = "select * from t_user order by identifier desc";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            return Dttolist(dataTable);
        }
        public static List<YF.Model.User> Dttolist(DataTable dt)
        {
            List<YF.Model.User> list = new List<YF.Model.User>();
            for(int i=0;i<dt.Rows.Count;i++)
            {
                YF.Model.User user = new YF.Model.User();
                user.Identifier = dt.Rows[i]["Identifier"].ToString();
                user.Name = dt.Rows[i]["Name"].ToString();
                user.Password = decode(dt.Rows[i]["Password"].ToString());
                user.Occupy = int.Parse(dt.Rows[i]["Occupy"].ToString());
                user.Mobile = dt.Rows[i]["Mobile"].ToString();
                list.Add(user);
            }
            return list;
        }
        public static bool del(string identifier)
        {
            bool result=false;
            string strsql = "delete from t_user where identifier='" + identifier + "'";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }
        public static bool update(YF.Model.User user)
        {
            bool result = false;
            user.Password = encode(user.Password);
            string strsql = "update t_user set name='" + user.Name + "',password='" + user.Password + "',occupy=" + user.Occupy + ",mobile='" + user.Mobile + "' where identifier='" + user.Identifier + "'";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            if (i > 0) result = true;
            return result;
        }
        
        public static YF.Model.User GetUser(string identifier)
        {
            YF.Model.User user = new YF.Model.User();
            string strsql = "select * from t_user where identifier='" + identifier + "'";
            DataTable dt = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if(dt.Rows.Count!=0)
            {
                user.Identifier = dt.Rows[0]["Identifier"].ToString();
                user.Name = dt.Rows[0]["Name"].ToString();
                user.Password = decode(dt.Rows[0]["Password"].ToString());
                user.Occupy = int.Parse(dt.Rows[0]["Occupy"].ToString());
                user.Mobile = dt.Rows[0]["Mobile"].ToString();
            }
            return user;
        }
    }
}
