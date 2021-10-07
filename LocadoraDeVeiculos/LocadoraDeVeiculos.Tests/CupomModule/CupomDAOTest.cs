using FluentAssertions;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.IntegrationTests.CupomModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class CupomDAOTest
    {
        private CupomRepository controlador;
        private ParceiroRepository controladorParceiro;

        private Cupom cupom;
        private string nome;
        private string nomeEditado;
        private string codigo;
        private double valor;
        private double valorMinimo;
        private bool ehDescontoFixo;
        private DateTime validade;
        private Parceiro parceiro;
        private int qtdUtilazada;

        [TestInitialize]
        public void Setup()
        {
            controlador = new CupomRepository();
            controladorParceiro = new ParceiroRepository();
            Configuracao();
        }

        [TestCleanup]
        public void TearDown()
        {
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserirUmCupom()
        {
            //arrange
            cupom = new CupomDataBuilder()
                .ComNome(nome)
                .ComCodigo(codigo)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(validade)
                .ComParceiro(parceiro)
                .ComQtdUtilizada(qtdUtilazada)
                .Build();

            //action
            controlador.InserirNovo(cupom);

            //assert
            var cupomEncontrado = controlador.SelecionarPorId(cupom.id);
            cupomEncontrado.Should().Be(cupom);
        }

        [TestMethod]
        public void DeveSelecionarDoisCupons()
        {
            //arrange
            cupom = new CupomDataBuilder()
               .ComNome(nome)
               .ComCodigo(codigo)
               .ComValor(valor)
               .ComValorMinimo(valorMinimo)
               .EhDescontoFixo(ehDescontoFixo)
               .ComValidade(validade)
               .ComParceiro(parceiro)
               .ComQtdUtilizada(qtdUtilazada)
               .Build();

            controlador.InserirNovo(cupom);
            controlador.InserirNovo(cupom);

            //action
            var cupons = controlador.SelecionarTodos();

            //assert
            cupons.Should().HaveCount(2);
        }

        [TestMethod]
        public void DeveEditarUmCupom()
        {
            //arrange
            cupom = new CupomDataBuilder()
                .ComNome(nome)
                .ComCodigo(codigo)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(validade)
                .ComParceiro(parceiro)
                .ComQtdUtilizada(qtdUtilazada)
                .Build();



            var cupomEditado = new CupomDataBuilder()
               .ComNome(nomeEditado)
               .ComCodigo(codigo)
               .ComValor(valor)
               .ComValorMinimo(valorMinimo)
               .EhDescontoFixo(ehDescontoFixo)
               .ComValidade(validade)
               .ComParceiro(parceiro)
               .ComQtdUtilizada(qtdUtilazada)
               .Build();

            //action
            controlador.InserirNovo(cupom);
            controlador.Editar(cupom.id, cupomEditado);

            //assert
            Cupom parceiroEncontrado = controlador.SelecionarPorId(cupom.id);
            parceiroEncontrado.Should().Be(cupomEditado);
        }

        [TestMethod]
        public void DeveExcluirUmParceiro()
        {
            //arrange
            cupom = new CupomDataBuilder()
                .ComNome(nome)
                .ComCodigo(codigo)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(validade)
                .ComParceiro(parceiro)
                .ComQtdUtilizada(qtdUtilazada)
                .Build();

            //action
            controlador.InserirNovo(cupom);
            controlador.Excluir(cupom.id);

            //assert
            var cupomEscolhido = controlador.SelecionarPorId(cupom.id);
            cupomEscolhido.Should().BeNull();
        }
        [TestMethod]
        public void DeveSelecionarCupomPorID()
        {
            //Arrange
            cupom = new CupomDataBuilder()
                .ComNome(nome)
                .ComCodigo(codigo)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(validade)
                .ComParceiro(parceiro)
                .ComQtdUtilizada(qtdUtilazada)
                .Build();

            //Action
            controlador.InserirNovo(cupom);
            var cupomEncontrado = controlador.SelecionarPorId(cupom.id);

            //Assert
            cupomEncontrado.Should().Be(cupom);
        }

        #region Métodos Privados
        public void Configuracao()
        {
            nome = "Cupom001";
            nomeEditado = "Cupom002";
            codigo = "CODIGOCUPOM";
            valor = 500;
            valorMinimo = 2000;
            ehDescontoFixo = true;
            validade = DateTime.Today.AddDays(30);
            qtdUtilazada = 0;
            parceiro = new Parceiro(0, "Nome Teste");
            controladorParceiro.InserirNovo(parceiro);
        }
        #endregion
    }
}