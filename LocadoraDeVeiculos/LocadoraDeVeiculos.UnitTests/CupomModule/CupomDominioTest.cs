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
        Parceiro parceiro = new Parceiro(1, "Parceiro teste");

        [TestMethod]
        public void DeveCriarCupom_Completo_Porcentagem()
        {
            //arrange
            Cupom cupom = new Cupom(0, "Nome Cupom", "NDD10TECH", 10, 2000, false, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarCupom_Completo_Fixo()
        {
            //arrange
            Cupom cupom = new Cupom(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarCupom_TotalmenteIncorreto_Porcentagem()
        {
            //arrange
            Cupom cupom = new Cupom(0, "", "", 101, 0, false, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório\nO campo código é obrigatório\nA porcentagem de desconto não pode ser maior que 100%\nÉ obrigatório possuir um parceiro vinculado\n");
        }
        [TestMethod]
        public void DeveCriarCupom_TotalmenteIncorreto_Fixo()
        {
            //arrange
            Cupom cupom = new Cupom(0, "", "", 0, 0, true, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório\nO campo código é obrigatório\nO valor não pode ser negativo ou 0(zero)\nÉ obrigatório possuir um parceiro vinculado\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ValorZero_Fixo()
        {
            //arrange
            Cupom cupom = new Cupom(0, "Nome Cupom", "NDD10TECH", 0, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("O valor não pode ser negativo ou 0(zero)\n");
        }

        [TestMethod]
        public void DeveApresentarErro_PorcentagemMaiorDeCem_Porcentagem()
        {
            //arrange
            Cupom cupom = new Cupom(0, "Nome Cupom", "NDD10TECH", 101, 2000, false, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("A porcentagem de desconto não pode ser maior que 100%\n");
        }

        [TestMethod]
        public void DeveApresentarErro_NomeVazio()
        {
            //arrange
            Cupom cupom = new Cupom(0, "", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), parceiro, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ParceiroNulo()
        {
            //arrange
            Cupom cupom = new Cupom(0, "Nome Cupom", "NDD10TECH", 10, 2000, true, DateTime.Now.AddDays(10), null, 0);

            //action
            string resultadoValidacao = cupom.Validar();

            //assert
            resultadoValidacao.Should().Be("É obrigatório possuir um parceiro vinculado\n");
        }
    }
}
