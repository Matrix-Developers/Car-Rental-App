using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ORMTests.CupomModule
{
    class LocacaoORMTest
    {
        private IRepository<Locacao> controlador;
        private IRepository<Veiculo> controladorVeiculo;
        private IRepository<Funcionario> controladorFuncionario;
        private IRepository<Cliente> controladorCliente;
        private IRepository<Cupom> controladoCupom;

        private Locacao locacao;
        private Veiculo veiculo;
        private Funcionario funcionarioLocador;
        private Cliente clienteContratante;
        private Cliente clienteCondutor;
        private Cupom cupom;
        private DateTime dataDeSaida;
        private DateTime dataPrevistaDeChegada;
        private DateTime dataDeChegada;
        private string tipoDoPlano;
        private string tipoDeSeguro;
        private double precoLocacao;
        private double precoDevolucao;
        private bool estaAberta;
        //private List<Servico> servicos;


        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new LocacaoORM(dbContext);
            controladorVeiculo = new VeiculoORM(dbContext);
            controladorFuncionario = new FuncionarioORM(dbContext);
            controladorCliente = new ClienteORM(dbContext);
            controladoCupom = new CupomORM(dbContext);
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
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);      //grupo de veiculos esta null. pode trazer problemas no db
            funcionarioLocador = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), false);
            cupom = new(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), null, 0);       //parceiro esta null. pode trazer problemas no db

            dataDeSaida = DateTime.Today;
            dataPrevistaDeChegada = DateTime.Today.AddDays(5f);
            tipoDoPlano = "KmLivre";
            tipoDeSeguro = "Nenhum";
            //servicos = null;
        }
        #endregion
    }
}
