using System;
using System.Collections.Generic;
using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using Moq;

namespace LocadoraDeVeiculos.ApplicationTests.ClienteModule
{
    public class ClienteAppServiceTest
    {
        #region atributos privados
        private Cliente cliente;

        private string joao;
        private string jose;

        private string cpf;
        private string cnpj;

        private string lages;
        private string florianopolis;

        private string celular;
        private string fixo;

        private string gmail;
        private string hotmail;

        private string cnh;
        private string cnhNull;

        private DateTime daquiUmAno;
        private DateTime? validadeNull;

        private bool pf;
        private bool pj;
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

            Mock<IRepository<Cliente>> clienteDAOMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object);
            clienteAppService.InserirNovoCliente(clienteNovo);

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

            Mock<IRepository<Cliente>> clienteDAOMock = new();

            clienteDAOMock.Setup(x => x.SelecionarPorId(cliente.Id))
                .Returns(() =>
                {
                    return  cliente;
                });

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object);
            clienteAppService.SelecionarClientePorId(cliente.Id);

            //assert
            clienteDAOMock.Verify(x => x.SelecionarPorId(cliente.Id));
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

            Mock<IRepository<Cliente>> clienteDAOMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object);
            clienteAppService.EditarCliente(cliente.Id, clienteNovo);

            //assert
            clienteDAOMock.Verify(x => x.Editar(cliente.Id, clienteNovo));
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

            Mock<IRepository<Cliente>> clienteDAOMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object);
            clienteAppService.ExcluirCliente(cliente.Id);

            //assert
            clienteDAOMock.Verify(x => x.Excluir(cliente.Id));
        }

        [Test]
        public void DeveChamar_Validar()
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

            Mock<IRepository<Cliente>> clienteDAOMock = new();

            //action
            ClienteAppService clienteAppService = new(clienteDAOMock.Object);
            clienteAppService.InserirNovoCliente(novoClienteMock.Object);

            //assert
            novoClienteMock.Verify(x => x.Validar());
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
            cnpj = "54738501000107";
        }
        private void ConfigurarEndereco()
        {
            lages = "Centro, Lages - SC";
            florianopolis = "Centro, Florianópolis - SC";
        }
        private void ConfigurarTelefone()
        {
            celular = "(49) 99999-9999";
            fixo = "(49) 9999-9999";
        }
        private void ConfigurarEmail()
        {
            gmail = "email@gmail.com";
            hotmail = "email@hotmail.com";
        }
        private void ConfigurarCnh()
        {
            cnh = "27124931834";
            cnhNull = "";
        }
        private void ConfigurarDatas()
        {
            daquiUmAno = DateTime.Today.AddYears(1);
            validadeNull = null;
        }
        private void ConfigurarEhPessoaFisica()
        {
            pf = true;
            pj = false;
        }
        #endregion
    }
}
