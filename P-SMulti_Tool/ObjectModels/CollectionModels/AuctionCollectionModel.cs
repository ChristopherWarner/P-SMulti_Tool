using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class AuctionCollectionModel : BaseCollectionModel
    {

        public string LotNumber { get; set; }
        public string DateOfSale { get; set; }
        public string AuctionHouse { get; set; }
        public int? CollectionListIndex { get; set; } = null;


        public AuctionCollectionModel()
        {

        }

        public AuctionCollectionModel(string jobnumber, string name, string description, bool collected, DateTime createDate, DateTime collectedOn, string lotNumber, string dateOfSale, string auctionHouse, int? collectionListIndex)
        {

            JobNumber = jobnumber;
            Name = name;
            Description = description;
            Collected = collected;
            CreateDate = createDate;
            CollectedOn = collectedOn;
            LotNumber = lotNumber;
            DateOfSale = dateOfSale;
            AuctionHouse = auctionHouse;
            CollectionListIndex = collectionListIndex;
        }

        public static void CreateAuctionCollection(string jobNumber, string name, string description, bool collected, DateTime createdOn, DateTime collectedOn, string lotNumber, string dateOfSale, string auctionHouse, int? collectionListIndex)
        {
            AuctionCollectionModel created = new AuctionCollectionModel(jobNumber, name, description, collected, createdOn, collectedOn, lotNumber, dateOfSale, auctionHouse, collectionListIndex);

            SQLiteDataAccess.SaveAuctionCollectionModel(created);
        }
        
        
      
        



    }
    public class RoseberyListManager
    {

        public static void SetCollectionIndex()
        {

        }









    }



}
