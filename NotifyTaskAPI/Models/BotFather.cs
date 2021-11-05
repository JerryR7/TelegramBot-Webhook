using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace NotifyTaskAPI.Models
{
    public abstract class BotFather
    {
        protected readonly IConfigurationRoot BotConfig;

        protected BotFather()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            BotConfig = builder.Build();
        }
        
        public abstract string Chat(string message);
    }
}