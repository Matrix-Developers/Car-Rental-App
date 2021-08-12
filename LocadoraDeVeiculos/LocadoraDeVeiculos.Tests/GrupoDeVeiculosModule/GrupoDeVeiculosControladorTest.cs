using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

    }
}
