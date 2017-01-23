using Accessors.Infrastructure;
using Core.Interfaces;
using Accessors;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, string connectionString)
        {
            services.AddScoped(p => new MongoContext(connectionString));
            services.AddTransient<IPictureAccessor, PictureAccessor>();
            return services;
        }
    }
}
