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

        [BsonElement("plot")]
        public string Plot { get; set; } = String.Empty;

        [BsonElement("genres")]
        public string[] Genres { get; set; } =  { };

        [BsonElement("poster")]
        public string Poster { get; set; } = String.Empty;

        [BsonElement("languages")]
        public string[] Languages { get; set; } = {};

        [BsonElement("year")]
        public int? Year { get; set; } = null;

        [BsonElement("released")]
        public DateTime? Released { get; set; } = null;

        [BsonElement("awards")]
        public Award? awards { get; set; } = null; 
    }
}

