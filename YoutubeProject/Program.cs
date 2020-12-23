using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using BusinessLogic.Security;
using DataAccess;
using BusinessLogic.AutoMapper.Extensions;
using DataAccess.Contexts;
using System.Configuration;
using DataAccess.Extensions;
using System.Linq;
using DataAccess.Models;

namespace YoutubeProject
{
    static class Program
    {
        public static ServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            var mongoSearchDbService = ServiceProvider.GetService<ISearchHistoryContext>();
            var mongoDownloadsDbService = ServiceProvider.GetService<IDownloadsHistoryContext>();
            mongoSearchDbService.Create(new SearchHistoryItem
            {
                UserId = 1,
                SearchTerm = "hello world"
            });
            mongoDownloadsDbService.Create(new DownloadsHistoryItem
            {
                UserId = 2,
                Uri = new Uri("https://google.com")
            });

            Application.Run(new EnterForm());
        }

        static void ConfigureServices()
        {
            var appConfig = ConfigurationManager.AppSettings;

            var mongoConnectionString = appConfig["mongoConnectionString"];
            var mongoDatabaseName = appConfig["mongoDatabaseName"];
            var downloadsCollectionName = appConfig["mongoDownloadHistoryCollectionName"];
            var searchCollectionName = appConfig["mongoSearchHistoryCollectionName"];

            var options = new MongoDbOptions
            {
                ConnectionString = mongoConnectionString,
                DatabaseName = mongoDatabaseName,
                DownloadHistoryCollectionName = downloadsCollectionName,
                SearchHistoryCollectionName = searchCollectionName
            };

            var services = new ServiceCollection();

            services.AddDataAccess(options);
            services.AddTransient<IUserManager, UserManager>();
            services.AddCustomAutoMapper();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}