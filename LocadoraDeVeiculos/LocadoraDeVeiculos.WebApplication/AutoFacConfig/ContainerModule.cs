using Autofac;
using AutoMapper;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Dominio.Shared;

namespace LocadoraDeVeiculos.WebApplication.AutoFacConfig
{
    public class ContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LocadoraDeVeiculosDBContext>().InstancePerLifetimeScope();

            builder.RegisterType<ParceiroORM>().As<IRepository<Parceiro>>();

            builder.RegisterType<Mapper>().As<IMapper>();
        }

    }
}

