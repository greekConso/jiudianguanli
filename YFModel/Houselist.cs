using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class Houselist
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int houseid;
        public int Houseid
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
    }
}
