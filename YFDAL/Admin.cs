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
    public class Admin
    {
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>    
        public static string encode(string s)
        {
            //加密方式：数字：加7模10；大写字母转小写，小写字母转大写
            string ans = "";
            char c;
            int digit, i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    digit = s[i] - '0';
                    digit += 7;
                    digit %= 10;
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

        public static string decode(string s)
        {
            //解密方式：数字：减7，小于0则加10；大写字母转小写，小写字母转大写
            string ans = "";
            char c;
            int digit, i;
            for (i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    digit = s[i] - '0';
                    digit -= 7;
                    if (digit < 0) digit += 10;
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
        public static bool add(YF.Model.Admin admin)
        {
            bool result = false;
            admin.Password = encode(admin.Password);
            string strsql = "insert into t_admin (name,password) values('" + admin.Name + "','" + admin.Password + "')";
            int i = YF.MsSqlHelper.YFMsSqlHelper.ExecuteSql(strsql);
            result = i > 0;
            return result;
        }
        public static bool Search(string name)
        {
            bool result = false;
            string strsql = "select * from t_user where name='" + name + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count == 0)
                result = true;
            else result = false;
            return result;
        }

        public static bool login(string name, string password)
        {
            bool result = false;
            string enc_pwd = encode(password);
            string strsql = "select * from t_admin where name='" + name + "' and password='" + enc_pwd + "'";
            DataTable dataTable = YF.MsSqlHelper.YFMsSqlHelper.Query(strsql).Tables[0];
            if (dataTable.Rows.Count != 0)
                result = true;
            else result = false;
            return result;
        }
    }
}
