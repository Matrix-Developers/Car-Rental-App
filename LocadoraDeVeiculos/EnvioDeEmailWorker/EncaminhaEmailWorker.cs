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

        LocacaoAppService locacaoAppService;// = new(new LocacaoORM(new LocadoraDeVeiculosDBContext()));
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
                    Parallel.ForEach(Program.ArquivosPdfEncontrados, (arquivoPdf) => EnviarEmail(arquivoPdf, new LocadoraDeVeiculosDBContext()));
                    //foreach (var item in ColetaDiretorio())
                    //{
                    //    string arquivoPdf = "";
                    //    Program.ArquivosPdfEncontrados.Enqueue(arquivoPdf);
                    //    _logger.LogInformation("Arquivo {titulo} encontrado, Hora: {time}, Tempo Decorrido: {stopWatch}", item.ToString(), DateTimeOffset.Now, stopwatch.ElapsedMilliseconds / 1000.0);
                    //}
                }
                catch (Exception ex)
                {
                    _logger.LogError("Erro: {exception} Tempo decorrido: {stopwatch}", ex, stopwatch.ElapsedMilliseconds / 1000.0);
                }
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(5000, stoppingToken);
            }
        }

        private void EnviarEmail(string arquivoPdf, LocadoraDeVeiculosDBContext locadoraDeVeiculosDBContext)
        {
            try
            {
                int idLocacacao = Convert.ToInt32(arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\recibo-", "").Replace(".pdf", ""));
                locacaoAppService = new LocacaoAppService(new LocacaoORM(locadoraDeVeiculosDBContext));
                Locacao locacao = locacaoAppService.SelecionarEntidadePorId(idLocacacao);
                GerenciadorDeEmail.EnviarEmail("matriquisdevelopers@gmail.com", "matrixadm", locacao);

                File.Copy(arquivoPdf, arquivoPdf.Replace("\\Recibos\\", "\\Enviados\\"));
                _logger.LogInformation("Arquivo: {arquivo} movido para a pasta Enviados", arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\", ""), stopwatch.ElapsedMilliseconds / 1000.0);
                File.Delete(arquivoPdf);
                _logger.LogInformation("Arquivo: {arquivo} removido da pasta Pdf  com suceso, Tempo decorrido: {stopwatch}", arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\", ""), stopwatch.ElapsedMilliseconds / 1000.0);
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro: {exception} Tempo decorrido: {stopwatch}", ex, stopwatch.ElapsedMilliseconds / 1000.0);
                if (File.Exists(arquivoPdf))
                {
                    File.Copy(arquivoPdf, arquivoPdf.Replace("\\Recibos\\", "\\Erro\\"));
                    _logger.LogInformation("Arquivo: {arquivo} movido para a pasta Erro, Tempo decorrido: {stopwatch}", arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\", ""), stopwatch.ElapsedMilliseconds / 1000.0);
                    File.Delete(arquivoPdf);
                    _logger.LogInformation("Arquivo: {arquivo} removido da pasta Pdf  com suceso, Tempo decorrido: {stopwatch}", arquivoPdf.Replace("..\\..\\..\\..\\Recibos\\", ""), stopwatch.ElapsedMilliseconds / 1000.0);
                }
            }
            stopwatch.Stop();
        }

        public string[] ColetaDiretorio()
        {
            string[] arquivosEncontrados = Directory.GetFiles($@"..\..\..\..\Recibos\", "*.pdf");
            _logger.LogInformation("{quantida} arquivos encontrados, Hora: {time}, Tempo Decorrido: {stopWatch}", arquivosEncontrados.Length, DateTimeOffset.Now, stopwatch.ElapsedMilliseconds / 1000.0);
            return arquivosEncontrados;
        }
    }
}
