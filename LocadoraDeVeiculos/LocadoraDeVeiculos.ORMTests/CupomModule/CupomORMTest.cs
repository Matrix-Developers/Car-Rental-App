using FluentAssertions;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;
using System.Linq;

namespace LocadoraDeVeiculos.ORMTests
{
    public class CupomORMTest
    {
        private ICupomRepository controlador;
        private IRepository<Parceiro> controladorParceiro;
        LocadoraDeVeiculosDBContext dbContext = new();

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
            controlador = new CupomORM(dbContext);
            controladorParceiro = new ParceiroORM(dbContext);
            Configuracao();
        }
        [TearDown]
        public void TearDown()
        {
            var listaLocacaoes = dbContext.Locacoes.ToList().Select(x => x as Locacao);
            foreach (var item in listaLocacaoes)
                dbContext.Locacoes.Remove(item);
            dbContext.SaveChanges();

            var listaCupons = dbContext.Cupons.ToList().Select(x => x as Cupom);
            foreach (var cupom in listaCupons)
                dbContext.Cupons.Remove(cupom);
            dbContext.SaveChanges();

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
        [Test]
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

            Cupom cupom2 = new CupomDataBuilder()
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
            controlador.InserirNovo(cupom2);

            //action
            var cupons = controlador.SelecionarTodos();

            //assert
            cupons.Should().HaveCount(2);
        }

        [Test]
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

            controlador.InserirNovo(cupom);

            //action
            cupom.Nome = "Editado";
            controlador.Editar(0, cupom);

            //assert
            Cupom parceiroEncontrado = controlador.SelecionarPorId(cupom.Id);
            parceiroEncontrado.Nome.Should().Be("Editado");
        }

        [Test]
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
            controlador.Excluir(cupom.Id);

            //assert
            var cupomEscolhido = controlador.SelecionarPorId(cupom.Id);
            cupomEscolhido.Should().BeNull();
        }
        [Test]
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
            var cupomEncontrado = controlador.SelecionarPorId(cupom.Id);

            //Assert
            cupomEncontrado.Should().Be(cupom);
        }
        [Test]
        public void DeveAtualizarQtdUtilizada()
        {
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

            //action
            controlador.AtualizarQtdUtilizada(cupom);

            //assert
            Cupom parceiroEncontrado = controlador.SelecionarPorId(cupom.Id);
            parceiroEncontrado.QtdUtilizada.Should().Be(1);
        }
        [Test]
        public void DeveVerificarSeExiteCodigo_Existe()
        {
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

            //action
            bool existCodigo = controlador.ExisteCodigo(codigo);

            //assert
            existCodigo.Should().BeTrue();
        }
        [Test]
        public void DeveVerificarSeExiteCodigo_NaoExiste()
        {
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

            //action
            bool existCodigo = controlador.ExisteCodigo("");

            //assert
            existCodigo.Should().BeFalse();
        }
        [Test]
        public void DeveSelecionarCupomPorCodigo()
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
            var cupomEncontrado = controlador.SelecionarPorCodigo(codigo);

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