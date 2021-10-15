using LocadoraDeVeiculos.Dominio.LocacaoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    class LocacaoConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.ToTable("TBLOCACAO");
            builder.HasKey(p => p.Id);

            //builder.Property(p => p.IdVeiculo).HasColumnType("INT");
            //builder.Property(p => p.IdFuncionarioLocador).HasColumnType("INT");
            //builder.Property(p => p.IdClienteContratante).HasColumnType("INT");
            //builder.Property(p => p.IdClienteCondutor).HasColumnType("INT");
            //builder.Property(p => p.IdCupom).HasColumnType("DATE").IsRequired();
            builder.Property(p => p.DataPrevistaDeChegada).HasColumnType("DATE").IsRequired();
            builder.Property(p => p.DataDeChegada).HasColumnType("DATE");
            builder.Property(p => p.TipoDoPlano).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.TipoDeSeguro).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.PrecoLocacao).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.PrecoDevolucao).HasColumnType("FLOAT").IsRequired();
            builder.Property(p => p.EstaAberta).HasColumnType("BIT");

            builder.HasMany(p => p.Servicos).WithMany(p => p.Locacoes);

            builder.HasOne(p => p.FuncionarioLocador).WithMany(p => p.Locacoes);
            builder.HasOne(p => p.ClienteContratante).WithMany(p => p.LocacoesContratante);  //.HasForeignKey(p => p.ClienteContratanteId);
            builder.HasOne(p => p.ClienteCondutor).WithMany(p => p.LocacoesCondutor);   //.HasForeignKey(p => p.ClienteCondutorId);
            builder.HasOne(p => p.Cupom).WithMany(p => p.Locacoes); ;
        }
    }
}
