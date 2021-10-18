using LocadoraDeVeiculos.Dominio.ParceiroModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class ParceiroConfiguration : IEntityTypeConfiguration<Parceiro>
    {
        public void Configure(EntityTypeBuilder<Parceiro> builder)
        {
            builder.ToTable("TBPARCEIRO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();

            builder.HasMany(p => p.Cupons).WithOne(p => p.Parceiro);
        }
    }
}
