using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.Infra.InternetServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.ApiServices
{
    public class EncaminhaEmailWorker : BackgroundService
    {

        LocacaoAppService locacaoAppService = new(new LocacaoORM(new LocadoraDeVeiculosDBContext()));
        public readonly ILogger<EncaminhaEmailWorker> _logger;
        Stopwatch stopwatch = new();
        public static string DiretorioEntrada { get; set; }
        public EncaminhaEmailWorker(ILogger<EncaminhaEmailWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    stopwatch.Start();
                    Parallel.ForEach(ColetaDiretorio(), (diretorio) => Program.ArquivosPdfEncontrados.Enqueue(diretorio));
                    Parallel.ForEach(Program.ArquivosPdfEncontrados, (arquivoPdf) => EnviarEmail(arquivoPdf));
                    //foreach (var item in ColetaDiretorio())
                    //{
                    //    string arquivoPdf = "";
                    //    Program.ArquivosPdfEncontrados.Enqueue(arquivoPdf);
                    //    _logger.LogInformation("Arquivo {titulo} encontrado, Hora: {time}, Tempo Decorrido: {stopWatch}", item.ToString(), DateTimeOffset.Now, stopwatch.ElapsedMilliseconds / 1000.0);
                    //}
                }
                catch (Exception ex)
                {

                    throw;
                }
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        private void EnviarEmail(string arquivoPdf)
        {
            int idLocacacao = Convert.ToInt32(arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\recibo-", "").Replace(".pdf", ""));
            Locacao locacao = locacaoAppService.SelecionarEntidadePorId(idLocacacao);

            GerenciadorDeEmail.EnviarEmail("matriquisdevelopers@gmail.com", "matrixadm", locacao);
        }

        public string[] ColetaDiretorio()
        {
            string[] arquivosEncontrados =  Directory.GetFiles($@"..\..\..\..\Recibos\", "*.pdf");
            _logger.LogInformation("{quantida} arquivos encontrados, Hora: {time}, Tempo Decorrido: {stopWatch}", arquivosEncontrados.Length, DateTimeOffset.Now, stopwatch.ElapsedMilliseconds / 1000.0);
            return arquivosEncontrados;
        }
    }
}
