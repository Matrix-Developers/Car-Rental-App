using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using System;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class FuncionarioDataBuilder
    {
        private readonly Funcionario funcionario;

        public FuncionarioDataBuilder()
        {
            funcionario = new Funcionario();
        }

        public FuncionarioDataBuilder ComNome(string nome)
        {
            funcionario.Nome = nome;
            return this;
        }
        public FuncionarioDataBuilder ComRegistroUnico(string registroUnico)
        {
            funcionario.RegistroUnico = registroUnico;
            return this;
        }
        public FuncionarioDataBuilder ComEndereco(string endereco)
        {
            funcionario.Endereco = endereco;
            return this;
        }
        public FuncionarioDataBuilder ComTelefone(string telefone)
        {
            funcionario.Telefone = telefone;
            return this;
        }
        public FuncionarioDataBuilder ComEmail(string email)
        {
            funcionario.Email = email;
            return this;
        }
        public FuncionarioDataBuilder ComMatriculaInterna(int matriculaInterna)
        {
            funcionario.MatriculaInterna = matriculaInterna;
            return this;
        }
        public FuncionarioDataBuilder ComUsuarioAcesso(string usuarioAcesso)
        {
            funcionario.UsuarioAcesso = usuarioAcesso;
            return this;
        }
        public FuncionarioDataBuilder ComSenha(string senha)
        {
            funcionario.Senha = senha;
            return this;
        }
        public FuncionarioDataBuilder ComDataAdmissao(DateTime dataAdmissao)
        {
            funcionario.DataAdmissao = dataAdmissao;
            return this;
        }
        public FuncionarioDataBuilder ComCargo(string cargo)
        {
            funcionario.Cargo = cargo;
            return this;
        }
        public FuncionarioDataBuilder ComSalario(double salario)
        {
            funcionario.Salario = salario;
            return this;
        }
        public FuncionarioDataBuilder ComEhPessoaFisica()
        {
            funcionario.EhPessoaFisica = true;
            return this;
        }

        public Funcionario Build()
        {
            return funcionario;
        }
    }
}
