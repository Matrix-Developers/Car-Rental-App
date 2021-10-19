using Autofac;
using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.WindowsApp.Features.Clientes;
using LocadoraDeVeiculos.WindowsApp.Features.Cupons;
using LocadoraDeVeiculos.WindowsApp.Features.Devolucoes;
using LocadoraDeVeiculos.WindowsApp.Features.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos;
using LocadoraDeVeiculos.WindowsApp.Features.Locacoes;
using LocadoraDeVeiculos.WindowsApp.Features.Parceiros;
using LocadoraDeVeiculos.WindowsApp.Features.Servicos;
using LocadoraDeVeiculos.WindowsApp.Features.Veiculos;

namespace LocadoraDeVeiculos.WindowsApp.Shared
{
    public class AutoFac
    {
        private static ContainerBuilder Builder = new();
        public static IContainer Container;

        static AutoFac()
        {
            Builder.RegisterType<LocadoraDeVeiculosDBContext>().InstancePerLifetimeScope();

            ConfigurarORM();

            ConfigurarAppService();

            ConfigurarOperacoes();

            Container = Builder.Build();
        }

        private static void ConfigurarOperacoes()
        {
            Builder.RegisterType<OperacoesClientes>().InstancePerDependency();
            Builder.RegisterType<OperacoesCupom>().InstancePerDependency();
            Builder.RegisterType<OperacoesDevolucao>().InstancePerDependency();
            Builder.RegisterType<OperacoesFuncionario>().InstancePerDependency();
            Builder.RegisterType<OperacoesGrupoDeVeiculos>().InstancePerDependency();
            Builder.RegisterType<OperacoesLocacao>().InstancePerDependency();
            Builder.RegisterType<OperacoesParceiro>().InstancePerDependency();
            Builder.RegisterType<OperacoesServico>().InstancePerDependency();
            Builder.RegisterType<OperacoesVeiculo>().InstancePerDependency();
        }

        private static void ConfigurarAppService()
        {
            Builder.RegisterType<ClienteAppService>().InstancePerDependency();
            Builder.RegisterType<CupomAppService>().InstancePerDependency();
            Builder.RegisterType<FuncionarioAppService>().InstancePerDependency();
            Builder.RegisterType<GrupoDeVeiculosAppService>().InstancePerDependency();
            Builder.RegisterType<LocacaoAppService>().InstancePerDependency();
            Builder.RegisterType<ParceiroAppService>().InstancePerDependency();
            Builder.RegisterType<ServicoAppService>().InstancePerDependency();
            Builder.RegisterType<VeiculoAppService>().InstancePerDependency();
        }

        private static void ConfigurarORM()
        {
            Builder.RegisterType<ClienteORM>().As<IRepository<Cliente>>().InstancePerDependency();
            Builder.RegisterType<CupomORM>().As<ICupomRepository>().InstancePerDependency();
            Builder.RegisterType<ImagemVeiculoORM>().As<IImagemVeiculoRepository>().InstancePerDependency();
            Builder.RegisterType<FuncionarioORM>().As<IRepository<Funcionario>>().InstancePerDependency();
            Builder.RegisterType<GrupoDeVeiculosORM>().As<IRepository<GrupoDeVeiculo>>().InstancePerDependency();
            Builder.RegisterType<LocacaoORM>().As<IRepository<Locacao>>().InstancePerDependency();
            Builder.RegisterType<ParceiroORM>().As<IRepository<Parceiro>>().InstancePerDependency();
            Builder.RegisterType<ServicoORM>().As<IRepository<Servico>>().InstancePerDependency();
            Builder.RegisterType<VeiculoORM>().As<IRepository<Veiculo>>().InstancePerDependency();
        }
    }
}
