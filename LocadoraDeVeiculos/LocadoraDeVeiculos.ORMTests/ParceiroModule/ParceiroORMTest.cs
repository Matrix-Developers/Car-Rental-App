using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System.Linq;

namespace LocadoraDeVeiculos.ORMTests.ParceiroModule
{
    public class ParceiroORMTest
    {
        private IRepository<Parceiro> controlador;
        LocadoraDeVeiculosDBContext dbContext = new();

        private Parceiro parceiro;
        private string nome;

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new ParceiroORM(dbContext);
            Configuracao();
        }

        [TearDown]
        public void TearDown()
        {
            var listaParceiros = dbContext.Parceiros.ToList().Select(x => x as Parceiro);
            foreach (var item in listaParceiros)
                dbContext.Parceiros.Remove(item);

            dbContext.SaveChanges();
        }

        [Test]
        public void DeveAdicionarParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(nome)
                .Build();

            //action
            controlador.InserirNovo(parceiro);

            //assert
            var parceiroEncontrado = controlador.SelecionarPorId(parceiro.Id);
            parceiroEncontrado.Should().Be(parceiro);
        }

        [Test]
        public void DeveSelecionarDoisParceiros()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
               .ComNome(nome)
               .Build();

            Parceiro parceiro2 = new ParceiroDataBuilder()
               .ComNome(nome)
               .Build();

            controlador.InserirNovo(parceiro);
            controlador.InserirNovo(parceiro2);

            //action
            var cupons = controlador.SelecionarTodos();

            //assert
            cupons.Should().HaveCount(2);
        }

        [Test]
        public void DeveEditarUmParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(nome)
                .Build();

            controlador.InserirNovo(parceiro);

            //action
            parceiro.Nome = "Editado";
            controlador.Editar(0, parceiro);

            //assert
            Parceiro parceiroEncontrado = controlador.SelecionarPorId(parceiro.Id);
            parceiroEncontrado.Nome.Should().Be("Editado");
        }

        [Test]
        public void DeveExcluirUmParceiro()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(nome)
                .Build();

            //action
            controlador.InserirNovo(parceiro);
            controlador.Excluir(parceiro.Id);

            //assert
            var parceiroEscolhido = controlador.SelecionarPorId(parceiro.Id);
            parceiroEscolhido.Should().BeNull();
        }
        [Test]
        public void DeveSelecionarParceiroPorID()
        {
            //Arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(nome)
                .Build();

            //Action
            controlador.InserirNovo(parceiro);
            var parceiroEncontrado = controlador.SelecionarPorId(parceiro.Id);

            //Assert
            parceiroEncontrado.Should().Be(parceiro);
        }

        #region Métodos Privados
        private void Configuracao()
        {
            nome = "NDD";
        }
        #endregion
    }
}
