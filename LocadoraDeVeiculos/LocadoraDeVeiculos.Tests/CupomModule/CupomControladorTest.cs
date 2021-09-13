using FluentAssertions;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Tests.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Tests.CupomModule
{
    [TestClass]
    public class CupomControladorTest
    {
        ControladorCupom controlador = null;
        ControladorParceiro controladorParceiro = null;
        Cupom cupom;
        Parceiro parceiro;
        public CupomControladorTest()
        {
            controlador = new ControladorCupom();
            controladorParceiro = new ControladorParceiro();
            ResetarBanco.ResetarTabelas();            
        }

        [TestMethod]
        public void DeveInserirUmParceiro()
        {
            //arrange
            InserirParceiro();
            cupom = new Cupom(0, "Cupom001", "CODIGOCUPOM", 500, 2000, true, DateTime.Today.AddDays(30), parceiro, 1);

            //action
            controlador.InserirNovo(cupom);

            //assert
            Cupom cupomEncontrado = controlador.SelecionarPorId(cupom.Id);
            cupomEncontrado.Should().Be(cupom);
        }        

        [TestMethod]
        public void DeveSelecionarDoisParceiros()
        {
            //arrange
            InserirParceiro();
            cupom = new Cupom(0, "Cupom001", "CODIGOCUPOM", 500, 2000, true, DateTime.Today.AddDays(30), parceiro, 1);

            //action
            controlador.InserirNovo(cupom);
            controlador.InserirNovo(cupom);

            //assert
            List<Cupom> parceiroEncontrado = controlador.SelecionarTodos();
            parceiroEncontrado.Count.Should().Be(2);
        }

        [TestMethod]
        public void DeveEditarUmParceiro()
        {
            //arrange
            InserirParceiro();
            cupom = new Cupom(0, "Cupom001", "CODIGOCUPOM", 500, 2000, true, DateTime.Today.AddDays(30), parceiro, 0);
            Cupom cupomEditado = new Cupom(0, "CupomEditado", "EDITADO", 50, 2000, false, DateTime.Today.AddDays(10), parceiro, 0);

            //action
            controlador.InserirNovo(cupom);
            controlador.Editar(cupom.Id, cupomEditado);

            //assert
            Cupom parceiroEncontrado = controlador.SelecionarPorId(cupom.Id);
            parceiroEncontrado.Should().Be(cupomEditado);
        }

        [TestMethod]
        public void DeveExcluirUmParceiro()
        {
            //arrange
            InserirParceiro();
            cupom = new Cupom(0, "Cupom001", "CODIGOCUPOM", 500, 2000, true, DateTime.Today.AddDays(30), parceiro, 0);

            //action
            controlador.InserirNovo(cupom);
            List<Cupom> cupomInserido = controlador.SelecionarTodos();
            controlador.Excluir(cupom.Id);

            //assert
            List<Cupom> bancoAposExclusao = controlador.SelecionarTodos();
            bancoAposExclusao.Count.Should().NotBe(cupomInserido.Count);
        }

        private void InserirParceiro()
        {
            parceiro = new Parceiro(0, "Nome Teste");
            controladorParceiro.InserirNovo(parceiro);
        }
    }
}
