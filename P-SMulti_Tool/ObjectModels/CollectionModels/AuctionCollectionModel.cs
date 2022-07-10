using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class AuctionCollectionModel : CollectionModel
    {

        public string LotNumber { get; set; }
        public string DateOfSale { get; set; }
        public int  AuctionHouseNumber { get; set; }

        public AuctionCollectionModel()
        {

        }

        public AuctionCollectionModel(string jobnumber, string name, string description, bool collected, DateTime createDate, DateTime collectedOn, string lotNumber, string dateOfSale, int auctionHouseNumber)
        {

            JobNumber = jobnumber;
            Name = name;
            Description = description;
            Collected = collected;
            CreateDate = createDate;
            CollectedOn = collectedOn;
            LotNumber = lotNumber;
            DateOfSale = dateOfSale;
            AuctionHouseNumber = auctionHouseNumber;
        }

        public static void CreateAuctionCollection(string jobNumber, string name, string description, bool collected, DateTime createdOn, DateTime collectedOn, string lotNumber, string dateOfSale, int auctionHouseNumber)
        {
            AuctionCollectionModel created = new AuctionCollectionModel(jobNumber, name, description, collected, createdOn, collectedOn, lotNumber, dateOfSale, auctionHouseNumber);


            SQLiteDataAccess.SaveAuctionCollectionModel(created);
        }



    }
    

    
}
