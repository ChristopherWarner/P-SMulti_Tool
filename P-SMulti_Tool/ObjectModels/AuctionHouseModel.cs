﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P_SMulti_Tool.ObjectModels
{
    class AuctionHouseModel
    {
        public string Name { get; set; }
        public string Road { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }

        public AuctionHouseModel(string _Name, string _Road, string _Town, string _Postcode, string _ContactNumber, string _Email)
        {
            Name = _Name;
            Road = _Road;
            Town = _Town;
            Postcode = _Postcode;
            ContactNumber = _ContactNumber;
            Email = _Email;
        }

        public static AuctionHouseModel CreateAuctionCollectionModel(string Name, string Road, string Town, string Postcode, string ContactNumber, string Email)
        {
            AuctionHouseModel created = new AuctionHouseModel(Name, Road, Town, Postcode, ContactNumber, Email);

            return created;
        }



    }



}

    

