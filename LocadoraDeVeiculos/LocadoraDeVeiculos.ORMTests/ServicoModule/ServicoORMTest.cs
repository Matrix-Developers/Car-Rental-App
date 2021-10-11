using FluentAssertions;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.ORMTests.ServicoModule
{
    [TestClass]
    [TestCategory("ORM")]
    public class ServicoORMTest
    {
        private IRepository<Servico> controlador;
        LocadoraDeVeiculosDBContext dbContext = new();

        private bool taxa;
        private string nome;
        private string outroNome;
        private int valor;
        private Servico servico;

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new ServicoORM(dbContext);
            Configuracao();
        }

        [TearDown]
        public void TearDown()
        {
            var listaServicos = dbContext.Servicos.ToList().Select(x => x as Servico);
            foreach (var item in listaServicos)
                dbContext.Servicos.Remove(item);

            dbContext.SaveChanges();
        }
        [Test]
        public void DeveInserirUmServico()
        {
            //arrange
            servico = new ServicoDataBuilder()
                .ComNome(nome)
                .ComTaxaDiaria(taxa)
                .ComValor(valor)
                .Build();

            //action
            controlador.InserirNovo(servico);

            //assert
            Servico servicoEncontrado = controlador.SelecionarPorId(servico.Id);
            servicoEncontrado.Should().Be(servico);
        }
        [Test]
        public void DeveSelecionarDoisServicos()
        {
            //arrange
            servico = new ServicoDataBuilder()
                .ComNome(nome)
                .ComTaxaDiaria(taxa)
                .ComValor(valor)
                .Build();

            Servico novoServico = new ServicoDataBuilder()
                .ComNome("Mecânico")
                .ComTaxaDiaria(true)
                .ComValor(2000)
                .Build();


            //action
            controlador.InserirNovo(servico);
            controlador.InserirNovo(novoServico);
            var servicos = controlador.SelecionarTodos();

            //assert
            servicos.Should().HaveCount(2);
            servicos[0].Should().Be(servico);
            servicos[1].Should().Be(novoServico);
        }

        [Test]
        public void DeveEditarUmServico()
        {
            //arrange
            servico = new ServicoDataBuilder()
                .ComNome(nome)
                .ComTaxaDiaria(taxa)
                .ComValor(valor)
                .Build();

            controlador.InserirNovo(servico);
            servico.Nome = outroNome;
 
            //action
            controlador.Editar(0, servico);

            //assert
            var servicoEncontrado = controlador.SelecionarPorId(servico.Id);
            servicoEncontrado.Nome.Should().Be("Cadeirinha");
        }

        [Test]
        public void DeveExcluirUmServico()
        {
            //arrange
            servico = new ServicoDataBuilder()
           .ComNome(nome)
           .ComTaxaDiaria(taxa)
           .ComValor(valor)
           .Build();

            //action
            controlador.Excluir(servico.Id);

            //assert
            var servicoEncontrado = controlador.SelecionarPorId(servico.Id);
            servicoEncontrado.Should().BeNull();
        }

        [Test]
        public void DeveSelecionarServicoPorID()
        {
            servico = new ServicoDataBuilder()
           .ComNome(nome)
           .ComTaxaDiaria(taxa)
           .ComValor(valor)
           .Build();

            controlador.InserirNovo(servico);
            Servico servicoEncontrado = controlador.SelecionarPorId(servico.Id);

            servicoEncontrado.Should().Be(servico);
        }

        private void Configuracao()
        {
            nome = "Lavação";
            outroNome = "Cadeirinha";
            valor = 1000;
            taxa = true;
        }
    }
}
