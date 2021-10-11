using FluentAssertions;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ORMTests
{
    public class CupomORMTest
    {
        private ICupomRepository controlador;
        private IRepository<Parceiro> controladorParceiro;

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

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new ();
            controlador = new CupomORM(dbContext);
            controladorParceiro = new ParceiroORM(dbContext);
            Configuracao();
        }

        [Test]
        public void DeveAdicionarCupom()
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
            var cupomEncontrado = controlador.SelecionarPorId(cupom.Id);
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