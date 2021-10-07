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


            Mock<IRepository<Funcionario, int>> funcionarioMock = new();
            Mock<IReadOnlyRepository<Funcionario, int>> funcionarioLeitura = new();

            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object, funcionarioLeitura.Object);
            funcionariooAppService.InserirEntidade(funcionario);

            //assert
            funcionarioMock.Verify(x => x.InserirNovo(funcionario));
        }
        [Test]

        public void DeveChamar_SelecionaridFuncionario()
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

            Mock<IReadOnlyRepository<Funcionario, int>> funcionarioLeitura = new();
            Mock<IRepository<Funcionario, int>> funcionarioMock = new();

            funcionarioLeitura.Setup(x => x.SelecionarPorId(funcionario.id)).Returns(() =>
            {
                return funcionario;
            });

            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object, funcionarioLeitura.Object);
            funcionariooAppService.SelecionarEntidadePorId(funcionario.id);

            //assert
            funcionarioLeitura.Verify(x => x.SelecionarPorId(funcionario.id));
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


            Mock<IRepository<Funcionario, int>> funcionarioMock = new();
            Mock<IReadOnlyRepository<Funcionario, int>> funcionarioLeitura = new();


            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object, funcionarioLeitura.Object);
            funcionariooAppService.EditarEntidade(funcionario.id, novoFuncionario);

            //assert
            funcionarioMock.Verify(x => x.Editar(funcionario.id, novoFuncionario));
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

            //Mock<Funcionario> novoFuncionario = new();
            Mock<IRepository<Funcionario, int>> funcionarioMock = new();
            Mock<IReadOnlyRepository<Funcionario, int>> funcionarioLeitura = new();

            //action
            FuncionarioAppService funcionariooAppService = new(funcionarioMock.Object, funcionarioLeitura.Object);
            funcionariooAppService.ExcluirEntidade(funcionario.id);

            //assert
            funcionarioMock.Verify(x => x.Excluir(funcionario.id));
        }
    }
}
