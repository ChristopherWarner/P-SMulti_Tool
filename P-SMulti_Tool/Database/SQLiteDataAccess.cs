using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;
using System.Reflection.Metadata.Ecma335;

namespace P_SMulti_Tool
{
    public class SQLiteDataAccess

    {
        private static string LoadConnectionString(string ID = "maindb")
        {

            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }

        //****** - Start of Load Methods - *******//

        public static int ReturnCollectionKey(AuctionCollectionModel ToRetrieve)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AuctionCollectionModel>("select CollectionNumber from AuctionCollections Where (JobNumber = @JobNumber AND Name = @Name AND Description = @Description AND Collected = @Collected AND CreateDate = @CreateDate AND CollectedOn = @CollectedOn AND LotNumber = @LotNumber AND DateOfSale = @DateOfSale AND AuctionHouse = @AuctionHouse)", ToRetrieve);
                return Convert.ToInt32(output);
            }
        }

        public static List<ResidentialCollectionModel> LoadResidentialCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ResidentialCollectionModel>("select * from ResidentialCollections", new DynamicParameters());
                return output.AsList();
            }

        }


        //Following method will be converted to display auction collections that are not Rosebery
        public static List<AuctionCollectionModel> LoadAuctionCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AuctionCollectionModel>("select * from AuctionCollections", new DynamicParameters());
                return output.AsList();
            }

        }

        public static List<ObjectModels.AuctioneerModel> LoadAuctioneers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ObjectModels.AuctioneerModel>("select * from AuctionHouses", new DynamicParameters());
                return output.AsList();
            }

        }


        //****** - End of Load Methods - *******//

        //****** - Overwrite Method - ******//
        public static void OverwriteDatabaseEntry(AuctionCollectionModel Original, AuctionCollectionModel Updated)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
            }
        }

        //****** - Overwrite Method - ******//

        //****** - Start of Save Methods - *******//

        public static void SaveResidentialCollectionModel(ResidentialCollectionModel created)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into ResidentialCollections (string JobNumber, Name, Description, Collected, CreateDate, CollectedOn, Address1, Address2, Postcode, ContactNumber) values (@JobNumber, @Name, @Description, @Collected, @CreateDate, @CollectedOn, @Address1, @Address2, @Postcode, @ContactNumber)", created);
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

        
      

        //Save auctioneer model passed to auctioneer table in MainDB
        public static void SaveAuctioneerModel(ObjectModels.AuctioneerModel created)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into AuctionHouses (Name, Road, Town, Postcode, ContactNumber, Email) values (@Name, @Road, @Town, @Postcode, @ContactNumber, @Email)", created);
            }
        }

        //****** - End of Save Methods - *******//
        //****** - Remove Method - *******//

        public static void RemoveAuctionCollection(AuctionCollectionModel toDelete)
        {
           
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE  from AuctionCollections WHERE  (JobNumber = @JobNumber AND Name = @Name AND Description = @Description AND Collected = @Collected AND CreateDate = @CreateDate AND CollectedOn = @CollectedOn AND LotNumber = @LotNumber AND DateOfSale = @DateOfSale AND AuctionHouse = @AuctionHouse)", toDelete);
            }
        }



    }


}
