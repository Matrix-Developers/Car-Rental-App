using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace LocadoraDeVeiculos.Infra.Logs
{
    public abstract class GeradorLog
    {
        static void GerarLog(string mensagem, string nivelLog)
        {
            using var logger = EnviarLog();
            switch (nivelLog)
            {
                case "Error": logger.Write(LogEventLevel.Error, mensagem); return;
                case "Debug": logger.Write(LogEventLevel.Debug, mensagem); return;
                default: return;
            }
            
        }

        private static Logger EnviarLog()
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();
            Log.Logger = logger;
            return logger;
        }
    }
}
