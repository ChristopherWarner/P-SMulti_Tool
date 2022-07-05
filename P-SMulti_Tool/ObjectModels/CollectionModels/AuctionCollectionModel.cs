using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool
{
    public class AuctionCollectionModel : CollectionModel
    {

        public string LotNumber { get; set; }
        public string DateOfSale { get; set; }
        public ObjectModels.AuctioneerModel  AuctionHouse { get; set; }

        public AuctionCollectionModel()
        {

        }

        public AuctionCollectionModel(string jobnumber, string name, string description, bool collected, DateTime createDate, DateTime collectedOn, string lotNumber, string dateOfSale, ObjectModels.AuctioneerModel auctionHouse)
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
        }

        public static AuctionCollectionModel CreateAuctionCollection(string jobNumber, string name, string description, bool collected, DateTime createdOn, DateTime collectedOn, string lotNumber, string dateOfSale, ObjectModels.AuctioneerModel auctionHouse)
        {
            AuctionCollectionModel create = new AuctionCollectionModel(jobNumber, name, description, collected, createdOn, collectedOn, lotNumber, dateOfSale, auctionHouse);

            return create;
        }



    }
    

    
}
