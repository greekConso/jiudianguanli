using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.Model
{
    public class House
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string occupy;
        public string Occupy
        {
            get { return occupy; }
            set { occupy = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private string img;
        public string Img
        {
            get { return img; }
            set { img = value; }
        }

    }
}
