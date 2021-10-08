using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class GrupoDeVeiculosConfiguration : IEntityTypeConfiguration<GrupoDeVeiculo>
    {
        public void Configure(EntityTypeBuilder<GrupoDeVeiculo> builder)
        {
            builder.ToTable("");
        }
    }
}
