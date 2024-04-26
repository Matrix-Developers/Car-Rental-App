using Serilog;

namespace LocadoraDeVeiculos.Infra.Logs
{    
    public abstract class GeradorLog
    {
        public static void ConfigurarLog()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.File(@"c:\\Car Rental App Data\\Logs\\LogOutput.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Logger = logger;
        }
    }
}
