using System;
using KumohProgramming.Model.DB;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace KumohProgramming.Utils.DB
{
	public class CollectorManager<T> where T : DBBaseModel
	{
		private IMongoDatabase database;
		private IMongoCollection<T> collection;
		public CollectorManager(string collection)
		{
			this.database = DatabaseConnector.Instance.database;
			this.collection = this.database.GetCollection<T>(collection);
			
		}

		/**
		 * Make CRUD
		 */
		public void create()
		{

		}


        private FilterDefinition<T> Filter(string tree, dynamic value)
        {
            return Builders<T>.Filter.Eq(tree, value);

        }
        protected async Task<IAsyncCursor<T>> Get(string tree, object value)
		{
			return await this.collection.FindAsync(Filter(tree, value));

			
		}

		public async Task a()
		{

			var ab = await Get("aa", "Aa");
			var a = this.collection.FindAsync(Builders<T>.Filter.Eq("hi",""));
		}
		protected bool collectionNullCheck()
		{
			return !(this.collection == null);
		}
	}

}