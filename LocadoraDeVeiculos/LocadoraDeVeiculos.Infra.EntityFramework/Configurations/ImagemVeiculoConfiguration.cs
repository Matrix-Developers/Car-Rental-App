using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    //public class ImagemVeiculoConfiguration : IEntityTypeConfiguration<ImagemVeiculo>
    //{
    //    public void Configure(EntityTypeBuilder<ImagemVeiculo> builder)
    //    {
    //        builder.ToTable("TBIMAGEMVEICULO");
    //
    //        builder.HasKey(p => p.Id);
    //
    //        builder.Property("ID_VEICULO").HasColumnType("INT");
    //        builder.Property("imagem").HasColumnType("VARBINARY(MAX)");
    //
    //        builder.HasOne(p => p.veiculo).WithMany(p => p.imagens).HasForeignKey(p => p.IdVeiculo);
    //    }
    //}
}
