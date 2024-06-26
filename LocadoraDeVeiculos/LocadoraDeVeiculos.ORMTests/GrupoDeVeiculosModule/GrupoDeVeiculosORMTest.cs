﻿using FluentAssertions;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System.Linq;

namespace LocadoraDeVeiculos.ORMTests.GrupoDeVeiculosModule
{

    public class GrupoDeVeiculosDAOTest
    {
        private IRepository<GrupoDeVeiculo> repository;
        LocadoraDeVeiculosDBContext dbContext = new();
        
        private GrupoDeVeiculo grupoDeVeiculos;
        private string nome;
        private string nomeEditado;
        private double taxaPlanoDiario;
        private double taxaKmDiario;
        private double taxaPlanoControlado;
        private int limiteKmControlado;
        private double taxaKmExcedidoControlado;
        private double taxaPlanoLivre;

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            repository = new GrupoDeVeiculosORM(dbContext);
            Configuracao();  
        }

        [TearDown]
        public void TearDown()
        {
            var listaLocacaoes = dbContext.Locacoes.ToList().Select(x => x as Locacao);
            foreach (var item in listaLocacaoes)
                dbContext.Locacoes.Remove(item);
            dbContext.SaveChanges();

            var listaVeiculos = dbContext.Veiculos.ToList().Select(x => x as Veiculo);
            foreach (var item in listaVeiculos)
                dbContext.Veiculos.Remove(item);

            var listaParceiros = dbContext.GrupoDeVeiculos.ToList().Select(x => x as GrupoDeVeiculo);
            foreach (var item in listaParceiros)
                dbContext.GrupoDeVeiculos.Remove(item);

            dbContext.SaveChanges();
        }

        [Test]
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
            repository.InserirNovo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = repository.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [Test]
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

            //action
            repository.InserirNovo(grupoDeVeiculos);
            grupoDeVeiculos.Nome = nomeEditado;
            repository.Editar(grupoDeVeiculos.Id, grupoDeVeiculos);

            //assert
            var grupoDeVeiculosAtualizado = repository.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosAtualizado.Should().Be(grupoDeVeiculos);
        }

        [Test]
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
            repository.InserirNovo(grupoDeVeiculos);
            repository.Excluir(grupoDeVeiculos.Id);

            //assert
            var grupoDeVeiculosEncontrado = repository.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().BeNull();
        }

        [Test]
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
            repository.InserirNovo(grupoDeVeiculos);

            //assert
            var grupoDeVeiculosEncontrado = repository.SelecionarPorId(grupoDeVeiculos.Id);
            grupoDeVeiculosEncontrado.Should().Be(grupoDeVeiculos);
        }

        [Test]
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
            repository.InserirNovo(grupoDeVeiculos);
            repository.InserirNovo(grupoDeVeiculosEditado);
            var grupoDeVeiculosAgrupado = repository.SelecionarTodos();

            //assert
            grupoDeVeiculosAgrupado.Should().HaveCount(2);
            grupoDeVeiculosAgrupado[0].Should().Be(grupoDeVeiculos);
            grupoDeVeiculosAgrupado[1].Should().Be(grupoDeVeiculosEditado);
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
