using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("TBVEICULO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.modelo).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.placa).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.chassi).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.marca).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.cor).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.tipoCombustivel).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.capacidadeTanque).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.ano).HasColumnType("INT").IsRequired();
            builder.Property(p => p.kilometragem).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.numeroPortas).HasColumnType("INT").IsRequired();
            builder.Property(p => p.capacidadePessoas).HasColumnType("INT").IsRequired();
            builder.Property(p => p.tamanhoPortaMala).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.temArCondicionado).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.temDirecaoHidraulica).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.temFreiosAbs).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.estaAlugado).HasColumnType("BIT").IsRequired();

            builder.HasOne(p => p.grupoVeiculos);
        }
    }
}
