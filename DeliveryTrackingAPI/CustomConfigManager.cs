using Microsoft.Extensions.Configuration;
using System.IO;

namespace DeliveryTrackingAPI
{
    public static class CustomConfigManager
    {
        public static IConfiguration AppSetting { get; }

        static CustomConfigManager()
        {
            AppSetting = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
    }
}
