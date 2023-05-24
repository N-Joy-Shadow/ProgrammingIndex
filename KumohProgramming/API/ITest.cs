using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KumohProgramming.API
{
	public interface ITest
	{
		[BsonId]
		public ObjectId _id { get; set; }
	}
}

