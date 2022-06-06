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
        public static List<ResidentialCollectionModel> LoadResidentialCollections()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ResidentialCollectionModel>("select * from residential collection model", new DynamicParameters());
                return output.AsList();
            }

        }
        public static void SaveResidentialCollectionModel()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute
            }
        }
        private static string LoadConnectionString(string ID = "Main")
        {

            return ConfigurationManager.ConnectionStrings[ID].ConnectionString;
        }
    }


}
