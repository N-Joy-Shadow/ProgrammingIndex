using System;
using MongoDB;
using MongoDB.Driver;

namespace KumohProgramming.Utils.DB
{
	public class DatabaseConnector
	{
        DatabaseConnector Instance = new DatabaseConnector();
		public DatabaseConnector()
		{
            string connectionString = Env.Get["MongoDB_URI"];

             var client = new MongoClient(connectionString);


        }
    }
}