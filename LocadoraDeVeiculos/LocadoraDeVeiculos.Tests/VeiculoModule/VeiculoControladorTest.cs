using FluentAssertions;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoControladorTest
    {
        ControladorVeiculo controlador = null;
        Veiculo novoVeiculo;
        public VeiculoControladorTest()
        {
            controlador = new ControladorVeiculo();
            Db.Update("DELETE FROM [TBVEICULO]");
            Db.Update("DELETE FROM [TBGRUPOVEICULO]");
        }
        [TestMethod]
        public void DeveInserirUmVeiculo()
        {
            //arrange
            novoVeiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true);

            //action
            controlador.InserirNovo(novoVeiculo);

            //assert
            Veiculo veiculoEncontrado = controlador.SelecionarPorId(novoVeiculo.Id);
            veiculoEncontrado.Should().Be(novoVeiculo);
        }

        [TestMethod]
        public void DeveSelecionarDoisVeiculos()
        {
            //arrange
            novoVeiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true);

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
            novoVeiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true);
            Veiculo veiculoEditado = new Veiculo(0, "Monza Tubarão Turbão Rebaixado", null, "ABC1234", "1ABCD12A12AB1AB1ABC", "Chevrolet", "Bordo", "Etanol", 60.5, 1996, 240000, 4, 5, 'G', false, false, false);
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
            novoVeiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true);

            //action
            controlador.InserirNovo(novoVeiculo);
            controlador.Excluir(novoVeiculo.Id);

            //assert
            List<Veiculo> veiculoEncontrado = controlador.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(0);
        }        
    }
}
