using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System;

namespace LocadoraDeVeiculos.ApplicationTests.CupomModule
{
    public class CupomAppServiceTest
    {
        #region atributos privados
        private Cupom cupom;

        private string cupomNdd;
        private string cupomDeko;

        private string codigoDeko;
        private string codigoNdd;

        private double valor;
        private double valorMinimo;

        private bool ehDescontoFixo;

        private DateTime trintaDias;
        private DateTime seteDias;

        private Parceiro parceiroNdd;
        private Parceiro parceiroDeko;

        private int utilizadoZeroVezes;
        private int utilizadoDezVezes;
        #endregion

        [SetUp]
        public void Setup()
        {
            ConfigurarNome();

            ConfigurarCodigo();

            ConfigurarValores();

            ConfigurarValidades();

            ConfigurarQuantidadeUtilizadas();

            ConfigurarParceiros();
        }

        [Test]
        public void DeveChamar_InserirNovo()
        {
            //arrange
            BuidCupom();

            Cupom cupomNovo = new CupomDataBuilder()
                .ComNome(cupomDeko)
                .ComCodigo(codigoDeko)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(seteDias)
                .ComParceiro(parceiroDeko)
                .ComQtdUtilizada(utilizadoDezVezes)
                .Build();

            Mock<ICupomRepository> cupomDAOMock = new();

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.InserirEntidade(cupomNovo);

            //assert
            cupomDAOMock.Verify(x => x.InserirNovo(cupomNovo));
        }

        [Test]
        public void DeveChamar_SelecionarPorId()
        {
            //arrange
            BuidCupom();

            Mock<Parceiro> novoParceiroMock = new();
            novoParceiroMock.Object.Nome = cupomDeko;

            Mock<ICupomRepository> cupomDAOMock = new();

            cupomDAOMock.Setup(x => x.SelecionarPorId(cupom.id))
                .Returns(() =>
                {
                    return cupom;
                });

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.SelecionarEntidadePorId(cupom.id);

            //assert
            cupomDAOMock.Verify(x => x.SelecionarPorId(cupom.id));
        }

        [Test]
        public void DeveChamar_Editar()
        {
            //arrange
            BuidCupom();

            Cupom cupomNovo = new CupomDataBuilder()
                .ComNome(cupomDeko)
                .ComCodigo(codigoDeko)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(seteDias)
                .ComParceiro(parceiroDeko)
                .ComQtdUtilizada(utilizadoDezVezes)
                .Build();

            Mock<ICupomRepository> cupomDAOMock = new();
            cupomDAOMock.Setup(x => x.Editar(cupom.id, cupomNovo))
                .Returns(() =>
                {
                    return true;
                });

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.EditarEntidade(cupom.id, cupomNovo);

            //assert
            cupomDAOMock.Verify(x => x.Editar(cupom.id, cupomNovo));
        }

        [Test]
        public void DeveChamar_Excluir()
        {
            //arrange
            BuidCupom();

            Mock<Parceiro> novoParceiroMock = new();

            Mock<ICupomRepository> cupomDAOMock = new();
            cupomDAOMock.Setup(x => x.Excluir(cupom.id))
                .Returns(() =>
                {
                    return true;
                });

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.ExcluirEntidade(cupom.id);

            //assert
            cupomDAOMock.Verify(x => x.Excluir(cupom.id));
        }

        [Test]
        public void DeveChamar_ExisteCodigo()
        {
            //arrange
            BuidCupom();

            Mock<ICupomRepository> cupomDAOMock = new();
            cupomDAOMock.Setup(x => x.ExisteCodigo(cupom.Codigo))
                .Returns(() =>
                {
                    return true;
                });

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.ExisteCodigo(cupom.Codigo);

            //assert
            cupomDAOMock.Verify(x => x.ExisteCodigo(cupom.Codigo));
        }

        [Test]
        public void DeveChamar_AtualizarQtdUtilizada()
        {
            //arrange
            BuidCupom();

            Mock<ICupomRepository> cupomDAOMock = new();

            //action
            CupomAppService cupomAppService = new(cupomDAOMock.Object);
            cupomAppService.AtualizarQuantidadeUtilizada(cupom.id, 5);

            //assert
            cupomDAOMock.Verify(x => x.AtualizarQtdUtilizada(cupom.id, 5));
        }

        #region Métodos privados
        private void ConfigurarNome()
        {
            cupomDeko = "Cupom Deko";
            cupomNdd = "Cupom NDD";
        }
        private void ConfigurarCodigo()
        {
            codigoDeko = "CODIGODEKO";
            codigoNdd = "CODIGONDD";
        }
        private void ConfigurarValores()
        {
            valor = 500;
            valorMinimo = 2000;
            ehDescontoFixo = true;
        }
        private void ConfigurarValidades()
        {
            trintaDias = DateTime.Today.AddDays(30);
            seteDias = DateTime.Today.AddDays(7);
        }
        private void ConfigurarQuantidadeUtilizadas()
        {
            utilizadoZeroVezes = 0;
            utilizadoDezVezes = 10;
        }
        private void ConfigurarParceiros()
        {
            parceiroNdd = new Parceiro(0, "NDD");
            parceiroDeko = new Parceiro(0, "Deko");
        }
        private void BuidCupom()
        {
            cupom = new CupomDataBuilder()
                .ComNome(cupomNdd)
                .ComCodigo(codigoNdd)
                .ComValor(valor)
                .ComValorMinimo(valorMinimo)
                .EhDescontoFixo(ehDescontoFixo)
                .ComValidade(trintaDias)
                .ComParceiro(parceiroNdd)
                .ComQtdUtilizada(utilizadoZeroVezes)
                .Build();
        }
        #endregion
    }
}
