using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Tests.GrupoDeVeiculosModule
{
    [TestClass]
    public class GrupoDeVeiculosControladorTest
    {
        ControladorGrupoDeVeiculos controlador = null;

        public GrupoDeVeiculosControladorTest()
        {
            controlador = new ControladorGrupoDeVeiculos();
            Db.Update("DELETE FROM [TBGRUPOVEICULO]");
        }

        [TestMethod]
        public void DeveInserir_GrupoDeVeiculos()
        {
            GrupoDeVeiculos novoGrupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);

            controlador.InserirNovo(novoGrupoDeVeiculos);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(novoGrupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoDeVeiculos()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);
            controlador.InserirNovo(grupoDeVeiculos);

            GrupoDeVeiculos novoGrupoDeVeiculos = new GrupoDeVeiculos(0, "emon", 5.12f, 37.52f, 99.31f, 2);

            controlador.Editar(grupoDeVeiculos.Id, novoGrupoDeVeiculos);

            var grupoDeVeiculosAtualizado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(novoGrupoDeVeiculos);
        }

        [TestMethod]
        public void DeveExcluir_GrupoDeVeiculos()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);
            controlador.InserirNovo(grupoDeVeiculos);

            controlador.Excluir(grupoDeVeiculos.Id);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculosPorId()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);
            controlador.InserirNovo(grupoDeVeiculos);

            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);

            grupoDeVeiculosEncontrado.Should().NotBeNull();
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoDeVeiculos()
        {
            GrupoDeVeiculos g1 = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);
            controlador.InserirNovo(g1);
            GrupoDeVeiculos g2 = new GrupoDeVeiculos(0, "emon", 5.12f, 37.52f, 99.31f, 2);
            controlador.InserirNovo(g2);
            GrupoDeVeiculos g3 = new GrupoDeVeiculos(0, "meno", 5.21f, 35.72f, 93.91f, 20);
            controlador.InserirNovo(g3);

            List<GrupoDeVeiculos> grupoDeVeiculosAgrupado = controlador.SelecionarTodos();

            grupoDeVeiculosAgrupado.Should().HaveCount(3);
            grupoDeVeiculosAgrupado[0].Nome.Should().Be("nome");
            grupoDeVeiculosAgrupado[1].Nome.Should().Be("emon");
            grupoDeVeiculosAgrupado[2].Nome.Should().Be("meno");
        }

        [TestMethod]
        public void DeveRetornarTrue_QuandoExisteGrupoDeVeiculos()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);
            controlador.InserirNovo(grupoDeVeiculos);

            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);

            existeGrupoDeVeiculos.Should().BeTrue();
        }

        [TestMethod]
        public void DeveRetornarFalse_QuandoNaoExisteGrupoDeVeiculos()
        {
            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(0, "nome", 12.50f, 25.73f, 13.99f, 200);

            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);

            existeGrupoDeVeiculos.Should().BeFalse();
        }

    }
}
