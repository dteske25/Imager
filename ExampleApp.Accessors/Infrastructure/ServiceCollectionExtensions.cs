using System;
using System.Collections.Generic;
using System.Text;
using ExampleApp.Accessors;
using ExampleApp.Accessors.Infrastructure;
using ExampleApp.Core.Accessors;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAccessors(this IServiceCollection services, string connectionString)
        {
            services.AddScoped(p => new MongoContext(connectionString));

            // services.AddTransient<IAccessor, Accessor>();
            services.AddTransient<IQuoteAccessor, QuoteAccessor>();
            return services;
        }
    }
}
