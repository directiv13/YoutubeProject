using DataAccess.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    class DownloadsHistoryContext : IDownloadsHistoryContext
    {
        private readonly IMongoCollection<DownloadsHistoryItem> historyCollection;

        public DownloadsHistoryContext(IMongoCollection<DownloadsHistoryItem> historyCollection)
        {
            this.historyCollection = historyCollection;
        }

        public List<DownloadsHistoryItem> Get() =>
            historyCollection.Find(item => true).ToList();

        public DownloadsHistoryItem Get(string id) =>
            historyCollection.Find(item => item.Id == id).FirstOrDefault();

        public DownloadsHistoryItem Create(DownloadsHistoryItem item)
        {
            historyCollection.InsertOne(item);
            return item;
        }

        public void Update(string id, DownloadsHistoryItem item) =>
            historyCollection.ReplaceOne(x => x.Id == id, item);

        public void Remove(DownloadsHistoryItem item) =>
            historyCollection.DeleteOne(x => x.Id == item.Id);

        public void Remove(string id) =>
            historyCollection.DeleteOne(x => x.Id == id);
    }
}
