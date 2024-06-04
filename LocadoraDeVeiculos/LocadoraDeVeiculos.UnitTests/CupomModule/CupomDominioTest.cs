using FluentAssertions;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.UnitTests.CupomModule
{
    [TestClass]
    [TestCategory("Domínio")]
    public class CupomDominioTest
    {
        readonly Parceiro parceiro = new(1, "Parceiro teste");

        [TestMethod]
        public void DeveCriarCupom_Completo_Porcentagem()
        {
            //arrange
            Cupom cupom = new(0, "Nome Cupom", "NDD10TECH", 10, 2000, false, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("VALID");
        }

        [TestMethod]
        public void DeveCriarCupom_Completo_Fixo()
        {
            //arrange
            Cupom cupom = new(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("VALID");
        }

        [TestMethod]
        public void DeveCriarCupom_TotalmenteIncorreto_Porcentagem()
        {
            //arrange
            Cupom cupom = new(0, "", "", 101, 0, false, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("The name field cannot be null.\nThe code field cannot be null.\nThe discount percentage cannot be greater than 100%.\nIt is mandatory to have a linked partner.\n");
        }
        [TestMethod]
        public void DeveCriarCupom_TotalmenteIncorreto_Fixo()
        {
            //arrange
            Cupom cupom = new(0, "", "", 0, 0, true, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("The name field cannot be null.\nThe code field cannot be null.\nThe value field cannot be negative or zero.\nIt is mandatory to have a linked partner.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ValorZero_Fixo()
        {
            //arrange
            Cupom cupom = new(0, "Nome Cupom", "NDD10TECH", 0, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("The value field cannot be negative or zero.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_PorcentagemMaiorDeCem_Porcentagem()
        {
            //arrange
            Cupom cupom = new(0, "Nome Cupom", "NDD10TECH", 101, 2000, false, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("The discount percentage cannot be greater than 100%.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_NomeVazio()
        {
            //arrange
            Cupom cupom = new(0, "", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("The name field cannot be null.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ParceiroNulo()
        {
            //arrange
            Cupom cupom = new(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("It is mandatory to have a linked partner.\n");
        }
    }
}
