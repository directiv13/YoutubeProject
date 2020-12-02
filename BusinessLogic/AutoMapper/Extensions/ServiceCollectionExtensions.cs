using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BusinessLogic.AutoMapper.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

    }
}
