using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;
using System.Linq;

namespace LocadoraDeVeiculos.ORMTests.ClientesModule
{
    public class ClienteORMTest
    {
        private IRepository<Cliente> controlador;
        LocadoraDeVeiculosDBContext dbContext = new();

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
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new ClienteORM(dbContext);

            ConfigurarNome();

            ConfigurarRegistroUnico();

            ConfigurarEndereco();

            ConfigurarTelefone();

            ConfigurarEmail();

            ConfigurarCnh();

            ConfigurarEhPessoaFisica();

            ConfigurarDatas();
        }

        [TearDown]
        public void TearDown()
        {
            var listaLocacaoes = dbContext.Locacoes.ToList().Select(x => x as Locacao);
            foreach (var item in listaLocacaoes)
                dbContext.Locacoes.Remove(item);
            dbContext.SaveChanges();

            var listaClientes = dbContext.Clientes.ToList().Select(x => x as Cliente);
            foreach (var item in listaClientes)
                dbContext.Clientes.Remove(item);

            dbContext.SaveChanges();
        }

        [Test]
        public void DeveAdicionarCliente()
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

            //action
            controlador.InserirNovo(cliente);

            //assert
            var clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Should().Be(cliente);
        }

        [Test]
        public void DeveSelecionarDoisClientes()
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

            Cliente cliente2 = new ClienteDataBuilder()
                .ComNome(jose)
                .ComRegistroUnico(cnpj)
                .ComEndereco(florianopolis)
                .ComTelefone(fixo)
                .ComEmail(hotmail)
                .ComCnh(cnhNull)
                .ComValidadeCnh(validadeNull)
                .ComEhPessoaFisica(pj)
                .Build();

            controlador.InserirNovo(cliente);
            controlador.InserirNovo(cliente2);

            //action
            var cupons = controlador.SelecionarTodos();

            //assert
            cupons.Should().HaveCount(2);
        }

        [Test]
        public void DeveEditarUmCliente()
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

            controlador.InserirNovo(cliente);

            //action
            cliente.Nome = jose;
            cliente.Email = hotmail;
            controlador.Editar(0, cliente);

            //assert
            Cliente clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Nome.Should().Be("José");
        }

        [Test]
        public void DeveExcluirUmCliente()
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

            //action
            controlador.InserirNovo(cliente);
            controlador.Excluir(cliente.Id);

            //assert
            var clienteEscolhido = controlador.SelecionarPorId(cliente.Id);
            clienteEscolhido.Should().BeNull();
        }
        [Test]
        public void DeveSelecionarClientePorID()
        {
            //Arrange
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

            //Action
            controlador.InserirNovo(cliente);
            var clienteEncontrado = controlador.SelecionarPorId(cliente.Id);

            //Assert
            clienteEncontrado.Should().Be(cliente);
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
