using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.IntegrationTests.ParceiroModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class ParceiroDAOTest
    {
        private ParceiroRepository controlador;

        private Parceiro parceiro;
        private string nome;
        private string segundoNome;

        [TestInitialize]

        public void Setup()
        {
            controlador = new ParceiroRepository();
            Configuracao();
            ResetarBanco.ResetarTabelas();
        }


        [TestMethod]
        public void DeveInserirUmParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
            .ComNome(nome)
            .Build();

            //action
            controlador.InserirNovo(parceiro);

            //assert
            Parceiro parceiroEncontrado = controlador.SelecionarPorId(parceiro.id);
            parceiroEncontrado.Should().Be(parceiroEncontrado);
        }

        [TestMethod]
        public void DeveSelecionarDoisParceiros()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
            .ComNome(nome)
            .Build();

            var novoParceiro = new ParceiroDataBuilder()
            .ComNome(segundoNome)
            .Build();


            controlador.InserirNovo(parceiro);
            controlador.InserirNovo(novoParceiro);

            //action
            var parceiros = controlador.SelecionarTodos();

            //assert
            parceiros.Should().HaveCount(2);
        }

        [TestMethod]
        public void DeveEditarUmParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
           .ComNome(nome)
           .Build();
            var novoParceiro = new ParceiroDataBuilder()
           .ComNome(segundoNome)
           .Build();

            //action
            controlador.InserirNovo(parceiro);
            controlador.Editar(parceiro.id, novoParceiro);

            //assert
            Parceiro parceiroEncontrado = controlador.SelecionarPorId(parceiro.id);
            parceiroEncontrado.Should().Be(novoParceiro);
        }

        [TestMethod]
        public void DeveExcluirUmParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
           .ComNome(nome)
           .Build();

            //action
            controlador.InserirNovo(parceiro);
            controlador.Excluir(parceiro.id);

            //assert
            var parceiroEncontrado = controlador.SelecionarPorId(parceiro.id);
            parceiroEncontrado.Should().BeNull();
        }
        [TestMethod]
        public void DeveSelecionarPorId()
        {
            parceiro = new ParceiroDataBuilder()
            .ComNome(nome)
            .Build();

            controlador.InserirNovo(parceiro);
            Parceiro parceiroEncontrado = controlador.SelecionarPorId(parceiro.id);

            parceiroEncontrado.Should().Be(parceiroEncontrado);
        }

        private void Configuracao()
        {
            nome = "NDD";
            segundoNome = "Deko";
        }
    }
}