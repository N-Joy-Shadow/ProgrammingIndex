using System;
using MongoDB;
namespace KumohProgramming.Utils.DB
{
	public class DatabaseConnector
	{

		public DatabaseConnector()
		{
            var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");

        }
    }
}