using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Mflix.Models
{
	[BsonIgnoreExtraElements]
	public class Movie
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; } = String.Empty;

		[BsonElement("title")]
		public string Title { get; set; } = String.Empty;
    }
}

