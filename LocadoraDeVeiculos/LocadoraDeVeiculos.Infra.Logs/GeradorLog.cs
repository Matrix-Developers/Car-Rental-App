using System;

namespace LocadoraDeVeiculos.Infra.Logs
{
    public abstract class GeradorLog
    {
        static void GerarLog(string mensagem, string nivelLog)
        {
            using (var logger = EnviarLog())
                logger.Write(LogEventLevel.Error, mensagem);
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
