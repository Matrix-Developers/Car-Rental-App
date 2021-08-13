using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Tests.SevicoModule
{
    [TestClass]
    public class ServicosControladorTest
    {
        ControladorServico controlador = null;
        Servico novoServico;
        public ServicosControladorTest()
        {
            controlador = new ControladorServico();
            Db.Update("DELETE FROM [TBSERVICO]");
        }
        [TestMethod]
        public void DeveInserirUmServico()
        {
            //arrange
            novoServico = new Servico(0, "nome", "tipo", 100);

            //action
            controlador.InserirNovo(novoServico);

            //assert
            Servico servicoEncontrado = controlador.SelecionarPorId(novoServico.Id);
            servicoEncontrado.Should().Be(novoServico);
        }
        [TestMethod]
        public void DeveSelecionarDoisServicos()
        {
            //arrange
            novoServico = new Servico(0, "nome", "tipo", 100);

            //action
            controlador.InserirNovo(novoServico);
            controlador.InserirNovo(novoServico);

            //assert
            List<Servico> servicoEncontrado = controlador.SelecionarTodos();
            servicoEncontrado.Count.Should().Be(2);
        }

        [TestMethod]
        public void DeveEditarUmServico()
        {
            //arrange
            novoServico = new Servico(0, "nome", "tipo", 100);
            Servico servicoEditado = new Servico(0, "Lavar Carro", "Fixo", 80);
            //action
            controlador.InserirNovo(novoServico);
            controlador.Editar(novoServico.Id, servicoEditado);

            //assert
            Servico servicoEncontrado = controlador.SelecionarPorId(novoServico.Id);
            servicoEncontrado.Should().Be(servicoEditado);
        }

        [TestMethod]
        public void DeveExcluirUmServico()
        {
            //arrange
            novoServico = new Servico(0, "nome", "tipo", 100);

            //action
            controlador.InserirNovo(novoServico);
            controlador.Excluir(novoServico.Id);

            //assert
            List<Servico> servicoEncontrado = controlador.SelecionarTodos();
            servicoEncontrado.Count.Should().Be(0);
        }
    }
}
