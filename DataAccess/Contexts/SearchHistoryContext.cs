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
    class SearchesHistoryContext : ISearchHistoryContext
    {
        private readonly IMongoCollection<SearchHistoryItem> historyCollection;

        public SearchesHistoryContext(IMongoCollection<SearchHistoryItem> historyCollection)
        {
            this.historyCollection = historyCollection;
        }

        public List<SearchHistoryItem> Get() =>
            historyCollection.Find(item => true).ToList();

        public SearchHistoryItem Get(string id) =>
            historyCollection.Find(item => item.Id == id).FirstOrDefault();

        public SearchHistoryItem Create(SearchHistoryItem item)
        {
            historyCollection.InsertOne(item);
            return item;
        }

        public void Update(string id, SearchHistoryItem item) =>
            historyCollection.ReplaceOne(x => x.Id == id, item);

        public void Remove(SearchHistoryItem item) =>
            historyCollection.DeleteOne(x => x.Id == item.Id);

        public void Remove(string id) =>
            historyCollection.DeleteOne(x => x.Id == id);
    }
}
