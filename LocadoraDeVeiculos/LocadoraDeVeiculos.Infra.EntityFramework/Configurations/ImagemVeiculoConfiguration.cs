using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class ImagemVeiculoConfiguration : IEntityTypeConfiguration<ImagemVeiculo>
    {
        private Bitmap bmp;
        public void Configure(EntityTypeBuilder<ImagemVeiculo> builder)
        {
            builder.ToTable("TBIMAGEMVEICULO");
    
            builder.HasKey(p => p.Id);
    
            builder.Property(p => p.Imagem).HasColumnType("image").HasConversion(v => ConverterParaArray(v), v => ConverterEmBitmap(v));

            builder.HasOne(p => p.veiculo);
        }
        #region Métodos privados
        protected byte[] ConverterParaArray(Bitmap entidade)
        {
            bmp = entidade;
            MemoryStream memoria = new();
            bmp.Save(memoria, ImageFormat.Bmp);
            byte[] imagemByte = memoria.ToArray();

            return imagemByte;
        }
        protected Bitmap ConverterEmBitmap(byte[] byteArray)
        {

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            bmp = (Bitmap)tc.ConvertFrom(byteArray);
            Bitmap imagem = new(bmp);

            return imagem;
        }
        #endregion
    }
}
