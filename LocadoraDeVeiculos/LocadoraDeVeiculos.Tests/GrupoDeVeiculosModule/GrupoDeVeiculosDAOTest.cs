using FluentAssertions;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.IntegrationTests.GrupoDeVeiculosModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class GrupoDeVeiculosDAOTest
    {
        private GrupoDeVeiculosRepository controlador;
        private GrupoDeVeiculo grupoDeVeiculos;
        private string nome;
        private string nomeEditado;
        private double taxaPlanoDiario;
        private double taxaKmDiario;
        private double taxaPlanoControlado;
        private int limiteKmControlado;
        private double taxaKmExcedidoControlado;
        private double taxaPlanoLivre;

        [TestInitialize]
        public void Setup()
        {
            Configuracao();
            controlador = new GrupoDeVeiculosRepository();
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserir_GrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
                .ComNome(nome)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [TestMethod]
        public void DeveAtualizar_GrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
           .ComNome(nome)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
           .ComNome(nomeEditado)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);
            controlador.Editar(grupoDeVeiculos.Id, grupoDeVeiculosEditado);

            //assert
            var grupoDeVeiculosAtualizado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(grupoDeVeiculosEditado);
        }

        [TestMethod]
        public void DeveExcluir_GrupoDeVeiculos()
        {
            //action
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
          .ComNome(nome)
          .ComTaxaPlanoDiario(taxaPlanoDiario)
          .ComTaxaPorKmDiario(taxaKmDiario)
          .ComTaxaPlanoControlado(taxaPlanoControlado)
          .ComLimiteKmControlado(limiteKmControlado)
          .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
          .ComTaxaPlanoLivre(taxaPlanoLivre)
          .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);
            controlador.Excluir(grupoDeVeiculos.Id);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculosPorId()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();
            //action
            controlador.InserirNovo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = controlador.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [TestMethod]
        public void DeveSelecionar_TodosGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();
            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
           .ComNome(nomeEditado)
           .ComTaxaPlanoDiario(taxaPlanoDiario)
           .ComTaxaPorKmDiario(taxaKmDiario)
           .ComTaxaPlanoControlado(taxaPlanoControlado)
           .ComLimiteKmControlado(limiteKmControlado)
           .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
           .ComTaxaPlanoLivre(taxaPlanoLivre)
           .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);
            controlador.InserirNovo(grupoDeVeiculosEditado);
            var grupoDeVeiculosAgrupado = controlador.SelecionarTodos();

            //assert
            grupoDeVeiculosAgrupado.Should().HaveCount(2);
            grupoDeVeiculosAgrupado[0].Should().Be(grupoDeVeiculos);
            grupoDeVeiculosAgrupado[1].Should().Be(grupoDeVeiculosEditado);
        }

        [TestMethod]
        public void DeveRetornarTrue_QuandoExisteGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);

            //assert
            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);
            existeGrupoDeVeiculos.Should().BeTrue();
        }

        [TestMethod]
        public void DeveRetornarFalse_QuandoNaoExisteGrupoDeVeiculos()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
             .ComNome(nome)
             .ComTaxaPlanoDiario(taxaPlanoDiario)
             .ComTaxaPorKmDiario(taxaKmDiario)
             .ComTaxaPlanoControlado(taxaPlanoControlado)
             .ComLimiteKmControlado(limiteKmControlado)
             .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
             .ComTaxaPlanoLivre(taxaPlanoLivre)
             .Build();

            //action
            bool existeGrupoDeVeiculos = controlador.Existe(grupoDeVeiculos.Id);

            //assert
            existeGrupoDeVeiculos.Should().BeFalse();
        }

        [TestMethod]
        public void NaoDeveInserir_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
              .ComNome(nome)
              .ComTaxaPlanoDiario(taxaPlanoDiario)
              .ComTaxaPorKmDiario(taxaKmDiario)
              .ComTaxaPlanoControlado(taxaPlanoControlado)
              .ComLimiteKmControlado(limiteKmControlado)
              .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
              .ComTaxaPlanoLivre(taxaPlanoLivre)
              .Build();
            var grupoDeVeiculosidentico = new GrupoDeVeiculosDataBuilder()
              .ComNome(nome)
              .ComTaxaPlanoDiario(taxaPlanoDiario)
              .ComTaxaPorKmDiario(taxaKmDiario)
              .ComTaxaPlanoControlado(taxaPlanoControlado)
              .ComLimiteKmControlado(limiteKmControlado)
              .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
              .ComTaxaPlanoLivre(taxaPlanoLivre)
              .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);
            string resposta = controlador.InserirNovo(grupoDeVeiculosidentico);

            //assert
            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }

        [TestMethod]
        public void NaoDeveAtualizar_GrupoDeVeiculosQuandoNomeJaExiste()
        {
            //arrange
            grupoDeVeiculos = new GrupoDeVeiculosDataBuilder()
                .ComNome(nome)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            var grupoDeVeiculosEditado = new GrupoDeVeiculosDataBuilder()
                .ComNome(nomeEditado)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            var grupoDeVeiculosConflitante = new GrupoDeVeiculosDataBuilder()
                .ComNome(nomeEditado)
                .ComTaxaPlanoDiario(taxaPlanoDiario)
                .ComTaxaPorKmDiario(taxaKmDiario)
                .ComTaxaPlanoControlado(taxaPlanoControlado)
                .ComLimiteKmControlado(limiteKmControlado)
                .ComTaxaKmExcedidoControlado(taxaKmExcedidoControlado)
                .ComTaxaPlanoLivre(taxaPlanoLivre)
                .Build();

            //action
            controlador.InserirNovo(grupoDeVeiculos);
            controlador.InserirNovo(grupoDeVeiculosEditado);

            //assert
            string resposta = controlador.Editar(grupoDeVeiculos.Id, grupoDeVeiculosConflitante);
            resposta.Should().Be("O nome do grupo de veículos deve ser único\n");
        }

        private void Configuracao()
        {
            nome = "nome";
            nomeEditado = "emon";
            taxaPlanoDiario = 12.50f;
            taxaKmDiario = 25.73f;
            taxaPlanoControlado = 13.99f;
            limiteKmControlado = 200;
            taxaKmExcedidoControlado = 11f;
            taxaPlanoLivre = 50.5f;
        }
    }
}