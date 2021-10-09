using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    class RelacionamentoLocServConfiguration : IEntityTypeConfiguration<RelacionamentoLocServ>
    {
        public void Configure(EntityTypeBuilder<RelacionamentoLocServ> builder)
        {
            builder.ToTable("TBRELACIONAMENTOLOCSERV");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.IdServico).HasColumnType("INT"); ;
            builder.Property(p => p.IdLocacao).HasColumnType("INT"); ;

            builder.HasOne(p => p.Locacao);

            //builder.HasMany(p => p.Servicos); ???????????????????????????????
        }
    }
}
