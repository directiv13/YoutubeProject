using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataAccess.Models
{
    public class YtHistoryItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public Uri Uri { get; set; }
        public int UserId { get; set; }
    }
}
