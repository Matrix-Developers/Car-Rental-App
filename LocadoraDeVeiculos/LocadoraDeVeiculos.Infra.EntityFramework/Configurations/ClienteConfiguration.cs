using LocadoraDeVeiculos.Dominio.ClienteModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("TBCLIENTE");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.RegistroUnico).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(50)").IsRequired(false);
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(50)").IsRequired(false);
            builder.Property(p => p.Email).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.EhPessoaFisica).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.Cnh).HasColumnType("VARCHAR(50)").IsRequired(false);
            builder.Property(p => p.ValidadeCnh).HasColumnType("DATETIME").IsRequired(false);
        }
    }
}
