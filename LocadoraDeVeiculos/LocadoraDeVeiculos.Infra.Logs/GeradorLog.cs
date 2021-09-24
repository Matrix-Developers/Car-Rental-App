using Serilog;

namespace LocadoraDeVeiculos.Infra.Logs
{
    public abstract class GeradorLog
    {
        public static void ConfigurarLog()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Seq("http://191.235.244.10:5341")
                .CreateLogger();
            Log.Logger = logger;
        }
    }
}
