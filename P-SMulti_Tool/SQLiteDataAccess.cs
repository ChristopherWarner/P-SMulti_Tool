using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace P_SMulti_Tool
{
    public class SQLiteDataAccess
    {
        public static List<ResidentialCollectionModel> LoadResidentialCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())
            {

            }

        }
        public static void SaveResidentialCollectionModel()
        {

        }
        private static string LoadConnectionString(string ID = "Main")
        {

            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }


}
