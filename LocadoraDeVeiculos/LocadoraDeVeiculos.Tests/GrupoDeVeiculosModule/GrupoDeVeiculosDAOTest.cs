using FluentAssertions;
using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
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
        private GrupoDeVeiculosAppService GrupoDeVeiculosAppService;
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
            GrupoDeVeiculosAppService = new GrupoDeVeiculosAppService(new GrupoDeVeiculosRepository(), new GrupoDeVeiculosRepository());
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarEntidadePorId(grupoDeVeiculos.id);
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);
            GrupoDeVeiculosAppService.EditarEntidade(grupoDeVeiculos.id, grupoDeVeiculosEditado);

            //assert
            var grupoDeVeiculosAtualizado = GrupoDeVeiculosAppService.SelecionarEntidadePorId(grupoDeVeiculos.id);
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);
            GrupoDeVeiculosAppService.ExcluirEntidade(grupoDeVeiculos.id);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarEntidadePorId(grupoDeVeiculos.id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionar_GrupoDeVeiculosPorid()
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = GrupoDeVeiculosAppService.SelecionarEntidadePorId(grupoDeVeiculos.id);
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculosEditado);
            var grupoDeVeiculosAgrupado = GrupoDeVeiculosAppService.SelecionarTodasEntidade();

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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);

            //assert
            bool existeGrupoDeVeiculos = GrupoDeVeiculosAppService.ExisteEntidade(grupoDeVeiculos.id);
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
            bool existeGrupoDeVeiculos = GrupoDeVeiculosAppService.ExisteEntidade(grupoDeVeiculos.id);

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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);
            bool resposta = GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculosidentico);

            //assert
            resposta.Should().Be(true);
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
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculos);
            GrupoDeVeiculosAppService.InserirEntidade(grupoDeVeiculosEditado);

            //assert
            bool resposta = GrupoDeVeiculosAppService.EditarEntidade(grupoDeVeiculos.id, grupoDeVeiculosConflitante);
            resposta.Should().Be(true);
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