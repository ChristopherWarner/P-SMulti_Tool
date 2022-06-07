using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool.ObjectModels
{
     public class AuctioneerModel
    {
        public string Name { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public AuctioneerModel(string _Name, string _Road, string _Town, string _Postcode, string _ContactNumber, string _Email)
        {
            Name = _Name;
            Road = _Road;
            Town = _Town;
            Postcode = _Postcode;
            ContactNumber = _ContactNumber;
            Email = _Email;
        }

        public static void CreateAuctionCollectionModel(string Name, string Road, string Town, string Postcode, string ContactNumber, string Email)
        {
            AuctioneerModel created = new AuctioneerModel(Name, Road, Town, Postcode, ContactNumber, Email);


        }
        public static void PassToDatabaseAuctionHouse(AuctioneerModel created)
        {


        }
    }
}
