using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.ApplicationTests.ServicoModule
{
    public class ServicoApplicationsTests
    {
        private Servico servico;
        [Test]
        public void DeveChamar_Inserir()
        {
            servico = new ServicoDataBuilder()
                .ComNome("Lavação")
                .ComTaxaDiaria(true)
                .ComValor(100)
                .Build();

            Mock<IRepository<Servico>> servicoDAOMock = new();

            //action
            ServicoAppService clienteAppService = new(servicoDAOMock.Object);
            clienteAppService.InserirNovoServico(servico);

            //assert
            servicoDAOMock.Verify(x => x.InserirNovo(servico));
        }
        [Test]
        public void DeveChamar_SelecionarId()
        {
            //arrange
            servico = new ServicoDataBuilder()
               .ComNome("Lavação")
               .ComTaxaDiaria(true)
               .ComValor(100)
               .Build();

            Mock<Servico> novoSevicoMock = new();
            novoSevicoMock.Object.Nome = "Lavação";

            Mock<IRepository<Servico>> servicoDAOMock = new();

            servicoDAOMock.Setup(x => x.SelecionarPorId(servico.Id))
                .Returns(() =>
                {
                    return servico;
                });

            //action
            ServicoAppService servicoAppService = new(servicoDAOMock.Object);
            servicoAppService.SelecionarServicoPorId(servico.Id);

            //assert
            servicoDAOMock.Verify(x => x.SelecionarPorId(servico.Id));
        }
        [Test]
        public void DeveChamar_Editar()
        {
            //arrange
            servico = new ServicoDataBuilder()
              .ComNome("Lavação")
              .ComTaxaDiaria(true)
              .ComValor(100)
              .Build();

            Servico novoServico = new ServicoDataBuilder()
               .ComNome("Lavação")
               .ComTaxaDiaria(true)
               .ComValor(100)
               .Build();

            Mock<IRepository<Servico>> servicoDAOMock = new();

            //action
            ServicoAppService clienteAppService = new(servicoDAOMock.Object);
            clienteAppService.EditarServico(servico.Id, novoServico);

            //assert
            servicoDAOMock.Verify(x => x.Editar(servico.Id, novoServico));
        }
        [Test]
        public void DeveChamar_Excluir()
        {
            //arrange
            servico = new ServicoDataBuilder()
              .ComNome("Lavação")
              .ComTaxaDiaria(true)
              .ComValor(100)
              .Build();

            Mock<Servico> novoServicoMock = new();

            Mock<IRepository<Servico>> servicoDAOMock = new();

            //action
            ServicoAppService clienteAppService = new(servicoDAOMock.Object);
            clienteAppService.ExcluirServico(servico.Id);

            //assert
            servicoDAOMock.Verify(x => x.Excluir(servico.Id));
        }
    }
}
