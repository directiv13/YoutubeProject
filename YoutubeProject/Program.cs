using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using BusinessLogic.Security;
using DataAccess;
using BusinessLogic.AutoMapper.Extensions;
namespace YoutubeProject
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new EnterForm());
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient(sp => new UserContext());
            services.AddTransient<IUserManager, UserManager>();
            services.AddCustomAutoMapper();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
