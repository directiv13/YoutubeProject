using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using BusinessLogic.Security;
using DataAccess;
using BusinessLogic.AutoMapper.Extensions;
using DataAccess.Contexts;
using System.Configuration;
using DataAccess.Extensions;

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
            Application.Run(new UserForm());
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