using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class GrupoDeVeiculosConfiguration : IEntityTypeConfiguration<GrupoDeVeiculo>
    {
        public void Configure(EntityTypeBuilder<GrupoDeVeiculo> builder)
        {
            builder.ToTable("TBGRUPOVEICULO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.TaxaPlanoDiario).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.TaxaPorKmDiario).HasColumnType("FLOAT");
            builder.Property(p => p.TaxaPlanoControlado).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.LimiteKmControlado).HasColumnType("INT");
            builder.Property(p => p.TaxaKmExcedidoControlado).HasColumnType("FLOAT");
            builder.Property(p => p.TaxaPlanoLivre).HasColumnType("FLOAT").IsRequired();

            builder.HasMany(p => p.Veiculos).WithOne(p => p.grupoVeiculos);
        }
    }
}
