using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.ApplicationTests.VeiculoModule
{
    [TestClass]
    [TestCategory("AppService")]
    public class VeiculoApplicationTests
    {
        #region atributos privados
        private VeiculoAppService veiculoAppService;
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

        [TestInitialize]
        public void Setup()
        {
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
