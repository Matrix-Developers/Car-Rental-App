using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ORMTests.LocacaoModule
{
    public class LocacaoORMTest
    {
        private IRepository<Locacao> controlador;
        private IRepository<GrupoDeVeiculo> controladorGrupoDeVeiculo;
        private IRepository<Veiculo> controladorVeiculo;
        private IRepository<Funcionario> controladorFuncionario;
        private IRepository<Cliente> controladorCliente;
        private IRepository<Parceiro> controladorParceiro;
        private IRepository<Cupom> controladorCupom;

        private Locacao locacao;
        private Parceiro parceiro;
        private GrupoDeVeiculo grupoDeVeiculo;

        private Veiculo veiculo;
        private Funcionario funcionarioLocador;
        private Cliente clienteContratante;
        private Cliente clienteCondutor;
        private Cupom cupom;
        private DateTime dataDeSaida;
        private DateTime dataPrevistaDeChegada;
        private string tipoDoPlano;
        private string tipoDeSeguro;
        //private List<Servico> servicos;


        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new LocacaoORM(dbContext);
            controladorGrupoDeVeiculo = new GrupoDeVeiculosORM(dbContext);
            controladorVeiculo = new VeiculoORM(dbContext);
            controladorFuncionario = new FuncionarioORM(dbContext);
            controladorCliente = new ClienteORM(dbContext);
            controladorParceiro = new ParceiroORM(dbContext);
            controladorCupom = new CupomORM(dbContext);
            Configuracao();
        }

        [Test]
        public void DeveAdicionarCupom()
        {
            //arrange
            locacao = new LocacaoDataBuilder()
                .ComVeiculo(veiculo)
                .ComFuncionarioLocador(funcionarioLocador)
                .ComClienteContratante(clienteContratante)
                .ComClienteCondutor(clienteCondutor)
                .ComCupom(cupom)
                .ComDataDeSaida(dataDeSaida)
                .ComDataPrevistaDeChegada(dataPrevistaDeChegada)
                .ComDataDeChegada()
                .ComTipoDoSeguro(tipoDeSeguro)
                .ComTipoDoPlano(tipoDoPlano)
                .Build();

            //action
            controlador.InserirNovo(locacao);

            //assert
            var registroEncontrado = controlador.SelecionarPorId(locacao.Id);
            registroEncontrado.Should().Be(locacao);
        }


        #region Métodos Privados
        public void Configuracao()
        {
            grupoDeVeiculo = new(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculo.InserirNovo(grupoDeVeiculo);
            veiculo = new(0, "Ecosport", grupoDeVeiculo, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionarioLocador = new(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionarioLocador);
            clienteContratante = new (0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), false);
            controladorCliente.InserirNovo(clienteCondutor);
            parceiro = new (0, "Nome Teste");
            controladorParceiro.InserirNovo(parceiro);
            cupom = new(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);
            controladorCupom.InserirNovo(cupom);

            dataDeSaida = DateTime.Today;
            dataPrevistaDeChegada = DateTime.Today.AddDays(5f);
            tipoDoPlano = "KmLivre";
            tipoDeSeguro = "Nenhum";
            //servicos = null;
        }
        #endregion
    }
}
