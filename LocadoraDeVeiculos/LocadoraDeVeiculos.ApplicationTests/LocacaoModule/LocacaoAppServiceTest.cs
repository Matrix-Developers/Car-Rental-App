using System;
using Moq;
using NUnit.Framework;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.TestDataBuilders;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System.Collections.Generic;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;

namespace LocadoraDeVeiculos.ApplicationTests.LocacaoModule
{
    public class LocacaoAppServiceTest
    {
        #region atributos privados
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

        List<Servico> listaServicosCheia;
        List<Servico> listaServicosApenasCadeirinha;

        private Cupom descontaoDoDeko;
        private Parceiro parceiro;

        private string planoDiario;

        private string seguroCliente;

        private DateTime hoje;
        private DateTime amanha;
        private DateTime daquiDezDias;
        private DateTime daquiSeteDias;
        private DateTime daquiUmAno;
        #endregion

        [SetUp]
        public void Setup()
        {
            ConfigurarDatas();

            InserirClientes();

            ConfigurarPlanosESeguro();

            InserirGruposDeVeiculos();

            InserirVeiculo();

            InserirFuncionarios();

            InserirTaxas();

            InserirParceiroECupom();
        }
        [Test]
        public void DeveChamar_InserirNovo()
        {
            //arrange
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
                .ComServicos(listaServicosCheia)
                .Build();

            Mock<IRepository<Locacao>> locacaoDAOMock = new();
            locacaoDAOMock.Setup(x => x.InserirNovo(locacao))
                .Returns(() =>
                {
                    return true;
                });

            //action
            LocacaoAppService locacaoAppService = new(locacaoDAOMock.Object);
            locacaoAppService.InserirEntidade(locacao);

            //assert
            locacaoDAOMock.Verify(x => x.InserirNovo(locacao));
        }

        [Test]
        public void DeveChamar_SelecionarPorId()
        {
            //arrange
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
                .ComServicos(listaServicosApenasCadeirinha)
                .Build();

            Mock<Locacao> locacaoMock = new();
            locacaoMock.Object.DataDeChegada = daquiUmAno;

            Mock<IRepository<Locacao>> locacaoDAOMock = new();
            locacaoDAOMock.Setup(x => x.SelecionarPorId(locacao.Id))
                .Returns(() =>
                {
                    return locacao;
                });

            //action
            LocacaoAppService locacaoAppService = new(locacaoDAOMock.Object);
            locacaoAppService.SelecionarEntidadePorId(locacao.Id);

            //assert
            locacaoDAOMock.Verify(x => x.SelecionarPorId(locacao.Id));
        }

        [Test]
        public void DeveChamar_Editar()
        {
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
                .ComServicos(listaServicosApenasCadeirinha)
                .Build();

            Locacao locacaoNova = new LocacaoDataBuilder()
                .ComVeiculo(fusca)
                .ComFuncionarioLocador(joao)
                .ComClienteContratante(condutorBruno)
                .ComClienteCondutor(condutorPedro)
                .ComCupom(descontaoDoDeko)
                .ComDataDeSaida(daquiSeteDias)
                .ComDataDeChegada()
                .ComDataPrevistaDeChegada(daquiDezDias)
                .ComTipoDoPlano(planoDiario)
                .ComTipoDoSeguro(seguroCliente)
                .ComServicos(listaServicosCheia)
                .Build();

            Mock<IRepository<Locacao>> locacaoDAOMock = new();

            //action
            LocacaoAppService locacaoAppService = new(locacaoDAOMock.Object);
            locacaoAppService.EditarEntidade(parceiro.Id, locacaoNova);

            //assert
            locacaoDAOMock.Verify(x => x.Editar(parceiro.Id, locacaoNova));
        }

        [Test]
        public void DeveChamar_Excluir()
        {
            //arrange
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
                 .ComServicos(listaServicosApenasCadeirinha)
                 .Build();

            Mock<IRepository<Locacao>> locacaoDAOMock = new();
            locacaoDAOMock.Setup(x => x.Excluir(locacao.Id))
                .Returns(() =>
                {
                    return true;
                });

            //action
            LocacaoAppService parceiroAppService = new(locacaoDAOMock.Object);
            parceiroAppService.ExcluirEntidade(parceiro.Id);

            //assert
            locacaoDAOMock.Verify(x => x.Excluir(parceiro.Id));
        }

        [Test]
        public void DeveChamar_ValidarDominio()
        {
            //arrange
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
                 .ComServicos(listaServicosApenasCadeirinha)
                 .Build();

            Mock<Locacao> locacaoMock = new();
            locacaoMock.Setup(x => x.Validar())
                .Returns(() =>
                {
                    return "VALIDO";
                });

            Mock<IRepository<Locacao>> locacaoDAOMock = new();

            //action
            LocacaoAppService locacaoAppService = new LocacaoAppService(locacaoDAOMock.Object);
            locacaoAppService.InserirEntidade(locacaoMock.Object);

            //assert
            locacaoMock.Verify(x => x.Validar());
        }

        #region Métodos Privados
        private void InserirParceiroECupom()
        {
            parceiro = new Parceiro(1, "Desconto do Deko");
            descontaoDoDeko = new Cupom(1, "100 de desconto", "DEKO", 100, 600, true, daquiDezDias, parceiro, 0);
        }

        private void InserirTaxas()
        {
            caderinhaBebe = new Servico(1, "Cadeirinha de Bebê", true, 30);
            lavacaoCarro = new Servico(1, "Lavação de Carro", false, 30);
            CriaListasTaxasEServicos();
            listaServicosCheia.Add(caderinhaBebe);
            listaServicosCheia.Add(lavacaoCarro);

            listaServicosApenasCadeirinha.Add(caderinhaBebe);
        }

        private void CriaListasTaxasEServicos()
        {
            listaServicosCheia = new();
            listaServicosApenasCadeirinha = new();
        }

        private void InserirFuncionarios()
        {
            beto = new Funcionario(1, "Alberto", "66513610079", "Lages", "99999999", "alberto@gmail.com", 1, "beto", "beto123", hoje, "dev", 600, true);
            joao = new Funcionario(1, "João Junior", "19559341006", "Florianopolis", "99999999", "joao@gmail.com", 2, "jao", "jao123", hoje, "vendedor", 6000, true);
        }

        private void InserirVeiculo()
        {
            kicks = new Veiculo(1, "Kicks", suv, "abc1234", "5pH h8Kf5K md TV2348", "Honda", "Branco", "Gasolina", 50, Convert.ToInt32(DateTime.Today.Year), 2000, 4, 5, 'G', true, true, true, true, null);
            fusca = new Veiculo(1, "Fusca", suv, "abc1234", "5pH h8Kf5K md TV2348", "Volkswagen", "Branco", "Etanol", 50, Convert.ToInt32(DateTime.Today.AddYears(-20).Year), 200000, 4, 5, 'P', false, false, false, false, null);
        }

        private void InserirGruposDeVeiculos()
        {
            suv = new GrupoDeVeiculo(0, "SUV", 12.50f, 25.73f, 13.99f, 200, 15f, 11.2f);
        }

        private void ConfigurarDatas()
        {
            hoje = DateTime.Now.Date;
            amanha = hoje.AddDays(1);
            daquiSeteDias = DateTime.Now.Date.AddDays(7);
            daquiDezDias = DateTime.Now.Date.AddDays(10);
            daquiUmAno = DateTime.Today.AddYears(1);
        }

        private void ConfigurarPlanosESeguro()
        {
            planoDiario = "PlanoDiario";
            seguroCliente = "SeguroCliente";
        }

        private void InserirClientes()
        {
            condutorBruno = new Cliente(1, "Bruno", "99516957013", "Lages", "999999999", "b@gmail.com", "77225735638", daquiUmAno, true);
            condutorPedro = new Cliente(1, "Pedro", "19043746037", "Florianopolis", "999999999", "p@gmail.com", "77225735638", daquiUmAno, true);
        }
        #endregion
    }
}
