using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("TBFUNCIONARIO");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.RegistroUnico).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.Email).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.EhPessoaFisica).HasColumnType("BIT").IsRequired();
            builder.Property(p => p.MatriculaInterna).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.UsuarioAcesso).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Senha).HasColumnType("VARCHAR(50)");
            builder.Property(p => p.DataAdmissao).HasColumnType("DATE").IsRequired();
            builder.Property(p => p.Cargo).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(p => p.Salario).HasColumnType("FLOAT").IsRequired();

            builder.HasMany(p => p.Locacoes).WithOne(p => p.FuncionarioLocador);
        }
    }
}
