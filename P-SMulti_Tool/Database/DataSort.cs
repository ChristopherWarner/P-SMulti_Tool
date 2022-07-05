using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool.Database
{
    public class DataSort
    {
        public static void ReturnNotArranged()
        {

        }
        public static void ReturnCollected()
        {

        }
        public static void ReturnOverdue()
        {

        }
        public static List<AuctionCollectionModel> ReturnRoseberyList()
        {
            List<AuctionCollectionModel> loaded = SQLiteDataAccess.LoadAuctionCollections();
            List<AuctionCollectionModel> Roseberys = new List<AuctionCollectionModel>();

            for (int i = 0; i < loaded.Count; i++)
            {
                if (loaded[i].AuctionHouse.Name == "Rosebery")
                {
                    Roseberys.Add(loaded[i]);
                }
                else { }
            }

            return Roseberys;
        }

    }
}
