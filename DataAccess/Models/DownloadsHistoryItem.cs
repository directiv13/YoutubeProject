using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataAccess.Models
{
    public class DownloadsHistoryItem : YtHistoryItemBase
    {
        public Uri Uri { get; set; }
    }
}
