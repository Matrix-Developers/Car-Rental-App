using LocadoraDeVeiculos.WindowsApp.Features.Login;
using System;
using LocadoraDeVeiculos.Infra.EntityFramework;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using LocadoraDeVeiculos.Infra.Logs;

namespace LocadoraDeVeiculos.WindowsApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LocadoraDeVeiculosDBContext db = new ();
            GeradorLog.ConfigurarLog();
            var pendingChanges = db.Database.GetPendingMigrations();
            if (pendingChanges.Any())
                db.Database.Migrate();
            Application.Run(new TelaLogin());
        }
    }
}
