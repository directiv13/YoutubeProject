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
    class YtHistoryContext : IDownloadsHistoryContext, ISearchHistoryContext
    {
        private readonly IMongoCollection<YtHistoryItem> historyCollection;

        public YtHistoryContext(IMongoCollection<YtHistoryItem> historyCollection)
        {
            this.historyCollection = historyCollection;
        }

        public List<YtHistoryItem> Get() =>
            historyCollection.Find(item => true).ToList();

        public YtHistoryItem Get(string id) =>
            historyCollection.Find(item => item.Id == id).FirstOrDefault();

        public YtHistoryItem Create(YtHistoryItem item)
        {
            historyCollection.InsertOne(item);
            return item;
        }

        public void Update(string id, YtHistoryItem item) =>
            historyCollection.ReplaceOne(x => x.Id == id, item);

        public void Remove(YtHistoryItem item) =>
            historyCollection.DeleteOne(x => x.Id == item.Id);

        public void Remove(string id) =>
            historyCollection.DeleteOne(x => x.Id == id);
    }
}
