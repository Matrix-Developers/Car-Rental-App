using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

namespace LocadoraDeVeiculos.Infra.Logs
{    
    public abstract class GeradorLog
    {
        public static void ConfigurarLog()
        {
            var config = InitConfiguration();

            var logger = new LoggerConfiguration()
                .WriteTo.Seq(config["ConexaoSeq"])
                .CreateLogger();
            Log.Logger = logger;
        }
        private static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            return config;
        }
    }
}
