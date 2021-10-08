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

            //private Veiculo veiculo;
            //private Funcionario funcionarioLocador;
            //private Cliente clienteContratante;
            //private Cliente clienteCondutor;
            //private Cupom cupom;
            //private DateTime dataDeSaida;
            //private DateTime dataPrevistaDeChegada;
            //private DateTime dataDeChegada;
            //private string tipoDoPlano;         //PlanoDiario, KmControlado ou KmLivre
            //private string tipoDeSeguro;    //SeguroCliente, SeguroTerceiro ou Nenhum
            //private double precoLocacao;
            //private double precoDevolucao;
            //private bool estaAberta;
            //private List<Servico> servicos;

            //builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
            //builder.Property(p => p.Codigo).HasColumnType("VARCHAR(50)").IsRequired();
            //builder.Property(p => p.Valor).HasColumnType("FLOAT").IsRequired();
            //builder.Property(p => p.ValorMinimo).HasColumnType("FLOAT").IsRequired();
            //builder.Property(p => p.EhDescontoFixo).HasColumnType("BIT").IsRequired();
            //builder.Property(p => p.Validade).HasColumnType("DATE").IsRequired();
            //builder.Property(p => p.ParceiroId).HasColumnType("INT");
            //builder.Property(p => p.QtdUtilizada).HasColumnType("INT").IsRequired();

            //builder.HasOne(p => p.Parceiro).WithMany(p => p.Cupons).HasForeignKey(p => p.ParceiroId);
        }
    }
}
