using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace LocadoraDeVeiculos.Infra.Logs
{
    public abstract class GeradorLog
    {
        public static void GerarLog(string mensagem, string nivelLog)
        {
            using var logger = EnviarLog();
            switch (nivelLog)
            {
                case "Error": logger.Write(LogEventLevel.Error, mensagem); return;
                case "Debug": logger.Write(LogEventLevel.Debug, mensagem); return;
                case "Information": logger.Write(LogEventLevel.Information, mensagem); return;
                default: return;
            }            
        }

        private static Logger EnviarLog()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Seq("http://191.235.244.10:5341")
                .CreateLogger();
            Log.Logger = logger;
            return logger;
        }
    }
}
