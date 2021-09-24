using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ApplicationTests.FuncionarioModule
{
    public class FuncionarioApplicationsTest
    {
        private Funcionario funcionario;


        [Test]
        public void DeveChamar_InserirNovoFuncionario()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome("joao")
                .ComRegistroUnico("26520624098")//""
                .ComEndereco("lages")
                .ComTelefone("(49) 99999-9999")
                .ComEmail("email@gmail.com")
                .ComMatriculaInterna(1)
                .ComUsuarioAcesso("jao")
                .ComSenha("jao123")
                .ComDataAdmissao(DateTime.Today.AddYears(-1))
                .ComCargo("dev")
                .ComSalario(600)
                .ComEhPessoaFisica()
                .Build();


            Mock<IRepository<Funcionario>> funcionarioMock = new();


            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object);
            funcionariooAppService.InserirEntidade(funcionario);

            //assert
            funcionarioMock.Verify(x => x.InserirNovo(funcionario));
        }
        [Test]

        public void DeveChamar_SelecionarIdFuncionario()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome("joao")
                .ComRegistroUnico("26520624098")//""
                .ComEndereco("lages")
                .ComTelefone("(49) 99999-9999")
                .ComEmail("email@gmail.com")
                .ComMatriculaInterna(1)
                .ComUsuarioAcesso("jao")
                .ComSenha("jao123")
                .ComDataAdmissao(DateTime.Today.AddYears(-1))
                .ComCargo("dev")
                .ComSalario(600)
                .ComEhPessoaFisica()
                .Build();

            Mock<Funcionario> novoFuncionarioMock = new();
            novoFuncionarioMock.Object.Nome = "Vini";

            Mock<IRepository<Funcionario>> funcionarioMock = new();

            funcionarioMock.Setup(x => x.SelecionarPorId(funcionario.Id)).Returns(() =>
            {
                return funcionario;
            });

            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object);
            funcionariooAppService.SelecionarEntidadePorId(funcionario.Id);

            //assert
            funcionarioMock.Verify(x => x.SelecionarPorId(funcionario.Id));
        }
        [Test]
        public void DeveChamar_EditarFuncionario()
        {
            funcionario = new FuncionarioDataBuilder()
               .ComNome("joao")
               .ComRegistroUnico("26520624098")//""
               .ComEndereco("lages")
               .ComTelefone("(49) 99999-9999")
               .ComEmail("email@gmail.com")
               .ComMatriculaInterna(1)
               .ComUsuarioAcesso("jao")
               .ComSenha("jao123")
               .ComDataAdmissao(DateTime.Today.AddYears(-1))
               .ComCargo("dev")
               .ComSalario(600)
               .ComEhPessoaFisica()
               .Build();

            Funcionario novoFuncionario = new FuncionarioDataBuilder()
               .ComNome("joao")
               .ComRegistroUnico("26520624098")//""
               .ComEndereco("lages")
               .ComTelefone("(49) 99999-9999")
               .ComEmail("email@gmail.com")
               .ComMatriculaInterna(1)
               .ComUsuarioAcesso("joao")
               .ComSenha("jao123")
               .ComDataAdmissao(DateTime.Today.AddYears(-1))
               .ComCargo("dev")
               .ComSalario(600)
               .ComEhPessoaFisica()
               .Build();


            Mock<IRepository<Funcionario>> funcionarioMock = new();


            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object);
            funcionariooAppService.EditarEntidade(funcionario.Id, novoFuncionario);

            //assert
            funcionarioMock.Verify(x => x.Editar(funcionario.Id, novoFuncionario));
        }
        [Test]

        public void DeveChamar_ExcluirFuncionario()
        {
            funcionario = new FuncionarioDataBuilder()
               .ComNome("joao")
               .ComRegistroUnico("26520624098")//""
               .ComEndereco("lages")
               .ComTelefone("(49) 99999-9999")
               .ComEmail("email@gmail.com")
               .ComMatriculaInterna(1)
               .ComUsuarioAcesso("jao")
               .ComSenha("jao123")
               .ComDataAdmissao(DateTime.Today.AddYears(-1))
               .ComCargo("dev")
               .ComSalario(600)
               .ComEhPessoaFisica()
               .Build();

            Mock<Funcionario> novoFuncionario = new();
            Mock<IRepository<Funcionario>> funcionarioMock = new();

            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object);
            funcionariooAppService.ExcluirEntidade(funcionario.Id);

            //assert
            funcionarioMock.Verify(x => x.Excluir(funcionario.Id));
        }
        [Test]

        public void DeveChamar_ValidarFuncionario()
        {
            funcionario = new FuncionarioDataBuilder()
              .ComNome("joao")
              .ComRegistroUnico("26520624098")//""
              .ComEndereco("lages")
              .ComTelefone("(49) 99999-9999")
              .ComEmail("email@gmail.com")
              .ComMatriculaInterna(1)
              .ComUsuarioAcesso("jao")
              .ComSenha("jao123")
              .ComDataAdmissao(DateTime.Today.AddYears(-1))
              .ComCargo("dev")
              .ComSalario(600)
              .ComEhPessoaFisica()
              .Build();

            Mock<Funcionario> novoFuncionarioMock = new();
            novoFuncionarioMock.Object.Nome = "Vini";

            Mock<IRepository<Funcionario>> funcionarioMock = new();

            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object);
            funcionariooAppService.InserirEntidade(novoFuncionarioMock.Object);

            novoFuncionarioMock.Verify(x => x.Validar());
        }
    }
}
