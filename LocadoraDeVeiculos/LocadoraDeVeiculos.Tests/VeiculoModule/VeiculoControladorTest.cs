using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoControladorTest
    {
        ControladorVeiculo controlador = null;
        ControladorGrupoDeVeiculos controladorGrupoDeVeiculos = null;        
        Veiculo novoVeiculo;
        GrupoDeVeiculo grupoVeiculos;

        public VeiculoControladorTest()
        {
            controlador = new ControladorVeiculo();
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            Db.Update("DELETE FROM [TBVEICULO]");
            Db.Update("DELETE FROM [TBGRUPOVEICULO]");
        }
        [TestMethod]
        public void DeveInserirUmVeiculo()
        {
            //arrange
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);

            //action
            controlador.InserirNovo(novoVeiculo);

            //assert
            var veiculoEncontrado = controlador.SelecionarPorId(novoVeiculo.Id);
            veiculoEncontrado.Should().Be(novoVeiculo);
        }

        [TestMethod]
        public void DeveSelecionarDoisVeiculos()
        {
            //arrange
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);

            //action
            controlador.InserirNovo(novoVeiculo);
            controlador.InserirNovo(novoVeiculo);

            //assert
            List<Veiculo> veiculoEncontrado = controlador.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(2);
        }

        [TestMethod]
        public void DeveEditarUmVeiculo()
        {
            //arrange
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);

            GrupoDeVeiculo grupoEditado = new GrupoDeVeiculo(0, "Pique Velozes e Furiosos", 100, 60.5, 40, 300, 45.2, 500);
            controladorGrupoDeVeiculos.InserirNovo(grupoEditado);
            Veiculo veiculoEditado = new Veiculo(0, "Monza Tubarão Turbão Rebaixado", grupoEditado, "ABC1234", "1ABCD12A12AB1AB1ABC", "Chevrolet", "Bordo", "Etanol", 60.5, 1996, "240000", 4, 5, 'G', false, false, false);
            //action
            controlador.InserirNovo(novoVeiculo);
            controlador.Editar(novoVeiculo.Id, veiculoEditado);

            //assert
            Veiculo veiculoEncontrado = controlador.SelecionarPorId(novoVeiculo.Id);
            veiculoEncontrado.Should().Be(veiculoEditado);
        }

        [TestMethod]
        public void DeveExcluirUmVeiculo()
        {
            //arrange
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);

            //action
            controlador.InserirNovo(novoVeiculo);
            controlador.Excluir(novoVeiculo.Id);

            //assert
            List<Veiculo> veiculoEncontrado = controlador.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(0);
        }        
    }
}
