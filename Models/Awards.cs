using MongoDB.Bson.Serialization.Attributes;

namespace Mflix.Models
{
    public class Award
    {
        [BsonElement("wins")]
        public int Wins { get; set; } = 0;

        [BsonElement("nominations")]
        public int Nominations { get; set; } = 0;

        [BsonElement("text")]
        public string Text { get; set; } = "";
    }

}

