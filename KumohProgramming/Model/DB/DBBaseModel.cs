using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KumohProgramming.Model.DB
{
	public class DBBaseModel
	{
		[BsonId]
		public ObjectId _id { get; set; }
	}
}

