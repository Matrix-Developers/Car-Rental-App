using Autofac;
using Autofac.Extensions.DependencyInjection;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.ApiServices
{
    public static class Program
    {
        public static ConcurrentQueue<String> ArquivosPdfEncontrados = new();
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService()
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterType<LocacaoAppService>();//.As<IRepository<Locacao>>();
                    builder.RegisterType<LocadoraDeVeiculosDBContext>().InstancePerLifetimeScope();
                    builder.RegisterType<LocacaoORM>().As<IRepository<Locacao>>();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<EncaminhaEmailWorker>();
                });
    }
}
