using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.IntegrationTests.SevicoModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class ServicoDAOTest
    {
        private ServicoRepository controlador;
        private Servico servico;
        private bool taxa;
        private string nome;
        private string outroNome;
        private int valor;

        [TestInitialize]
        public void Setup()
        {
            controlador = new ServicoRepository();
            Configuracao();
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
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
            Servico servicoEncontrado = controlador.SelecionarPorId(servico.id);
            servicoEncontrado.Should().Be(servico);
        }
        [TestMethod]
        public void DeveSelecionarDoisServicos()
        {
            //arrange
            servico = new ServicoDataBuilder()
                .ComNome(nome)
                .ComTaxaDiaria(taxa)
                .ComValor(valor)
                .Build();

            controlador.InserirNovo(servico);
            controlador.InserirNovo(servico);

            //action
            var servicos = controlador.SelecionarTodos();

            //assert
            servicos.Should().HaveCount(2);
        }

        [TestMethod]
        public void DeveEditarUmServico()
        {
            //arrange
            servico = new ServicoDataBuilder()
                .ComNome(nome)
                .ComTaxaDiaria(taxa)
                .ComValor(valor)
                .Build();

            controlador.InserirNovo(servico);

            var servicoEditado = new ServicoDataBuilder()
               .ComNome(outroNome)
               .ComTaxaDiaria(false)
               .ComValor(2000)
               .Build();


            //action

            controlador.Editar(servico.id, servicoEditado);

            //assert
            Servico servicoEncontrado = controlador.SelecionarPorId(servico.id);
            servicoEncontrado.Should().Be(servicoEditado);
        }

        [TestMethod]
        public void DeveExcluirUmServico()
        {
            //arrange
            servico = new ServicoDataBuilder()
           .ComNome(nome)
           .ComTaxaDiaria(taxa)
           .ComValor(valor)
           .Build();

            //action
            controlador.Excluir(servico.id);

            //assert
            var servicoEncontrado = controlador.SelecionarPorId(servico.id);
            servicoEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveSelecionarServicoPorID()
        {
            servico = new ServicoDataBuilder()
           .ComNome(nome)
           .ComTaxaDiaria(taxa)
           .ComValor(valor)
           .Build();

            controlador.InserirNovo(servico);
            Servico servicoEncontrado = controlador.SelecionarPorId(servico.id);

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