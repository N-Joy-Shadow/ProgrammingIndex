using System;
using MongoDB;
using MongoDB.Driver;
namespace KumohProgramming.Utils.DB
{
    public class DatabaseConnector
    {
        public MongoClient client;
        public IMongoDatabase database;
        public static DatabaseConnector Instance = new DatabaseConnector();

        public DatabaseConnector()
        {
            string connectionString = Env.Get["MongoDB_URI"];

            this.client = new MongoClient(connectionString);
            this.database = client.GetDatabase("learn_lang");

        }
    }
}