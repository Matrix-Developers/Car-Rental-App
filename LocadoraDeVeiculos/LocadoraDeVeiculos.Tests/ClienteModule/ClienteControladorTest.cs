using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.IntegrationTests.ClienteModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ClienteControladorTest
    {
        ClienteRepository controlador = null;
        Cliente cliente;
        public ClienteControladorTest()
        {
            controlador = new ClienteRepository();
            ResetarBanco.ResetarTabelas();
        }
        [TestMethod]
        public void DeveInserir_NovoCliente()
        {
            //arrange
            Cliente cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

            //action
            controlador.InserirNovo(cliente);

            //assert
            Cliente clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Should().Be(cliente);

        }

        [TestMethod]
        public void DeveAtualizar_Cliente()
        {
            //arrange
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controlador.InserirNovo(cliente);

            Cliente clienteeditado = new Cliente(2, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);

            //action
            controlador.Editar(cliente.Id, clienteeditado);

            //assert
            Cliente clienteAtualizado = controlador.SelecionarPorId(cliente.Id);
            clienteAtualizado.Should().Be(cliente);
        }

        [TestMethod]
        public void DeveExcluir_Cliente()
        {
            //arrange
            Cliente cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controlador.InserirNovo(cliente);

            //action
            controlador.Excluir(cliente.Id);

            //assert
            Cliente clienteEncontrado = controlador.SelecionarPorId(cliente.Id);
            clienteEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosClientes()
        {
            Cliente c1 = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

            controlador.InserirNovo(c1);
            controlador.InserirNovo(c1);

            var clientes = controlador.SelecionarTodos();

            clientes.Should().HaveCount(2);
            clientes[0].Nome.Should().Be("Nome Teste");
            clientes[1].Nome.Should().Be("Nome Teste");
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveSelecionar_Cliente_PorID()
        {
            //arrange
            Cliente cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controlador.InserirNovo(cliente);

            //action
            Cliente clienteEncontrado = controlador.SelecionarPorId(cliente.Id);

            //assert
            clienteEncontrado.Should().NotBeNull();
        }        
    }
}
