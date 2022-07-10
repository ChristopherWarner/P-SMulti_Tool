﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;

namespace P_SMulti_Tool
{
    public class SQLiteDataAccess

    {
        public static int GetAuctionHouseNumber(string Name)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var auctioneer = cnn.Query<ObjectModels.AuctioneerModel>("select AuctionHouseNumber from AuctionHouses WHERE AuctioneerName = @Name", new DynamicParameters());
                return Convert.ToInt32(auctioneer);
            }
            
            
            
        }
        
        public static List<AuctionCollectionModel> ReturnRoseberyList(AuctionCollectionModel passed)
        {
            var AuctionHouseNumber = passed.AuctionHouseNumber;
            
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var auctioneer = cnn.Query<ResidentialCollectionModel>("select * from AuctionHouses WHERE AuctionHouseNumber = @AuctionHouseNumber", new DynamicParameters());
            }



            
        }

        //Return residentials in List<T>
        public static List<ResidentialCollectionModel> LoadResidentialCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ResidentialCollectionModel>("select * from ResidentialCollections", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save residential object to residential table in MainDB
        public static void SaveResidentialCollectionModel(ResidentialCollectionModel created)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into ResidentialCollections (string JobNumber, Name, Description, Collected, CreateDate, CollectedOn, Address1, Address2, Postcode, ContactNumber) values (@JobNumber, @Name, @Description, @Collected, @CreateDate, @CollectedOn, @Address1, @Address2, @Postcode, @ContactNumber)", created);
            }
        }


        // Return auction collections from MainDB in form of list <T>
        public static List<AuctionCollectionModel> LoadAuctionCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AuctionCollectionModel>("select * from AuctionCollections", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save auction collection passed to AuctionCollection table in MainDB
        public static void SaveAuctionCollectionModel(AuctionCollectionModel created)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into AuctionCollections (JobNumber, Name, Description, Collected, CreateDate, CollectedOn, LotNumber, DateOfSale, AuctionHouse) values (@JobNumber, @Name, @Description, @Collected, @CreateDate, @CollectedOn, @LotNumber, @DateOfSale, @AuctionHouse)", created);
            }
        }

        // load list of Auctioneer model from auctioneer table in MainDB in form of List<T>
        public static List<ObjectModels.AuctioneerModel> LoadAuctioneers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ObjectModels.AuctioneerModel>("select * from AuctionHouses", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save auctioneer model passed to auctioneer table in MainDB
        public static void SaveAuctioneerModel(ObjectModels.AuctioneerModel created)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into AuctionHouses (Name, Road, Town, Postcode, ContactNumber, Email) values (@Name, @Road, @Town, @Postcode, @ContactNumber, @Email)", created);
            }
        }
        public static ObjectModels.AuctioneerModel 

        
        private static string LoadConnectionString(string ID = "maindb")
        {

            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }


}
