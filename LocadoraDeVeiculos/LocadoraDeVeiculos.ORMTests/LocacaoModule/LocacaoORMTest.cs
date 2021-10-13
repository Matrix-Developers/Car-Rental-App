using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.ORMTests.LocacaoModule
{
    public class LocacaoORMTest
    {
        #region atributos privados
        private IRepository<Locacao> controlador;
        private IRepository<GrupoDeVeiculo> controladorGrupoDeVeiculos;
        private IRepository<Veiculo> controladorVeiculo;
        private IRepository<Funcionario> controladorFuncionario;
        private IRepository<Cliente> controladorCliente;
        private IRepository<Parceiro> controladorParceiro;
        private IRepository<Cupom> controladorCupom;
        private IRepository<Servico> controladorServico;
        private LocadoraDeVeiculosDBContext dbContext = new();

        private Locacao locacao;
        private GrupoDeVeiculo suv;

        private Veiculo kicks;
        private Veiculo fusca;

        private Funcionario beto;
        private Funcionario joao;

        private Cliente condutorBruno;
        private Cliente condutorPedro;

        private Servico caderinhaBebe;
        private Servico lavacaoCarro;

        private Cupom descontaoDoDeko;
        private Parceiro deko;

        private string planoDiario;
        private string planoKmControlado;

        private string seguroCliente;
        private string seguroNenhum;

        private DateTime hoje;
        private DateTime amanha;
        private DateTime daquiDezDias;
        private DateTime daquiSeteDias;
        private DateTime daquiUmAno;
        #endregion


        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new LocacaoORM(dbContext);
            controladorGrupoDeVeiculos = new GrupoDeVeiculosORM(dbContext);
            controladorVeiculo = new VeiculoORM(dbContext);
            controladorFuncionario = new FuncionarioORM(dbContext);
            controladorCliente = new ClienteORM(dbContext);
            controladorParceiro = new ParceiroORM(dbContext);
            controladorCupom = new CupomORM(dbContext);

            ConfigurarDatas();

            InserirClientes();

            ConfigurarSeguro();

            ConfigurarTiposDePlanos();

            InserirGruposDeVeiculos();

            InserirVeiculo();

            InserirFuncionarios();

            InserirTaxas();

            InserirParceiroECupom();
        }

        [Test]
        public void DeveAdicionarLocacao()
        {
            //Arrange
            List<Servico> listaServicos = new()
            {
                caderinhaBebe,
                lavacaoCarro
            };
            locacao = new LocacaoDataBuilder()
                .ComVeiculo(kicks)
                .ComFuncionarioLocador(beto)
                .ComClienteContratante(condutorPedro)
                .ComClienteCondutor(condutorPedro)
                .ComCupom(descontaoDoDeko)
                .ComDataDeSaida(hoje)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiSeteDias)
                .ComTipoDoPlano(planoDiario)
                .ComTipoDoSeguro(seguroCliente)
                .ComServicos(listaServicos)
                .Build();

            //Action
            controlador.InserirNovo(locacao);

            //Assert
            var locacaoEncontrada = controlador.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(locacao); ;
        }

        [Test]
        public void DeveSelecionarDuasLocacoes()
        {
            //Arrange
            List<Servico> listaServicos = new()
            {
                caderinhaBebe,
                lavacaoCarro
            };
            locacao = new LocacaoDataBuilder()
                .ComVeiculo(kicks)
                .ComFuncionarioLocador(beto)
                .ComClienteContratante(condutorPedro)
                .ComClienteCondutor(condutorPedro)
                .ComCupom(descontaoDoDeko)
                .ComDataDeSaida(hoje)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiSeteDias)
                .ComTipoDoPlano(planoDiario)
                .ComTipoDoSeguro(seguroCliente)
                .ComServicos(listaServicos)
                .Build();
            Locacao segundaLocacao = new LocacaoDataBuilder()
                .ComVeiculo(fusca)
                .ComFuncionarioLocador(joao)
                .ComClienteContratante(condutorBruno)
                .ComClienteCondutor(condutorBruno)
                .ComCupom(null)
                .ComDataDeSaida(amanha)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiDezDias)
                .ComTipoDoPlano(planoKmControlado)
                .ComTipoDoSeguro(seguroNenhum)
                .ComServicos(null)
                .Build();

            //Action
            controlador.InserirNovo(locacao);
            controlador.InserirNovo(segundaLocacao);

            //Assert
            List<Locacao> locacaoEncontrado = controlador.SelecionarTodos();
            locacaoEncontrado[0].Should().Be(locacao);
            locacaoEncontrado[1].Should().Be(segundaLocacao);
        }

        [Test]
        public void DeveEditarUmaLocacao()
        {
            //Arrange
            List<Servico> listaServicos = new()
            {
                caderinhaBebe,
                lavacaoCarro
            };
            locacao = new LocacaoDataBuilder()
                .ComVeiculo(kicks)
                .ComFuncionarioLocador(beto)
                .ComClienteContratante(condutorPedro)
                .ComClienteCondutor(condutorPedro)
                .ComCupom(descontaoDoDeko)
                .ComDataDeSaida(hoje)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiSeteDias)
                .ComTipoDoPlano(planoDiario)
                .ComTipoDoSeguro(seguroCliente)
                .ComServicos(listaServicos)
                .Build();

            Locacao segundaLocacao = new LocacaoDataBuilder()
                .ComVeiculo(fusca)
                .ComFuncionarioLocador(joao)
                .ComClienteContratante(condutorBruno)
                .ComClienteCondutor(condutorBruno)
                .ComCupom(null)
                .ComDataDeSaida(amanha)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiDezDias)
                .ComTipoDoPlano(planoKmControlado)
                .ComTipoDoSeguro(seguroNenhum)
                .ComServicos(null)
                .Build();

            //Action
            controlador.InserirNovo(locacao);
            controlador.Editar(locacao.Id, segundaLocacao);

            //Assert
            var locacaoEncontrada = controlador.SelecionarPorId(locacao.Id);
            locacaoEncontrada.Should().Be(segundaLocacao);
        }

        [Test]
        public void DeveExcluirUmaLocacao()
        {
            //Arrange
            List<Servico> listaServicos = new()
            {
                caderinhaBebe,
                lavacaoCarro
            };
            locacao = new LocacaoDataBuilder()
                .ComVeiculo(kicks)
                .ComFuncionarioLocador(beto)
                .ComClienteContratante(condutorPedro)
                .ComClienteCondutor(condutorPedro)
                .ComCupom(descontaoDoDeko)
                .ComDataDeSaida(hoje)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiSeteDias)
                .ComTipoDoPlano(planoDiario)
                .ComTipoDoSeguro(seguroCliente)
                .ComServicos(listaServicos)
                .Build();

            //Action
            controlador.InserirNovo(locacao);
            controlador.Excluir(locacao.Id);

            //Assert
            List<Locacao> locacaoEncontrado = controlador.SelecionarTodos();
            locacaoEncontrado.Count.Should().Be(0);
        }


        #region Métodos Privados
        private void InserirParceiroECupom()
        {
            deko = new Parceiro(0, "Desconto do Deko");

            controladorParceiro.InserirNovo(deko);

            descontaoDoDeko = new Cupom(0, "100 de desconto", "DEKO", 100, 600, true, daquiDezDias, deko, 0);

            controladorCupom.InserirNovo(descontaoDoDeko);
        }

        private void InserirTaxas()
        {
            caderinhaBebe = new Servico(0, "Cadeirinha de Bebê", true, 30);
            lavacaoCarro = new Servico(0, "Lavação de Carro", false, 30);

            controladorServico.InserirNovo(caderinhaBebe);
            controladorServico.InserirNovo(lavacaoCarro);
        }

        private void InserirFuncionarios()
        {
            beto = new Funcionario(0, "Alberto", "66513610079", "Lages", "99999999", "alberto@gmail.com", 1, "beto", "beto123", hoje, "dev", 600, true);

            joao = new Funcionario(0, "João Junior", "19559341006", "Florianopolis", "99999999", "joao@gmail.com", 2, "jao", "jao123", hoje, "vendedor", 6000, true);

            controladorFuncionario.InserirNovo(beto);
            controladorFuncionario.InserirNovo(joao);
        }

        private void InserirVeiculo()
        {
            kicks = new Veiculo(0, "Kicks", suv, "abc1234", "5pH h8Kf5K md TV2348", "Honda", "Branco", "Gasolina", 50, Convert.ToInt32(DateTime.Today.Year), 2000, 4, 5, 'G', true, true, true, true, null);

            fusca = new Veiculo(0, "Fusca", suv, "abc1234", "5pH h8Kf5K md TV2348", "Volkswagen", "Branco", "Etanol", 50, Convert.ToInt32(DateTime.Today.AddYears(-20).Year), 200000, 4, 5, 'P', false, false, false, false, null);

            controladorVeiculo.InserirNovo(kicks);
            controladorVeiculo.InserirNovo(fusca);
        }

        private void InserirGruposDeVeiculos()
        {
            suv = new GrupoDeVeiculo(0, "SUV", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);

            controladorGrupoDeVeiculos.InserirNovo(suv);
        }

        private void ConfigurarDatas()
        {
            hoje = DateTime.Now.Date;
            amanha = hoje.AddDays(1);
            daquiSeteDias = DateTime.Now.Date.AddDays(7);
            daquiDezDias = DateTime.Now.Date.AddDays(10);
            daquiUmAno = DateTime.Today.AddYears(1);
        }

        private void ConfigurarTiposDePlanos()
        {
            planoDiario = "PlanoDiario";
            planoKmControlado = "KmControlado";
        }

        private void ConfigurarSeguro()
        {
            seguroCliente = "SeguroCliente";
            seguroNenhum = "Nenhum";
        }

        private void InserirClientes()
        {
            condutorBruno = new Cliente(0, "Bruno", "99516957013", "Lages", "999999999", "b@gmail.com", "77225735638", daquiUmAno, true);
            condutorPedro = new Cliente(0, "Pedro", "19043746037", "Florianopolis", "999999999", "p@gmail.com", "77225735638", daquiUmAno, true);

            controladorCliente.InserirNovo(condutorBruno);
            controladorCliente.InserirNovo(condutorPedro);
        }
        #endregion
    }
}
