using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.IntegrationTests.GrupoDeVeiculosModule
{
    [TestClass]
    public class GrupoDeVeiculosControladorTest
    {
        GrupoDeVeiculosRepository controlador = null;

        public GrupoDeVeiculosControladorTest()
        {
            controlador = new GrupoDeVeiculosRepository();
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserir_GrupoDeVeiculos()
        {
            GrupoDeVeiculo novoGrupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f); ;

            controlador.InserirNovo(novoGrupoDeVeiculos);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(novoGrupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoDeVeiculos()
        {
            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 14f, 30.2f);
            controlador.InserirNovo(grupoDeVeiculos);

            GrupoDeVeiculo novoGrupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 5.12f, 37.52f, 99.31f, 2, 15f, 11.2f);

            controlador.Editar(grupoDeVeiculos.Id, novoGrupoDeVeiculos);

            var grupoDeVeiculosAtualizado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveExcluir_GrupoDeVeiculos()
        {
            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);
            controlador.InserirNovo(grupoDeVeiculos);

            controlador.Excluir(grupoDeVeiculos.Id);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculosPorId()
        {
            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 14f, 65.2f);
            controlador.InserirNovo(grupoDeVeiculos);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);

            grupoDeVeiculosEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoDeVeiculos()
        {
            GrupoDeVeiculo g1 = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 11f, 65f);
            controlador.InserirNovo(g1);
            GrupoDeVeiculo g2 = new GrupoDeVeiculo(0, "emon", 5.12f, 37.52f, 99.31f, 2, 4.5f, 50f);
            controlador.InserirNovo(g2);
            GrupoDeVeiculo g3 = new GrupoDeVeiculo(0, "meno", 5.21f, 35.72f, 93.91f, 20, 5f, 11f);
            controlador.InserirNovo(g3);

            List<GrupoDeVeiculo> grupoDeVeiculosAgrupado = controlador.SelecionarTodos();

            grupoDeVeiculosAgrupado.Should().HaveCount(3);
            grupoDeVeiculosAgrupado[0].Nome.Should().Be("nome");
            grupoDeVeiculosAgrupado[1].Nome.Should().Be("emon");
            grupoDeVeiculosAgrupado[2].Nome.Should().Be("meno");
        }

        [TestMethod]
        public void DeveRetornarTrue_QuandoExisteGrupoDeVeiculos()
        {
            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 5f, 30f);
            controlador.InserirNovo(grupoDeVeiculos);

            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);

            existeGrupoDeVeiculos.Should().BeTrue();
        }

        [TestMethod]
        public void DeveRetornarFalse_QuandoNaoExisteGrupoDeVeiculos()
        {
            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);

            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);

            existeGrupoDeVeiculos.Should().BeFalse();
        }

        [TestMethod]
        public void NaoDeveInserir_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            GrupoDeVeiculo novoGrupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);
            controlador.InserirNovo(novoGrupoDeVeiculos);
            GrupoDeVeiculo identicoGrupoDeVeiculos = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);
            
            string resposta = controlador.InserirNovo(identicoGrupoDeVeiculos);

            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }

        [TestMethod]
        public void NaoDeveAtualizar_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            GrupoDeVeiculo grupoDeVeiculosParaEditar = new GrupoDeVeiculo(0, "nome", 12.50f, 25.73f, 13.99f, 200, 11f, 50.5f);
            controlador.InserirNovo(grupoDeVeiculosParaEditar);
            GrupoDeVeiculo grupoDeVeiculosExistente = new GrupoDeVeiculo(0, "emon", 5.12f, 37.52f, 99.31f, 2, 5f, 90f);
            controlador.InserirNovo(grupoDeVeiculosExistente);

            GrupoDeVeiculo grupoDeVeiculosConflitante = new GrupoDeVeiculo(0, "emon", 5.21f, 35.72f, 93.91f, 20, 13f, 85.3f);
            string resposta =  controlador.Editar(grupoDeVeiculosParaEditar.Id, grupoDeVeiculosConflitante);

            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }
    }
}
