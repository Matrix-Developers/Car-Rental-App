using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using System.Collections.Generic;
using LocadoraDeVeiculos.Tests.Shared;

namespace LocadoraDeVeiculos.Tests.VeiculoModule
{
    [TestClass]
    public class VeiculoControladorTest
    {
        VeiculoRepository controlador = null;
        GrupoDeVeiculosRepository controladorGrupoDeVeiculos = null;        
        Veiculo novoVeiculo;
        GrupoDeVeiculo grupoVeiculos;
        List<ImagemVeiculo> imagem;

        public VeiculoControladorTest()
        {
            controlador = new VeiculoRepository();
            controladorGrupoDeVeiculos = new GrupoDeVeiculosRepository();

            ResetarBanco.ResetarTabelas();
        }
        [TestMethod]
        public void DeveInserirUmVeiculo()
        {
            //arrange
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true,true, null);

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
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true,true, null);

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
            imagem = new List<ImagemVeiculo>();
            grupoVeiculos = new GrupoDeVeiculo(0, "SUV", 10.0, 10.5, 10, 100, 15.5, 45.8);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);

            GrupoDeVeiculo grupoEditado = new GrupoDeVeiculo(0, "Pique Velozes e Furiosos", 100, 60.5, 40, 300, 45.2, 500);
            controladorGrupoDeVeiculos.InserirNovo(grupoEditado);
            Veiculo veiculoEditado = new Veiculo(0, "Monza Tubarão Turbão Rebaixado", grupoEditado, "ABC1234", "1ABCD12A12AB1AB1ABC", "Chevrolet", "Bordo", "Etanol", 60.5, 1996, 240000, 4, 5, 'G', false, false, false, false,imagem);
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
            novoVeiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);

            //action
            controlador.InserirNovo(novoVeiculo);
            controlador.Excluir(novoVeiculo.Id);

            //assert
            List<Veiculo> veiculoEncontrado = controlador.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(0);
        }        
    }
}
