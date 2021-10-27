using LocadoraDeVeiculos.WindowsApp.Features.Login;
using System;
using LocadoraDeVeiculos.Infra.EntityFramework;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LocadoraDeVeiculos.Infra.ApiServices;
using System.Collections.Concurrent;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace LocadoraDeVeiculos.WindowsApp
{
    public static class Program
    {
        public static ConcurrentQueue<String> ArquivosPdfEncontrados = new();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main(string[] args)
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LocadoraDeVeiculosDBContext db = new ();
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();
            Application.Run(new TelaLogin());
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<EncaminhaEmailWorker>();
                });
    }
}
