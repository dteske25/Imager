using System;
using System.Collections.Generic;
using System.Text;
using ExampleApp.Core.Engines;
using ExampleApp.Engines;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEngines(this IServiceCollection services)
        {
            // services.AddTransient<IEngine, Engine>();
            services.AddTransient<IQuoteEngine, QuoteEngine>();

            return services;
        }
    }
}
