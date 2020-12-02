using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contexts;
using DataAccess.Models;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace DataAccess.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection, MongoDbOptions options)
        {
            var client = new MongoClient(options.ConnectionString);
            var database = client.GetDatabase(options.DatabaseName);
            var downloads = database.GetCollection<YtHistoryItem>(options.DownloadHistoryCollectionName);
            var searches = database.GetCollection<YtHistoryItem>(options.SearchHistoryCollectionName);
            var downloadsDbContext = new YtHistoryContext(downloads);
            var searchesDbContext = new YtHistoryContext(searches);

            serviceCollection.AddSingleton<IDownloadsHistoryContext>(downloadsDbContext);
            serviceCollection.AddSingleton<ISearchHistoryContext>(searchesDbContext);
            serviceCollection.AddSingleton(new UserContext());
            return serviceCollection;
        }
    }
}
