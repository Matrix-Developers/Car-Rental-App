using LocadoraDeVeiculos.Dominio.CupomModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class CupomConfiguration : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.ToTable("TBCupom");

            builder.HasKey(p => p.id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Codigo).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.ValorMinimo).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.Valor).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.EhDescontoFixo).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.Validade).HasColumnType("DATE").IsRequired();
            builder.Property(p => p.QtdUtilizada).HasColumnType("INT").IsRequired();
            builder.HasOne(p => p.Parceiro);
        }
    }
}
