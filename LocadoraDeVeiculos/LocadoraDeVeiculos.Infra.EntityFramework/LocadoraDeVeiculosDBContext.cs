using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework
{
    public class LocadoraDeVeiculosDBContext : DbContext
    {
        private static ILoggerFactory loggerFactoryConsole = LoggerFactory.Create(x => x.AddConsole());

        private string connectionString = "";        

        //public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cupom> Cupons { get; set; }
        //public DbSet<Funcionario> Funcionarios { get; set; }
        //public DbSet<GrupoDeVeiculo> GrupoDeVeiculos { get; set; }
        //public DbSet<ImagemVeiculo> ImagemVeiculos { get; set; }
        //public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Parceiro> Parceiros { get; set; }
        //public DbSet<RelacionamentoLocServ> Relacionamentos { get; set; }
        //public DbSet<Servico> Servicos{ get; set; }
        //public DbSet<Veiculo> Veiculos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = InitConfiguration();
            connectionString = config.GetSection("ConnectionStrings").GetSection("SqlServer").Value;
            optionsBuilder
                .UseLoggerFactory(loggerFactoryConsole)
                .UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LocadoraDeVeiculosDBContext).Assembly);
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));

                foreach (var property in properties)
                    if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
                        property.SetColumnType("decimal(18,2)");
            }
        }
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            return config;
        }
    }
}
