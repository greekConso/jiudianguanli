using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YF.BLL
{
    public class House
    {
        public static bool add(YF.Model.House house)
        {
            return YF.DAL.House.add(house);
        }
        public static bool Search(int id)
        {
            return YF.DAL.House.Search(id);
        }

        public static List<YF.Model.House> list()
        {
            return YF.DAL.House.list();
        }

        public static List<YF.Model.House> ListOccupy(string occupy)
        {
            return YF.DAL.House.ListOccupy(occupy);
        }
        public static bool del(int id)
        {
            return YF.DAL.House.del(id);
        }

        public static bool update(YF.Model.House house)
        {
            return YF.DAL.House.update(house);
        }

        public static YF.Model.House GetHouse(int id)
        {
            return YF.DAL.House.GetHouse(id);
        }
    }
}
