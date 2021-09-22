using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.ApplicationTests.ParceiroModule
{
    public class ParceiroAppServiceTest
    {
        #region Atributos Privados
        private Parceiro parceiro;
        private string ndd;
        private string deko;
        #endregion

        [SetUp]
        public void Setup()
        {
            ConfigurarNome();
        }

        [Test]
        public void DeveChamar_InserirNovo()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Parceiro parceiroNovo = new ParceiroDataBuilder()
                .ComNome(deko)
                .Build();

            Mock<IRepository<Parceiro>> parceiroDAOMock = new();

            //action
            ParceiroAppService parceiroAppService = new(parceiroDAOMock.Object);
            parceiroAppService.InserirNovoParceiro(parceiroNovo);

            //assert
            parceiroDAOMock.Verify(x => x.InserirNovo(parceiroNovo));
        }

        [Test]
        public void DeveChamar_SelecionarTodos()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Mock<Parceiro> novoParceiroMock = new();
            novoParceiroMock.Object.Nome = deko;

            Mock<IRepository<Parceiro>> parceiroDAOMock = new();

            parceiroDAOMock.Setup(x => x.SelecionarPorId(parceiro.Id))
                .Returns(() =>
                {
                    return parceiro;
                });

            //action
            ParceiroAppService parceiroAppService = new(parceiroDAOMock.Object);
            parceiroAppService.SelecionarParceiroPorId(parceiro.Id);

            //assert
            parceiroDAOMock.Verify(x => x.SelecionarPorId(parceiro.Id));
        }

        [Test]
        public void DeveChamar_Editar()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Parceiro parceiroNovo = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Mock<IRepository<Parceiro>> parceiroDAOMock = new();

            //action
            ParceiroAppService parceiroAppService = new(parceiroDAOMock.Object);
            parceiroAppService.EditarParceiro(parceiro.Id, parceiroNovo);

            //assert
            parceiroDAOMock.Verify(x => x.Editar(parceiro.Id, parceiroNovo));
        }

        [Test]
        public void DeveChamar_Excluir()
        {
            //arrange
            parceiro = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Mock<Parceiro> novoParceiroMock = new();

            Mock<IRepository<Parceiro>> parceiroDAOMock = new();

            //action
            ParceiroAppService parceiroAppService = new(parceiroDAOMock.Object);
            parceiroAppService.ExcluirParceiro(parceiro.Id);

            //assert
            parceiroDAOMock.Verify(x => x.Excluir(parceiro.Id));
        }

        [Test]
        public void DeveChamar_ValidarDominio()
        {
            //arrange
            Parceiro parceiroExistente = new ParceiroDataBuilder()
                .ComNome(ndd)
                .Build();

            Mock<Parceiro> novaParceiroMock = new Mock<Parceiro>();
            Mock<IRepository<Parceiro>> locacaoDAOMock = new();

            //action
            ParceiroAppService locacaoAppService = new ParceiroAppService(locacaoDAOMock.Object);
            locacaoAppService.InserirNovoParceiro(novaParceiroMock.Object);

            //assert
            novaParceiroMock.Verify(x => x.Validar());
        }
        #region Métodos Privados
        private void ConfigurarNome()
        {
            ndd = "NDD";
            deko = "Deko";
        }
        #endregion
    }
}
