using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ApplicationTests.ClienteModule
{
    public class ClienteAppServiceTest
    {
        #region atributos privados
        private Cliente cliente;

        private string joao;
        private string jose;

        private string cpf;

        private string lages;

        private string celular;

        private string gmail;

        private string cnh;

        private DateTime daquiUmAno;

        private bool pf;
        #endregion

        [SetUp]
        public void Setup()
        {
            ConfigurarNome();

            ConfigurarRegistroUnico();

            ConfigurarEndereco();

            ConfigurarTelefone();

            ConfigurarEmail();

            ConfigurarCnh();

            ConfigurarEhPessoaFisica();

            ConfigurarDatas();
        }

        [Test]
        public void DeveChamar_InserirNovo()
        {
            //arrange
            cliente = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Cliente clienteNovo = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Mock<IRepository<Cliente, int>> clienteDAOMock = new();
            Mock<IReadOnlyRepository<Cliente, int>> clienteLeituraMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object, clienteLeituraMock.Object);
            clienteAppService.InserirEntidade(clienteNovo);

            //assert
            clienteDAOMock.Verify(x => x.InserirNovo(clienteNovo));
        }

        [Test]
        public void DeveChamar_SelecionarTodos()
        {
            //arrange
            cliente = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Mock<Cliente> novoClienteMock = new();
            novoClienteMock.Object.Nome = jose;

            Mock<IRepository<Cliente, int>> clienteDAOMock = new();
            Mock<IReadOnlyRepository<Cliente, int>> clienteLeituraMock = new();


            clienteLeituraMock.Setup(x => x.SelecionarPorId(cliente.id))
                .Returns(() =>
                {
                    return cliente;
                });

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object, clienteLeituraMock.Object);
            clienteAppService.SelecionarEntidadePorId(cliente.id);

            //assert
            clienteLeituraMock.Verify(x => x.SelecionarPorId(cliente.id));
        }

        [Test]
        public void DeveChamar_Editar()
        {
            //arrange
            cliente = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Cliente clienteNovo = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Mock<IRepository<Cliente, int>> clienteDAOMock = new();
            Mock<IReadOnlyRepository<Cliente, int>> clienteLeituraMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object, clienteLeituraMock.Object);
            clienteAppService.EditarEntidade(cliente.id, clienteNovo);

            //assert
            clienteDAOMock.Verify(x => x.Editar(cliente.id, clienteNovo));
        }

        [Test]
        public void DeveChamar_Excluir()
        {
            //arrange
            cliente = new ClienteDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComCnh(cnh)
                .ComValidadeCnh(daquiUmAno)
                .ComEhPessoaFisica(pf)
                .Build();

            Mock<Cliente> novoClienteMock = new();

            Mock<IRepository<Cliente, int>> clienteDAOMock = new();
            Mock<IReadOnlyRepository<Cliente, int>> clienteLeituraMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object, clienteLeituraMock.Object);
            clienteAppService.ExcluirEntidade(cliente.id);

            //assert
            clienteDAOMock.Verify(x => x.Excluir(cliente.id));
        }
        #region Métodos privados
        private void ConfigurarNome()
        {
            joao = "João";
            jose = "José";
        }
        private void ConfigurarRegistroUnico()
        {
            cpf = "26520624098";
        }
        private void ConfigurarEndereco()
        {
            lages = "Centro, Lages - SC";
        }
        private void ConfigurarTelefone()
        {
            celular = "(49) 99999-9999";
        }
        private void ConfigurarEmail()
        {
            gmail = "email@gmail.com";
        }
        private void ConfigurarCnh()
        {
            cnh = "27124931834";
        }
        private void ConfigurarDatas()
        {
            daquiUmAno = DateTime.Today.AddYears(1);
        }
        private void ConfigurarEhPessoaFisica()
        {
            pf = true;
        }
        #endregion
    }
}
