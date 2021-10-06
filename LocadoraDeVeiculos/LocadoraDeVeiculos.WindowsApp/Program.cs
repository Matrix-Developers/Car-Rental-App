using LocadoraDeVeiculos.WindowsApp.Features.Login;
using System;
using LocadoraDeVeiculos.Infra.EntityFramework;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            using var db = new LocadoraDeVeiculosDBContext();
            var pendingChanges = db.Database.GetPendingMigrations().Any();
            if (pendingChanges)
                db.Database.Migrate();
            Application.Run(new TelaLogin());
        }
    }
}
