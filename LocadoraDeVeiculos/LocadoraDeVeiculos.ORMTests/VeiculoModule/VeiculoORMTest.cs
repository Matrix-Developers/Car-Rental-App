using FluentAssertions;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using System;
using LocadoraDeVeiculos.ORMTests.Shared;

namespace LocadoraDeVeiculos.ORMTests.VeiculoModule
{
    public class VeiculoORMTest
    {
        #region atributos privados
        private IRepository<Veiculo> veiculoRepository;
        private IRepository<GrupoDeVeiculo> GrupoDeVeiculosRepository;
        LocadoraDeVeiculosDBContext dbContext = new();

        private GrupoDeVeiculo grupoDeVeiculo;
        private Veiculo veiculo;

        private string civic;
        private string corolla;

        private string abc1234;
        private string abc1d34;

        private string chassi1;
        private string chassi2;

        private string honda;
        private string toyota;

        private string azul;
        private string vermelho;

        private string flex;
        private string gasolina;

        private int litros40;
        private int litros50;

        private int anoAtual;
        private int anoAnterior;

        private double km50;
        private double km100;

        private int numPortas2;
        private int numPortas4;

        private int numPessoas4;
        private int numPessoas5;

        private char portaMalasG;
        private char portaMalasP;

        private bool verdade;
        private bool falso;

        private List<ImagemVeiculo> naoPossuiImagens;
        #endregion

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            veiculoRepository = new VeiculoORM(dbContext);
            GrupoDeVeiculosRepository = new GrupoDeVeiculosORM(dbContext);

            ConfigurarModelo();

            ConfigurarGrupoDeVeiculo();

            ConfigurarPlaca();

            ConfigurarChassi();

            ConfigurarMarca();

            ConfigurarCor();

            ConfigurarTipoCombustivel();

            ConfigurarCapacidadeTanque();

            ConfigurarAno();

            ConfigurarKm();

            ConfigurarNumeroPortas();

            ConfigurarCapacidadePessoas();

            ConfigurarTamanhoPortaMalas();

            ConfigurarTemArCondicionado();

            ConfigurarImagens();
        }

        [TearDown]
        public void TearDown()
        {
            PopularBancoORMTest.DeletaTabelas();
        }

        [Test]
        public void DeveInserirUmVeiculo()
        {
            //arrange
            GrupoDeVeiculosRepository.InserirNovo(grupoDeVeiculo);
            veiculo = new VeiculoDataBuilder()
                .ComModelo(civic)
                .ComGrupoDeVeiculo(grupoDeVeiculo)
                .ComPlaca(abc1234)
                .ComChassi(chassi1)
                .ComMarca(honda)
                .ComCor(azul)
                .ComTipoCombustivel(gasolina)
                .ComCapacidadeTanque(litros40)
                .ComAno(anoAtual)
                .ComQuilometragem(km50)
                .ComNumPortas(numPortas2)
                .ComCapacidadePessoas(numPessoas4)
                .ComTamanhoPortaMala(portaMalasG)
                .ComArCondicionado(verdade)
                .ComDirecaoHidraulica(verdade)
                .ComFreiosAbs(verdade)
                .ComAlocaoAtiva(verdade)
                .ComImagem(naoPossuiImagens)
                .Build();
            //action
            veiculoRepository.InserirNovo(veiculo);

            //assert
            var veiculoEncontrado = veiculoRepository.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.Should().Be(veiculo);
        }

        [Test]
        public void DeveSelecionarDoisVeiculos()
        {
            //arrange  
            GrupoDeVeiculosRepository.InserirNovo(grupoDeVeiculo);
            veiculo = new VeiculoDataBuilder()
                .ComModelo(civic)
                .ComGrupoDeVeiculo(grupoDeVeiculo)
                .ComPlaca(abc1234)
                .ComChassi(chassi1)
                .ComMarca(honda)
                .ComCor(azul)
                .ComTipoCombustivel(gasolina)
                .ComCapacidadeTanque(litros40)
                .ComAno(anoAtual)
                .ComQuilometragem(km50)
                .ComNumPortas(numPortas2)
                .ComCapacidadePessoas(numPessoas4)
                .ComTamanhoPortaMala(portaMalasG)
                .ComArCondicionado(verdade)
                .ComDirecaoHidraulica(verdade)
                .ComFreiosAbs(verdade)
                .ComAlocaoAtiva(verdade)
                .ComImagem(naoPossuiImagens)
                .Build();

            Veiculo veiculo2 = new VeiculoDataBuilder()
                .ComModelo(corolla)
                .ComGrupoDeVeiculo(grupoDeVeiculo)
                .ComPlaca(abc1d34)
                .ComChassi(chassi2)
                .ComMarca(toyota)
                .ComCor(vermelho)
                .ComTipoCombustivel(flex)
                .ComCapacidadeTanque(litros50)
                .ComAno(anoAnterior)
                .ComQuilometragem(km100)
                .ComNumPortas(numPortas4)
                .ComCapacidadePessoas(numPessoas5)
                .ComTamanhoPortaMala(portaMalasP)
                .ComArCondicionado(falso)
                .ComDirecaoHidraulica(falso)
                .ComFreiosAbs(falso)
                .ComAlocaoAtiva(falso)
                .ComImagem(naoPossuiImagens)
                .Build();

            //action
            veiculoRepository.InserirNovo(veiculo);
            veiculoRepository.InserirNovo(veiculo2);

            //assert
            List<Veiculo> veiculoEncontrado = veiculoRepository.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(2);
        }

        [Test]
        public void DeveEditarUmVeiculo()
        {
            //arrange
            GrupoDeVeiculosRepository.InserirNovo(grupoDeVeiculo);
            veiculo = new VeiculoDataBuilder()
                .ComModelo(civic)
                .ComGrupoDeVeiculo(grupoDeVeiculo)
                .ComPlaca(abc1234)
                .ComChassi(chassi1)
                .ComMarca(honda)
                .ComCor(azul)
                .ComTipoCombustivel(gasolina)
                .ComCapacidadeTanque(litros40)
                .ComAno(anoAtual)
                .ComQuilometragem(km50)
                .ComNumPortas(numPortas2)
                .ComCapacidadePessoas(numPessoas4)
                .ComTamanhoPortaMala(portaMalasG)
                .ComArCondicionado(verdade)
                .ComDirecaoHidraulica(verdade)
                .ComFreiosAbs(verdade)
                .ComAlocaoAtiva(verdade)
                .ComImagem(naoPossuiImagens)
                .Build();

            //action
            veiculoRepository.InserirNovo(veiculo);
            veiculo.modelo = corolla;
            veiculoRepository.Editar(veiculo.Id, veiculo);

            //assert
            var veiculoEncontrado = veiculoRepository.SelecionarPorId(veiculo.Id);
            veiculoEncontrado.modelo.Should().Be(corolla);
        }

        [Test]
        public void DeveExcluirUmVeiculo()
        {
            //arrange
            GrupoDeVeiculosRepository.InserirNovo(grupoDeVeiculo);
            veiculo = new VeiculoDataBuilder()
                .ComModelo(civic)
                .ComGrupoDeVeiculo(grupoDeVeiculo)
                .ComPlaca(abc1234)
                .ComChassi(chassi1)
                .ComMarca(honda)
                .ComCor(azul)
                .ComTipoCombustivel(gasolina)
                .ComCapacidadeTanque(litros40)
                .ComAno(anoAtual)
                .ComQuilometragem(km50)
                .ComNumPortas(numPortas2)
                .ComCapacidadePessoas(numPessoas4)
                .ComTamanhoPortaMala(portaMalasG)
                .ComArCondicionado(verdade)
                .ComDirecaoHidraulica(verdade)
                .ComFreiosAbs(verdade)
                .ComAlocaoAtiva(verdade)
                .ComImagem(naoPossuiImagens)
                .Build();

            //action
            veiculoRepository.InserirNovo(veiculo);
            List<Veiculo> veiculosAntesDaExclusao = veiculoRepository.SelecionarTodos();
            veiculosAntesDaExclusao.Count.Should().Be(1);
            veiculoRepository.Excluir(veiculo.Id);

            //assert
            List<Veiculo> veiculoEncontrado = veiculoRepository.SelecionarTodos();
            veiculoEncontrado.Count.Should().Be(0);
        }

        #region Métodos privados
        private void ConfigurarModelo()
        {
            civic = "Civic";
            corolla = "Corolla";
        }
        private void ConfigurarGrupoDeVeiculo()
        {
            grupoDeVeiculo = new GrupoDeVeiculo(0, "Grupo Teste", 12.50, 25.73, 13.99, 200, 15, 11.2);
        }
        private void ConfigurarPlaca()
        {
            abc1234 = "abc1234";
            abc1d34 = "abc1d34";
        }
        private void ConfigurarChassi()
        {
            chassi1 = "17r Kf2AJZ B7 km8913";
            chassi2 = "2Al 95A6fK 8A nA1127";
        }
        private void ConfigurarMarca()
        {
            honda = "Honda";
            toyota = "Toyota";
        }
        private void ConfigurarCor()
        {
            azul = "Azul";
            vermelho = "Vermelho";
        }
        private void ConfigurarTipoCombustivel()
        {
            gasolina = "Gasolina";
            flex = "Flex";
        }
        private void ConfigurarCapacidadeTanque()
        {
            litros40 = 40;
            litros50 = 50;
        }
        private void ConfigurarAno()
        {
            anoAtual = Convert.ToInt32(DateTime.Today.Year);
            anoAnterior = Convert.ToInt32(DateTime.Today.AddYears(-1).Year);
        }
        private void ConfigurarKm()
        {
            km50 = 50;
            km100 = 60;
        }
        private void ConfigurarNumeroPortas()
        {
            numPortas2 = 2;
            numPortas4 = 4;
        }
        private void ConfigurarCapacidadePessoas()
        {
            numPessoas4 = 4;
            numPessoas5 = 5;
        }
        private void ConfigurarTamanhoPortaMalas()
        {
            portaMalasG = 'G';
            portaMalasP = 'P';
        }
        private void ConfigurarTemArCondicionado()
        {
            verdade = true;
            falso = false;
        }
        private void ConfigurarImagens()
        {
            naoPossuiImagens = null;
        }
        #endregion
    }
}
