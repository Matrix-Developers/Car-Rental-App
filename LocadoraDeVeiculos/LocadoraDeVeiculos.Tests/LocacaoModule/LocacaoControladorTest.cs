using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Tests.LocacaoModule
{
    [TestClass]
    public class LocacaoControladorTest
    {
        ControladorLocacao controlador = null;
        ControladorGrupoDeVeiculos controladorGrupoDeVeiculos = null;
        ControladorVeiculo controladorVeiculo = null;
        ControladorFuncionario controladorFuncionario = null;
        ControladorCliente controladorCliente = null;
        ControladorServico controladorServico = null;
        ControladorCupom controladorCupom = null;
        GrupoDeVeiculo grupoVeiculos;
        Veiculo veiculo;
        Funcionario funcionario;
        Cliente clienteContratante;
        Cliente clienteCondutor;
        Locacao locacao;

        public LocacaoControladorTest()
        {
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            controladorVeiculo = new ControladorVeiculo();
            controladorFuncionario = new ControladorFuncionario();
            controladorCliente = new ControladorCliente();
            controladorServico = new ControladorServico();
            controladorCupom = new ControladorCupom();

            controlador = new ControladorLocacao(controladorVeiculo,controladorFuncionario,controladorCliente,controladorServico, controladorCupom);
            Db.Update("DELETE FROM [TBVEICULO]");
            Db.Update("DELETE FROM [TBGRUPOVEICULO]");
            Db.Update("DELETE FROM [TBFUNCIONARIO]");
            Db.Update("DELETE FROM [TBCLIENTE]");
            Db.Update("DELETE FROM [TBLOCACAO]");
        }

        [TestMethod]
        public void DeveInserirUmaLocacao()
        {
            grupoVeiculos = new GrupoDeVeiculo(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            veiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionario);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new Cliente(0, "Nardolindo", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteCondutor);

            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", 0,0,false,null);
            controlador.InserirNovo(locacao);

            var locacaoEncontrada = controlador.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(locacao);
        }

        [TestMethod]
        public void DeveSelecionarDuasLocacoes()
        {
            grupoVeiculos = new GrupoDeVeiculo(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            veiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionario);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new Cliente(0, "Nardolindo", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteCondutor);

            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);
            controlador.InserirNovo(locacao);
            Locacao outraLocacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today.AddDays(-10), DateTime.Today.AddDays(15), "PlanoDiario", "SeguroCliente", null);
            controlador.InserirNovo(outraLocacao);

            List<Locacao> locacaoEncontrado = controlador.SelecionarTodos();
            locacaoEncontrado.Count.Should().Be(2);
        }

        [TestMethod]
        public void DeveEditarUmaLocacao()
        {
            grupoVeiculos = new GrupoDeVeiculo(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            veiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionario);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new Cliente(0, "Nardolindo", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteCondutor);

            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);
            controlador.InserirNovo(locacao);
            Locacao outraLocacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", 0, 0, false, null);
            controlador.Editar(locacao.Id, outraLocacao);

            var locacaoEncontrada = controlador.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(outraLocacao);
        }

        [TestMethod]
        public void DeveExcluirUmVeiculo()
        {
            grupoVeiculos = new GrupoDeVeiculo(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            veiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionario);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new Cliente(0, "Nardolindo", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteCondutor);

            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);
            controlador.InserirNovo(locacao);
            controlador.Excluir(locacao.Id);

            List<Locacao> locacaoEncontrado = controlador.SelecionarTodos();
            locacaoEncontrado.Count.Should().Be(0);
        }

    }
}
