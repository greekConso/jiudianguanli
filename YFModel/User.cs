using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    /// <summary>
    /// 实体层
    /// </summary>
    public class User
    {

        private string identifier;
        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int occupy;
        public int Occupy
        {
            get { return occupy; }
            set { occupy = value; }
        }


        private string mobile;
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
    }
}
