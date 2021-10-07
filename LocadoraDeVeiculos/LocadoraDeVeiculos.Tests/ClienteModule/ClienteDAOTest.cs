using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.IntegrationTests.ClienteModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class ClienteDAOTest
    {
        #region atributos privados
        private ClienteRepository controlador;
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

        [TestInitialize]
        public void Setup()
        {
            controlador = new ClienteRepository();

            ConfigurarNome();

            ConfigurarRegistroUnico();

            ConfigurarEndereco();

            ConfigurarTelefone();

            ConfigurarEmail();

            ConfigurarCnh();

            ConfigurarEhPessoaFisica();

            ConfigurarDatas();
        }

        [TestCleanup]
        public void TearDown()
        {
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserir_NovoCliente()
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
            var clienteEncontrado = controlador.SelecionarPorId(cliente.id);
            clienteEncontrado.Should().Be(cliente);
        }

        [TestMethod]
        public void DeveAtualizar_Cliente()
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

            Cliente clienteeditado;
            clienteeditado = new ClienteDataBuilder()
                .ComNome(jose)
                .ComRegistroUnico(cnpj)
                .ComEndereco(florianopolis)
                .ComTelefone(fixo)
                .ComEmail(hotmail)
                .ComCnh(cnhNull)
                .ComValidadeCnh(validadeNull)
                .ComEhPessoaFisica(pj)
                .Build();

            //action
            controlador.InserirNovo(cliente);
            controlador.Editar(cliente.id, clienteeditado);

            //assert
            var clienteAtualizado = controlador.SelecionarPorId(cliente.id);
            clienteAtualizado.Should().Be(clienteeditado);
        }

        [TestMethod]
        public void DeveExcluir_Cliente()
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
            controlador.Excluir(cliente.id);

            //assert
            var clienteEncontrado = controlador.SelecionarPorId(cliente.id);
            clienteEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosClientes()
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

            Cliente clienteDois = new ClienteDataBuilder()
                .ComNome(jose)
                .ComRegistroUnico(cnpj)
                .ComEndereco(florianopolis)
                .ComTelefone(fixo)
                .ComEmail(hotmail)
                .ComCnh(cnhNull)
                .ComValidadeCnh(validadeNull)
                .ComEhPessoaFisica(pj)
                .Build();

            //action
            controlador.InserirNovo(cliente);
            controlador.InserirNovo(clienteDois);
            var clientes = controlador.SelecionarTodos();

            //assert
            clientes.Should().HaveCount(2);
            clientes[0].Should().Be(cliente);
            clientes[1].Should().Be(clienteDois);
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveSelecionar_Cliente_PorID()
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
            Cliente clienteEncontrado = controlador.SelecionarPorId(cliente.id);

            //assert
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
