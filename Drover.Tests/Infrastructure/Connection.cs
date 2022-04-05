using System.IO;
using Drover.Api.Factories;
using Microsoft.Extensions.Configuration;

namespace Drover.Tests.Infrastructure
{
    public static class Connection
    {
        private static IConfigurationBuilder builder => new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("config.json", optional: false);

        private static IConfiguration config => builder.Build();

        public static BugherdConfig BugherdConfig => config.GetSection("BugherdConfig").Get<BugherdConfig>();

        public static IBugherdConnection BugherdConnection => ConnectionFactory.CreateConnection(BugherdConfig.ApiKey, BugherdConfig.BaseUri);

    }
}
