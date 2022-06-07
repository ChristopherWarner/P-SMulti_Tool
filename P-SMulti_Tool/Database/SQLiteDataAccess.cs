using System;
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
        //Return residentials in List<T>
        public static List<ResidentialCollectionModel> LoadResidentialCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ResidentialCollectionModel>("select * from residential collection model", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save residential object to residential table in MainDB
        public static void SaveResidentialCollectionModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute
            }
        }


        // Return auction collections from MainDB in form of list <T>
        public static List<AuctionCollectionModel> LoadAuctionCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<AuctionCollectionModel>("select * from residential collection model", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save auction collection passed to auction collection table in MainDB
        public static void SaveAuctionCollectionModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute
            }
        }

        // load list of Auctioneer model from auctioneer table in MainDB in form of List<T>
        public static List<ObjectModels.AuctioneerModel> LoadAuctioneers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ObjectModels.AuctioneerModel>("select * from residential collection model", new DynamicParameters());
                return output.AsList();
            }

        }

        //Save auctioneer model passed to auctioneer table in MainDB
        public static void SaveAuctioneerModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute
            }
        }

        
        private static string LoadConnectionString(string ID = "Main")
        {

            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }


}
