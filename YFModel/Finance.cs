using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class Finance
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string houseid;
        public string Houseid
        {
            get { return houseid; }
            set { houseid = value; }
        }

        private string userid;
        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        private int user_delete;
        public int User_delete
        {
            get { return user_delete; }
            set { user_delete = value; }
        }

        private int admin_delete;
        public int Admin_delete
        {
            get { return admin_delete; }
            set { admin_delete = value; }
        }

    }
}
