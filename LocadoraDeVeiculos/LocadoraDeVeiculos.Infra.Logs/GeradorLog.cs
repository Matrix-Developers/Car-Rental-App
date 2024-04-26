using Serilog;

namespace LocadoraDeVeiculos.Infra.Logs
{    
    public abstract class GeradorLog
    {
        public static void ConfigurarLog()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.File(@"c:\\ProgramData\\Car Rental App\\Logs\\LogOutput.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Logger = logger;
        }
    }
}
