using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool.ObjectModels
{
    internal class AuctionListModel
    {
        public List<AuctionCollectionModel> ToCollect { get; set; }

        public int ItemCount { get; set; }

        public DateTime CollectionDate { get; set; }

        public AuctionListModel(List<AuctionCollectionModel> _ToCollect, int _ItemCount, DateTime _CollectionDate)
        {
            ToCollect = _ToCollect;
            ItemCount = _ItemCount;
            CollectionDate = _CollectionDate;
        }
        public static void CreateCollectionList(List<AuctionCollectionModel> ToCollect,int  ItemCount,DateTime CollectionDate)
        {
            AuctionListModel created = new AuctionListModel(ToCollect, ItemCount, CollectionDate);

            //save to db
        }
    }
}
